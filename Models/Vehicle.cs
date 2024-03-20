using System;
namespace CarProject.Models
{
	public class Vehicle
	{
		public Vehicle()
		{
		}
        public int Id { get; set; }
        public string Carplate { get; set; }
        public int km { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string GearType { get; set; }
        public string Brand { get; set; }
    }
}

