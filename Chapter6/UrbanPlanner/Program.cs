using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MCTC = new Building("1 Mountwest Way")
            {
                Width = 100,
                Depth = 200,
                NumberofStories = 4
            };

            Building CapitalBuilding = new Building("412 8th Street")
            {
                Width = 1000,
                Depth = 250,
                NumberofStories = 6
            };

            Building MyHouse = new Building("3602 3rd Avenue")
            {
                Width = 200,
                Depth = 300,
                NumberofStories = 2
            };

            MCTC.Construct();
            CapitalBuilding.Construct();
            MyHouse.Construct();
            MCTC.Purchase("Russ Miller");
            CapitalBuilding.Purchase("George Washington");
            MyHouse.Purchase("Cameron Pruitt");

            MCTC.DisplayBuildingInfo();
            CapitalBuilding.DisplayBuildingInfo();
            MyHouse.DisplayBuildingInfo();


            Console.WriteLine("");
        }
    }
}
