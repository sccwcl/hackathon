namespace SystrayApp
{
    partial class SysTrayApp
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
            this.Btn_UpVote = new System.Windows.Forms.Button();
            this.Btn_DownVote = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_UpVote
            // 
            this.Btn_UpVote.Location = new System.Drawing.Point(84, 52);
            this.Btn_UpVote.Name = "Btn_UpVote";
            this.Btn_UpVote.Size = new System.Drawing.Size(75, 23);
            this.Btn_UpVote.TabIndex = 0;
            this.Btn_UpVote.Text = "Up Vote";
            this.Btn_UpVote.UseVisualStyleBackColor = true;
            this.Btn_UpVote.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_DownVote
            // 
            this.Btn_DownVote.AllowDrop = true;
            this.Btn_DownVote.Location = new System.Drawing.Point(262, 52);
            this.Btn_DownVote.Name = "Btn_DownVote";
            this.Btn_DownVote.Size = new System.Drawing.Size(75, 23);
            this.Btn_DownVote.TabIndex = 1;
            this.Btn_DownVote.Text = "Down Vote";
            this.Btn_DownVote.UseVisualStyleBackColor = true;
            this.Btn_DownVote.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SysTrayApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 190);
            this.Controls.Add(this.Btn_DownVote);
            this.Controls.Add(this.Btn_UpVote);
            this.Name = "SysTrayApp";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_UpVote;
        private System.Windows.Forms.Button Btn_DownVote;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
    }
}

