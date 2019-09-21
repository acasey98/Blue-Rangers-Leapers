using System;
using System.Collections.Generic;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {        
<<<<<<< HEAD
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
=======
            Leaper pickALeaper(string whyTheyPicked)
>>>>>>> master
            {
                // changes the phrase shown depending on what option they picked
                var doThisThing = (whyTheyPicked == "1" ? "get leapin": "show their leaps");
                // A large number just so it goes
                var leaperPickedNumber = "";
                // initializes a new repo class
                var leaperRepo = new LeaperRepository();
                // leapers is now a list of all the Leapers
                var leapers = leaperRepo.GetAll();
                // while the number picked is not the options we need, repeat the question
                while(leaperPickedNumber != "1" & leaperPickedNumber != "2" & leaperPickedNumber != "3")
                {
                    Console.WriteLine($"Please pick a leaper to {doThisThing}");
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
<<<<<<< HEAD
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
=======
                    var pickedLeaper = pickALeaper(response);
>>>>>>> master
                    response = "";
                }
                while(response == "2")
                {
                    Budget.AddMoney();
                    response = "";
                }
                while(response =="3")
                {
                    var pickedLeaper = pickALeaper(response);
                    var leapRepo = new LeapRepository();
                    var leaps = leapRepo.GetLeaps(pickedLeaper);
                    foreach(string leap in leaps)
                    {
                        Console.WriteLine(leap);
                    }
                    if (leaps.Count == 0)
                    {
                        Console.WriteLine("They haven't leaped yet! Try sending them out on their first leap");
                    }
                    response = "";
                }
                if (response.ToLower() == "q")
                {
                    break;
                }
            }
        }
    }
}
