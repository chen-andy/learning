Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If (Page.IsPostBack = False) Then
            Calendar1.SelectedDate = Now
            Label1.Text = "Pick a selected date"
        End If
    End Sub

    Private Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Label1.Text = "You selected: " & Calendar1.SelectedDate.ToShortDateString()
    End Sub

End Class