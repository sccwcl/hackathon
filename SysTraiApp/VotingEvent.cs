using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTrayApp
{
    public class VotingEvent
    {
        public int MeetingID { get; set; }
        public int UserID { get; set; }
        public DateTime VotingTime { get; set; }
        public bool Vote { get; set; }
        public string Reason { get; set; }

    }
}
