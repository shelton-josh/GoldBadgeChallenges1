using Challenge1_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge1Test
{
    [TestClass]
    public class RepoTest
    {
        [TestMethod]
        public void AddMeals_ShouldAddMealsToDirectory()
        {
            //arrange
            MenuItems items = new MenuItems();

            MenuItemsRepo repository = new MenuItemsRepo();
            //act

            bool addResult = repository.AddItemsToDirectory(items);
            //assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //arrange
            MenuItems items = new MenuItems();
            MenuItemsRepo repo = new MenuItemsRepo();

            repo.AddItemsToDirectory(items);

            //act
            List <MenuItems> item = repo.GetContents();

            bool directoryHasItems = item.Contains(items);
            //assert
            Assert.IsTrue(directoryHasItems);
        }
        private MenuItemsRepo _repo;
        private MenuItems _items;     

        [TestMethod]
        public void Arrange()
        {
            _repo = new MenuItemsRepo();
            _items = new MenuItems("Test", "A test", "test", price: 5, mealNumber: 6);

           
            _repo.AddItemsToDirectory(_items);

        }
    }
}
