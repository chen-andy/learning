Public Class Author

    Private _firstName As String
    Private _lastName As String

    Public Property Firstname() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Sub New(ByVal firstname As String, ByVal lastname As String)
        Me.Firstname = firstname
        Me.LastName = lastname
    End Sub

End Class
