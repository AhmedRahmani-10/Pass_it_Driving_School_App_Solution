Public Class BookLessons
    Private Sub TCloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles BCloseBtn_Icon.Click
        Hide()
    End Sub

    Private Sub BMenuIcon_Dashboard_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Dashboard.Click
        NavigateToForm("Dashboard")
    End Sub

    Private Sub BMenuIcon_Learners_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Learners.Click
        NavigateToForm("Learners")
    End Sub

    Private Sub BMenuIcon_Trainers_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Trainers.Click
        NavigateToForm("Trainers")
    End Sub

    Private Sub BMenuIcon_Courses_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Courses.Click
        NavigateToForm("ManageCourses")
    End Sub

    Private Sub NavigateToForm(formName As String)
        ' Hide the current form
        Me.Hide()

        ' Create an instance of the specified form
        Dim formInstance As New Form()

        ' Assuming the forms are in the same namespace and have the same naming convention
        ' Construct the form class name dynamically and create an instance
        formInstance = DirectCast(Activator.CreateInstance(Type.GetType(Me.GetType().Namespace & "." & formName)), Form)

        ' Display the specified form
        formInstance.Show()
    End Sub

    Private Sub B_Mini_Btn_Icon_Click(sender As Object, e As EventArgs) Handles B_Mini_Btn_Icon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub B_RefreshBtn_Click(sender As Object, e As EventArgs) Handles B_RefreshBtn.Click
        Me.Refresh()
    End Sub

    Private Sub BMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class