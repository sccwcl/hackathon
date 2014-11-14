using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTrayApp
{
    class Meeting
    {
        //calendar properties we care about
        /// <summary>
        /// Unique GUID of the meeting 
        /// </summary>
        public string id;
        /// <summary>
        /// meeting owner
        /// </summary>
        public string owner;
        /// <summary>
        /// meeting subject
        /// </summary>
        public string subject;
        /// <summary>
        /// start time of meeting
        /// </summary>
        public string startTime;
        /// <summary>
        /// end time of meeting
        /// </summary>
        public string endTime;
        /// <summary>
        /// list of email IDs of meeting attendees
        /// </summary>
        public List<string> attendees = new List<string>();
    }
}
