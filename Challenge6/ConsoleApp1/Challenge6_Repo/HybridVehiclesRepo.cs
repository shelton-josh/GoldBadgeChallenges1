using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6_Repo
{
    public class HybridVehiclesRepo
    {
        protected readonly List<HybridVehicles> _hybridvehicles = new List<HybridVehicles>();


        //create hybrid
        public bool AddHybridVehiclesToDirectory(HybridVehicles items)
        {
            int startingCount = _hybridvehicles.Count;
            _hybridvehicles.Add(items);

            bool wasAdded = (_hybridvehicles.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //read hybrid
        public List<HybridVehicles> GetContents()
        {
            return _hybridvehicles;
        }

        public HybridVehicles GetHybridVehiclesByVehicleName(string vehicleName)
        {
            foreach (HybridVehicles items in _hybridvehicles)
            {
                if (items.VehicleName.ToLower() == vehicleName.ToLower())
                {
                    return items;
                }
            }
            return null;
        }

        //update hybrid
        public bool UpdateExistingHybridVehicles(string originalVehicle, HybridVehicles items)
        {
            HybridVehicles oldItems = GetHybridVehiclesByVehicleName(originalVehicle);

            if (oldItems != null)
            {
                oldItems.VehicleName = items.VehicleName;
                oldItems.Description = items.Description;
                oldItems.Benefits = items.Benefits;
                oldItems.Price = items.Price;

                return true;
            }
            else
                return false;
        }

        //delete hybrid
        public bool DeleteExistingHybridVehicles(HybridVehicles existingVehicle)
        {
            bool deleteResult = _hybridvehicles.Remove(existingVehicle);
            return deleteResult;
        }

        public bool DeleteExistingHybridVehiclesByVehicleName(string items)
        {
            return DeleteExistingHybridVehicles(GetHybridVehiclesByVehicleName(items));
        }
    }
}
