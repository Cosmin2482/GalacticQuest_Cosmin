Models\Planet.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace GalacticQuest.Models
{
    internal abstract class Planet : IPlanet
    {
        private static readonly Random _rng = new Random();

        public List<(string, int)> Items { get; private set; }

        protected Planet(IEnumerable<(string, int)>? items = null)
        {
            Items = items?.ToList() ?? new List<(string, int)>();
        }

        public (string, int) GetRandomItem()
        {
            if (Items == null || Items.Count == 0)
                throw new InvalidOperationException("No items available on this planet.");

            int index = _rng.Next(0, Items.Count);
            return Items[index];
        }

        public bool TryGetRandomItem(out (string, int) item)
        {
            if (Items == null || Items.Count == 0)
            {
                item = default;
                return false;
            }

            item = GetRandomItem();
            return true;
        }
    }
}