﻿Imports System

Namespace Classes
    Public Class Employee
        Implements IEquatable(Of Employee)

        Public Property EmployeeIdentifier() As Integer
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property DepartmentName() As String
        Public Function Equals(ByVal other As Employee) As Boolean Implements IEquatable(Of Employee).Equals
            Return other.EmployeeIdentifier = EmployeeIdentifier AndAlso other.FirstName = FirstName AndAlso other.DepartmentName = DepartmentName

        End Function

        Public Overrides Function GetHashCode() As Integer
            Return StringComparer.OrdinalIgnoreCase.GetHashCode(FirstName) Xor StringComparer.OrdinalIgnoreCase.GetHashCode(LastName) Xor StringComparer.OrdinalIgnoreCase.GetHashCode(DepartmentName)
        End Function

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function
    End Class
End Namespace
