using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool isFixed { get; set; }
        public Dictionary<int, bool> Hosts { get; set; }

    }
}
