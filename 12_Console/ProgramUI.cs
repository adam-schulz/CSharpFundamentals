using _12_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    public class ProgramUI
    {
        public void Run()
        {
            Person personOne = new Person();  // This is calling to the original empty Person constructor in our Person class
            personOne.Name = "Adam";    // Adam is a real value being held inside Name property for personOne  // expressions in code work from right to left
            personOne.Age = 30;
            personOne.IsMarried = true;


            Person personTwo = new Person("Christa", 40, true);  //Fill out actual values found in overloaded Person constructor
            Console.WriteLine(personTwo.IsMarried);
            Console.ReadKey();


            PersonRepository _repo = new PersonRepository();  // repo is a PersonRepository object that we named repo
            _repo.AddPerson(personOne);     // This puts personOne inside of listOfPeople
            _repo.AddPerson(personTwo);

            List<Person> localList = _repo.ReturnList();   // need to hold what this method returns to a variable

            int number = localList.Count();
            Console.WriteLine(number);


        }
        
    }
}
