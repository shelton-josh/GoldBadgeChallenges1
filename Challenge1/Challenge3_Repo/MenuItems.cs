using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Repo
{    
 
    public class MenuItems
    {
        public MenuItems() { }
        public MenuItems(string mealName, string description, string ingredients, double price, double mealNumber)
        {
            MealName = mealName;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            MealNumber = mealNumber;
        }

        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public double MealNumber { get; set; }
    }
}
