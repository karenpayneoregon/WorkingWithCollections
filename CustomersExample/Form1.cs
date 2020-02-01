using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Karen", Family = "Payne" } ,
                new Customer() { Name = "Mary", Family = "Payne" } ,
                new Customer() { Name = "Karen", Family = "Payne" }
            } ;

            var result = customers.Distinct(new CustomerNameComparer());
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Bill", Family = "Gallagher" } ,
                new Customer() { Name = "Mary", Family = "Payne" } ,
                new Customer() { Name = "Jim", Family = "Gallagher" }
            };

            var result = customers.Distinct(new CustomerFamilyComparer());
            Console.WriteLine();
        }
    }
}
