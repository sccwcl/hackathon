using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;

namespace SysTrayApp
{
    class CalendarData
    {
        public List<Meeting> GetAlerts(DateTime start, DateTime end)
        {
            return GetCalendarMeetings(start, end);
        }

        /// <summary>
        /// get list of meetings on calendar that will start in next 30 min
        /// </summary>
        private List<Meeting> GetCalendarMeetings(DateTime start, DateTime end)
        {
            List<Meeting> meetingList = new List<Meeting>();

            Application app = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace session = app.Session;
            Stores stores = session.Stores;
            Folder calFolder =
            app.Session.GetDefaultFolder(OlDefaultFolders.olFolderCalendar) as Folder;
            Items rangeAppts = GetAppointmentsInRange(calFolder, start, end);
            if (rangeAppts != null)
            {                
                foreach (AppointmentItem appt in rangeAppts)
                {
                    Meeting meet = new Meeting(); 
                    meet.subject =  appt.Subject;
                    meet.id = appt.GlobalAppointmentID;
                    meet.startTime = appt.Start.ToString("yyyy:mm:dd hh:mm:ss");
                    meet.endTime = appt.End.ToString("yyyy:mm:dd hh:mm:ss");
                    meetingList.Add(meet);
                }
            }

            return meetingList;
        }

        /// <summary>
        /// Get recurring appointments in date range.
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns>Outlook.Items</returns>
        private Items GetAppointmentsInRange(
          Folder folder, DateTime startTime, DateTime endTime)
        {
            string filter = "[Start] >= '"
                + startTime.ToString("g")
                + "' AND [Start] <= '"
                + endTime.ToString("g") + "'";
            try
            {
                Items calItems = folder.Items;
                calItems.IncludeRecurrences = true;
                calItems.Sort("[Start]", Type.Missing);
                Items restrictItems = calItems.Restrict(filter);
                if (restrictItems.Count > 0)
                {
                    
                    return restrictItems;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
        }
    }
}