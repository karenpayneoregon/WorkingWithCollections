using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operations.Classes;
using Operations.Extensions;
using TestProject.BaseClasses;

namespace TestProject
{
    [TestClass]
    public class UnitTest1 : TestBase
    {
        [TestMethod]
        public void GroupByTest()
        {
            JoinNotes();
        }
        [TestMethod]
        public void SimpleDistinctNumberTest()  
        {
            var longs = new List<long> { 1, 2, 3, 4, 3, 2, 5 };
            var unique = longs.Distinct().ToList();
            Assert.IsTrue(unique.Count == 5);

        }
        [TestMethod]
        public void MyTestMethod()
        {
            string[] original = SupplierNameArray();

            var withDuplicateValues = original.ToList();
            var noDupicateValues = withDuplicateValues.Distinct().ToList();

            Assert.IsTrue(noDupicateValues.Count == 29);
        }
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
            var employees = EmployeeHashSet();

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

            peopleList.AddRangeUnique((person1, person2) => person1.Id == person2.Id, PeopleList());

            Assert.IsTrue(peopleList.Count == 3,
                "People count incorrect for AddUniqueBy");
        }
        /// <summary>
        /// Get distinct items from a list and transform to a dictionary
        /// where primary key is unique and company name unique.
        ///
        /// There is complexity in that if there are more than two duplicates
        /// those will be excluded from the resulting dictionary.
        /// </summary>
        [TestMethod]
        public void DictionaryTest()
        {
            var dictionaryFirst = SupplierList().Distinct(new ExampleComparer()).ToList()
                .GroupBy(supplier => supplier.SupplierIdentifier)
                .ToDictionary(grouping => grouping.Key, grouping => grouping.First());

            Assert.IsTrue(dictionaryFirst.Count == 2, 
                "Expected two for dictionary first");


            var dictionaryLast = SupplierList().Distinct(new ExampleComparer()).ToList()
                .GroupBy(supplier => supplier.SupplierIdentifier)
                .ToDictionary(grouping => grouping.Key, grouping => grouping.Last());

            Assert.IsTrue(dictionaryLast.Count == 2,
                "Expected two for dictionary last");

        }
    }
}
