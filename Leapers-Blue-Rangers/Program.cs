using System;
using System.Collections.Generic;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {        
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            Leaper pickALeaper(string whyTheyPicked)
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

            Event pickRandomEvent(Leaper pickedLeaper)
            {
                var eventsRepo = new EventsRepository();
                var eventsAvailableToLeap = eventsRepo.GetEvents().Where(singleEvent => singleEvent.isPutRight == false & singleEvent.DateTime != pickedLeaper.CurrentDateTime).ToArray();
                if (eventsAvailableToLeap.Length > 0)
                {
                    var randomEvent = eventsAvailableToLeap[RandomNumber(0, eventsAvailableToLeap.Count())];
                    return randomEvent;
                }
                return null;
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
                    var pickedLeaper = pickALeaper(response);
                    var randomEvent = pickRandomEvent(pickedLeaper);
                    if (randomEvent == null)
                    {
                        Console.WriteLine("Congrats MFer, you won!");
                        Console.ReadLine();
                        response = "q";
                    }
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
