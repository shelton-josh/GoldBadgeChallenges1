using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Repo
{

    public class MenuItemsRepo
    {
        protected readonly List<MenuItems> _menuItems = new List<MenuItems>();


        //create
        public bool AddItemsToDirectory(MenuItems items)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(items);

            bool wasAdded = (_menuItems.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //read
        public List<MenuItems> GetContents()
        {
            return _menuItems;
        }

        public MenuItems GetItemsByMealName(string mealName)
        {
            foreach (MenuItems items in _menuItems)
            {
                if(items.MealName.ToLower() == mealName.ToLower())
                {
                    return items;
                }
            }
            return null;
        }
        //update
        public bool UpdateExistingItemsByMealName(string originalMealName, MenuItems items)
        {
            MenuItems oldItems = GetItemsByMealName(originalMealName);

            if (oldItems != null)
            {
                oldItems.MealName = items.MealName;
                oldItems.Description = items.Description;
                oldItems.Ingredients = items.Ingredients;
                oldItems.Price = items.Price;

                return true;
            }
            else
                return false;
        }
        // delete
        public bool DeleteExistingItems(MenuItems existingItems)
        {
            bool deleteResult = _menuItems.Remove(existingItems);
            return deleteResult;
        }

        public bool DeleteExistingItemsByMenuItems(string items)
        {
            return DeleteExistingItems(GetItemsByMealName(items));
        }        
    }
}
