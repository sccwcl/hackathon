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
        /// <summary>
        /// get list of meetings on calendar
        /// </summary>
        public void GetCalendarMeetings()
        {
            Application app = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace session = app.Session;
            Stores stores = session.Stores;
            Folder calFolder =
            app.Session.GetDefaultFolder(OlDefaultFolders.olFolderCalendar) as Folder;
            DateTime start = DateTime.Now;
            DateTime end = start.AddDays(1);
            Items rangeAppts = GetAppointmentsInRange(calFolder, start, end);
            if (rangeAppts != null)
            {
                foreach (AppointmentItem appt in rangeAppts)
                {
                    string subject =  appt.Subject;
                    string startTime = appt.Start.ToString("yyyy:mm:dd hh:mm:ss");
                }
            }

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
                + "' AND [End] <= '"
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