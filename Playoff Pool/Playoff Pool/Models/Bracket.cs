using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.Models
{
    public class Bracket
    {
        public Game AFCWildCardGame1 { get; set; }
        public Game AFCWildCardGame2 { get; set; }
        public Game NFCWildCardGame1 { get; set; }
        public Game NFCWildCardGame2 { get; set; }
        public Game AFCDivisionalGame1 { get; set; }
        public Game AFCDivisionalGame2 { get; set; }
        public Game NFCDivisionalGame1 { get; set; }
        public Game NFCDivisionalGame2 { get; set; }
        public Game AFCChampionship { get; set; }
        public Game NFCChampionship { get; set; }
        public Game SuperBowl { get; set; }
    }
}
