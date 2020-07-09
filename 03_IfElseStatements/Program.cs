using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }
            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("Are you even trying?");
            }

            bool choresAreDone = false;
            if (choresAreDone)
            {
                Console.WriteLine("Have fun playing video games");
            }
            else
            {
                Console.WriteLine("Finish your chores!");
            }

            Console.WriteLine("How many hours do you sleep?");  // Console.ReadLines always result in a string!!!!!!!!!!!!!!!!!!!!!!
            string input = Console.ReadLine();
            int totalHours = int.Parse(input);

            if (totalHours >= 8)
            {
                Console.WriteLine("Congrats. You are a tired parent!");
            }
            else
            {
                Console.WriteLine("Get off Reddit and go to bed!");
                if (totalHours < 3)
                {
                    Console.WriteLine("That's rough, buddy");
                }
            }

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            if (age > 17)
            {
                Console.WriteLine("Congrats on being an adult :(");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("Have fun in school!");
                }
                else if (age > 0)
                {
                    Console.WriteLine("You are just a wee lad");
                }
                else
                {
                    Console.WriteLine("You are a tiny baby");
                }
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("You likely relaxin, fam");
            }



            Console.ReadLine();

        }
    }
}
