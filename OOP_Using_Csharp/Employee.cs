using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Using_Csharp
{
    class Employee
    {
        protected int test { get; set; }
        public int ID { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public static double FixedBouns { get; set; }
        private double _salary;
        public double salary
        {
            get { return _salary; }
            set
            {
                if (value > 5000)
                    _salary = value;
                else
                    throw new Exception("salary mest be greater than 5000$");
            }
        }

        public string Report()
        {

            return "ID:" + ID + " name:" + name + " city:" + city + " FixedBouns:" + FixedBouns;
        }
        public static double sum(double x,double y)
        {
            return x + y;
        }

    }
    class Manager : Employee
    {
        public int Bouns { get; set; }
        public string Title { get; set; }

        public string MangerReport()
        {
            test = 10;
            return Report() + "Bouns:" + Bouns + " Title:" + Title+" salary:"+salary;   
        }
    }
}
