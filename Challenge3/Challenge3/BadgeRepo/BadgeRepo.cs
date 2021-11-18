using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepo
{

    //{key - value} = {int, "string"} key = BadgeID and value = List of Door Names
   
    //CRUD
  
    public class BadgeRepos
    {
        private Dictionary<int, List<string>> _doorValid = new Dictionary<int, List<string>>();
      
        //create
        public void AddBadge(Badges badge)
        {
            _doorValid.Add(badge.BadgeID, badge.DoorValid);
        }
        //read
        public Dictionary<int, List<string>> GetDictonary() 
        {
            return _doorValid;
        }
        //update
        public void DoorValid(int badgeId, string doorValid) 
        {
            List<string> doors = _doorValid[badgeId];
            doors.Add(doorValid);
        }
        //delete
        public void DoorInvalid(int badgeId, string doorValid) 
        {
            List<string> doors = _doorValid[badgeId];
            doors.Remove(doorValid);
        }

    }
    public class Badges
    {
       

        public int BadgeID { get; set; }
        public List<string> DoorValid { get; set; }

        public Badges() { }
        
            public Badges(int badgeId, List<string> doorValid)
            {
                BadgeID = badgeId;
                DoorValid = doorValid;
            }     
    }
}
