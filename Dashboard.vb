Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DCloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles DCloseBtn_Icon.Click
        Hide()
    End Sub

    Private Sub DMenuIcon_Learners_Click(sender As Object, e As EventArgs) Handles DMenuIcon_Learners.Click
        NavigateToForm("Learners")
    End Sub

    Private Sub DMenuIcon_Trainers_Click(sender As Object, e As EventArgs) Handles DMenuIcon_Trainers.Click
        NavigateToForm("Trainers")
    End Sub

    Private Sub DMenuIcon_Courses_Click(sender As Object, e As EventArgs) Handles DMenuIcon_Courses.Click
        NavigateToForm("ManageCourses")
    End Sub

    Private Sub DMenuIcon_BookLessons_Click(sender As Object, e As EventArgs) Handles DMenuIcon_BookLessons.Click
        NavigateToForm("BookLessons")
    End Sub

    Private Sub NavigateToForm(formName As String)
        ' Hide the current form
        Me.Hide()

        ' Create an instance of the specified form
        Dim formInstance As New Form()

        ' Construct the form class name dynamically and create an instance
        formInstance = DirectCast(Activator.CreateInstance(Type.GetType(Me.GetType().Namespace & "." & formName)), Form)

        ' Display the specified form
        formInstance.Show()
    End Sub

    Private Sub DMiniBtn_Icon_Click(sender As Object, e As EventArgs) Handles DMiniBtn_Icon.Click
        ' Minimize the window
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles DMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class