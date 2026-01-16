Models\Laponia.cs
using System.Collections.Generic;

namespace GalacticQuest.Models
{
    internal class Laponia : Planet
    {
        public Laponia()
            : base(new List<(string, int)>
            {
                ("Frost Spear", 200),
                ("Glacial Armor", 180),
                ("Aurora Charm", 60)
            })
        {
        }

        public override string ToString() => "Laponia";
    }
}