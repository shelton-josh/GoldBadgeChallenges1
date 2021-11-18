using Challenge1_Repo;
using ChallengeRepoInheritence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1.UI
{
    public class ProgramUI
    {
        private readonly ChallengeRepo _challengeRepo = new ChallengeRepo();

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
                    "1. Create New Menu Items\n" +
                    "2. Delete Menu Items\n" +
                    "3. View All Cafe Menu Items\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewItems();
                        break;
                    case "2":
                        RemoveItemsFromList();
                        break;
                    case "3":
                        ShowAllItems();
                        break;
                    case "4":
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

        // Create for manager
        private void CreateNewItems()
        {
            Console.Clear();

            MenuItems items = new MenuItems();

            Console.WriteLine("Please enter a meal name ");
            items.MealName = Console.ReadLine();

            Console.WriteLine("Please enter a description ");
            items.Description = Console.ReadLine();

            Console.WriteLine("Please enter ingredients ");
            items.Ingredients = Console.ReadLine();

            Console.WriteLine("Please enter a price");
            items.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a meal number");
            items.MealNumber = double.Parse(Console.ReadLine());

            if (_challengeRepo.AddItemsToDirectory(items))
            {
                Console.WriteLine("Meal Added!");
            }
            else
            {
                Console.WriteLine("Meal was not added :(");
            }

        }

        // Delete for manager
        private void RemoveItemsFromList()
        {
            Console.Clear();

            Console.WriteLine("Which item would you like to remove?\n");

            List<MenuItems> currentItems = _challengeRepo.GetItems();

            int count = 0;
            foreach (MenuItems items in currentItems)
            {
                count++;
                Console.WriteLine($"{count}. {items.MealName}");
            }

            int targetItemsId = int.Parse(Console.ReadLine());
            int targetIndex = targetItemsId - 1;

            if (targetIndex >= 0 && targetIndex < currentItems.Count)
            {
                MenuItems desiredItems = currentItems[targetIndex];

                if (_challengeRepo.DeleteExistingItems(desiredItems))
                {
                    Console.WriteLine($"{desiredItems.MealName} was deleted");
                    AnyKey();
                }
                else
                {
                    Console.WriteLine("Deletion failed");
                    AnyKey();
                }
            }
            else
                Console.WriteLine("No content with that ID");
        }

        // Show all meals for manager
        private void ShowAllItems()
        {
            Console.Clear();
            List<MenuItems> listOfItems = _challengeRepo.GetItems();
            foreach(MenuItems items in listOfItems)
            {
                DisplayItems(items);
            }
            AnyKey();
        }

        private void ShowItemsByMealName()
        {
            Console.Clear();
            Console.WriteLine("Enter a meal name: ");
            string mealName = Console.ReadLine();

            MenuItems items = _challengeRepo.GetItemsByMealName(mealName);

            if (items != null)
            {
                DisplayItems(items);
            }
            else
            {
                Console.WriteLine("Invalid meal name, meal not found");
            }
            AnyKey();
        }


        private void DisplayItems(MenuItems items)
        {
            Console.WriteLine($"Meal Name: {items.MealName}\n" +
                   $"Description: {items.Description}\n" +
                   $"Ingredients: {items.Ingredients}\n" +
                   $"Price:       {items.Price}\n" +
                   $"Meal Number: {items.MealNumber}\n");
        }

        private void AnyKey()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        private void SeedItems()
        {
            MenuItems peppyPizza = new MenuItems("Peppy Pizza", "A super tasty crispy pepperoni pizza, it's really good.", "Dough, Tomatoes, Peppies, Oil", price: 12.99, mealNumber: 1);
            MenuItems cereal = new MenuItems("Cereal", "Can't go wrong with cereal.", "Milk, Cereal", price: 2.99, mealNumber: 2);
            MenuItems breadAndOil = new MenuItems("Bread & Oil", "Fresh baked bread with oil", "Bread, Oil", price: 2.99, mealNumber: 3);

            _challengeRepo.AddItemsToDirectory(peppyPizza);
            _challengeRepo.AddItemsToDirectory(cereal);
            _challengeRepo.AddItemsToDirectory(breadAndOil);
        }
    }
}
