using BadgeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        private Dictionary<int, List<string>> _doorValid = new Dictionary<int, List<string>>();
        [TestMethod]
        public void TestMethod1()
        {
            Badges content = new Badges();
            content.DoorValid = new List<string>();         
        }

        public Dictionary<int, List<string>> GetDictonary()
        {
            return _doorValid;
        }

        public void DoorValid(int badgeId, string doorValid)
        {
            List<string> doors = _doorValid[badgeId];
            doors.Add(doorValid);
        }

        public void DoorInvalid(int badgeId, string doorValid)
        {
            List<string> doors = _doorValid[badgeId];
            doors.Remove(doorValid);
        }

    }
}
