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
                   CurrentDateTime = new DateTime(2016,11,08),
                   CurrentEventID = 0,
                   CurrentHostID = 5,

                },

                new Leaper
                {
                    ID = 1,
                    Name = "Jesse",
                    CurrentDateTime = new DateTime(1998,08,17),
                    CurrentEventID = 1,
                    CurrentHostID = 1,
                },

                new Leaper
                {
                    ID = 3,
                    Name = "Jackie",
                    CurrentDateTime = new DateTime(2016,11,08),
                    CurrentEventID = 0,
                    CurrentHostID = 6,
                }
            };

        public List<Leaper> GetAll()
        {
            return leapers;
        }


    }
}
