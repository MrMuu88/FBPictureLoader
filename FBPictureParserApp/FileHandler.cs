namespace FBPictureParserApp
{
    public class FileHandler
    {
        public async Task CopyFileAsync(string orgPath, string newPath) => await Task.Run(() => CopyFile(orgPath, newPath));

        public void CopyFile(string orgPath, string newPath) {
            var counter = 0;
            var extension = Path.GetExtension(newPath); //it will include the .
            while (File.Exists(newPath)) {
                counter++;
                newPath = Path.ChangeExtension(newPath, $"_({counter}){extension}");
            }
            File.Copy(orgPath, newPath);
        }

        internal void Report(IEnumerable<string> lines)
        {
            File.WriteAllLines($"{Environment.CurrentDirectory}\\report.txt", lines);
        }
    }
}