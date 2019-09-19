using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Leapers_Blue_Rangers
{
    class LeapRepository
    {
        static List<Leap> _leaps = new List<Leap>();
        public List<Leap> GetLeaps(Leaper leaperSelected)
        {
            var leapsToReturn = _leaps.Where(leap => leap.Leaper == leaperSelected)
                .Select(leap => $"Name: {leap.Leaper.Name}\nLocation: {leap.Event.Location}\nDate: {leap.Event.dateTime}\nHost: {leap.Host.Name}");
            
        }

        public void SaveNewLeap(Leap newLeap)
        {
            _leaps.Add(newLeap);

        }

    }
}
