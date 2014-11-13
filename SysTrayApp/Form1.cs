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
    public partial class Form1 : Form
    {
        private NotifyIcon sysTrayIcon;
        private ContextMenu sysTrayMenu;
        
        public Form1()
        {
            InitializeComponent();

            ControlBox = false;
            sysTrayMenu = new ContextMenu();
            sysTrayMenu.MenuItems.Add("Enable UI", OnEnable);
            sysTrayMenu.MenuItems.Add("Exit", OnExit);

            sysTrayIcon = new NotifyIcon();
            sysTrayIcon.Icon = new Icon(SystemIcons.Shield, 40, 40);

            sysTrayIcon.ContextMenu = sysTrayMenu;
            sysTrayIcon.Text = "MeetingVotingApp";
            sysTrayIcon.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;
            base.OnLoad(e);    
        }

        private void OnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnEnable(object sender, EventArgs e)
        {
            VotingForm newForm = new VotingForm();
            newForm.Visible = true;
        }

        
    }
}
