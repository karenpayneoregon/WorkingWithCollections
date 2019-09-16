using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.Classes
{
    public class Product : IEquatable<Product>
    {
        public string ProductName { get; set; }
        public int CategoryIdentifier { get; set; }

        public bool Equals(Product other)
        {

            //Check whether the compared object is null. 
            if (ReferenceEquals(other, null)) return false;

            //Check whether the compared object references the same data. 
            if (ReferenceEquals(this, other)) return true;

            //Check whether the products' properties are equal. 
            return CategoryIdentifier.Equals(other.CategoryIdentifier) && ProductName.Equals(other.ProductName);
        }

        // If Equals() returns true for a pair of objects  
        // then GetHashCode() must return the same value for these objects. 

        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null. 
            int hashProductName = ProductName == null ? 0 : ProductName.GetHashCode();

            //Get hash code for the Code field. 
            int hashProductCode = CategoryIdentifier.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName ^ hashProductCode;
        }
    }

    public class Dummy
    {


        public int Id { get; set; } 
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
