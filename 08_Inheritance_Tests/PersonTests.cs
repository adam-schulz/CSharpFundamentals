using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            Person martha = new Person();
            martha.PhoneNumber = "8675309";

            Customer bob = new Customer();
            bob.PhoneNumber = "2721234";

            SalaryEmployee ted = new SalaryEmployee();
            ted.PhoneNumber = "5057124";
        }
    }
    [TestMethod]
    public void CustomerIsPremium_ShouldGetCorrectBool()
    {
        Customer firstCustomer = new Customer();
        firstCustomer.IsPremium = true;
        Person newPerson = new Person;
        Console.WriteLine(newPerson.GetType());
        Console.WriteLine(firstCustomer.GetType());
        Assert.IsTrue(firstCustomer.IsPremium);

    }

    [TestMethod]
    public void EmployeeTests()
    {
        Employee jarvis = new Employee();
        HourlyEmployee tony = new HourlyEmployee();
        SalaryEmployee janet = new SalaryEmployee();
        tony.HoursWorked = 55;
        tony.HourlyWage = 20.15m;
        janet.Salary = 55000;
        //--tony.Name = "Tony Stark";
        tony.SetFirstName("Tony");
        tony.SetLastName("Stark");

        List<Employee> allEmployees = new List<Employee>();
        allEmployees.Add(jarvis);
        allEmployees.Add(tony);
        allEmployees.Add(janet);

        foreach(Employee worker in allEmployees)
        {
            if(worker.GetType() == typeof(SalaryEmployee))
            {
                SalaryEmployee salaryEmployee = (SalaryEmployee)worker;
                Console.WriteLine($"This is a salary employee that makes {salaryEmployee.Salary}");
            }
            else if(worker is HourlyEmployee hourlyWorker) // pattern matching
            {
                //--HourlyEmployee hourlyEmployee = (HourlyEmployee)hourlyWorker; // don't have to cast this, can just change the type
                Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
            }
        }
    }
}
