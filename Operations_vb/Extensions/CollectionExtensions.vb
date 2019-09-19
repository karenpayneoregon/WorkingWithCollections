Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports Interfaces

Namespace Extensions
    Public Module CollectionExtensions
        ''' <summary>
        ''' Add item to collection if not already exists in collection
        ''' </summary>
        ''' <typeparam name="TType">Class type</typeparam>
        ''' <param name="self">Collection of type</param>
        ''' <param name="item">instance of T</param>
        ''' <remarks>
        ''' T must implement IBase
        ''' </remarks>
        <Runtime.CompilerServices.Extension>
        Public Sub AddUnique(Of TType As IBase)(self As ICollection(Of TType), item As TType)
            If self.FirstOrDefault(Function(data) data.Id = item.Id) Is Nothing Then
                self.Add(item)
            End If
        End Sub
        ''' <summary>
        ''' Adds a value uniquely to to a collection and returns
        ''' a value whether the value was added or not.
        ''' </summary>
        ''' <typeparam name = "T">The generic collection value type</typeparam>
        ''' <param name = "sender">The collection.</param>
        ''' <param name = "pValue">The value to be added.</param>
        ''' <returns>Indicates whether the value was added or not</returns>
        ''' <remarks>Naming done to not conflict with extension method above</remarks>
        <Runtime.CompilerServices.Extension>
        Public Function AddUniqueNoInterface(Of T)(sender As ICollection(Of T), pValue As T) As Boolean
            Dim alreadyHasValue = sender.Contains(pValue)

            If Not alreadyHasValue Then
                sender.Add(pValue)
            End If

            Return alreadyHasValue
        End Function
        ''' <summary>
        ''' Add item if not currently in the list case insensitive 
        ''' </summary>
        ''' <param name="self"></param>
        ''' <param name="item"></param>
        ''' <remarks>There could be an optional parameter to allow another comparer</remarks>
        <Runtime.CompilerServices.Extension>
        Public Sub AddUnique(self As List(Of String), item As String)
            If Not self.Contains(item, StringComparer.OrdinalIgnoreCase) Then
                self.Add(item)
            End If
        End Sub

        ''' <summary>
        ''' Adds only items that do not exist in source.
        ''' Can be slow for large collections and some complex types of source.
        ''' </summary>
        ''' <typeparam name="TType">Type in the collection.</typeparam>
        ''' <param name="self">Source collection</param>
        ''' <param name="predicate">Predicate to determine whether a new item is already in source.</param>
        ''' <param name="items">New items.</param>
        <Runtime.CompilerServices.Extension>
        Public Sub AddRangeUnique(Of TType)(self As ICollection(Of TType), predicate As Func(Of TType, TType, Boolean), items As IEnumerable(Of TType))
            For Each item As TType In items
                If Not self.Any(Function(data) predicate(data, item)) Then
                    self.Add(item)
                End If
            Next
        End Sub
        ''' <summary>
        ''' Add KeyValue pair if key does not already exists in Dictionary
        ''' </summary>
        ''' <typeparam name="TType"></typeparam>
        ''' <param name="dictionary"></param>
        ''' <param name="key"></param>
        ''' <param name="value"></param>
        <Runtime.CompilerServices.Extension>
        Public Sub AddSafe(Of TType)(dictionary As Dictionary(Of Integer, TType), key As Integer, value As TType)
            If Not dictionary.ContainsKey(key) Then
                dictionary.Add(key, value)
            End If
        End Sub
    End Module
End Namespace
