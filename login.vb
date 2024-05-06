Public Class login
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Private Sub LoginForm_Btn_Click(sender As Object, e As EventArgs) Handles LoginForm_Btn.Click
        Dim username As String = LoginForm_User_Text.Text
        Dim password As String = LoginForm_Pass_Text.Text

        ' Validate username and password (you might want to do more secure validation in a real application)
        If ValidateLogin(username, password) Then
            ' If login is successful, navigate to dashboard
            Me.Hide()
            Dim dashboardForm As New Dashboard()
            dashboardForm.Show()
        Else
            ' If login fails, show error message
            LoginForm_errMsg_Text.Visible = True
        End If
    End Sub

    Private Function ValidateLogin(username As String, password As String) As Boolean
        ' You would typically query your database here to validate the login
        ' For demonstration purposes, let's assume a hardcoded username and password
        Dim validUsername As String = "Ahmed"
        Dim validPassword As String = "Rahmani123"

        ' Check if the provided username and password match the valid credentials
        If username = validUsername AndAlso password = validPassword Then
            Return True
        Else
            Return False
        End If
    End Function

End Class