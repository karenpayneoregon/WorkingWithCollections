Imports System.Collections.Generic

Namespace Classes
	Public Class CustomerNameStreetCityCountryComparer
		Implements IEqualityComparer(Of Customer)

		Public Function Equals(ByVal customer1 As Customer, ByVal customer2 As Customer) As Boolean Implements IEqualityComparer(Of Customer).Equals
			Return customer1.CompanyName = customer2.CompanyName AndAlso customer1.Street = customer2.Street AndAlso customer1.City = customer2.City AndAlso customer1.CountryIdentfier.Equals(customer2.CountryIdentfier)
		End Function

		Public Function GetHashCode(ByVal obj As Customer) As Integer Implements IEqualityComparer(Of Customer).GetHashCode
			Return New With { _
				Key obj.CompanyName, _
				Key obj.CountryIdentfier _
			}.GetHashCode()
		End Function
	End Class
End Namespace