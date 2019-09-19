using System;

namespace Operations.Classes
{
    public class Employee : IEquatable<Employee>
    {
        public int EmployeeIdentifier { get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;} 
        public string DepartmentName {get;set;}
        public bool Equals(Employee other)
        {
            return other.EmployeeIdentifier == EmployeeIdentifier && 
                   other.FirstName == FirstName && 
                   other.DepartmentName == DepartmentName;

        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(FirstName) ^
                   StringComparer.OrdinalIgnoreCase.GetHashCode(LastName) ^
                   StringComparer.OrdinalIgnoreCase.GetHashCode(DepartmentName);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
