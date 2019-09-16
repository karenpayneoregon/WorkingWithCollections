using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return other.EmployeeIdentifier == EmployeeIdentifier && other.FirstName == FirstName && other.DepartmentName == DepartmentName;

        }
        public override int GetHashCode() =>
            new { EmployeeIdentifier, FirstName, LastName, DepartmentName }.GetHashCode();

    }
}
