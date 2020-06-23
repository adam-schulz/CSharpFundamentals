using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            int b = 7;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //Multiplication
            int product = a * b;
            Console.WriteLine(product);

            //Division
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Remainder
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1822, 4, 5);
            TimeSpan timeSpan = now - someDay;

            //Comparison Operators
            Console.WriteLine("Enter your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name:");
            string username = Console.ReadLine();
            bool equals = age == 30;
            bool userIsDan = username == "Dan";
            Console.WriteLine("User is 30" + equals);
            Console.WriteLine("User is Frank" + userIsDan);

            bool notEqual = age != 116;
            bool userIsNotJake = username != "Jake";
            Console.WriteLine($"User is not 116: {notEqual}");
            Console.WriteLine($"User is not Jake: {userIsNotJake}");


            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 33;

            bool orValue = equals || lessThan;

            bool tOrT = true || true;
            bool fOrT = false || true;
            bool torF = true || false;
            bool fOrF = false || false;

            bool andValue = greaterThan && orValue;
            bool tAndT = true && true;
            bool tAndF = true && false;
            bool fAndT = false && true;
            bool fAndF = false && false;


            Console.ReadKey();


        }
    }
}
