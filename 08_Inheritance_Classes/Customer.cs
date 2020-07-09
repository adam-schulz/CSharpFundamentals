using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Customer : Person  //-- Customer = child - Person = parent ( : Person = inheriting from Person class. Can only inherit one class )
    {
        public bool IsPremium { get; set; }
        public bool SubscribedToEmails { get; set; }
    }

}
