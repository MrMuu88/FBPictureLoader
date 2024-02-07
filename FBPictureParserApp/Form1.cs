using FBPictureParserApp.Models;
using Newtonsoft.Json;

namespace FBPictureParserApp
{
    public partial class Form1 : Form
    {
        public MessageProcessor Processor { get;} = new MessageProcessor();

        public CancellationTokenSource TokenSource { get;} = new CancellationTokenSource();

        public bool Isrunig { get; private set; } = false;

        public Form1()
        {
            InitializeComponent();
            Processor.MessageProcessed += Processor_MessageProcessed;
        }

        private void Processor_MessageProcessed(object? sender, bool isCompleted)
        {
            Isrunig = isCompleted;
            progressBar1.Value++;
            if (Isrunig)
            {
                btnProcess.Text = "Start";
            }
        }

        private void btnJsonPick_Click(object sender, EventArgs e)
        {
            var result = fdialMessageJson.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtMessageJson.Text = fdialMessageJson.FileName;
            }
        }

        private void btnOutputPick_Click(object sender, EventArgs e)
        {
            var result = ddialOutputDir.ShowDialog(this);
            if (result == DialogResult.OK) {
                txtOutputDir.Text = ddialOutputDir.SelectedPath;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (Isrunig) { 
                TokenSource.Cancel();
                btnProcess.Text = "Start";
                return;
            }

            progressBar1.Value = 0;
            btnProcess.Text = "Stop";

            if (!File.Exists(txtMessageJson.Text)) { 
                MessageBox.Show("messages json File does not exists","file not found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(txtOutputDir.Text)) {
                MessageBox.Show("Output dir does not exists", "Directory not exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var rawContent = File.ReadAllText(txtMessageJson.Text);

            var chat = JsonConvert.DeserializeObject<Chat>(rawContent);


            var imageCount = chat.Messages.SelectMany(m => m.Photos).Count();
            imageCount += chat.Messages.SelectMany(m => m.Videos).Count();
            progressBar1.Maximum = imageCount;
            var datapath = Path.GetDirectoryName(txtMessageJson.Text);
            Processor.Process(chat,datapath,txtOutputDir.Text, TokenSource.Token); // to end the process prematurely, I will need to pipe in a cancelation token
        }
    }
}