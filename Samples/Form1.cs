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

            if ("Karen".Contains("Aren", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            if ("Karen".Contains("Aren",StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            var person1 = new Person() { Identifier = 1, FirstName = "Karen", LastName = "payne" };
            var person2 = new Person() { Identifier = 1, FirstName = "Karen", LastName = "Payne" };

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1 == person2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var firstName1 = "Bill";
            var firstName2 = "Bill";

            if (firstName1 == firstName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No match");
            }


            firstName2 = "BILL";

            if (firstName1 == firstName2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No match");
            }

            if (firstName1.ToLower() == firstName2.ToLower())
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No match");
            }

            if (string.Equals(firstName1, firstName2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Match ~~~");
            }
            else
            {
                Console.WriteLine("No match");
            }

            if (string.Equals(firstName1, firstName2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Match !!!");
            }
            else
            {
                Console.WriteLine("No match");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] array1 = { "dot", "net", "perls" };
            string[] array2 = { "a", "different", "array" };
            string[] array3 = { "dot", "net", "perls" };
            string[] array4 = { "DOT", "NET", "PERLS" };

            bool result1 = array1.SequenceEqual(array2);
            bool result2 = array1.SequenceEqual(array3);
            bool result3 = array1.SequenceEqual(array4, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.WriteLine();



            Pet pet1 = new Pet { Name = "Turbo", Age = 2 };
            Pet pet2 = new Pet { Name = "Peanut", Age = 8 };

            List<Pet> pets1 = new List<Pet> { pet1, pet2 };
            List<Pet> pets2 = new List<Pet> { pet1, pet2 };

            bool equal = pets1.SequenceEqual(pets2);
            Console.WriteLine($"The lists {(equal ? "are" : "are not")} equal.");

        }

    }
    public class ProductA : IEquatable<Pet>
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public bool Equals(Pet other)
        {
            if (other is null)
                return false;

            return Name == other.Name && Code == other.Code;
        }

        public override bool Equals(object obj) => Equals(obj as Pet);
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ Code;
            }
        }
    }
}
