namespace FBPictureParserApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddialOutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.fdialMessageJson = new System.Windows.Forms.OpenFileDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnJsonPick = new System.Windows.Forms.Button();
            this.btnOutputPick = new System.Windows.Forms.Button();
            this.txtMessageJson = new System.Windows.Forms.TextBox();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fdialMessageJson
            // 
            this.fdialMessageJson.FileName = "Message_1.json";
            this.fdialMessageJson.Filter = "Json files |*.json";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(368, 2);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(102, 56);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Start";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 2);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 56);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            // 
            // btnJsonPick
            // 
            this.btnJsonPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJsonPick.Location = new System.Drawing.Point(388, 3);
            this.btnJsonPick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJsonPick.Name = "btnJsonPick";
            this.btnJsonPick.Size = new System.Drawing.Size(82, 22);
            this.btnJsonPick.TabIndex = 2;
            this.btnJsonPick.Text = "open";
            this.btnJsonPick.UseVisualStyleBackColor = true;
            this.btnJsonPick.Click += new System.EventHandler(this.btnJsonPick_Click);
            // 
            // btnOutputPick
            // 
            this.btnOutputPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputPick.Location = new System.Drawing.Point(388, 29);
            this.btnOutputPick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOutputPick.Name = "btnOutputPick";
            this.btnOutputPick.Size = new System.Drawing.Size(82, 22);
            this.btnOutputPick.TabIndex = 3;
            this.btnOutputPick.Text = "select";
            this.btnOutputPick.UseVisualStyleBackColor = true;
            this.btnOutputPick.Click += new System.EventHandler(this.btnOutputPick_Click);
            // 
            // txtMessageJson
            // 
            this.txtMessageJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageJson.Location = new System.Drawing.Point(3, 4);
            this.txtMessageJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessageJson.Name = "txtMessageJson";
            this.txtMessageJson.PlaceholderText = "Messages Json File";
            this.txtMessageJson.Size = new System.Drawing.Size(381, 23);
            this.txtMessageJson.TabIndex = 4;
            this.txtMessageJson.Text = "C:\\Users\\simont\\Desktop\\FB 2022\\messages\\inbox\\lauraeskornel_1545785728826718\\mes" +
    "sage_1.json";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputDir.Location = new System.Drawing.Point(3, 28);
            this.txtOutputDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.PlaceholderText = "Output Directory";
            this.txtOutputDir.Size = new System.Drawing.Size(381, 23);
            this.txtOutputDir.TabIndex = 5;
            this.txtOutputDir.Text = "C:\\Users\\simont\\Desktop\\FB 2022\\output";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnOutputPick);
            this.panel1.Controls.Add(this.txtOutputDir);
            this.panel1.Controls.Add(this.btnJsonPick);
            this.panel1.Controls.Add(this.txtMessageJson);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 53);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnProcess);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Location = new System.Drawing.Point(3, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 60);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 125);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 125);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FolderBrowserDialog ddialOutputDir;
        private OpenFileDialog fdialMessageJson;
        private Button btnProcess;
        private ProgressBar progressBar1;
        private Button btnJsonPick;
        private Button btnOutputPick;
        private TextBox txtMessageJson;
        private TextBox txtOutputDir;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}