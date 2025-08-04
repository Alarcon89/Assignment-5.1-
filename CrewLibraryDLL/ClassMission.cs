using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    // In this case, classmission is the child class of ClassCrew
    public class ClassMission : ClassCrew
    {
        // give our crew their own properties
        public string PlanetName { get; set; }



        // Create a constructor that will pass data to the parent class
        // And require the mission name that will not be passed up to the parent class
        public ClassMission(string planetName, string missionName, string firstName, string lastName) 
            : base(firstName, lastName, planetName)
        {
            // The only property that will not be passed up to the parent class is MissionName because
            // the other we are passing up our parent class for it to handle. 

            PlanetName = planetName;
        }

        public ClassMission(string firstName, string lastName, string missionName) : base(firstName, lastName, missionName)
        {
        }

        // Creating a method so the mission can do stuff
        // This method will return a string with the mission name and the first and last name of the crew member
        public string GetMissionDetails()
        {
            string result;
            result = FirstName + " in a mission at Mars " + PlanetName + " for Democracy!";
            return result;
        }




    }
}
