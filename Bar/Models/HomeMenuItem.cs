using System;
using System.Collections.Generic;
using System.Text;

namespace Bar.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Shared
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
