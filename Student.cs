using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
      class Student:BaseKisi// We inherit from the basekisi class for the student 
    {
        public int StudentNumber { get; set; }// create the spesific property for the student class

        public void StudentProp ()// cretae the spesific method for the student class
        {
            Console.WriteLine("Student Number:"+StudentNumber);
            NameSurname();//call the basekisi method 

        }
    }
}
