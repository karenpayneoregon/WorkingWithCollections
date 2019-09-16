using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations.Classes;

namespace TestProject.BaseClasses
{
    public class TestBase
    {
        public Product[] Products()
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

        public List<Person> PeopleList()
        {
            return new List<Person>()
            {
                new Person() { Identifier = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Identifier = 2, FirstName = "Mary", LastName = "Jones"},
                new Person() { Identifier = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Identifier = 3, FirstName = "Mary", LastName = "Clime"}
            };
        }

        public List<Category> CategoryList()
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
    }
}
