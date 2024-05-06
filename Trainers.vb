
Imports System.IO
Imports Newtonsoft.Json

Public Class Trainers
    Private Sub TCloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles TCloseBtn_Icon.Click
        Hide()
    End Sub

    Private Sub TMenuIcon_Dashboard_Click(sender As Object, e As EventArgs) Handles TMenuIcon_Dashboard.Click
        NavigateToForm("Dashboard")
    End Sub

    Private Sub TMenuIcon_Learners_Click(sender As Object, e As EventArgs) Handles TMenuIcon_Learners.Click
        NavigateToForm("Learners")
    End Sub

    Private Sub TMenuIcon_Courses_Click(sender As Object, e As EventArgs) Handles TMenuIcon_Courses.Click
        NavigateToForm("ManageCourses")
    End Sub

    Private Sub TMenuIcon_BookLessons_Click(sender As Object, e As EventArgs) Handles TMenuIcon_BookLessons.Click
        NavigateToForm("BookLessons")
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

    Private Sub TMini_Btn_Icon_Click(sender As Object, e As EventArgs) Handles TMini_Btn_Icon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' form validation and submission

    Public Class Trainer
        Public Property ID As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Gender As String
        Public Property Email As String
        Public Property Phone As String
        Public Property DOB As Date
        Public Property Tariff As Decimal
        Public Property Teaches As List(Of String)
    End Class

    Private Sub TForm_Btn_Add_Click(sender As Object, e As EventArgs) Handles TForm_Btn_Add.Click
        ' Validate form data
        If ValidateFormData() Then
            ' Create Trainer object
            Dim trainer As New Dictionary(Of String, Object)()
            trainer("ID") = TForm_TBox_ID.Text
            trainer("FirstName") = TForm_TBox_Fname.Text
            trainer("LastName") = TForm_TBox_Lname.Text
            trainer("Gender") = If(TForm_CBox_Gender.SelectedItem IsNot Nothing, TForm_CBox_Gender.SelectedItem.ToString(), "")
            trainer("Email") = TForm_TBox_Email.Text
            trainer("Phone") = TForm_TBox_Phone.Text
            trainer("DOB") = TForm_DateBox_DOB.Value
            trainer("Tariff") = If(IsNumeric(TForm_NumBox_Tariff.Text), Convert.ToDecimal(TForm_NumBox_Tariff.Text), 0)

            ' List to store teaches
            Dim teaches As New List(Of String)()
            If TForm_ChkBox1_Teaches.Checked Then teaches.Add(TForm_ChkBox1_Teaches.Text)
            If TForm_ChkBox2_Teaches.Checked Then teaches.Add(TForm_ChkBox2_Teaches.Text)
            If TForm_ChkBox3_Teaches.Checked Then teaches.Add(TForm_ChkBox3_Teaches.Text)
            If TForm_ChkBox4_Teaches.Checked Then teaches.Add(TForm_ChkBox4_Teaches.Text)
            trainer("Teaches") = teaches

            ' Serialize Trainer object to JSON
            Dim json As String = JsonConvert.SerializeObject(trainer)

            ' Append JSON to trainers.json file
            Using writer As New StreamWriter("trainers.json", True)
                writer.WriteLine(json)
            End Using

            ' Clear form fields
            ClearFormFields()

            ' Reload data into DataGridView
            ' LoadDataIntoDataGridView()
            MessageBox.Show("Successfully Data Added")

        End If
    End Sub

    Private Function ValidateFormData() As Boolean
        ' Validate form data
        If TForm_TBox_ID.Text = "" Then
            TForm_ErrMsg_ID.Visible = True
            Return False
        Else
            TForm_ErrMsg_ID.Visible = False
        End If

        If TForm_TBox_Fname.Text = "" Then
            TForm_ErrMsg_Fname.Visible = True
            Return False
        Else
            TForm_ErrMsg_Fname.Visible = False
        End If

        If TForm_TBox_Lname.Text = "" Then
            TForm_ErrMsg_Lname.Visible = True
            Return False
        Else
            TForm_ErrMsg_Lname.Visible = False
        End If

        If TForm_TBox_Email.Text = "" Then
            TForm_ErrMsg_Email.Visible = True
            Return False
        Else
            TForm_ErrMsg_Email.Visible = False
        End If

        If TForm_TBox_Phone.Text = "" Then
            TForm_ErrMsg_Phone.Visible = True
            Return False
        Else
            TForm_ErrMsg_Phone.Visible = False
        End If

        ' You can add more validation logic here if needed

        Return True
    End Function

    Private Sub ClearFormFields()
        ' Clear form fields
        ' Clear all textboxes, checkboxes, etc.
        TForm_TBox_ID.Text = ""
        TForm_TBox_Fname.Text = ""
        TForm_TBox_Lname.Text = ""
        TForm_TBox_Email.Text = ""
        TForm_TBox_Phone.Text = ""

    End Sub



    Private Sub TMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles TMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub





    ' form validation and submission END
End Class