using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask
{
    public abstract class Animals
    {
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; } //you can only read value
            set
            {
                if (value >= 0 && value <= 175) // set can only write information in the private field.
                {
                    _age = value;
                    return;
                }
                Console.WriteLine("Invalid age by default are set on 2!");
                _age = 2;
            }
        }
        public string Color { get; set; }
        public abstract void Print();
    }
}

