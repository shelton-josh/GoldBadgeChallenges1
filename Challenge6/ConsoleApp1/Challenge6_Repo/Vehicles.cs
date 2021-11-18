using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6_Repo
{

    public class Vehicles
    {
        public Vehicles() { }
        public Vehicles(string vehicleName, string description, string benefits, double price)
        {
            VehicleName = vehicleName;
            Description = description;
            Benefits = benefits;
            Price = price;
        }

        public string VehicleName { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public double Price { get; set; }
    }

    public class ElectricVehicles
    {
        public ElectricVehicles() { }
        public ElectricVehicles(string vehicleName, string description, string benefits, double price)
        {
            VehicleName = vehicleName;
            Description = description;
            Benefits = benefits;
            Price = price;
        }

        public string VehicleName { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public double Price { get; set; }
    }

    public class HybridVehicles
    {
        public HybridVehicles() { }
        public HybridVehicles(string vehicleName, string description, string benefits, double price)
        {
            VehicleName = vehicleName;
            Description = description;
            Benefits = benefits;
            Price = price;
        }

        public string VehicleName { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public double Price { get; set; }
    }
}
