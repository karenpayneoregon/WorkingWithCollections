using System.Collections.Generic;

namespace Operations.Classes
{
    public class CustomerComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer customer1, Customer customer2)
        {
            return customer1.CompanyName == customer2.CompanyName &&
                   customer1.Street == customer2.Street &&
                   customer1.City == customer2.City && 
                   customer1.CountryIdentfier == customer2.CountryIdentfier;
        }

        public int GetHashCode(Customer obj)
        {
            return new { obj.CompanyName, obj.Street, obj.City,obj.CountryIdentfier }.GetHashCode();
        }
    }
}