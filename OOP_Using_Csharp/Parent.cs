using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Using_Csharp
{
    public class Parent
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        public int sum (int x,int y)
        {
            return x + y;
        }
        public int sum (int x,int y,int z)
        {
            return x + y + z;
        }
        public virtual string Report()
        {
            return "ID:" + ID + " name:" + name + " city:" + city;
        }
        
    }
    public class Child:Parent
    {
        public int age { get; set; }
        new public int sum(int x, int y)
        {
            return x + y + 3;
        }
        public override string Report()
        {
            return base.Report() + " age:" + age;
        }

    }
    interface Ipayment
    {
        int Clac(int n1, int n2);
        string Pay(int amount);
    }
    public class Atm:Ipayment
    {
        public int Clac(int n1,int n2)
        {
            return n1 + n2;
        }
        public string Pay (int amount)
        {
            return "pay using Atm "+amount.ToString();
        }
    }
    public class CreditCard:Ipayment
    {
        public int Clac(int n1, int n2)
        {
            return n1 - n2;
        }

        public string Pay(int amount)
        {
            return "pay using credit card " + amount.ToString();
        }

       
    }
}
