using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /*public enum Size
    {
        Small,
        Medium,
        Large
    }*/

    public abstract class Drink :IMenuItem
    {
        public double Price { get; set; }

        public uint Calories { get; set; }

        public abstract List<string> Ingredients { get; }

        public bool Ice { get; set; } = true;

        public abstract Size Size { get; set; }

        public Drink()
        {
            Size = Size.Small;
            Ice = true;
        }

        public void HoldIce()
        {
            this.Ice = false;
        }

    }
}
