using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class LeapRepository
    {
        static List<Leap> _leaps = new List<Leap>();

        public List<Leap> GetLeaps()
        {
            throw new NotImplementedException();
        }

        public void SaveNewLeap(Leap newLeap)
        {
            throw new NotImplementedException();
        }
    }
    class Leap
    {
        public int eventId { get; set; }

    }
}
