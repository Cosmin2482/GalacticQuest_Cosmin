using System;
using System.Collections.Generic;

namespace GalacticQuest.Models
{
    internal class Laponia : IPlanet
    {
        private static Random _rng = new Random();

        public List<(string, int)> Items { get; } = new List<(string, int)>
        {
            ("Frost Spear", 200), ("Glacial Armor", 180), ("Aurora Charm", 60)
        };
        public (string, int) GetRandomItem()
        {
            if (Items == null || Items.Count == 0)
            {
                throw new InvalidOperationException("No items on this planet.");
            }
                int index = _rng.Next(0, Items.Count);
            return Items[index];
        }
    }
}
