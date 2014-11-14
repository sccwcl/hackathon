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
        /// get list of meetings on calendar that will start within start-end range
        /// </summary>
        /// <param name="start">start time</param>
        /// <param name="end">end time</param>
        /// <returns>list of Meeting objects</returns>
        private List<Meeting> GetCalendarMeetings(DateTime start, DateTime end)
        {
            List<Meeting> meetingList = new List<Meeting>();

            Application app = new Microsoft.Office.Interop.Outlook.Application();
            NameSpace session = app.Session;
            Stores stores = session.Stores;

            string user = GetCurrentUserName(app);
            string email = GetCurrentUserEmail(app);

            Folder calFolder =
            app.Session.GetDefaultFolder(OlDefaultFolders.olFolderCalendar) as Folder;
            Items rangeAppts = GetAppointmentsInRange(calFolder, start, end);
            if (rangeAppts != null)
            {
                foreach (AppointmentItem appt in rangeAppts)
                {
                    Meeting meet = new Meeting();
                    meet.subject = appt.Subject;
                    meet.id = appt.GlobalAppointmentID;
                    //meet.startTime = appt.Start.ToString("yyyy:mm:dd hh:mm:ss");
                    //meet.endTime = appt.End.ToString("yyyy:mm:dd hh:mm:ss");
                    meet.startTime = appt.Start;
                    meet.endTime = appt.End;
                    meet.owner = GetMeetingOrganizer(appt).Name;
                    Recipients rp = GetMeetingRecipients(appt);
                    foreach (Recipient recip in rp)
                    {
                        PropertyAccessor pa = recip.PropertyAccessor;
                        const string PR_SMTP_ADDRESS = "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
                        string smtpAddress =
                            pa.GetProperty(PR_SMTP_ADDRESS).ToString();
                        meet.attendees.Add(smtpAddress);
                    }
                    meetingList.Add(meet);
                }
            }

            return meetingList;
        }

        /// <summary>
        /// Get recurring appointments in date range.
        /// </summary>
        /// <param name="folder">Default appointments folder</param>
        /// <param name="startTime">start time</param>
        /// <param name="endTime">end time</param>
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

        /// <summary>
        /// get meeting organizer for given meeting
        /// </summary>
        /// <param name="appt">appointment item</param>
        /// <returns>address entry of meeting organizer</returns>
        private AddressEntry GetMeetingOrganizer(AppointmentItem appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException();
            }
            string PR_SENT_REPRESENTING_ENTRYID =
                @"http://schemas.microsoft.com/mapi/proptag/0x00410102";
            string organizerEntryID =
                appt.PropertyAccessor.BinaryToString(
                    appt.PropertyAccessor.GetProperty(
                    PR_SENT_REPRESENTING_ENTRYID));
            AddressEntry organizer =
                appt.Session.
                GetAddressEntryFromID(organizerEntryID);
            if (organizer != null)
            {
                return organizer;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// get current user's username
        /// </summary>
        /// <param name="appt">outlook application object</param>
        /// <returns>username as string</returns>
        public string GetCurrentUserName(Application appt)
        {
            AddressEntry addrEntry =
                appt.Session.CurrentUser.AddressEntry;
            if (addrEntry.Type == "EX")
            {
                ExchangeUser currentUser =
                    appt.Session.CurrentUser.
                    AddressEntry.GetExchangeUser();
                if (currentUser != null)
                {
                    return currentUser.Name;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// get current user's email ID
        /// </summary>
        /// <param name="appt">outlook appointment object</param>
        /// <returns>current user's email as string</returns>
        public string GetCurrentUserEmail(Application appt)
        {
            AddressEntry addrEntry =
                appt.Session.CurrentUser.AddressEntry;
            if (addrEntry.Type == "EX")
            {
                ExchangeUser currentUser =
                    appt.Session.CurrentUser.
                    AddressEntry.GetExchangeUser();
                if (currentUser != null)
                {
                    return currentUser.PrimarySmtpAddress;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// get collection of meeting recepients for given meeting
        /// </summary>
        /// <param name="appt">outlook appointment item</param>
        /// <returns>collection of meeting recepients</returns>
        private Recipients GetMeetingRecipients(AppointmentItem appt)
        {
            if (appt == null)
            {
                throw new ArgumentNullException();
            }

            Recipients recips = appt.Recipients;

            const string PR_SMTP_ADDRESS =
        "http://schemas.microsoft.com/mapi/proptag/0x39FE001E";
            //foreach (Recipient recip in recips)
            //{
            //    PropertyAccessor pa = recip.PropertyAccessor;
            //    string smtpAddress =
            //        pa.GetProperty(PR_SMTP_ADDRESS).ToString();
            //}
            if (recips != null)
            {
                return recips;
            }
            else
            {
                return null;
            }
        }
    }
}