using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Samples.Classes;

namespace Samples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var person1 = new Person() {Identifier = 1, FirstName = "Karen", LastName = "payne"};
            var person2 = new Person() {Identifier = 1, FirstName = "Karen", LastName = "Payne"};

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1 == person2);
        }
    }
}
