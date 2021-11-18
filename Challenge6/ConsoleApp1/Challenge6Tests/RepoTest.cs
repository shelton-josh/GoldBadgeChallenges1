using Challenge6_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace RepoTest
{
   
    [TestClass]
    public class RepoTest
    {
        [TestMethod]
        public void AddVehicles_ShouldAddVehiclesToDirectory()
        {
            //arrange
            Vehicles items = new Vehicles();

            VehiclesRepo repository = new VehiclesRepo();
            //act

            bool addResult = repository.AddVehiclesToDirectory(items);
            //assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //arrange
            Vehicles items = new Vehicles();
            VehiclesRepo repo = new VehiclesRepo();

            repo.AddVehiclesToDirectory(items);

            //act
            List<Vehicles> item = repo.GetContents();

            bool directoryHasItems = item.Contains(items);
            //assert
            Assert.IsTrue(directoryHasItems);
        }
        private VehiclesRepo _repo;
        private Vehicles _items;
     

        [TestMethod]
        public void Arrange()
        {
            _repo = new VehiclesRepo();
            _items = new Vehicles("Test", "A test", "test", price: 5);


            _repo.AddVehiclesToDirectory(_items);

        }

       


    }
}
