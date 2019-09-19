using System;
using System.Collections.Generic;


namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {
            var Events = new List<Event>()
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
                        { 5, false },
                        { 6, false },
                        { 7, false }
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
                        { 5, false },
                        { 6, false },
                        { 7, false }
                    },
                    isPutRight = false
                }
            };

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            int generateRandomEvent()
            {
                return RandomNumber(0, Events.Count);
            }
        }
    }
}
