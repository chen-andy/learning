

Public Class Publisher

    Public Function GetAuthorsByState(ByVal state As String) As List(Of Author)

        Dim authors As New List(Of Author)

        If (state = "wa") Then
            authors.Add(New Author("Adam", "Smith"))
            authors.Add(New Author("Bob", "Jones"))
            authors.Add(New Author("Fred", "Baker"))
        End If

        Return authors

    End Function
End Class
