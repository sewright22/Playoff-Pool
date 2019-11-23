using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.Models
{
    public class Team
    {
        public string City { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", City, Name);
        }
    }
}
