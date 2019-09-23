using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class LeapRepository
    {
        static List<Leap> _leaps = new List<Leap>();
        public List<string> GetLeaps(Leaper leaperSelected)
        {
            var leapsToReturn = _leaps.Where(leap => leap.Leaper == leaperSelected)
                .Select(leap => $"Location: {leap.SingleEvent.Description}\nDate: {leap.SingleEvent.DateTime}\nHost: {leap.Host.Name}")
                .ToList();
            return leapsToReturn;
        }

        public void SaveNewLeap(Leap newLeap)
        {
            _leaps.Add(newLeap);            
        }

    }
}
