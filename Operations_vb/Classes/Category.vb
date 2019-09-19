Imports Interfaces

Namespace Classes
    Public Class Category
        Implements IBase

        Public Property CategoryIdentifier() As Integer
        Public Property Name() As String
        Public ReadOnly Property Id() As Integer Implements IBase.Id
            Get
                Return CategoryIdentifier
            End Get
        End Property
    End Class
End Namespace
