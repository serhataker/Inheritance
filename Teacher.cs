using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : BaseKisi//We inherit from the basekisi class for the teacher 
    
    {

        public int Salary { get; set; }// create the spesific property for the teacher class
        public void TeacherProp() // cretae the spesific method for the teacher class
        {
            Console.WriteLine($"Teachers salary:{Salary}");
            NameSurname();//call the basekisi method 

        }
    }
}