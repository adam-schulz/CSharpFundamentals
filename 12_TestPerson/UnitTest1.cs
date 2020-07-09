using System;
using System.Collections.Generic;
using _12_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _12_TestPerson
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1_AddPerson()  // Method to test a method - Declare which method you are testing so you know
        {
            // AAA

            // Arrange
            PersonRepository _repo = new PersonRepository();  // How do you access it? Create a new instance of PersonRepository
            Person personOne = new Person();  // What does this method need? Person   

            // Act - this portion of the test is using our method. 
            _repo.AddPerson(personOne);
            List<Person> localList = _repo.ReturnList();  // because list returns something, want to save it to a variable to make it easier to access

            // Assert - How do I know if this method (AddPerson) worked? 
            int expected = 1;
            int actual = localList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
