using System.Windows.Forms;
namespace SysTrayApp
{
    partial class VotingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotingForm));
            this.Btn_UpVote = new System.Windows.Forms.Button();
            this.Btn_DownVote = new System.Windows.Forms.Button();
            this.ComboBox_Reasons = new System.Windows.Forms.ComboBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_MeetingName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NotAttending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_UpVote
            // 
            this.Btn_UpVote.BackColor = System.Drawing.Color.Transparent;
            this.Btn_UpVote.FlatAppearance.BorderSize = 0;
            this.Btn_UpVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UpVote.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UpVote.Image")));
            this.Btn_UpVote.Location = new System.Drawing.Point(101, 61);
            this.Btn_UpVote.Name = "Btn_UpVote";
            this.Btn_UpVote.Size = new System.Drawing.Size(63, 69);
            this.Btn_UpVote.TabIndex = 0;
            this.Btn_UpVote.TabStop = false;
            this.Btn_UpVote.UseVisualStyleBackColor = false;
            this.Btn_UpVote.Click += new System.EventHandler(this.Btn_UpVote_Click);
            // 
            // Btn_DownVote
            // 
            this.Btn_DownVote.FlatAppearance.BorderSize = 0;
            this.Btn_DownVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DownVote.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DownVote.Image")));
            this.Btn_DownVote.Location = new System.Drawing.Point(184, 62);
            this.Btn_DownVote.Name = "Btn_DownVote";
            this.Btn_DownVote.Size = new System.Drawing.Size(63, 67);
            this.Btn_DownVote.TabIndex = 1;
            this.Btn_DownVote.TabStop = false;
            this.Btn_DownVote.UseVisualStyleBackColor = true;
            this.Btn_DownVote.Click += new System.EventHandler(this.Btn_DownVote_Click);
            // 
            // ComboBox_Reasons
            // 
            this.ComboBox_Reasons.FormattingEnabled = true;
            this.ComboBox_Reasons.Location = new System.Drawing.Point(91, 135);
            this.ComboBox_Reasons.Name = "ComboBox_Reasons";
            this.ComboBox_Reasons.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_Reasons.TabIndex = 2;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(235, 134);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(38, 23);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your vote helps us improve!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meeting:";
            // 
            // Lbl_MeetingName
            // 
            this.Lbl_MeetingName.AutoSize = true;
            this.Lbl_MeetingName.Location = new System.Drawing.Point(138, 44);
            this.Lbl_MeetingName.Name = "Lbl_MeetingName";
            this.Lbl_MeetingName.Size = new System.Drawing.Size(0, 13);
            this.Lbl_MeetingName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Why:";
            // 
            // lbl_NotAttending
            // 
            this.lbl_NotAttending.AutoSize = true;
            this.lbl_NotAttending.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NotAttending.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_NotAttending.Location = new System.Drawing.Point(110, 139);
            this.lbl_NotAttending.Name = "lbl_NotAttending";
            this.lbl_NotAttending.Size = new System.Drawing.Size(119, 13);
            this.lbl_NotAttending.TabIndex = 8;
            this.lbl_NotAttending.Text = "Not attending today";
            this.lbl_NotAttending.Click += new System.EventHandler(this.lbl_NotAttending_Click);
            this.lbl_NotAttending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_NotAttending_MouseMove);
            // 
            // VotingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(350, 168);
            this.Controls.Add(this.lbl_NotAttending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_MeetingName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.ComboBox_Reasons);
            this.Controls.Add(this.Btn_DownVote);
            this.Controls.Add(this.Btn_UpVote);
            this.Name = "VotingForm";
            this.Text = "VotingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_UpVote;
        private System.Windows.Forms.Button Btn_DownVote;
        private System.Windows.Forms.ComboBox ComboBox_Reasons;
        private System.Windows.Forms.Button Btn_Ok;
        private Label label1;
        private Label label2;
        private Label Lbl_MeetingName;
        private Label label3;
        private Label lbl_NotAttending;
    }
}