using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    enum PastryType { Cake, Cupcake, Criossant, Donut, Danish, Cookie, Scone};
    class Program
    {
        static void Main(string[] args)
        {
            //Bools
            bool isDeclared; //declared
            isDeclared = true; //initialized

            bool isDeclaredAndInitialized = false; //code reads top down, so everything below this initialization will be false until told otherwise
            isDeclaredAndInitialized = true;

            //characters
            char character = 'a';
            char symbol = '&';
            char number = '5'; //character can only ever be 1 character, not 55 or av
            char space = ' ';
            char specialCharacter = '\n';

            //Whole Numbers
            byte byteExample = 255; //8-bit unsigned integer
            sbyte sByteExample = -128; //8-bit signed integer
            short shortExample = 32767; //16-bit signed integer
            Int16 anotherShortExample = 32000; //16-bit signed integer (another name for short)
            int intMin = -2147483648; //32-bit signed integer
            Int32 intMax = 2147483647; //32-bit signed integer (another name for int)
            long longExample = 9223372036854775807; //64-bit signed integer
            Int64 longMin = -9223372036854775808; //64-bit signed integer (another name for long)

            int a = 7;
            int b = -7000;

            byte age = 104;

            //Decimals
            float floatExample = 1.045231f; //single precision floating number
            double doubleExample = 1.789053278907036d; //double precision floating number
            decimal decimalExample = 1.2578907289045789789789789787897m;
            Console.WriteLine(1.2578907289045789789789789787897f); //shortcut is cw tab tab
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);

            Console.ReadKey();

            //Enums - assigned outside the class!!!!
            PastryType myPastry = PastryType.Danish; 
            PastryType anotherOne = PastryType.Scone;
            
            //Structs 

            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1990, 3, 21);
            DateTime test = new DateTime();



        }
    }
}
