using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SysTrayApp
{
    public partial class Form1 : Form
    {
        private NotifyIcon sysTrayIcon;
        private ContextMenu sysTrayMenu;
        private static List<Meeting> meetings = new List<Meeting>();
        
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


            CalendarData d = new CalendarData();
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(5);
            List<Meeting> result = d.GetAlerts(start, end);
            meetings.AddRange(result);

            for (int i = 0; i < meetings.Count;i++ )
            {
                Meeting m = meetings[i];
                Random random = new Random();
                int randomNumer = random.Next(1, 10) * (-1);
                DateTime ddt = m.endTime;
                DateTime dt = m.endTime.AddMinutes(-59);
                m.RatingTime = dt;
            }
                //foreach (Meeting m in meetings)
                //{
                //    Random random = new Random();
                //    int randomNumer = random.Next(1, 10) * (-1);
                //    DateTime dt = DateTime.Parse(m.endTime).AddHours(randomNumer);
                //    m.RatingTime = dt.ToString();
                //}
            meetings = meetings.OrderBy(o => o.RatingTime).ToList();

            var t = new Thread(CheckAlerts);
            t.Start();

            //Start the timer;
            System.Timers.Timer calendarCheckTimer = new System.Timers.Timer();
            calendarCheckTimer.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            calendarCheckTimer.Interval = 300000;
            calendarCheckTimer.Enabled = true;
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            CalendarData d = new CalendarData();
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(5);
            List<Meeting> result = d.GetAlerts(start, end);
            meetings.AddRange(result);
            
            foreach (Meeting m in meetings)
            {
                Random random = new Random();
                int randomNumer = random.Next(1, 10) * (-1);
                DateTime dt = m.endTime.AddHours(randomNumer);
                m.RatingTime = dt;
            }
            meetings = meetings.OrderBy(o => o.RatingTime).ToList();
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
 
        private static void PopUpRatingWindow()
        {
            Application.Run(new VotingForm());
        }

 
        public static void CheckAlerts()
        {
            while(true)
            {
                if(meetings.Count>0)
                {
                    
                    Meeting m = meetings[0];
                    DateTime dt = m.RatingTime;
                    if(DateTime.Compare(DateTime.Now,dt) > 0)
                    {
                        Application.Run(new VotingForm());
                        //Task.Factory.StartNew(() => PopUpRatingWindow());
                        
                        meetings.Remove(meetings[0]);
                    }
                }
            }
        }
    }
}
