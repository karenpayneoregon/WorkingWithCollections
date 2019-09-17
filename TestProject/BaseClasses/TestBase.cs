using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;
using Operations.Classes;
using TestProject.Classes;

namespace TestProject.BaseClasses
{
    public class TestBase
    {
        protected List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author() {AuthorIdentifier = 1, FirstName = "Joe", LastName = "Smith"},
                new Author() {AuthorIdentifier = 2, FirstName = "Bill", LastName = "White"},
                new Author() {AuthorIdentifier = 3, FirstName = "Mary", LastName = "Jones"}

            };
        }

        protected List<Note> Notes()
        {
            return new List<Note>()
            {
                new Note() { NoteIdentifier = 1, AuthorIdentifier = 2, Text = "Buy eggs", Title = "TODO 1"},
                new Note() { NoteIdentifier = 2, AuthorIdentifier = 1, Text = "Dentist appointment today", Title = "TODO 2"},
                new Note() { NoteIdentifier = 3, AuthorIdentifier = 2, Text = "Buy Milk", Title = "TODO 3"},
                new Note() { NoteIdentifier = 4, AuthorIdentifier = 1, Text = "Change oil in car", Title = "TODO 4"}
            };
        }
        /// <summary>
        /// Demonstration for explanations in article
        /// </summary>
        public void JoinNotes()
        {
            var query = (from note in Notes()
                join author in Authors() on note.AuthorIdentifier equals author.AuthorIdentifier
                select new NoteItem
                {
                    NoteIdentifier = note.NoteIdentifier,
                    NoteTitle = note.Text,
                    Title = note.Title,
                    AuthorIdentifier = note.AuthorIdentifier,
                    AuthorName = $"{author.FirstName} {author.LastName}"
                }).ToList();


            IEnumerable<NoteItem> distinctByAuthorIdentifier1 = 
                query
                    .GroupBy(item => item.AuthorIdentifier)
                    .Select(noteGroup => noteGroup.First());


            // uses MoreLinq, installed via NuGet
            IEnumerable<NoteItem> distinctByAuthorIdentifier2 =
                query.DistinctBy(item => item.AuthorIdentifier).ToList();

            Console.WriteLine();
        }


        protected Product[] Products()
        {
            return new Product[]
            {
                new Product { ProductName = "apple", CategoryIdentifier = 1 },
                new Product { ProductName = "orange", CategoryIdentifier = 4 },
                new Product { ProductName = "apple", CategoryIdentifier = 1 },
                new Product { ProductName = "apple", CategoryIdentifier = 5 },
                new Product { ProductName = "lemon", CategoryIdentifier = 2 }
            };
        }

        protected List<Person> PeopleList()
        {
            return new List<Person>()
            {
                new Person() { Identifier = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Identifier = 2, FirstName = "Mary", LastName = "Jones"},
                new Person() { Identifier = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Identifier = 3, FirstName = "Mary", LastName = "Clime"}
            };
        }

        protected List<Category> CategoryList()
        {
            return new List<Category>()
            {
                new Category() { CategoryIdentifier = 1, Name = "Seafood" },
                new Category() { CategoryIdentifier = 2, Name = "Confections" },
                new Category() { CategoryIdentifier = 3, Name = "Soft drinks, coffees, teas, beers, and ales" },
                new Category() { CategoryIdentifier = 2, Name = "Confections" },
                new Category() { CategoryIdentifier = 1, Name = "Seafood" },
                new Category() { CategoryIdentifier = 4, Name = "Grains/Cereals" }
            };
        }

        protected HashSet<Employee> EmployeeHashSet()
        {
            return new HashSet<Employee>
            {
                {new Employee {EmployeeIdentifier = 1, FirstName = "Karen", LastName = "Payne", DepartmentName = "Finance"}},
                {new Employee {EmployeeIdentifier = 3, FirstName = "Mary", LastName = "Jones",   DepartmentName = "IT"}},
                {new Employee {EmployeeIdentifier = 1, FirstName = "Karen", LastName = "Payne",  DepartmentName = "Finance"}},
                {new Employee {EmployeeIdentifier = 4, FirstName = "Frank", LastName = "Anderson",  DepartmentName = "IT"}}
            };
        }

        protected List<Suppliers> SupplierList()
        {
            return new List<Suppliers>
            {
                new Suppliers() {SupplierIdentifier = 1, CompanyName = "Tokyo Traders"},
                new Suppliers() {SupplierIdentifier = 2, CompanyName = "Tokyo Traders"},
                new Suppliers() {SupplierIdentifier = 2, CompanyName = "Tokyo Traders"},
                new Suppliers() {SupplierIdentifier = 1, CompanyName = "Tokyo Traders"},
                new Suppliers() {SupplierIdentifier = 2, CompanyName = "Specialty Biscuits, Ltd."}
            };
        }

        protected string[] SupplierNameArray()
        {
            string[] original =
            {
                "Exotic Liquids",
                "New Orleans Cajun Delights",
                "Grandma Kelly's Homestead",
                "Tokyo Traders",
                "Tokyo Traders",
                "Cooperativa de Quesos 'Las Cabras'",
                "Mayumi's", "Pavlova, Ltd.",
                "Specialty Biscuits, Ltd.",
                "PB Knäckebröd AB",
                "PB Knäckebröd AB",
                "PB Knäckebröd AB",
                "Refrescos Americanas LTDA",
                "Heli Süßwaren GmbH &amp; Co. KG",
                "Plutzer Lebensmittelgroßmärkte AG",
                "Nord-Ost-Fisch Handelsgesellschaft mbH",
                "Formaggi Fortini s.r.l.", "Norske Meierier",
                "Bigfoot Breweries", "Svensk Sjöföda AB",
                "Aux joyeux ecclésiastiques", "New England Seafood Cannery",
                "Leka Trading", "Lyngbysild", "Zaanse Snoepfabriek",
                "Karkki Oy", "G'day, Mate", "Ma Maison",
                "Pasta Buttini s.r.l.", "Escargots Nouveaux",
                "Gai pâturage",
                "Forêts d'érables"
            };

            return original;

        }
    }


}
