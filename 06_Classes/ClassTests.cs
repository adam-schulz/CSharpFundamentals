using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle firstVehicle = new Vehicle(); //Vehicle = Type    firstVehicle = Object (instance of a class that you are able to assign value to the different properties
            firstVehicle.Color = "White";
            Console.WriteLine(firstVehicle.Color);
            firstVehicle.Make = "Kia";
            firstVehicle.Model = "Sorento";
            firstVehicle.Mileage = 44250;
            firstVehicle.Year = 2017;
            firstVehicle.TypeOfVehicle = VehicleType.SUV;

            string carDetails = $"{ firstVehicle.Make} { firstVehicle.Color}";
            Console.WriteLine(carDetails);

            Vehicle secondVehicle = new Vehicle();
            secondVehicle.Year = 2013;

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 2019, 98765, "Space Gray", VehicleType.Spaceship);
        }

        [TestMethod]  //testm + tab + tab is shortcut to create new test method
        public void PersonTests()
        {
            Person firstPerson = new Person("Adam", "Schulz", new DateTime(1990, 06, 18));
            Console.WriteLine(firstPerson.AgeInYears);
            Console.WriteLine(firstPerson.FullName);

            Person secondPerson = new Person("Daisy", "Mae", new DateTime(2015, 02, 24));
            secondPerson.Transport = new Vehicle("Ford", "Raptor", 2017, 63456, "White", VehicleType.Truck);
            Console.WriteLine(secondPerson.Transport.Model);

            Assert.AreEqual("Daisy Mae", secondPerson.FullName);
            Assert.AreEqual("Daisy Mae", secondPerson.FullName);
        }
    }
}
