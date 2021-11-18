using Challenge1_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeRepoInheritence
{
    public class ChallengeRepo : MenuItemsRepo
    {
        public List<MenuItems> GetItems() 
        { 
            List<MenuItems> allMenuItems = new List<MenuItems>();
            foreach (MenuItems items in _menuItems)
            {
                if (items is MenuItems)
                {
                    allMenuItems.Add((MenuItems)items);
                }         
            }

            return allMenuItems;
        }
    }
}
