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

<<<<<<< HEAD
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
=======

            var Leapers = new List<Leaper>() {

                new Leaper
                {
                   ID = 0,
                   Name = "Johnnie",
                   CurrentDateTime = ,
                   CurrentEventID = ,
                   CurrentHostID = 5,

                },

                new Leaper
                {
                    ID = 1,
                    Name = "Jesse",
                    CurrentDateTime = ,
                    CurrentEventID = ,
                    CurrentHostID = 1,
                },

                new Leaper
                {
                    ID = 3,
                    Name = "Jackie",
                    CurrentDateTime = ,
                    CurrentEventID = ,
                    CurrentHostID = 6,
                }
            };
                  
            var Hosts = new List<Host>()
            {
                new Host
                {
                    ID = 0,
                    Name = "Cigar"
                },
                new Host
                {
                    ID = 1,
                    Name = "Bill Clinton"
                },
                new Host
                {
                    ID = 2,
                    Name = "Monica Lewinsky"
                },
                new Host
                {
                    ID = 3,
                    Name = "Kanye West"
                },
                new Host
                {
                    ID = 4,
                    Name = "VMA Judge"
                },
                new Host
                {
                    ID = 5,
                    Name = "Voter"
                },
                new Host
                {
                    ID = 6,
                    Name = "Donald Trump"
                },
                new Host
                {
                    ID = 7,
                    Name = "Vladmir Putin"
                }
            };
>>>>>>> master
        }
    }
}
