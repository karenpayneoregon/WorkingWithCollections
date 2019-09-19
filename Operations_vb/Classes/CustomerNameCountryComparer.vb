Imports System.Collections.Generic

Namespace Classes
    Public Class CustomerNameCountryComparer
        Implements IEqualityComparer(Of Customer)

        Public Function Equals(customer1 As Customer, customer2 As Customer) As Boolean Implements IEqualityComparer(Of Customer).Equals
            Return customer1.CompanyName = customer2.CompanyName AndAlso customer1.CountryIdentfier.Equals(customer2.CountryIdentfier)
        End Function

        Public Function GetHashCode(ByVal obj As Customer) As Integer Implements IEqualityComparer(Of Customer).GetHashCode
            Return New With {
                Key obj.CompanyName,
                Key obj.CountryIdentfier
            }.GetHashCode()
        End Function
    End Class
End Namespace