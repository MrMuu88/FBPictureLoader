using FBPictureParserApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FBPictureParserApp
{
    public class MessageProcessor
    {
        public FileHandler FileHandler { get; set; } = new FileHandler();

        public event EventHandler<bool> MessageProcessed;

        public async Task Process(Chat chat,string dataPath, string outdir, CancellationToken token) {
            List<string> report = new List<string>();
            var all = chat.Messages.SelectMany(m => m.Photos);
            all = all.Union(chat.Messages.SelectMany(m => m.Videos));

            
            foreach (Models.Image image in all) {
                try
                {
                    var match = Regex.Match(image.Uri, @".*?((photos/|videos/).*)");
                    if (!match.Success)
                    {
                        report.Add($"{image.Uri},incorrect image path");
                        continue;
                    }

                    var orgPath = Path.Combine(dataPath, match.Groups[1].Value);

                    if (!File.Exists(orgPath))
                    {
                        report.Add($"{orgPath}, doesnot exists");
                        continue;
                    }

                    var newPath = Path.Combine(
                                        outdir,
                                        image.CreationTimeStamp.ToString("yyyy_MM_dd_hh_mm_ss") +
                                        Path.GetExtension(orgPath)
                                  );

                    await FileHandler.CopyFileAsync(orgPath, newPath);
                    MessageProcessed?.Invoke(this, false);
                }
                catch { }
            }

            FileHandler.Report(report);
            MessageProcessed?.Invoke(this, true);
        }

    }
}
