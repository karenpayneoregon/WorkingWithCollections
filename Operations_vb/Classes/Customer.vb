Imports Interfaces

Namespace Classes
    Public Class Customer
        Implements IBase

        Public ReadOnly Property Id() As Integer Implements IBase.Id
        Public Property CustomerIdentifier() As Integer
        Public Property CompanyName() As String
        Public Property ContactIdentifier() As Integer?
        Public Property ContactTypeIdentifier() As Integer?
        Public Property Street() As String
        Public Property City() As String
        Public Property PostalCode() As String
        Public Property CountryIdentfier() As Integer?
        Public Property Phone() As String
        Public Property ModifiedDate() As DateTime?
        Public Property InUse() As Boolean?

    End Class

End Namespace
