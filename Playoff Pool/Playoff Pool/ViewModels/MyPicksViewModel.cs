using Playoff_Pool.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.ViewModels
{
    public class MyPicksViewModel : BaseViewModel
    {
        public MyPicksViewModel()
        {
            AFCWildCardGame1HomeTeam = new Team() { City = "Tennessee", Name = "Titans" };
            AFCWildCardGame1AwayTeam = new Team() { City = "Pittsburgh", Name = "Steelers" };
            AFCWildCardGame2HomeTeam = new Team() { City = "New England", Name = "Patriots" };
            AFCWildCardGame2AwayTeam = new Team() { City = "Baltimore", Name = "Ravens" };
            AFCDivisionalGame1HomeTeam = new Team() { City = "Kansas City", Name = "Chiefs" };
            AFCDivisionalGame2HomeTeam = new Team() { City = "Las Vegas", Name = "Raiders" };
        }

        public Bracket MyBracket { get; set; }

        public Team AFCWildCardGame1HomeTeam { get; set; }
        public Team AFCWildCardGame1AwayTeam { get; set; }
        public Team AFCWildCardGame2HomeTeam { get; set; }
        public Team AFCWildCardGame2AwayTeam { get; set; }
        public Team AFCDivisionalGame1HomeTeam { get; set; }
        public Team AFCDivisionalGame1AwayTeam { get; set; }
        public Team AFCDivisionalGame2HomeTeam { get; set; }
        public Team AFCDivisionalGame2AwayTeam { get; set; }
    }
}
