using System;
using System.Collections.Generic;

namespace Leapers_Blue_Rangers
{
    class Program
    {
        static void Main(string[] args)
        {


            var Leapers = new List<Leaper>() {

                new Leaper
                {
                   ID = 0,
                   Name = "Johnnie",
                   CurrentDateTime = ,
                   CurrentEventID = ,
                   CurrentHostID = 5,

                },

                new Leaper
                {
                    ID = 1,
                    Name = "Jesse",
                    CurrentDateTime = ,
                    CurrentEventID = ,
                    CurrentHostID = 1,
                },

                new Leaper
                {
                    ID = 3,
                    Name = "Jackie",
                    CurrentDateTime = ,
                    CurrentEventID = ,
                    CurrentHostID = 6,
                }
            };
                  
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

            
        }
    }
}
