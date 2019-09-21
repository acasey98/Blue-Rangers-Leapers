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

        public Boolean BudgetCheck(Leaper leaperToCheck, Event eventToCheck)
        {
            var leaperDate = leaperToCheck.CurrentDateTime;
            var eventDate = eventToCheck.DateTime;
            TimeSpan differenceBetweenDates = leaperDate - eventDate;
            // makes it a positive number incase it was a negative
            var differenceInDays = Math.Abs(differenceBetweenDates.Days);

            if ((differenceInDays * 1000) > _budget)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
