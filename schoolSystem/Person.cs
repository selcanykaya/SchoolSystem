using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolSystem
{
    public class Person
    {   
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public void Info()
        {
            Console.WriteLine("Name: " + Name + " Surname: " + Surname + " Date of Birth: " + DateOfBirth);
        }
    }
}
