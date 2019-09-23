using System;
using System.Collections.Generic;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiates the leap repo for the rest of the code
            var leapRepo = new LeapRepository();

            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

            Leaper PickALeaper(string whyTheyPicked)
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

            Host PickAHost(Event SingleEvent)
            {
                var hostRepo = new HostRepository();
                var hosts = hostRepo.GetHosts();

                var hostId = 1000;
                foreach (var (key, value) in SingleEvent.Hosts)
                {
                    if (!value)
                    {
                        hostId = key;

                        break;
                    }
                }
                var pickedHost = hosts.First(host => host.ID == hostId);
                return pickedHost;
            }

            Event PickRandomEvent(Leaper pickedLeaper)
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
            Console.WriteLine("Welcome To Quantom Leap!");
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
                    // if hostPicked is empty than find another event
                    var pickedLeaper = PickALeaper(response);                    
                    var randomEvent = PickRandomEvent(pickedLeaper);
                    if (randomEvent == null)
                    {
                        Console.WriteLine("Congrats MFer, you won!");
                        Console.ReadLine();
                        response = "q";
                        break;
                    }
                    var pickedHost = PickAHost(randomEvent);
                    if (Budget.BudgetCheck(pickedLeaper, randomEvent) == false)
                    {
                        //This code will execute when the user decides they do not want to add funds, and would rather try to leap again
                        response = "";
                        break;
                    }
                    else
                    {
                        //This code will execute when the user has sufficient funds in the budget
                        //This is where the Leap should be instantiated using the previously generated data
                        Console.WriteLine($"{pickedLeaper.Name} leaps from {pickedLeaper.CurrentDateTime} to {randomEvent.DateTime}.");
                        var newLeap = new Leap
                        {
                            Leaper = pickedLeaper,
                            Host = pickedHost,
                            SingleEvent = randomEvent,
                        };                        
                        leapRepo.SaveNewLeap(newLeap);
                        var leaperRepo = new LeaperRepository();
                        //Now the appropriate bool values of the previous and leapt to event's hosts must be changed.
                        //also check the previous event of the leaper and switch its `isPutRight` to true.
                        leaperRepo.ChangeLeaperInfo(pickedLeaper, randomEvent, pickedHost);
                        //The CurrentDateTime, CurrentEventID, CurrentHostID properties must be changed according to the new event and host leapt to. 
                    }
                    response = "";
                }
                while (response == "2")
                {
                    Budget.AddMoney();
                    response = "";
                }
                while(response =="3")
                {
                    var pickedLeaper = PickALeaper(response);                    
                    var leaps = leapRepo.GetLeaps(pickedLeaper);
                    Console.WriteLine($"These are {pickedLeaper.Name}'s Leaps:");
                    foreach(string leap in leaps)
                    {
                        Console.WriteLine($"{leap}\n");
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
