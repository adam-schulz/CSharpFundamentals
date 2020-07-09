using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console
{
    class Program
    {
        static void Main(string[] args) // This is where the program starts
        {
            ProgramUI ui = new ProgramUI(); // Need to make a new instance of ProgramUI class so that you have access to Run method. Newing up an instance of the
            ui.Run();                       //  ProgramUI class so that you have access to methods in that class. 

        }
    }
}
