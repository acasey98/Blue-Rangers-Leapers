using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class EventsRepository
    {
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
        public List<Event> GetEvents()
        {
            return _events;
        }

        public void SaveNewEvent(Event newEvent)
        {
            throw new NotImplementedException();
        }

        public void ChangeFinishedLeapInfo(Leaper leaper)
        {
            if (leaper.CurrentEventID == 100)
            {
                return;
            }
            // selects the leaper's finished event and sets 'isPutRight' to true
            var finishedLeap = _events.First(eventThing => eventThing.ID == leaper.CurrentEventID);
            finishedLeap.isPutRight = true;

            // selects the finished Host and sets it back to false (the Host is becoming available again because the leaper is leaving this host & event)
            finishedLeap.Hosts[leaper.CurrentHostID] = false;

            // selects a random event - if the event's date is in the future, then there is a 15% chance the future event isPutRight will be set to false
            var randomEvent = _events[RandomNumber(0, _events.Count())];
            if (randomEvent.DateTime > leaper.CurrentDateTime && RandomNumber(1, 100) <= 15)
            {
                randomEvent.isPutRight = false;
            }
        }

        public void ChangeCurrentLeapInfo(Event eventThing, Host host)
        {
            eventThing.Hosts[host.ID] = true;
        }

        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
