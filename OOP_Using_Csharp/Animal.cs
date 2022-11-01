using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Using_Csharp
{
    public abstract class Animal
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string Drink()
        {
            return name + " is drinking water";
        }
        public abstract string Eat();

    }
    public class Lion : Animal
    {
        public override string Eat()
        {
            return name + " is eating la7ma";
        }

    }
}
