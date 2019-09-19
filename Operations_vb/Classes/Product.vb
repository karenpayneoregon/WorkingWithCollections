Imports System

Namespace Classes
    Public Class Product
        Implements IEquatable(Of Product)

        Public Property ProductName() As String
        Public Property CategoryIdentifier() As Integer

        Public Function Equals(ByVal other As Product) As Boolean Implements IEquatable(Of Product).Equals

            If ReferenceEquals(other, Nothing) Then
                Return False
            End If

            If ReferenceEquals(Me, other) Then
                Return True
            End If

            'Check whether the products' properties are equal. 
            Return CategoryIdentifier.Equals(other.CategoryIdentifier) AndAlso ProductName.Equals(other.ProductName)
        End Function
        Public Overrides Function GetHashCode() As Integer

            'Get hash code for the Name field if it is not null. 
            Dim hashProductName As Integer = If(ProductName Is Nothing, 0, ProductName.GetHashCode())

            'Get hash code for the Code field. 
            Dim hashProductCode As Integer = CategoryIdentifier.GetHashCode()

            'Calculate the hash code for the product. 
            Return hashProductName Xor hashProductCode
        End Function
    End Class
End Namespace
