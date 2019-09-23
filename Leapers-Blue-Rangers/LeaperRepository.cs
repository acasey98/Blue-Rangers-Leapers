using System;
using System.Collections.Generic;
using System.Text;

namespace Leapers_Blue_Rangers
{
    class LeaperRepository
    {
        static List<Leaper> leapers = new List<Leaper>() {
                new Leaper
                {
                   ID = 0,
                   Name = "Johnnie",
                   CurrentDateTime = DateTime.Today,
                   CurrentEventID = 100,
                   CurrentHostID = 100,

                },

                new Leaper
                {
                    ID = 1,
                    Name = "Jesse",
                    CurrentDateTime = DateTime.Today,
                    CurrentEventID = 100,
                    CurrentHostID = 100,
                },

                new Leaper
                {
                    ID = 2,
                    Name = "Jackie",
                    CurrentDateTime = DateTime.Today,
                    CurrentEventID = 100,
                    CurrentHostID = 100,
                }
            };

        public List<Leaper> GetAll()
        {
            return leapers;
        }
        public void ChangeLeaperInfo(Leaper leaper, Event events, Host host)
        {
            leaper.CurrentEventID = events.ID;

            leaper.CurrentDateTime = events.DateTime;

            leaper.CurrentHostID = host.ID;

        }

    }
}
