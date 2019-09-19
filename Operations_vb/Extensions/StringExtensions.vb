Namespace Extensions
    Public Module StringExtensions
        ''' <summary>
        ''' Perform case insensitive equal on two strings
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="item"></param>
        ''' <returns>true if both strings are a match, false if not a match</returns>
        <Runtime.CompilerServices.Extension>
        Public Function AreEqual(ByVal sender As String, ByVal item As String) As Boolean
            Return String.Equals(sender, item, StringComparison.OrdinalIgnoreCase)
        End Function
        ''' <summary>
        ''' Determines if a string is within another string with Comparison options
        ''' </summary>
        ''' <param name="source"></param>
        ''' <param name="compareToken">string to see if it exists in source string</param>
        ''' <param name="comparer">StringComparison</param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function Contains(ByVal source As String, ByVal compareToken As String, Optional ByVal comparer As StringComparison = StringComparison.OrdinalIgnoreCase) As Boolean
            Return source?.IndexOf(compareToken, comparer) >= 0
        End Function
    End Module
End Namespace
