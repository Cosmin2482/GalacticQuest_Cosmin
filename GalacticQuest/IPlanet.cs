Models\IPlanet.cs
using System.Collections.Generic;

namespace GalacticQuest.Models
{
    internal interface IPlanet
    {
        List<(string, int)> Items { get; }

        (string, int) GetRandomItem();
    }
}