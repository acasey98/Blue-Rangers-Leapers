using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class EventsRepository
    {
        static List<Event> _events = new List<Event>() {

            new Event
                {
                 ID = 0,
                 DateTime = new DateTime(2016, 11, 08),
                 Description = "Trump inauguration",
                 Hosts = new Dictionary<int, bool>
                 {
                     { 5, false },
                     { 6, false },
                     { 7, false }
                 },
                 isPutRight = false
                },
            new Event
                {
                 ID = 1,
                 DateTime = new DateTime(1998, 08, 17),
                 Description = "Clinton testimony",
                 Hosts = new Dictionary<int, bool>
                 {
                     { 0, false },
                     { 1, false },
                     { 2, false }
                 },
                 isPutRight = false
                },
            new Event
                {
                 ID = 2,
                 DateTime = new DateTime(2009, 09, 13),
                 Description = "Kanye interrupts T-Swift VMA speech",
                 Hosts = new Dictionary<int, bool>
                 {
                     { 3, false },
                     { 4, false },
                     { 5, false }
                 },
                 isPutRight = false
                }
                };

        public List<Event> GetEvents()
        {
            return _events;
        }
    }
}
