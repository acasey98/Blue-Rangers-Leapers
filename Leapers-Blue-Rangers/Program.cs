using System;
using System.Collections.Generic;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {        
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

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            Leaper pickALeaper()
            {
                // A large number just so it goes
                var leaperPickedNumber = "";
                // initializes a new repo class
                var leaperRepo = new LeaperRepository();
                // leapers is now a list of all the Leapers
                var leapers = leaperRepo.GetAll();
                // while the number picked is not the options we need, repeat the question
                while(leaperPickedNumber != "1" & leaperPickedNumber != "2" & leaperPickedNumber != "3")
                {
                    Console.WriteLine("Please pick a leaper to get leapin");
                    for (var i = 0; i < leapers.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {leapers[i].Name}");
                    }
                    leaperPickedNumber = Console.ReadLine();
                }
                var leaperPicked = leapers.First(Leaper => Leaper.ID == (Int32.Parse(leaperPickedNumber) - 1));
                Console.WriteLine($"You picked {leaperPicked.Name}");
                return leaperPicked;
            }

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
                    var pickedLeaper = pickALeaper();
                    var eventsRepo = new EventsRepository();
                    var eventsAvailableToLeap = eventsRepo.GetEvents().Where(singleEvent => singleEvent.isPutRight == false & singleEvent.DateTime != pickALeaper().CurrentDateTime).ToArray();
                    if (eventsAvailableToLeap.Length > 0)
                    {
                        var randomEvent = eventsAvailableToLeap[RandomNumber(0, eventsAvailableToLeap.Count())];
                    }

                    /*                    var eventsRepo = new EventsRepository();
                                        var events = eventsRepo.GetAll().Where(singleEvent => singleEvent.isPutRight == false & singleEvent.DateTime != leaperPicked.CurrentDateTime).ToArray();
                                        // TODO If events is empty than GAMEOVER
                                        var randomEvent = events[RandomNumber(0, events.Count())];
                                        var hostPicked = randomEvent.Hosts.First((key, value) => value == false);*/
                    // if hostPicked is empty than find another event
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
        }
    }
}
