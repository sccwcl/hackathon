namespace SysTraiApp
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
            this.Btn_UpVote = new System.Windows.Forms.Button();
            this.Btn_DownVote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_UpVote
            // 
            this.Btn_UpVote.Location = new System.Drawing.Point(144, 85);
            this.Btn_UpVote.Name = "Btn_UpVote";
            this.Btn_UpVote.Size = new System.Drawing.Size(75, 23);
            this.Btn_UpVote.TabIndex = 0;
            this.Btn_UpVote.Text = "Up Vote";
            this.Btn_UpVote.UseVisualStyleBackColor = true;
            this.Btn_UpVote.Click += new System.EventHandler(this.Btn_UpVote_Click);
            // 
            // Btn_DownVote
            // 
            this.Btn_DownVote.Location = new System.Drawing.Point(303, 85);
            this.Btn_DownVote.Name = "Btn_DownVote";
            this.Btn_DownVote.Size = new System.Drawing.Size(75, 23);
            this.Btn_DownVote.TabIndex = 1;
            this.Btn_DownVote.Text = "Down Vote";
            this.Btn_DownVote.UseVisualStyleBackColor = true;
            this.Btn_DownVote.Click += new System.EventHandler(this.Btn_DownVote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 263);
            this.Controls.Add(this.Btn_DownVote);
            this.Controls.Add(this.Btn_UpVote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_UpVote;
        private System.Windows.Forms.Button Btn_DownVote;
    }
}

