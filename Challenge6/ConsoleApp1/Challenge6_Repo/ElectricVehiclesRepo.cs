using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6_Repo
{
    public class ElectricVehiclesRepo
    {
        protected readonly List<ElectricVehicles> _electricvehicles = new List<ElectricVehicles>();


        //create electric
        public bool AddElectricVehiclesToDirectory(ElectricVehicles items)
        {
            int startingCount = _electricvehicles.Count;
            _electricvehicles.Add(items);

            bool wasAdded = (_electricvehicles.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //read electric
        public List<ElectricVehicles> GetContents()
        {
            return _electricvehicles;
        }

        public ElectricVehicles GetElectricVehiclesByVehicleName(string vehicleName)
        {
            foreach (ElectricVehicles items in _electricvehicles)
            {
                if (items.VehicleName.ToLower() == vehicleName.ToLower())
                {
                    return items;
                }
            }
            return null;
        }

        //update electric
        public bool UpdateExistingElectricVehicles(string originalVehicle, ElectricVehicles items)
        {
            ElectricVehicles oldItems = GetElectricVehiclesByVehicleName(originalVehicle);

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

        //delete electric
        public bool DeleteExistingElectricVehicles(ElectricVehicles existingVehicle)
        {
            bool deleteResult = _electricvehicles.Remove(existingVehicle);
            return deleteResult;
        }

        public bool DeleteExistingElectricVehiclesByVehicleName(string items)
        {
            return DeleteExistingElectricVehicles(GetElectricVehiclesByVehicleName(items));
        }
    }
}
