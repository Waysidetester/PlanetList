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
                "Neptune",
                "Uranus"
            };

            PlanetList.AddRange(RemainingPlanets);
            PlanetList.Insert(1, "Earth");
            PlanetList.Insert(1, "Venus");
            PlanetList.Add("Pluto");
            List<string> RockyPlanets = PlanetList.GetRange(0, 4);

            PlanetList.RemoveAt(PlanetList.Count - 1);

            var MercuryShuttles = new List<string>
            {
                "Mariner 10",
                "Messenger"
            };

            var VenusShuttles = new List<string>
            {
                "Mariner 2",
                "Venera 4",
                "Mariner 5",
                "Venera 5",
                "Venera 6"
            };

            var EarthShuttles = new List<string>
            {
                "Giotto",
                "Galileo",
                "Cassini",
                "Stardust"
            };

            var MarsShuttles = new List<string>
            {
                "Mariner 4",
                "Mariner 6",
                "Mariner 7"
            };

            var JupiterShuttles = new List<string>
            {
                "Pioneer 10",
                "Pioneer 11",
                "Voyager 1",
                "Voyager 2"
            };

            var SatrunShuttles = new List<string>
            {
                "Pioneer 11",
                "Voyager 1",
                "Voyager 2",
                "Cassini"
            };

            var UranusShuttles = new List<string>
            {
                "Voyager 2"
            };

            var NeptuneShuttles = new List<string>
            {
                "Voyager2"
            };

            Dictionary<string, List<string>> SpaceFlights = new Dictionary<string, List<string>>();

            SpaceFlights.Add(PlanetList[0], MercuryShuttles);
            SpaceFlights.Add(PlanetList[1], VenusShuttles);
            SpaceFlights.Add(PlanetList[2], EarthShuttles);
            SpaceFlights.Add(PlanetList[3], MarsShuttles);
            SpaceFlights.Add(PlanetList[4], JupiterShuttles);
            SpaceFlights.Add(PlanetList[5], SatrunShuttles);
            SpaceFlights.Add(PlanetList[6], NeptuneShuttles);
            SpaceFlights.Add(PlanetList[7], UranusShuttles);

            foreach (var planet in PlanetList)
            {
                string shuttles = "";
                foreach (var shuttle in SpaceFlights[planet])
                {
                    if (shuttle != SpaceFlights[planet][0])
                    {
                    shuttles += $", {shuttle}";
                    } else
                    {
                        shuttles += $"{shuttle}";
                    }
                }
                Console.WriteLine($"{planet}: {shuttles}\n");
            }

            Console.ReadKey();
        }
    }
}
