using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    
    public class ClassCrew
    {
        //create properties for this class
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MissionName { get; set; }
        

        // Here I am creating a contructor for the ClassCrew class, 
        // to populate the values of an object when the object is created.

        public ClassCrew(string firstName, string lastName, string missionName)
        {
            
            // Here I am setting a property with data that has been passed
            // set the firstname, last name and mission name
            FirstName = firstName;
            LastName = lastName;
            MissionName = missionName;

        }

       

        //create a method so the person can do stuff 
        // this method will return a string with the first and last name of the crew member
        // in the list. 
        public string GetFullName()
        {
            // Here I am creating a string to hold data to return from this method. 
            string result = string.Empty;
            // Build data string to return
            result = FirstName + " ready to fight " + "lets go! ";
            // Now this line right here will return the data I built and stuffed into the string variable. 
            return result;
        }
    }
}
