using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Using_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.FixedBouns = 300;
            Employee emp1 = new Employee()
            {
                ID = 1,
                name = "ali",
                city = "egypt",
                
                
            };
            Employee emp2 = new Employee()
            {
                ID = 2,
                name = "abdo",
                city = "egypt",


            };
            MessageBox.Show(emp1.Report());
            MessageBox.Show(emp2.Report());
            MessageBox.Show(Employee.sum(500,300).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager()
            {   ID=1,
                name="ali",
                city="egypt",
                Bouns = 5,
                Title = "Gedawy",
                
            };
            MessageBox.Show(manager.MangerReport());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            Manager m = new Manager()
            {
                ID = 1,
                name = "ali",
                city = "egypt",
                salary = s,
                Bouns = 5,
                Title = "Gedawy",

            };
            MessageBox.Show(m.MangerReport());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal a = new Lion() {
                ID = 1,
                name = "semba",
            };
            MessageBox.Show(a.Drink());
            MessageBox.Show(a.Eat());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Parent p = new Parent()
            {
                ID=1,
                name="ahmed",
                city="sohag",
            };
            Child c = new Child()
            {
                ID = 1,
                name = "ali",
                city = "sohag",
                age = 22,
            };
            
            MessageBox.Show(p.sum(2,3,6).ToString());
            MessageBox.Show(c.sum(2,3).ToString());

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ipayment p = new Atm();
            MessageBox.Show(p.Clac(3, 6).ToString());
            MessageBox.Show(p.Pay(100).ToString());
            p = new CreditCard();
            MessageBox.Show(p.Clac(3, 6).ToString());
            MessageBox.Show(p.Pay(1000).ToString());
            Console.WriteLine("ali");

        }
    }
}
