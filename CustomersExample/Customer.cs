using System.Collections.Generic;

namespace CustomersExample
{
    public class Customer
    {
        public string Name { get; set; }
        public string Family { get; set; } 
    }
    public class CustomerNameComparer : IEqualityComparer<Customer> 
    {
        public bool Equals(Customer customer1, Customer customer2)
        {
            return customer1.Name == customer2.Name;
        }

        public int GetHashCode([DisallowNull] Customer customer)
        {
            return new { customer.Name}.GetHashCode();
        }
    }
    public class CustomerFamilyComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer customer1, Customer customer2)
        {
            return customer1.Family == customer2.Family;
        }

        public int GetHashCode([DisallowNull] Customer customer)
        {
            return new { customer.Family }.GetHashCode();
        }
    }
}
