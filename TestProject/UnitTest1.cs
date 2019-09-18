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
        public void AddUniqueDatesWithExtensionMethod()
        {
            var datesTimes = DateTimeList();

            var dateTimesDistinct = new List<DateTime>();

            foreach (var dateTime in datesTimes)
            {
                dateTimesDistinct.AddUniqueNoInterface(dateTime);
            }

            Assert.IsTrue(dateTimesDistinct.Count == 3,
                "Expected three unique dates");

        }
        [TestMethod]
        public void AddUniqueDatesWithoutExtensionMethod()
        {
            var datesTimes = DateTimeList();

            var dateTimesDistinct = new List<DateTime>();

            foreach (var dateTime in datesTimes)
            {
                if (!dateTimesDistinct.Contains(dateTime))
                {
                    dateTimesDistinct.Add(dateTime);
                }
            }

            Assert.IsTrue(dateTimesDistinct.Count == 3,
                "Expected three unique dates");

        }
        [TestMethod]
        public void AddUniqueIntWithoutExtensionTest()
        {
            var integerList = IntList();
            var intListDistIntList = new List<int>();

            foreach (var integer in integerList)
            {
                if (!intListDistIntList.Contains(integer))
                {
                    intListDistIntList.Add(integer);
                }
            }

            Assert.IsTrue(intListDistIntList.Count == 4,
                "Expected four unique int");

        }
        [TestMethod]
        public void AddUniqueIntWithExtensionTest()
        {
            var integerList = IntList();
            var intListDistIntList = new List<int>();

            foreach (var integer in integerList)
            {
                intListDistIntList.AddUniqueNoInterface(integer);
            }

            Assert.IsTrue(intListDistIntList.Count == 4, 
                "Expected four unique int");

        }
        /// <summary>
        /// This demonstrates how a generic method can fail as it
        /// knows nothing about a string case. The test below handles
        /// case properly
        /// </summary>
        [TestMethod]
        public void AddUniqueStringCaseIssueTest()
        {
            var nameList = new List<string>() {"jim", "Jim", "BOB", "bob"};
            var distinctNameList = new List<string>();

            foreach (var name in nameList)
            {
                distinctNameList.AddUniqueNoInterface(name);
            }

            Assert.IsTrue(distinctNameList.Count == 4,
                "Expected four names");
        }
        /// <summary>
        /// Add unique strings to a list disregarding case of string.
        /// </summary>
        [TestMethod]
        public void AddUniqueStringCaseInsensitiveTest()
        {
            var nameList = new List<string>() { "jim", "Jim", "BOB", "bob" };
            var distinctNameList = new List<string>();

            foreach (var name in nameList)
            {
                distinctNameList.AddUnique(name);
            }

            Assert.IsTrue(distinctNameList.Count == 2,
                "Expected two names");
        }

        /// <summary>
        /// For article text demo for performing distinct against
        /// a list with by a foreign key in this case the duplicates
        /// are okay
        /// </summary>
        [TestMethod]
        public void GroupByTest()
        {
            JoinNotes();
        }
        /// <summary>
        /// Example of working with a pre-existing list of numbers with
        /// duplicates using Distinct extension.
        /// </summary>
        [TestMethod]
        public void SimpleDistinctNumberTest()  
        {
            var longs = new List<long> { 1, 2, 3, 4, 3, 2, 5 };
            var unique = longs.Distinct().ToList();
            Assert.IsTrue(unique.Count == 5);
        }
        /// <summary>
        /// Conventional logic flow to take incoming data,
        /// add to a new list without duplicates
        /// </summary>
        [TestMethod]
        public void ConventionalAddLongToListTest() 
        {
            var data = new List<long> { 1, 2, 3, 4, 3, 2, 5 };
            var results = new List<long>();

            foreach (var item in data)
            {
                if (!results.Contains(item))
                {
                    results.Add(item);
                }
            }

            Assert.IsTrue(results.Count == 5);

        }
        /// <summary>
        /// Example of working with a pre-existing list of strings with
        /// duplicates using Distinct extension. Is not case insensitive
        /// </summary>
        [TestMethod]
        public void SimpleDistinctStringsTest() 
        {
            string[] original = SupplierNameArray();

            var withDuplicateValues = original.ToList();
            var noDuplicateValues = withDuplicateValues.Distinct().ToList();

            Assert.IsTrue(noDuplicateValues.Count == 29);
        }
        /// <summary>
        /// Example for preventing duplicate strings in list of string using
        /// case insensitive extension method
        /// </summary>
        [TestMethod]
        public void AddUniqueStringsToListTest()
        {
            var nameList = new List<string>();

            nameList.AddUnique("Karen");
            nameList.AddUnique("karen");

            Assert.IsTrue(nameList.Count == 1, 
                "Failed add unique string");
            
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
            var dictionaryFirst = SupplierList().Distinct(new SuppliersComparer()).ToList()
                .GroupBy(supplier => supplier.SupplierIdentifier)
                .ToDictionary(grouping => grouping.Key, grouping => grouping.First());

            Assert.IsTrue(dictionaryFirst.Count == 2, 
                "Expected two for dictionary first");


            var dictionaryLast = SupplierList().Distinct(new SuppliersComparer()).ToList()
                .GroupBy(supplier => supplier.SupplierIdentifier)
                .ToDictionary(grouping => grouping.Key, grouping => grouping.Last());

            Assert.IsTrue(dictionaryLast.Count == 2,
                "Expected two for dictionary last");

        }
        [TestMethod]
        public void CustomersComparerTest() 
        {

            var customers = CustomerList().Distinct(new CustomerNameStreetCityCountryComparer()).ToList();
            Assert.IsTrue(customers.Count == 2, 
                "Expected two customers");

            var secondAttempt = CustomerList();
            secondAttempt[0].CountryIdentfier = 1;
            customers = secondAttempt.Distinct(new CustomerNameStreetCityCountryComparer()).ToList();
            Assert.IsTrue(customers.Count == 3,
                "Expected three customers");


        }
        /// <summary>
        /// Example of what might be done by a typical developer,
        /// read data from an external data source which potentially
        /// have duplicate entries which would be tested after the
        /// list is populated then iterate incoming data, assert for
        /// duplicates by, in this case three fields where strings
        /// are not case insensitive in a for-each.
        ///
        /// The method above uses a IEqualityComparer to perform the
        /// same task, keeps code clean where the actual work is being done.
        /// </summary>
        [TestMethod]
        public void CustomersConventionalTest() 
        {

            var customers = CustomerList();
            var incomingCustomers = new List<Customer>();

            foreach (var customer in customers)
            {
                var cust = incomingCustomers.FirstOrDefault(c => 
                    c.CompanyName == customer.CompanyName && 
                    c.Street == customer.Street &&  
                    c.City == customer.City &&
                    c.CountryIdentfier == customer.CountryIdentfier);

                if (cust == null)
                {
                    incomingCustomers.Add(customer);
                }
            }

            Assert.IsTrue(incomingCustomers.Count == 2, 
                "Customer conventional expected two customers");
        }
    }
}
