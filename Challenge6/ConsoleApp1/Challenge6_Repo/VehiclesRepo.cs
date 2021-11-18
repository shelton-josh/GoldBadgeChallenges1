using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6_Repo
{

    public class VehiclesRepo
    {
        protected readonly List<Vehicles> _vehicles = new List<Vehicles>();
        
        //create gas
        public bool AddVehiclesToDirectory(Vehicles items)
        {
            int startingCount = _vehicles.Count;
            _vehicles.Add(items);

            bool wasAdded = (_vehicles.Count > startingCount) ? true : false;
            return wasAdded;
        }



        //read gas
        public List<Vehicles> GetContents()
        {
            return _vehicles;
        }

        public Vehicles GetVehiclesByVehicleName(string vehicleName)
        {
            foreach (Vehicles items in _vehicles)
            {
                if (items.VehicleName.ToLower() == vehicleName.ToLower())
                {
                    return items;
                }
            }
            return null;
        }



        //update gas
        public bool UpdateExistingVehicles(string originalVehicle, Vehicles items)
        {
            Vehicles oldItems = GetVehiclesByVehicleName(originalVehicle);

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



        // delete gas
        public bool DeleteExistingVehicles(Vehicles existingVehicle)
        {
            bool deleteResult = _vehicles.Remove(existingVehicle);
            return deleteResult;
        }

        public bool DeleteExistingVehiclesByVehicleName(string items)
        {
            return DeleteExistingVehicles(GetVehiclesByVehicleName(items));
        }


    }
}
