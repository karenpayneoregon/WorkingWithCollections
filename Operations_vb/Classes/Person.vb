Imports Interfaces

Namespace Classes
    Public Class Person
        Implements IBase

        Public Property Identifier() As Integer
        Public ReadOnly Property Id() As Integer Implements IBase.Id
            Get
                Return Identifier
            End Get
        End Property
        Public Property FirstName() As String
        Public Property LastName() As String
    End Class

End Namespace
