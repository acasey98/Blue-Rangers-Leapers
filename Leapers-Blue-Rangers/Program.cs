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

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            int generateRandomEvent()
            {
                return RandomNumber(0, Events.Count);
            }
<<<<<<< HEAD

            var Leapers = new List<Leaper>() {

                new Leaper
                {
                   ID = 0,
                   Name = "Johnnie",
                   CurrentDateTime = ,
                   CurrentEventID = ,
                   CurrentHostID = 5,

                },
=======
>>>>>>> master


<<<<<<< HEAD
                new Leaper
                {
                    ID = 3,
                    Name = "Jackie",
                    CurrentDateTime = ,
                    CurrentEventID = ,
                    CurrentHostID = 6,
                }
            };
=======
         
>>>>>>> master
                  
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
<<<<<<< HEAD
=======

            var response = "";
            var runsTheGame = (response != "1" || response != "2" || response != "3" || response != "q");
            while (runsTheGame)
            {
                Console.WriteLine("Please select one of the following options or press 'q' to quit");
                Console.WriteLine("1. Send a leaper on their next mission!");
                Console.WriteLine("2. Fund more leaps!");
                Console.WriteLine("3. Show past leaps");
                response = Console.ReadLine();
                while(response == "1")
                {
                    Console.WriteLine("You picked one");
                    response = "";
                    // Does whatever we do in 1, then at the end changes the response variable to an empty string which goes back to main menu
                }
                while(response == "2")
                {
                    Console.WriteLine("You picked two");
                    response = "";
                    // Does the budget stuff, then at the end changes the response variable to an empty string which goes back to the main menu
                }
                while(response =="3")
                {
                    Console.WriteLine("You picked three");
                    response = "";
                    // Does the show past leaps stuff, then at the end changes the response variable to an empty string which goes back to the main menu
                }
                if (response.ToLower() == "q")
                {
                    break;
                }
            }
>>>>>>> master
        }
    }
}
