using System;
using System.Collections.Generic;
using System.Text;

namespace Playoff_Pool.Models
{
    public enum MenuItemType
    {
        Home,
        Leaderboard,
        History,
        MyPicks
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
