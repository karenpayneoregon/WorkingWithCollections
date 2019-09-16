using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations.Classes;
using Operations.Extensions;
using TestProject.BaseClasses;

namespace TestProject
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        /// <summary>
        /// Implements IEquatable on Product class to discard duplicates
        /// by primary key and foreign key
        /// </summary>
        [TestMethod]
        public void EquatableProductTest()
        {
            var noduplicate = Products()
                .ToList()
                .Distinct();

            Assert.IsTrue(noduplicate.Count() == 4,
                "Expected four products for custom distinct");
        }
        /// <summary>
        /// Implements IEquatable on properties
        ///    EmployeeIdentifier
        ///    FirstName
        ///    LastName
        ///    DepartmentName
        /// </summary>
        [TestMethod]
        public void HashSetIEquatableTest() 
        {
            var employees = new HashSet<Employee>
            {
                {new Employee {EmployeeIdentifier = 1, FirstName = "Karen", LastName = "Payne", DepartmentName = "Finance"}},
                {new Employee {EmployeeIdentifier = 3, FirstName = "Mary", LastName = "Jones",   DepartmentName = "IT"}},
                {new Employee {EmployeeIdentifier = 1, FirstName = "Karen", LastName = "Payne",  DepartmentName = "Finance"}},
                {new Employee {EmployeeIdentifier = 4, FirstName = "Frank", LastName = "Anderson",  DepartmentName = "IT"}}
            };

            Assert.IsTrue(employees.Count  == 3);
        }
        /// <summary>
        /// No duplicates based on primary key
        /// </summary>
        [TestMethod]
        public void AddUniqueCategoryByPrimaryKeyTest()
        {
            var categoryList = new List<Category>();

            foreach (var category in CategoryList())
            {
                categoryList.AddUnique(category);
            }

            Assert.IsTrue(categoryList.Count == 4,
                "Category count incorrect for AddUnique");

        }
        /// <summary>
        /// No duplicates based on primary key.
        /// </summary>
        /// <remarks>
        /// Good for processing in a loop e.g. for-each or for-next
        /// </remarks>
        [TestMethod]
        public void AddUniquePersonByPrimaryTest()
        {
            var peopleList = new List<Person>();

            foreach (var person in PeopleList())
            {
                peopleList.AddUnique(person);
            }

            Assert.IsTrue(peopleList.Count == 3,
                "People count incorrect for AddUnique");
        }
        /// <summary>
        /// No duplicates based on a predicate
        /// </summary>
        /// <remarks>
        /// Note this example uses Id from IBase but could use Identifier instead.
        /// </remarks>
        [TestMethod]
        public void AddUniquePersonAfterTest()
        {
            var peopleList = new List<Person>();

            peopleList.AddArrangeUniqueBy((person1, person2) => person1.Id == person2.Id, PeopleList());

            Assert.IsTrue(peopleList.Count == 3,
                "People count incorrect for AddUniqueBy");
        }
    }


}
