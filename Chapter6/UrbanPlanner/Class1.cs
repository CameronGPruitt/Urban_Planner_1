using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        private string DesignerNamer { get; set; }


        private DateTime DateConstructed { get; set; }

        private string BuildingAddress { get; set; }

        private string BuildingOwner { get; set; }

        public int NumberofStories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

       public double Volume
        {
            get
            {
                return Width * Depth * (3 * NumberofStories); 
            }
        }

        public Building (string address)
        {
            BuildingAddress = address;
        }


        public void Construct()
        {
            DateConstructed = DateTime.Now; 
        }

        public void Purchase(string buyer)
        {
            BuildingOwner = buyer;
        }

        public void DisplayBuildingInfo()
        {
            Console.WriteLine("--------------");
            Console.WriteLine(this.BuildingAddress);
            Console.WriteLine("Designed By: " + DesignerNamer);
            Console.WriteLine("Date Constructed: " + DateConstructed);
            Console.WriteLine("Owned By: " + BuildingOwner);
            Console.WriteLine(Volume + " cubic metes or space");
            Console.WriteLine("---------------");

        }
    }        
}
