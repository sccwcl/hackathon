using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTrayApp
{
    public partial class VotingForm : Form
    {
        private VotingEvent votingEvent = new VotingEvent();
        public VotingForm()
        {
            InitializeComponent();
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            var wa = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(wa.Right - Width, wa.Bottom - Height);

            this.Btn_UpVote.TabStop = false;
            this.Btn_UpVote.FlatStyle = FlatStyle.Flat;
            this.Btn_UpVote.FlatAppearance.BorderSize = 0;

            this.Btn_DownVote.TabStop = false;
            this.Btn_DownVote.FlatStyle = FlatStyle.Flat;
            this.Btn_DownVote.FlatAppearance.BorderSize = 0;

            
            label3.Visible = false;
            ComboBox_Reasons.Visible = false;
            Btn_Ok.Visible = false;
            lbl_NotAttending.Visible = true;

            //Lbl_MeetingName.Text = meeting.subject;
        }

        private void Btn_UpVote_Click(object sender, EventArgs e)
        {
            Btn_UpVote.Enabled = false;
            
            votingEvent.Vote = true;
            Visible = false;

        }

        private void Btn_DownVote_Click(object sender, EventArgs e)
        {
            //Btn_DownVote.Enabled = false;
            Btn_UpVote.Enabled = true;
            ComboBox_Reasons.Enabled = true;
            votingEvent.Vote = false;
            label3.Visible = true;
            ComboBox_Reasons.Visible = true;
            Btn_Ok.Visible = true;
            lbl_NotAttending.Visible = false;
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void lbl_NotAttending_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void lbl_NotAttending_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

    }
}
