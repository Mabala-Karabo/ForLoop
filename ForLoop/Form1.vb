Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 1

        For i = 0 To 10 'for loop i starts from zero to 10
            MsgBox("This is a for loop where i  value = " & i)
        Next
    End Sub
End Class
