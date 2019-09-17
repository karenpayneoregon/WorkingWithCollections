using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.Classes
{
    public class Suppliers
    {
        public int SupplierIdentifier { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
 
    }

    public class ExampleComparer : IEqualityComparer<Suppliers>
    {
        public bool Equals(Suppliers supplier1, Suppliers supplier2)
        {
            return supplier1.SupplierIdentifier == supplier2.SupplierIdentifier && 
                   supplier1.CompanyName == supplier2.CompanyName;
        }

        public int GetHashCode(Suppliers obj)
        {
            return new {obj.SupplierIdentifier, ComanyName = obj.CompanyName}.GetHashCode();
        }
    }
}
