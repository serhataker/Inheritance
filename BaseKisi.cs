using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BaseKisi // create the main class for the inheitance
    {
        public string Name { get; set; } //defined the propertys
        public string Surname { get; set; }



        public void NameSurname()// cretae the return name surname method
        {
            Console.WriteLine($"Name:{Name}\nSurname:{Surname}");
        }
    }
}
