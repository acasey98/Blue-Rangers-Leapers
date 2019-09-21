using System;
using System.Collections.Generic;

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
        }
    }
}
