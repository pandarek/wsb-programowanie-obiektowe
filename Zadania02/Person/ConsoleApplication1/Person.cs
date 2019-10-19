using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {

        private string _name;
        private int _age;

        public string Name {
        
            get {
                return _name;
            }
            set
            {
                this._name = value;
            }

    }
        
        public Person() : this(name: "Krzys", age:21)
        {
            Console.WriteLine("No arg constructor");
        }
        public Person(string name) : this(name, age:21)
        {
            _name = name;
            Console.WriteLine("One arg constructor");
        }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            Console.WriteLine("Person created");
        }

        public void Breathe()
        {
            Console.WriteLine("Person is breathing");

        }

    }
}
