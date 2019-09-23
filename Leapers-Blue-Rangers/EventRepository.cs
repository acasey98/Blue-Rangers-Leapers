using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class EventRepository
    {
        public List<Event> GetEvents()
        {
            return _events;
        }

        public void ChangeFinishedLeapInfo(Leaper leaper)
        {
            // selects the leaper's finished event and sets 'isPutRight' to true
            var finishedEvent = GetEvents().Where(singleEvent => singleEvent.ID == leaper.CurrentEventID);
            finishedEvent.Select(singleEvent => singleEvent.isPutRight = true).ToList();

            // selects the finished Host and sets it back to false (the Host is becoming available again because the leaper is leaving this host & event)
            finishedEvent.Select(singleEvent => singleEvent.Hosts[leaper.CurrentHostID] = false);

        }

        public void ChangeCurrentLeapInfo(Event event)
        {
            var startingEvent = GetEvents().Where(singleEvent => singleEvent.ID == event.ID);
        }

        static List<Event> _events = new List<Event>()
        {
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
    }
}
