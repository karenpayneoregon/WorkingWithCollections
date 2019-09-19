Imports System.Collections.Generic

Namespace Classes
    Public Class SuppliersComparer
        Implements IEqualityComparer(Of Suppliers)

        Public Function Equals(supplier1 As Suppliers, supplier2 As Suppliers) As Boolean Implements IEqualityComparer(Of Suppliers).Equals
            Return supplier1.SupplierIdentifier = supplier2.SupplierIdentifier AndAlso supplier1.CompanyName = supplier2.CompanyName
        End Function

        Public Function GetHashCode(obj As Suppliers) As Integer Implements IEqualityComparer(Of Suppliers).GetHashCode
            Return New With {
                Key obj.SupplierIdentifier,
                Key .ComanyName = obj.CompanyName
            }.GetHashCode()
        End Function
    End Class
End Namespace