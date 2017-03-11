namespace TextBasedProgramming.Forms
{
    partial class TestDropboxAPIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestDropboxAPIForm));
            this.btn_upload_file = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_create_folder = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listView2 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loadingProgressBar = new CircularProgressBar.CircularProgressBar();
            this.SuspendLayout();
            // 
            // btn_upload_file
            // 
            this.btn_upload_file.Location = new System.Drawing.Point(940, 616);
            this.btn_upload_file.Name = "btn_upload_file";
            this.btn_upload_file.Size = new System.Drawing.Size(103, 33);
            this.btn_upload_file.TabIndex = 10;
            this.btn_upload_file.Text = "Upload file";
            this.btn_upload_file.UseVisualStyleBackColor = true;
            this.btn_upload_file.Click += new System.EventHandler(this.btn_upload_file_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 565);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(911, 33);
            this.textBox1.TabIndex = 9;
            // 
            // btn_create_folder
            // 
            this.btn_create_folder.Location = new System.Drawing.Point(940, 565);
            this.btn_create_folder.Name = "btn_create_folder";
            this.btn_create_folder.Size = new System.Drawing.Size(103, 33);
            this.btn_create_folder.TabIndex = 8;
            this.btn_create_folder.Text = "Create folder";
            this.btn_create_folder.UseVisualStyleBackColor = true;
            this.btn_create_folder.Click += new System.EventHandler(this.btn_create_folder_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView2.GridLines = true;
            this.listView2.LargeImageList = this.imageList1;
            this.listView2.Location = new System.Drawing.Point(12, 12);
            this.listView2.Name = "listView2";
            this.listView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView2.Size = new System.Drawing.Size(1031, 540);
            this.listView2.TabIndex = 12;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 100);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 616);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(911, 33);
            this.progressBar1.TabIndex = 11;
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("loadingProgressBar.AnimationFunction")));
            this.loadingProgressBar.AnimationSpeed = 500;
            this.loadingProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.loadingProgressBar.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadingProgressBar.InnerColor = System.Drawing.Color.White;
            this.loadingProgressBar.InnerMargin = 0;
            this.loadingProgressBar.InnerWidth = 0;
            this.loadingProgressBar.Location = new System.Drawing.Point(485, 220);
            this.loadingProgressBar.MarqueeAnimationSpeed = 2000;
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.loadingProgressBar.OuterMargin = -11;
            this.loadingProgressBar.OuterWidth = 5;
            this.loadingProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(251)))), ((int)(((byte)(50)))));
            this.loadingProgressBar.ProgressWidth = 8;
            this.loadingProgressBar.SecondaryFont = new System.Drawing.Font("Segoe UI Semilight", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingProgressBar.Size = new System.Drawing.Size(100, 100);
            this.loadingProgressBar.StartAngle = 270;
            this.loadingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingProgressBar.SubscriptColor = System.Drawing.Color.Gray;
            this.loadingProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.loadingProgressBar.SubscriptText = "";
            this.loadingProgressBar.SuperscriptColor = System.Drawing.Color.Gray;
            this.loadingProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.loadingProgressBar.SuperscriptText = "°C";
            this.loadingProgressBar.TabIndex = 13;
            this.loadingProgressBar.Text = "Chờ chút nha";
            this.loadingProgressBar.TextMargin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.loadingProgressBar.Value = 67;
            // 
            // TestDropboxAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 661);
            this.Controls.Add(this.btn_upload_file);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_create_folder);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.loadingProgressBar);
            this.Controls.Add(this.listView2);
            this.Name = "TestDropboxAPIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestDropboxAPIForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestDropboxAPIForm_FormClosed);
            this.Load += new System.EventHandler(this.TestDropboxAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upload_file;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_create_folder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private CircularProgressBar.CircularProgressBar loadingProgressBar;
    }
}