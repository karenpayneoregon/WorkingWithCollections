Imports Classes

Namespace Examples
    Public Class EmployeeHOperations
        Protected Function EmployeeList() As HashSet(Of Employee)
            Return New HashSet(Of Employee) From {
                {New Employee With {.EmployeeIdentifier = 1, .FirstName = "Karen", .LastName = "payne", .DepartmentName = "Finance"}},
                {New Employee With {.EmployeeIdentifier = 3, .FirstName = "Mary", .LastName = "Jones", .DepartmentName = "IT"}},
                {New Employee With {.EmployeeIdentifier = 1, .FirstName = "karen", .LastName = "Payne", .DepartmentName = "finance"}},
                {New Employee With {.EmployeeIdentifier = 4, .FirstName = "Frank", .LastName = "Anderson", .DepartmentName = "IT"}}}
        End Function
        Public Sub Demo()
            Dim employeesList = EmployeeList().ToList()
            Console.WriteLine(employeesList.Count)
        End Sub
    End Class
End Namespace