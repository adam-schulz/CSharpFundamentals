using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Classes
{
    public class Person

    { // List properties that a person would have

        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public Person()
        {
            // This is what the empty constructor looks like in the background. We only have to type this out if we have an overloaded constructor
        }

        public Person(string name, int age, bool isMarried)  // pass in the values that would make this person
        {
            // Match these back to the properties we created for Person
            Name = name;
            Age = age;
            IsMarried = isMarried;

        }

        // What would allow us to new up an instance of this class? 
    }
}
