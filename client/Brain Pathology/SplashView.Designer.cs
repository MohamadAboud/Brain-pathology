namespace Brain_Pathology
{
    partial class SplashView
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
            components = new System.ComponentModel.Container();
            progressBar = new CircularProgressBar.CircularProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
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
            progressBar.Location = new Point(33, 104);
            progressBar.MarqueeAnimationSpeed = 2000;
            progressBar.Name = "progressBar";
            progressBar.OuterColor = Color.FromArgb(26, 28, 43);
            progressBar.OuterMargin = -25;
            progressBar.OuterWidth = 26;
            progressBar.ProgressColor = Color.FromArgb(22, 204, 200);
            progressBar.ProgressWidth = 6;
            progressBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            progressBar.Size = new Size(175, 175);
            progressBar.StartAngle = 270;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            progressBar.SubscriptText = "";
            progressBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            progressBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            progressBar.SuperscriptText = "";
            progressBar.TabIndex = 1;
            progressBar.Text = "00%";
            progressBar.TextMargin = new Padding(8, 8, 0, 0);
            progressBar.Value = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(22, 204, 200);
            label1.Location = new Point(19, 46);
            label1.Name = "label1";
            label1.Size = new Size(214, 26);
            label1.TabIndex = 2;
            label1.Text = "Brain pathhology";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(58, 321);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 3;
            label2.Text = "Mohamad Aboud";
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(255, 378);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Cursor = Cursors.WaitCursor;
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashView";
            Opacity = 0.9D;
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CircularProgressBar.CircularProgressBar progressBar;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}