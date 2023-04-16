namespace Brain_Pathology
{
    partial class AppView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppView));
            panel1 = new Panel();
            btnSettings = new Button();
            btn1 = new Button();
            panel2 = new Panel();
            dateTimeLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            imagePanel = new Panel();
            label16 = new Label();
            pictureBox5 = new PictureBox();
            lineBar = new Panel();
            label3 = new Label();
            textBox1 = new TextBox();
            btnClose = new Button();
            AppBar = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            labelServerInfo = new Label();
            labelServerConnection = new Label();
            label4 = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            labelImageCount = new Label();
            label9 = new Label();
            panel6 = new Panel();
            progressBar = new CircularProgressBar.CircularProgressBar();
            label12 = new Label();
            panel7 = new Panel();
            ImageBox = new PictureBox();
            labelDropImage = new Label();
            label14 = new Label();
            panel8 = new Panel();
            labelModelVersion = new Label();
            labelModelName = new Label();
            btnPrediction = new Button();
            btnMoreInfo = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            AppBar.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(imagePanel);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 750);
            panel1.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.FromArgb(22, 204, 200);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 708);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 42);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "  Settings";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Top;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.FromArgb(22, 204, 200);
            btn1.Image = (Image)resources.GetObject("btn1.Image");
            btn1.Location = new Point(0, 188);
            btn1.Name = "btn1";
            btn1.Size = new Size(186, 42);
            btn1.TabIndex = 1;
            btn1.Text = "Brain tumor";
            btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            btn1.Leave += btn_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimeLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 188);
            panel2.TabIndex = 0;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.BackColor = Color.Transparent;
            dateTimeLabel.Font = new Font("Microsoft Sans Serif", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimeLabel.ForeColor = Color.FromArgb(158, 141, 176);
            dateTimeLabel.Location = new Point(16, 141);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(19, 16);
            dateTimeLabel.TabIndex = 2;
            dateTimeLabel.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 204, 200);
            label1.Location = new Point(16, 106);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "Mohamad Aboud";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // imagePanel
            // 
            imagePanel.Controls.Add(label16);
            imagePanel.Controls.Add(pictureBox5);
            imagePanel.Location = new Point(12, 301);
            imagePanel.Name = "imagePanel";
            imagePanel.Size = new Size(156, 337);
            imagePanel.TabIndex = 7;
            imagePanel.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Gray;
            label16.Location = new Point(179, 457);
            label16.Name = "label16";
            label16.Size = new Size(515, 67);
            label16.TabIndex = 1;
            label16.Text = "Drop the image here";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(208, 129);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(448, 292);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // lineBar
            // 
            lineBar.BackColor = Color.FromArgb(0, 126, 249);
            lineBar.Location = new Point(0, 193);
            lineBar.Name = "lineBar";
            lineBar.Size = new Size(3, 42);
            lineBar.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(158, 161, 176);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(279, 64);
            label3.TabIndex = 2;
            label3.Text = "Brain tumor";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(74, 79, 99);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft YaHei", 15F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(515, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search....";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(311, 39);
            textBox1.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(840, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 64);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // AppBar
            // 
            AppBar.Controls.Add(label3);
            AppBar.Controls.Add(btnClose);
            AppBar.Controls.Add(textBox1);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(186, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(889, 64);
            AppBar.TabIndex = 5;
            AppBar.MouseDown += AppBar_MouseDown;
            AppBar.MouseMove += AppBar_MouseMove;
            AppBar.MouseUp += AppBar_MouseUp;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(37, 42, 64);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(labelServerInfo);
            panel4.Controls.Add(labelServerConnection);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(221, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(306, 153);
            panel4.TabIndex = 6;
            panel4.Click += CheckConnection_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(190, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += CheckConnection_Click;
            // 
            // labelServerInfo
            // 
            labelServerInfo.AutoSize = true;
            labelServerInfo.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelServerInfo.ForeColor = Color.FromArgb(159, 151, 176);
            labelServerInfo.Location = new Point(27, 123);
            labelServerInfo.Name = "labelServerInfo";
            labelServerInfo.Size = new Size(83, 23);
            labelServerInfo.TabIndex = 2;
            labelServerInfo.Text = "Loading...";
            labelServerInfo.Click += CheckConnection_Click;
            // 
            // labelServerConnection
            // 
            labelServerConnection.AutoSize = true;
            labelServerConnection.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelServerConnection.ForeColor = Color.Red;
            labelServerConnection.Location = new Point(30, 62);
            labelServerConnection.Name = "labelServerConnection";
            labelServerConnection.Size = new Size(157, 29);
            labelServerConnection.TabIndex = 1;
            labelServerConnection.Text = "Disconncted";
            labelServerConnection.Click += CheckConnection_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 23);
            label4.Name = "label4";
            label4.Size = new Size(82, 31);
            label4.TabIndex = 0;
            label4.Text = "Server";
            label4.Click += CheckConnection_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(37, 42, 64);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(labelImageCount);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(551, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(306, 153);
            panel5.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(180, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(111, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(159, 151, 176);
            label7.Location = new Point(30, 115);
            label7.Name = "label7";
            label7.Size = new Size(138, 23);
            label7.TabIndex = 2;
            label7.Text = "Details of  image";
            // 
            // labelImageCount
            // 
            labelImageCount.AutoSize = true;
            labelImageCount.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point);
            labelImageCount.ForeColor = Color.FromArgb(0, 146, 249);
            labelImageCount.Location = new Point(30, 62);
            labelImageCount.Name = "labelImageCount";
            labelImageCount.Size = new Size(37, 39);
            labelImageCount.TabIndex = 1;
            labelImageCount.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(27, 23);
            label9.Name = "label9";
            label9.Size = new Size(148, 31);
            label9.TabIndex = 0;
            label9.Text = "Image count";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(37, 42, 64);
            panel6.Controls.Add(progressBar);
            panel6.Controls.Add(label12);
            panel6.Location = new Point(221, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(306, 379);
            panel6.TabIndex = 6;
            // 
            // progressBar
            // 
            progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            progressBar.AnimationSpeed = 500;
            progressBar.BackColor = Color.Transparent;
            progressBar.Font = new Font("Myanmar Text", 25F, FontStyle.Bold, GraphicsUnit.Point);
            progressBar.ForeColor = Color.FromArgb(22, 204, 200);
            progressBar.InnerColor = Color.Transparent;
            progressBar.InnerMargin = 2;
            progressBar.InnerWidth = -1;
            progressBar.Location = new Point(30, 98);
            progressBar.MarqueeAnimationSpeed = 2000;
            progressBar.Name = "progressBar";
            progressBar.OuterColor = Color.FromArgb(26, 28, 43);
            progressBar.OuterMargin = -25;
            progressBar.OuterWidth = 26;
            progressBar.ProgressColor = Color.FromArgb(22, 204, 200);
            progressBar.ProgressWidth = 16;
            progressBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            progressBar.Size = new Size(244, 248);
            progressBar.StartAngle = 270;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressBar.SubscriptText = "";
            progressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressBar.SuperscriptText = "";
            progressBar.TabIndex = 2;
            progressBar.TextMargin = new Padding(8, 8, 0, 0);
            progressBar.Value = 68;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(27, 23);
            label12.Name = "label12";
            label12.Size = new Size(206, 31);
            label12.TabIndex = 0;
            label12.Text = "Confirmation rate";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(37, 42, 64);
            panel7.Controls.Add(ImageBox);
            panel7.Controls.Add(labelDropImage);
            panel7.Controls.Add(label14);
            panel7.Location = new Point(546, 259);
            panel7.Name = "panel7";
            panel7.Size = new Size(505, 379);
            panel7.TabIndex = 6;
            panel7.Click += selectImage_Click;
            // 
            // ImageBox
            // 
            ImageBox.Image = (Image)resources.GetObject("ImageBox.Image");
            ImageBox.Location = new Point(96, 88);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(280, 207);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 3;
            ImageBox.TabStop = false;
            ImageBox.Click += selectImage_Click;
            // 
            // labelDropImage
            // 
            labelDropImage.AutoSize = true;
            labelDropImage.Font = new Font("Nirmala UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDropImage.ForeColor = Color.FromArgb(159, 151, 176);
            labelDropImage.Location = new Point(106, 298);
            labelDropImage.Name = "labelDropImage";
            labelDropImage.Size = new Size(249, 32);
            labelDropImage.TabIndex = 2;
            labelDropImage.Text = "Browse or drop image";
            labelDropImage.Click += selectImage_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(27, 23);
            label14.Name = "label14";
            label14.Size = new Size(164, 31);
            label14.TabIndex = 0;
            label14.Text = "Upload image";
            label14.Click += selectImage_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(37, 42, 64);
            panel8.Controls.Add(labelModelVersion);
            panel8.Controls.Add(labelModelName);
            panel8.Location = new Point(879, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(172, 150);
            panel8.TabIndex = 6;
            // 
            // labelModelVersion
            // 
            labelModelVersion.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelModelVersion.ForeColor = Color.FromArgb(159, 151, 176);
            labelModelVersion.Location = new Point(27, 106);
            labelModelVersion.Name = "labelModelVersion";
            labelModelVersion.Size = new Size(132, 30);
            labelModelVersion.TabIndex = 2;
            // 
            // labelModelName
            // 
            labelModelName.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelModelName.ForeColor = Color.White;
            labelModelName.ImageAlign = ContentAlignment.MiddleLeft;
            labelModelName.Location = new Point(27, 23);
            labelModelName.Name = "labelModelName";
            labelModelName.Size = new Size(132, 75);
            labelModelName.TabIndex = 0;
            labelModelName.Text = "Info";
            // 
            // btnPrediction
            // 
            btnPrediction.BackColor = Color.FromArgb(37, 42, 64);
            btnPrediction.FlatAppearance.BorderSize = 0;
            btnPrediction.FlatStyle = FlatStyle.Flat;
            btnPrediction.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrediction.ForeColor = Color.FromArgb(22, 204, 200);
            btnPrediction.Location = new Point(546, 654);
            btnPrediction.Name = "btnPrediction";
            btnPrediction.Size = new Size(505, 67);
            btnPrediction.TabIndex = 1;
            btnPrediction.Text = "Prediction";
            btnPrediction.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrediction.UseVisualStyleBackColor = false;
            btnPrediction.Click += btnPrediction_Click;
            btnPrediction.MouseLeave += btnPrediction_MouseLeave;
            btnPrediction.MouseHover += btnPrediction_MouseHover;
            // 
            // btnMoreInfo
            // 
            btnMoreInfo.BackColor = Color.FromArgb(37, 42, 64);
            btnMoreInfo.Enabled = false;
            btnMoreInfo.FlatAppearance.BorderSize = 0;
            btnMoreInfo.FlatStyle = FlatStyle.Flat;
            btnMoreInfo.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMoreInfo.ForeColor = Color.Red;
            btnMoreInfo.Location = new Point(221, 654);
            btnMoreInfo.Name = "btnMoreInfo";
            btnMoreInfo.Size = new Size(306, 67);
            btnMoreInfo.TabIndex = 7;
            btnMoreInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMoreInfo.UseVisualStyleBackColor = false;
            btnMoreInfo.Click += btnMoreInfo_Click;
            // 
            // AppView
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1075, 750);
            Controls.Add(btnMoreInfo);
            Controls.Add(panel7);
            Controls.Add(btnPrediction);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(AppBar);
            Controls.Add(lineBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AppView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brian Pathology";
            Load += AppView_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            DragLeave += Form1_DragLeave;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            imagePanel.ResumeLayout(false);
            imagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            AppBar.ResumeLayout(false);
            AppBar.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label dateTimeLabel;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSettings;
        private Button btn1;
        private Panel lineBar;
        private Label label3;
        private TextBox textBox1;
        private Button btnClose;
        private Panel AppBar;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label labelServerInfo;
        private Label labelServerConnection;
        private Label label4;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label7;
        private Label labelImageCount;
        private Label label9;
        private Panel panel6;
        private Label label12;
        private CircularProgressBar.CircularProgressBar progressBar;
        private Panel panel7;
        private PictureBox ImageBox;
        private Label label14;
        private Panel panel8;
        private Label labelModelVersion;
        private Label labelModelName;
        private Button btnPrediction;
        private Label labelDropImage;
        private Panel imagePanel;
        private Label label16;
        private PictureBox pictureBox5;
        private Button btnMoreInfo;
    }
}