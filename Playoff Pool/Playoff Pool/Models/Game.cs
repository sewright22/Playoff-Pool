using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.Models
{
    public class Game
    {
        public BracketSpot HomeTeam { get; set; }
        public BracketSpot AwayTeam { get; set; }
        public BracketSpot Winner { get; set; }

    }
}
