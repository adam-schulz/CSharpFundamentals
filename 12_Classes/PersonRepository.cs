using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{ // Place to hold our methods to allow us to do things with the objects we created in Person class. This is our toolbox
    public class PersonRepository
    {
        // List<variable name> nameOfList = new list holding objects of person class. This is an empty person jar and only persons can go in this jar. When you make a new instance of a list, that list is empty unless we specify otherwise
        // '_' signifies this a "field" - it will be used throughout the program. It doesn't affect its function. Like div / section in HTML
        // Declare the list at the top of the repository, we'll use this list in all our methods in PersonRepository class. (it is global)


        List<Person> _listOfPeople = new List<Person>();

        public void AddPerson(Person x) // (Type of object that has to come into the method - placeholder for the actual value)
        {
            _listOfPeople.Add(x);    // Now we want to add Person x to our List
        }

        public void RemovePerson(Person y)
        {
            _listOfPeople.Remove(y);
        }

        public List<Person> ReturnList()
        {
            return _listOfPeople;
        }
    }
}
