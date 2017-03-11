namespace TextBasedProgramming.Forms
{
    partial class StartForm
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
            this.btn_block_based_programming = new System.Windows.Forms.Button();
            this.btn_test_based_programming = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_block_based_programming
            // 
            this.btn_block_based_programming.Location = new System.Drawing.Point(12, 56);
            this.btn_block_based_programming.Name = "btn_block_based_programming";
            this.btn_block_based_programming.Size = new System.Drawing.Size(104, 146);
            this.btn_block_based_programming.TabIndex = 0;
            this.btn_block_based_programming.Text = "Block";
            this.btn_block_based_programming.UseVisualStyleBackColor = true;
            this.btn_block_based_programming.Click += new System.EventHandler(this.btn_block_based_programming_Click);
            // 
            // btn_test_based_programming
            // 
            this.btn_test_based_programming.Location = new System.Drawing.Point(147, 56);
            this.btn_test_based_programming.Name = "btn_test_based_programming";
            this.btn_test_based_programming.Size = new System.Drawing.Size(104, 146);
            this.btn_test_based_programming.TabIndex = 0;
            this.btn_test_based_programming.Text = "Test";
            this.btn_test_based_programming.UseVisualStyleBackColor = true;
            this.btn_test_based_programming.Click += new System.EventHandler(this.btn_test_based_programming_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.btn_test_based_programming);
            this.Controls.Add(this.btn_block_based_programming);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_block_based_programming;
        private System.Windows.Forms.Button btn_test_based_programming;
    }
}