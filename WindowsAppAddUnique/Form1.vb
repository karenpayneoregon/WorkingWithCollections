Public Class Form1
    ''' <summary>
    ''' Only add string if not in list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddUniqueItemButton_Click(sender As Object, e As EventArgs) _
        Handles AddUniqueItemButton.Click

        Dim titleList As New List(Of String) From
                {"The Cat is fat", "The Cat is fat", "The dog barked", "The Cat is FAT"}

        Dim UniqueTitles As New List(Of String)

        For Each title In titleList
            UniqueTitles.AddUnique(title)
        Next

        For Each title As String In UniqueTitles
            Console.WriteLine(title)
        Next
    End Sub
    ''' <summary>
    ''' Only add list items if not in list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddUniqueItemFromListButton_Click(sender As Object, e As EventArgs) _
        Handles AddUniqueItemFromListButton.Click

        Dim UniqueTitles As New List(Of String)
        Dim titleList As New List(Of String) From
                {"The Cat is fat", "The Cat is fat", "The dog barked", "The Cat is FAT"}

        UniqueTitles.AddUnique(titleList)
        For Each title As String In UniqueTitles
            Console.WriteLine(title)
        Next
    End Sub
    ''' <summary>
    ''' Case insensitive check if string in list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListContainsButton_Click(sender As Object, e As EventArgs) _
        Handles ListContainsButton.Click

        Dim titleList As New List(Of String) From
                {"The Cat is fat", "The Cat is fat", "The dog barked", "The Cat is FAT"}

        Dim title = "THE CAT IS FAT"


        If titleList.HasValue(title) Then
            MessageBox.Show($"found '{title}' in list")
        Else
            MessageBox.Show($"'{title}' Not in list")
        End If


    End Sub
End Class
Public Module CollectionExtensions
    <Runtime.CompilerServices.Extension>
    Public Sub AddUnique(self As List(Of String), item As String)
        If Not self.Contains(item, StringComparer.OrdinalIgnoreCase) Then
            self.Add(item)
        End If
    End Sub

    <Runtime.CompilerServices.Extension>
    Public Sub AddUnique(self As List(Of String), incoming As List(Of String))
        For Each item As String In incoming
            If Not self.Contains(item, StringComparer.OrdinalIgnoreCase) Then
                self.Add(item)
            End If
        Next
    End Sub
    <Runtime.CompilerServices.Extension>
    Public Function HasValue(self As List(Of String), item As String) As Boolean
        Return self.Any(Function(value) value.Equals(item, StringComparison.OrdinalIgnoreCase))
    End Function
End Module
