using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Erick");
            SayHello("Harry");

            int inputOne = 7;
            int inputTwo = 13;
            int sum = AddTwoNumbers(inputOne, inputTwo);
            Console.WriteLine(sum);
            double doubleSum = AddTwoNumbers(242.2d, 234.5d);             //Overloads 

            int myAge = CalculateAge(new DateTime(1990, 06, 18));
            Console.WriteLine("My age is: " + myAge);
        }
        /*
         * 1) Access Modifier
         * 2) Return Type - What you want the method to return
         * 3) Method Signature (Method Name & Parameters) - Name Method to Explain What it is Doing
         * 4) Body
         */
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddTwoNumbers(int numOne, int numTwo) 
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumbers(double one, double two)
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
