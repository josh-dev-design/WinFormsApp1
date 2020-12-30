Public Class Form1
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TXTBusername.Text = "admin" Then
            If TXTBpassword.Text = "admin" Then
            End If
            MessageBox.Show("Hello, Admin", "Login Sucessfully")
        Else
            MessageBox.Show("Username and Password is incorrect. Try Again!")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
