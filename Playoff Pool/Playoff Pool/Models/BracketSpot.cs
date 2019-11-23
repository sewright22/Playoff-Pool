using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.Models
{
    public class BracketSpot
    {
        public Conference Conference { get; set; }
        public int Seed { get; set; }
        public Team Team { get; set; }
    }
}
