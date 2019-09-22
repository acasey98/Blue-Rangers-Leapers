using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class Budget
    {
        static int _budget = 15000000;   


        public static void AddMoney()
        {
            Console.WriteLine("Choose an amount of funds to request:");
            Console.WriteLine("1: $1,000,000");
            Console.WriteLine("2: $5,000,000");
            Console.WriteLine("3: $10,000,000");
            Console.WriteLine("4: $25,000,000");
            Console.WriteLine("0: $0");
            var choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    _budget += 1000000;
                    Console.WriteLine("Added $1,000,000 to the budget.");
                    break;
                case "2":
                    _budget += 5000000;
                    Console.WriteLine("Added $5,000,000 to the budget.");
                    break;
                case "3":
                    _budget += 10000000;
                    Console.WriteLine("Added $10,000,000 to the budget.");
                    break;
                case "4":
                    _budget += 25000000;
                    Console.WriteLine("Added $25,000,000 to the budget.");
                    break;
                case "0":
                    Console.WriteLine("You did not add any funds to the budget.");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.WriteLine($"Your new budget is ${_budget}.");
        }

        public static bool BudgetCheck(Leaper leaperToCheck, Event eventToCheck)
        {
            var leaperDate = leaperToCheck.CurrentDateTime;
            var eventDate = eventToCheck.DateTime;
            TimeSpan differenceBetweenDates = leaperDate - eventDate;
            // makes it a positive number incase it was a negative
            var travelCost = Math.Abs(differenceBetweenDates.Days) * 1000;
            Console.WriteLine($"Cost of {Math.Abs(differenceBetweenDates.Days)} day leap: ${travelCost}.");

            if (travelCost <= _budget)
            {
                _budget -= travelCost;
                Console.WriteLine($"New Budget: {_budget}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Insufficient funds budgeted for selected leap. Please try again or request additional funds.\n" +
                    $"1: Request additional funds.\n" +
                    $"2: Attempt another leap.");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddMoney();
                        BudgetCheck(leaperToCheck, eventToCheck);
                        break;
                    case "2":
                        Console.WriteLine("Returning to leaper selection.");
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Returning to leaper selection.");
                        break;
                }
                return false;
            }
        }
    }
}
