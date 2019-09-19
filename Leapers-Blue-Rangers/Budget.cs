using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class Budget
    {
        static int _budget;

        public void AddMoney(int AmountOfMoneyAddedToBudget)
        {
            _budget += AmountOfMoneyAddedToBudget;
        }

        public Boolean BudgetCheck(Leaper leaperToCheck, Event eventToCheck)
        {
            var leaperDate = leaperToCheck.currentDateTime;
            var eventDate = eventToCheck.dateTime;
            Timespan differenceBetweenDates = leaperDate - eventDate;
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
