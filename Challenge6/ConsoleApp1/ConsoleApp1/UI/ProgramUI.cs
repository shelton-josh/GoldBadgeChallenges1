using Challenge6_Repo;
using Challenge6_RepoInheritence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.UI
{
    public class ProgramUI
    {
        private readonly VehiclesRepo _vehicleRepo = new VehiclesRepo();
        private readonly ElectricVehiclesRepo _electricvehicleRepo = new ElectricVehiclesRepo();
        private readonly HybridVehiclesRepo _hybridvehicleRepo = new HybridVehiclesRepo();

        public void Run()
        {
            SeedItems();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of the option you want to select:\n" +
                    "1. Create New Gas Vehicle\n" +
                    "2. Delete Gas Vehicle\n" +
                    "3. View All Gas Vehicles\n======================================\n" +
                    "4. Create New Electric Vehicle\n" +
                    "5. Delete Electric Vehicle\n" +
                    "6. View All Electric Vehicles\n======================================\n" +
                    "7. Create New Hybrid Vehicle\n" +
                    "8. Delete Hybrid Vehicle\n" +
                    "9. View All Hybrid Vehicles\n======================================\n" +
                    "0. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewGasVehicle();
                        break;
                    case "2":
                        RemoveGasVehicleFromList();
                        break;
                    case "3":
                        ShowAllGasVehicles();
                        break;
                    case "4":
                        CreateNewElectricVehicle();
                        break;
                    case "5":
                        RemoveElectricVehicleFromList();
                        break;
                    case "6":
                        ShowAllElectricVehicles();
                        break;
                    case "7":
                        CreateNewHybridVehicle();
                        break;
                    case "8":
                        RemoveHybridVehicleFromList();
                        break;
                    case "9":
                        ShowAllHybridVehicles();
                        break;
                    case "0":
                    case "exit":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 4.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // START OF ALL CREATE SWITCH METHODS
        private void CreateNewGasVehicle()
        {
            Console.Clear();

            Vehicles items = new Vehicles();

            Console.WriteLine("Please enter a vehicle name ");
            items.VehicleName = Console.ReadLine();

            Console.WriteLine("Please enter a description ");
            items.Description = Console.ReadLine();

            Console.WriteLine("Please enter benefits ");
            items.Benefits = Console.ReadLine();

            Console.WriteLine("Please enter a price");
            items.Price = double.Parse(Console.ReadLine());

            if (_vehicleRepo.AddVehiclesToDirectory(items))
            {
                Console.WriteLine("Vehicle Added!");
            }
            else
            {
                Console.WriteLine("Vehicle was not added :(");
            }

        }

        private void CreateNewElectricVehicle()
        {
            Console.Clear();

            ElectricVehicles items = new ElectricVehicles();

            Console.WriteLine("Please enter a vehicle name ");
            items.VehicleName = Console.ReadLine();

            Console.WriteLine("Please enter a description ");
            items.Description = Console.ReadLine();

            Console.WriteLine("Please enter benefits ");
            items.Benefits = Console.ReadLine();

            Console.WriteLine("Please enter a price");
            items.Price = double.Parse(Console.ReadLine());

            if (_electricvehicleRepo.AddElectricVehiclesToDirectory(items))
            {
                Console.WriteLine("Vehicle Added!");
            }
            else
            {
                Console.WriteLine("Vehicle was not added :(");
            }

        }

        private void CreateNewHybridVehicle()
        {
            Console.Clear();

            HybridVehicles items = new HybridVehicles();

            Console.WriteLine("Please enter a vehicle name ");
            items.VehicleName = Console.ReadLine();

            Console.WriteLine("Please enter a description ");
            items.Description = Console.ReadLine();

            Console.WriteLine("Please enter benefits ");
            items.Benefits = Console.ReadLine();

            Console.WriteLine("Please enter a price");
            items.Price = double.Parse(Console.ReadLine());

            if (_hybridvehicleRepo.AddHybridVehiclesToDirectory(items))
            {
                Console.WriteLine("Vehicle Added!");
            }
            else
            {
                Console.WriteLine("Vehicle was not added :(");
            }

        }
        // END OF ALL CREATE SWITCH METHODS

        // START OF ALL REMOVE SWITCH METHODS
        private void RemoveGasVehicleFromList()
        {
            Console.Clear();

            Console.WriteLine("Which vehicle would you like to yeet?\n");

            List<Vehicles> currentVehicles = _vehicleRepo.GetContents();

            int count = 0;
            foreach (Vehicles items in currentVehicles)
            {
                count++;
                Console.WriteLine($"{count}. {items.VehicleName}");
            }

            int targetItemsId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemsId - 1;

            if (targetIndex >= 0 && targetIndex < currentVehicles.Count)
            {
                Vehicles desiredItems = currentVehicles[targetIndex];

                if (_vehicleRepo.DeleteExistingVehicles(desiredItems))
                {
                    Console.WriteLine($"{desiredItems.VehicleName} was yeeted");
                    AnyKey();
                }
                else
                {
                    Console.WriteLine("Deletion failed");
                    AnyKey();
                }
            }
            else
                Console.WriteLine("No vehicle with that name");
        }

        private void RemoveElectricVehicleFromList()
        {
            Console.Clear();

            Console.WriteLine("Which vehicle would you like to yeet?\n");

            List<ElectricVehicles> currentVehicles = _electricvehicleRepo.GetContents();

            int count = 0;
            foreach (ElectricVehicles items in currentVehicles)
            {
                count++;
                Console.WriteLine($"{count}. {items.VehicleName}");
            }

            int targetItemsId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemsId - 1;

            if (targetIndex >= 0 && targetIndex < currentVehicles.Count)
            {
                ElectricVehicles desiredItems = currentVehicles[targetIndex];

                if (_electricvehicleRepo.DeleteExistingElectricVehicles(desiredItems))
                {
                    Console.WriteLine($"{desiredItems.VehicleName} was yeeted");
                    AnyKey();
                }
                else
                {
                    Console.WriteLine("Deletion failed");
                    AnyKey();
                }
            }
            else
                Console.WriteLine("No vehicle with that name");
        }

        private void RemoveHybridVehicleFromList()
        {
            Console.Clear();

            Console.WriteLine("Which vehicle would you like to yeet?\n");

            List<HybridVehicles> currentVehicles = _hybridvehicleRepo.GetContents();

            int count = 0;
            foreach (HybridVehicles items in currentVehicles)
            {
                count++;
                Console.WriteLine($"{count}. {items.VehicleName}");
            }

            int targetItemsId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemsId - 1;

            if (targetIndex >= 0 && targetIndex < currentVehicles.Count)
            {
                HybridVehicles desiredItems = currentVehicles[targetIndex];

                if (_hybridvehicleRepo.DeleteExistingHybridVehicles(desiredItems))
                {
                    Console.WriteLine($"{desiredItems.VehicleName} was yeeted");
                    AnyKey();
                }
                else
                {
                    Console.WriteLine("Deletion failed");
                    AnyKey();
                }
            }
            else
                Console.WriteLine("No vehicle with that name");
        }
        //END OF ALL SWITCH REMOVE METHODS

        // START OF ALL SWITCH SHOW ALL METHODS
        private void ShowAllGasVehicles()
        {
            Console.Clear();
            List<Vehicles> listOfItems = _vehicleRepo.GetContents();
            foreach (Vehicles items in listOfItems)
            {
                DisplayItems(items);
            }
            AnyKey();
        }

        private void ShowAllElectricVehicles()
        {
            Console.Clear();
            List<ElectricVehicles> listOfItems = _electricvehicleRepo.GetContents();
            foreach (ElectricVehicles items in listOfItems)
            {
                DisplayItems(items);
            }
            AnyKey();
        }

        private void ShowAllHybridVehicles()
        {
            Console.Clear();
            List<HybridVehicles> listOfItems = _hybridvehicleRepo.GetContents();
            foreach (HybridVehicles items in listOfItems)
            {
                DisplayItems(items);
            }
            AnyKey();
        }
        // END OF SHOW ALL SWITCH METHODS
        private void ShowVehiclesByVehicleName()
        {
            Console.Clear();
            Console.WriteLine("Enter a vehicle name: ");
            string vehicleName = Console.ReadLine();

            Vehicles items = _vehicleRepo.GetVehiclesByVehicleName(vehicleName);
      
            if (items != null)
            {
                DisplayItems(items);
            }
            else
            {
                Console.WriteLine("Invalid vehicle name, vehicle not found");
            }
            AnyKey();
        }

        private void ShowElectricVehiclesByVehicleName()
        {
            Console.Clear();
            Console.WriteLine("Enter a vehicle name: ");
            string vehicleName = Console.ReadLine();

            ElectricVehicles items = _electricvehicleRepo.GetElectricVehiclesByVehicleName(vehicleName);
         
            if (items != null)
            {
                DisplayItems(items);
            }
            else
            {
                Console.WriteLine("Invalid vehicle name, vehicle not found");
            }
            AnyKey();
        }

        private void ShowHybridVehiclesByVehicleName()
        {
            Console.Clear();
            Console.WriteLine("Enter a vehicle name: ");
            string vehicleName = Console.ReadLine();
  
            HybridVehicles items = _hybridvehicleRepo.GetHybridVehiclesByVehicleName(vehicleName);

            if (items != null)
            {
                DisplayItems(items);
            }
            else
            {
                Console.WriteLine("Invalid vehicle name, vehicle not found");
            }
            AnyKey();
        }


        private void DisplayItems(Vehicles items)
        {
            Console.WriteLine($"Vehicle Name: {items.VehicleName}\n" +
                   $"Description: {items.Description}\n" +
                   $"Benefit: {items.Benefits}\n" +
                   $"Price:       {items.Price}\n");
        }

        private void DisplayItems(ElectricVehicles items)
        {
            Console.WriteLine($"Vehicle Name: {items.VehicleName}\n" +
                   $"Description: {items.Description}\n" +
                   $"Benefit: {items.Benefits}\n" +
                   $"Price:       {items.Price}\n");
        }

        private void DisplayItems(HybridVehicles items)
        {
            Console.WriteLine($"Vehicle Name: {items.VehicleName}\n" +
                   $"Description: {items.Description}\n" +
                   $"Benefit: {items.Benefits}\n" +
                   $"Price:       {items.Price}\n");
        }

        private void AnyKey()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        //SEED
        private void SeedItems()
        {
            Vehicles ram_3500_Dually = new Vehicles("Ram 3500 Dually", "A super huge Ram 3500 that runs on diseal gas and gets 8-10 MPG.","Can haul and tow very heavy things but at the cost of the environment.", price: 56000.00);
            Vehicles ford_F150 = new Vehicles("Ford F-150", "Half ton Ford F-150 is a middle choice for semi-heavy towing and hauling, middle ranged mpg at 15-20 MPG", "Can run on unleaded gasoline, however still at the cost of the environment.", price: 35000.00);
            Vehicles ford_MustangGT = new Vehicles("Ford Mustand GT", "A super fast car that goes vroom vroom.", "Higher MPG at 20-24, however the V-8 engine sucks up a lot of gas / diseal and at the cost of the environment.", price: 50000.00);
            ElectricVehicles tesla = new ElectricVehicles("Tesla Model S", "This thing is super fast because it runs on a battery with no lag on acceleration.", "Can run on solar power.", price: 40000.00);
            HybridVehicles ford_HybridZ = new HybridVehicles("Ford Hybrid Z", "A super fast car that goes zoomy zoom.", "Higher MPG at 30-35, however the V-4 engine uses gas at the cost of the environment. But is still a better solution than full gas with a battery using power as well", price: 32000.00);

            _vehicleRepo.AddVehiclesToDirectory(ram_3500_Dually);
            _vehicleRepo.AddVehiclesToDirectory(ford_F150);
            _vehicleRepo.AddVehiclesToDirectory(ford_MustangGT);
            _electricvehicleRepo.AddElectricVehiclesToDirectory(tesla);
            _hybridvehicleRepo.AddHybridVehiclesToDirectory(ford_HybridZ);
        }
    }
}
