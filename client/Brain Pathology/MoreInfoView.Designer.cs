namespace Brain_Pathology
{
    partial class MoreInfoView
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
            imageBox = new PictureBox();
            titleLb = new Label();
            descLb = new Label();
            btnDone = new Button();
            AppBar = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            AppBar.SuspendLayout();
            SuspendLayout();
            // 
            // imageBox
            // 
            imageBox.Location = new Point(388, 75);
            imageBox.Name = "imageBox";
            imageBox.Size = new Size(412, 313);
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.TabIndex = 0;
            imageBox.TabStop = false;
            imageBox.Click += imageBox_Click;
            // 
            // titleLb
            // 
            titleLb.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLb.ForeColor = Color.WhiteSmoke;
            titleLb.Location = new Point(3, 0);
            titleLb.Name = "titleLb";
            titleLb.Size = new Size(379, 69);
            titleLb.TabIndex = 1;
            titleLb.Text = "label1";
            titleLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // descLb
            // 
            descLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descLb.ForeColor = Color.WhiteSmoke;
            descLb.Location = new Point(12, 75);
            descLb.Name = "descLb";
            descLb.Size = new Size(370, 313);
            descLb.TabIndex = 2;
            descLb.Text = "label2";
            descLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.FromArgb(37, 42, 64);
            btnDone.FlatAppearance.BorderSize = 0;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDone.ForeColor = Color.FromArgb(22, 204, 200);
            btnDone.Location = new Point(12, 396);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(776, 67);
            btnDone.TabIndex = 3;
            btnDone.Text = "Done";
            btnDone.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // AppBar
            // 
            AppBar.Controls.Add(btnClose);
            AppBar.Controls.Add(titleLb);
            AppBar.Dock = DockStyle.Top;
            AppBar.Location = new Point(0, 0);
            AppBar.Name = "AppBar";
            AppBar.Size = new Size(800, 69);
            AppBar.TabIndex = 4;
            AppBar.MouseDown += AppBar_MouseDown;
            AppBar.MouseMove += AppBar_MouseMove;
            AppBar.MouseUp += AppBar_MouseUp;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(751, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 69);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MoreInfoView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 475);
            Controls.Add(AppBar);
            Controls.Add(btnDone);
            Controls.Add(descLb);
            Controls.Add(imageBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoreInfoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MoreInfoView";
            Load += MoreInfoView_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            AppBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imageBox;
        private Label titleLb;
        private Label descLb;
        private Button btnDone;
        private Panel AppBar;
        private Button btnClose;
    }
}