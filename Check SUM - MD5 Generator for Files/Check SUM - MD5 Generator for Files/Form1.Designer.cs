namespace Check_SUM___MD5_Generator_for_Files
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectFile = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.TextBox();
            this.CheckSum = new System.Windows.Forms.RichTextBox();
            this.CalculateMD5 = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(197, 12);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 23);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "Select File";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(12, 14);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(179, 20);
            this.FileName.TabIndex = 1;
            // 
            // CheckSum
            // 
            this.CheckSum.Location = new System.Drawing.Point(8, 138);
            this.CheckSum.Name = "CheckSum";
            this.CheckSum.ReadOnly = true;
            this.CheckSum.Size = new System.Drawing.Size(264, 111);
            this.CheckSum.TabIndex = 2;
            this.CheckSum.Text = "";
            // 
            // CalculateMD5
            // 
            this.CalculateMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CalculateMD5.Location = new System.Drawing.Point(12, 40);
            this.CalculateMD5.Name = "CalculateMD5";
            this.CalculateMD5.Size = new System.Drawing.Size(260, 92);
            this.CalculateMD5.TabIndex = 3;
            this.CalculateMD5.Text = "Calculate MD5";
            this.CalculateMD5.UseVisualStyleBackColor = true;
            this.CalculateMD5.Click += new System.EventHandler(this.CalculateMD5_Click);
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.Color.Chartreuse;
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Loading.Location = new System.Drawing.Point(57, 186);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(145, 17);
            this.Loading.TabIndex = 4;
            this.Loading.Text = "Loading MD5 Hash....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.CalculateMD5);
            this.Controls.Add(this.CheckSum);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.SelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.RichTextBox CheckSum;
        private System.Windows.Forms.Button CalculateMD5;
        private System.Windows.Forms.Label Loading;
    }
}

