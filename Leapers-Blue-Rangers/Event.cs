using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class Event
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public bool isPutRight { get; set; }
        public int ID { get; set; }
        public string Location { get; set; }
        public Dictionary <int, bool> Hosts { get; set; }

    }
}
