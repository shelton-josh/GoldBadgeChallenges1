using BadgeRepo;
using System;
using System.Collections.Generic;

namespace Challenge3.UI
{
    public class ProgramUI
    {
        private readonly BadgeRepos _badgerepo = new BadgeRepos();

        public void Run()
        {
            SeedContent();
            RunMenu();
        }

        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine(
                    "Enter the number of the option you would like to select:\n" +
                    "1. Add badge\n" +
                    "2. Edit badge\n" +
                    "3. List badges\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreateNewBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadgeAndDoors();
                        break;
                    case "4":
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
        //SWITCH CHEATE METHODS ===START===
        public void CreateNewBadge()
        {
            Badges content = new Badges();
            content.DoorValid = new List<string>();

            Console.Clear();
            Console.WriteLine("Please enter a new badge ID\n ");
            content.BadgeID = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter a door ID for the current Badge's access \n");
            content.DoorValid.Add(Console.ReadLine());

            bool yes = true;

            Console.WriteLine("Door access granted for the current Badge");

            while (yes)
            {
                Console.WriteLine("Would you like to add another door?\n");
                Console.WriteLine("Press 'y' for yes");
                Console.WriteLine("Press 'n' for no");
                string userinput = Console.ReadLine();
                switch (userinput)
                {

                    case "y":
                        Console.WriteLine("Enter a door that the current Badge needs access to\n");
                        content.DoorValid.Add(Console.ReadLine());
                        break;
                    case "n":
                        yes = false;
                        break;

                }
            }

            _badgerepo.AddBadge(content);



            Console.WriteLine("Press any key to return");


            Console.ReadKey();

        }
        //END OF SWITCH CREATE METHODS

        //START OF REMOVE SWITCH METHOD

        public void RemoveDoorFromEdit(int badgeid)
        {

            Console.WriteLine("Delete Door Access From Current Badge");
            string door = Console.ReadLine();

            Console.WriteLine("Door Access Removed From Current Badge");
            Console.WriteLine("Press any key to continue");
            _badgerepo.DoorInvalid(badgeid, door);

            Console.ReadKey();
        }
        //END OF REMOVE SWITCH METHODS


        //START OF SHOW ALL BADGES AND DOORS METHODS
        public void ListBadgeAndDoors()
        {
            Dictionary<int, List<string>> BadgeList = _badgerepo.GetDictonary();
            Console.Clear();

            Console.WriteLine("---------------------");
            foreach (KeyValuePair<int, List<string>> badge in BadgeList)
            {
                Console.WriteLine($"BadgeID: {badge.Key}\n");

                foreach (string door in badge.Value)
                {
                    Console.WriteLine("Door Access Granted:   \n" + door);
                }
                Console.WriteLine("\n\n\n--------------------");
            }
            Console.WriteLine("\nPress any key to return\n ");
            Console.ReadLine();
        }

        //END OF SHOW ALL BADGES AND DOORS METHODS


        //START OF ALL EDIT BADGE AND DOOR METHODS
        public void EditBadge()
        {
            Badges content = new Badges();
            content.DoorValid = new List<string>();

            Console.Clear();
            Console.WriteLine("Please enter an existing badge to edit \n");
            content.BadgeID = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Please select an option\n");
            Console.WriteLine("1. Add Another Door");
            Console.WriteLine("2. Delete A Door");
            Console.WriteLine("3. Go Back");




            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddDoorToEdit(content.BadgeID);
                    break;
                case "2":
                    RemoveDoorFromEdit(content.BadgeID);
                    break;
                case "3":
                    RunMenu();
                    break;
            }
        }

        public void AddDoorToEdit(int badgeid)
        {
            Console.WriteLine("Enter a door to add:");
            string door = Console.ReadLine();
            _badgerepo.DoorValid(badgeid, door);

            Console.WriteLine("Door access has been added!");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();

        }
        //END OF ALL EDIT BADGE AND DOOR METHODS
        public void DisplayItems(Badges items)
        {
            Console.WriteLine($"Badges: {items.BadgeID}\n" +
                $"Doors: {items.DoorValid}");
        }

        //SEED
        public void SeedContent()
        {
            Badges badge1 = new Badges(007, new List<string> { "A1" });
            Badges badge2 = new Badges(117, new List<string> { "A2", "A3" });
            Badges badge3 = new Badges(118, new List<string> { "A3", "A7" });



            _badgerepo.AddBadge(badge1);
            _badgerepo.AddBadge(badge2);
            _badgerepo.AddBadge(badge3);
        }
    }
}
