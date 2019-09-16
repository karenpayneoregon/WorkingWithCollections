using System;
using System.Collections.Generic;
using System.Linq;
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
        /// No duplicates based on primary key
        /// </summary>
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
    }
}
