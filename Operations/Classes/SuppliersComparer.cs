using System.Collections.Generic;

namespace Operations.Classes
{
    public class SuppliersComparer : IEqualityComparer<Suppliers>
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