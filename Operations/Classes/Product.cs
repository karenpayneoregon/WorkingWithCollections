using System;
namespace Operations.Classes
{
    public class Product : IEquatable<Product>
    {
        public string ProductName { get; set; }
        public int CategoryIdentifier { get; set; }

        public bool Equals(Product other)
        {

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            //Check whether the products' properties are equal. 
            return CategoryIdentifier.Equals(other.CategoryIdentifier) && 
                   ProductName.Equals(other.ProductName);
        }
        public override int GetHashCode()
        {

            //Get hash code for the Name field if it is not null. 
            var hashProductName = ProductName == null ? 0 : ProductName.GetHashCode();

            //Get hash code for the Code field. 
            var hashProductCode = CategoryIdentifier.GetHashCode();

            //Calculate the hash code for the product. 
            return hashProductName ^ hashProductCode;
        }
    }
}
