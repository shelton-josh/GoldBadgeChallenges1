using Challenge6_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6_RepoInheritence
{
    public class Challenge6_Repo : VehiclesRepo
    {
        public List<Vehicles> GetVehicles()
        {
            List<Vehicles> allVehicles = new List<Vehicles>();
            foreach (Vehicles items in _vehicles)
            {
                if (items is Vehicles)
                {
                    allVehicles.Add((Vehicles)items);
                }
            }

            return allVehicles;
        }
    }

    public class Challenge6Electric_Repo : ElectricVehiclesRepo
    {
        public List<ElectricVehicles> GetElectricVehicles()
        {
            List<ElectricVehicles> allElectricVehicles = new List<ElectricVehicles>();
            foreach (ElectricVehicles items in _electricvehicles)
            {
                if (items is ElectricVehicles)
                {
                    allElectricVehicles.Add((ElectricVehicles)items);
                }
            }

            return allElectricVehicles;
        }
    }


    public class Challenge6Hybrid_Repo : HybridVehiclesRepo
    {
        public List<HybridVehicles> GetHybridVehicles()
        {
            List<HybridVehicles> allHybridVehicles = new List<HybridVehicles>();
            foreach (HybridVehicles items in _hybridvehicles)
            {
                if (items is HybridVehicles)
                {
                    allHybridVehicles.Add((HybridVehicles)items);
                }
            }

            return allHybridVehicles;
        }
    }
}
