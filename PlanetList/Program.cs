using System;
using System.Collections.Generic;

namespace PlanetList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PlanetList = new List<string>
            {
                "Mercury",
                "Mars"
            };

            PlanetList.Add("Jupiter");
            PlanetList.Add("Saturn");

            List<string> RemainingPlanets = new List<string>
            {
                "Uranus",
                "Neptune"
            };

            PlanetList.AddRange(RemainingPlanets);
            PlanetList.Insert(1, "Earth");
            PlanetList.Insert(1, "Venus");

            Console.WriteLine(PlanetList[2]);
        }
    }
}
