using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student : Person
    {
        private int id;
        public Student()
        {

        }
        public Student(int id)
        {
            this.id = id;
            Console.WriteLine("Student created");
        }
        public void Breathe()
        {
            
            Console.WriteLine("Student is breathing");

        }

    }
}
