
Imports System.IO
Imports Newtonsoft.Json
Imports PassIT_DrivingSchool.Learners

Public Class Learners
    Private Sub CloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles LCloseBtn_Icon.Click
        Me.Hide()
    End Sub


    ' Menu Click Events =========================================================
    Private Sub LMenuIcon_Dashboard_Click(sender As Object, e As EventArgs) Handles LMenuIcon_Dashboard.Click
        NavigateToForm("Dashboard")
    End Sub

    Private Sub DMenuIcon_Trainers_Click(sender As Object, e As EventArgs) Handles LMenuIcon_Trainers.Click
        NavigateToForm("Trainers")
    End Sub

    Private Sub DMenuIcon_Courses_Click(sender As Object, e As EventArgs) Handles LMenuIcon_Courses.Click
        NavigateToForm("ManageCourses")
    End Sub

    Private Sub DMenuIcon_BookLessons_Click(sender As Object, e As EventArgs) Handles LMenuIcon_BookLessons.Click
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

    ' Menu Click Events End ==========================================================


    ' Form validation
    ' Form Validation Learners ID check

    Private Sub LForm_TBox_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LForm_TBox_ID.KeyPress
        ' Make the error message label visible
        LForm_ErrMsg_ID.Visible = True

        If String.IsNullOrEmpty(LForm_TBox_ID.Text & e.KeyChar) Then
            ' If empty, hide the checkmark
            LForm_ChkMark_ID.Visible = False
        Else
            ' Check if the key pressed is a digit, backspace, or delete
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                ' If the key is not a digit and not a control key (like backspace or delete), then it's an invalid input
                ' Set the error message in red color
                LForm_ErrMsg_ID.ForeColor = Color.Red
                LForm_ErrMsg_ID.Text = "Invalid input. Please enter only numbers between 100 and 999."
                e.Handled = True ' Prevent the input from being entered into the text box
                LForm_ChkMark_ID.Visible = False
            Else
                ' If the key is a digit, backspace, or delete, check the validity of the input
                Dim input As Integer
                If Integer.TryParse(LForm_TBox_ID.Text & e.KeyChar, input) OrElse e.KeyChar = ChrW(Keys.Back) Then
                    ' If the input can be parsed as an integer or it's a backspace, continue validation
                    If input >= 100 AndAlso input <= 999 OrElse e.KeyChar = ChrW(Keys.Back) Then
                        ' If the input is within the range or it's a backspace, hide the error message
                        LForm_ErrMsg_ID.Visible = False
                        ' If the input is within the range, set the check mark visibility to true
                        LForm_ChkMark_ID.Visible = input >= 100 AndAlso input <= 999
                    Else
                        ' If the input is not within the range and it's not a backspace, show error message and hide check mark
                        LForm_ErrMsg_ID.ForeColor = Color.Red
                        LForm_ErrMsg_ID.Text = "Input must be between 100 and 999."
                        LForm_ChkMark_ID.Visible = False
                    End If
                Else
                    ' If the input cannot be parsed as an integer and it's not a backspace, show error message and hide check mark
                    LForm_ErrMsg_ID.ForeColor = Color.Red
                    LForm_ErrMsg_ID.Text = "Invalid input. Please enter only numbers."
                    LForm_ChkMark_ID.Visible = False
                End If
            End If
        End If


    End Sub

    ' Form Validation Learners ID check End


    ' Form Validation First Name TextBox check

    Private Sub LForm_TBox_Fname_TextChanged(sender As Object, e As EventArgs) Handles LForm_TBox_Fname.TextChanged
        If String.IsNullOrWhiteSpace(LForm_TBox_Fname.Text) Then
            ' If the text box is empty or contains only white spaces, hide the check mark
            LForm_ChkMark_Fname.Visible = False
            ' Hide the error message
            LForm_ErrMsg_Fname.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(LForm_TBox_Fname.Text, "^[a-zA-Z]*$") AndAlso LForm_TBox_Fname.Text.Length <= 18 Then
            ' If the text contains only alphabets and is within 18 characters, show the check mark and hide the error message
            LForm_ChkMark_Fname.Visible = True
            LForm_ErrMsg_Fname.Visible = False
        ElseIf LForm_TBox_Fname.Text.Length > 18 Then
            ' If the length of text is greater than 18, show an error message and hide the check mark
            LForm_ErrMsg_Fname.ForeColor = Color.Red
            LForm_ErrMsg_Fname.Text = "Maximum length is 18 characters"
            LForm_ErrMsg_Fname.Visible = True
            LForm_ChkMark_Fname.Visible = False
        Else
            ' If the text contains other characters than alphabets, show an error message and hide the check mark
            LForm_ErrMsg_Fname.ForeColor = Color.Red
            LForm_ErrMsg_Fname.Text = "Please enter First name"
            LForm_ErrMsg_Fname.Visible = True
            LForm_ChkMark_Fname.Visible = False
        End If
    End Sub

    Private Sub LForm_TBox_Fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LForm_TBox_Fname.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a letter, show an error message and prevent it from being entered into the text box
            LForm_ErrMsg_Fname.ForeColor = Color.Red
            LForm_ErrMsg_Fname.Text = "Only alphabet characters are allowed"
            LForm_ErrMsg_Fname.Visible = True
            e.Handled = True
        Else
            ' If it's a letter or a control character, hide the error message
            LForm_ErrMsg_Fname.Visible = False
        End If
    End Sub

    ' Form Validation First Name TextBox check End

    ' Form Validation Last Name TextBox check 

    Private Sub LForm_TBox_Lname_TextChanged(sender As Object, e As EventArgs) Handles LForm_TBox_Lname.TextChanged
        If String.IsNullOrWhiteSpace(LForm_TBox_Lname.Text) Then
            ' If the text box is empty or contains only white spaces, hide the check mark
            LForm_ChkMark_Lname.Visible = False
            ' Hide the error message
            LForm_ErrMsg_Lname.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(LForm_TBox_Lname.Text, "^[a-zA-Z]*$") AndAlso LForm_TBox_Lname.Text.Length <= 18 Then
            ' If the text contains only alphabets and is within 18 characters, show the check mark and hide the error message
            LForm_ChkMark_Lname.Visible = True
            LForm_ErrMsg_Lname.Visible = False
        ElseIf LForm_TBox_Lname.Text.Length > 18 Then
            ' If the length of text is greater than 18, show an error message and hide the check mark
            LForm_ErrMsg_Lname.ForeColor = Color.Red
            LForm_ErrMsg_Lname.Text = "Maximum length is 18 characters"
            LForm_ErrMsg_Lname.Visible = True
            LForm_ChkMark_Lname.Visible = False
        Else
            ' If the text contains other characters than alphabets, show an error message and hide the check mark
            LForm_ErrMsg_Lname.ForeColor = Color.Red
            LForm_ErrMsg_Lname.Text = "Please enter Last name"
            LForm_ErrMsg_Lname.Visible = True
            LForm_ChkMark_Lname.Visible = False
        End If
    End Sub

    Private Sub LForm_TBox_Lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LForm_TBox_Lname.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a letter, show an error message and prevent it from being entered into the text box
            LForm_ErrMsg_Lname.ForeColor = Color.Red
            LForm_ErrMsg_Lname.Text = "Only alphabet characters are allowed"
            LForm_ErrMsg_Lname.Visible = True
            e.Handled = True
        Else
            ' If it's a letter or a control character, hide the error message
            LForm_ErrMsg_Lname.Visible = False
        End If
    End Sub

    ' Form Validation for Last Name TextBox check End

    ' Form Validation for Email check

    Private Sub LForm_TBox_Email_TextChanged(sender As Object, e As EventArgs) Handles LForm_TBox_Email.TextChanged
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        If String.IsNullOrWhiteSpace(LForm_TBox_Email.Text) Then
            ' If the text box is empty or contains only white spaces, hide the validation check mark
            LForm_ChkMark_Email.Visible = False
            ' Hide the error message
            LForm_ErrMsg_Email.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(LForm_TBox_Email.Text, emailPattern) Then
            ' If the entered email matches the email pattern, show the validation check mark and hide the error message
            LForm_ChkMark_Email.Visible = True
            LForm_ErrMsg_Email.Visible = False
        Else
            ' If the entered email does not match the email pattern, show an error message and hide the validation check mark
            LForm_ErrMsg_Email.ForeColor = Color.Red
            LForm_ErrMsg_Email.Text = "Please enter a valid email address"
            LForm_ErrMsg_Email.Visible = True
            LForm_ChkMark_Email.Visible = False
        End If
    End Sub

    ' Form Validation for Email check End

    ' Form Validation for Phone number check 

    Private Sub LForm_TBox_Phone_TextChanged(sender As Object, e As EventArgs) Handles LForm_TBox_Phone.TextChanged
        Dim phoneNumberPattern As String = "^0\d{10}$|^[1-9]\d{9}$"

        If String.IsNullOrWhiteSpace(LForm_TBox_Phone.Text) Then
            ' If the text box is empty or contains only white spaces, hide the validation check mark
            LForm_ChkMark_Phone.Visible = False
            ' Hide the error message
            LForm_ErrMsg_Phone.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(LForm_TBox_Phone.Text, phoneNumberPattern) Then
            ' If the entered phone number matches the phone number pattern, show the validation check mark and hide the error message
            LForm_ChkMark_Phone.Visible = True
            LForm_ErrMsg_Phone.Visible = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(LForm_TBox_Phone.Text, "^\d+$") Then
            ' If the entered phone number contains non-numeric characters, show an error message and hide the validation check mark
            LForm_ErrMsg_Phone.ForeColor = Color.Red
            LForm_ErrMsg_Phone.Text = "Phone number must contain only numbers"
            LForm_ErrMsg_Phone.Visible = True
            LForm_ChkMark_Phone.Visible = False
        ElseIf LForm_TBox_Phone.Text.Length > 11 Then
            ' If the entered phone number length is greater than 11, show an error message and hide the validation check mark
            LForm_ErrMsg_Phone.ForeColor = Color.Red
            LForm_ErrMsg_Phone.Text = "Phone number must not exceed 11 digits"
            LForm_ErrMsg_Phone.Visible = True
            LForm_ChkMark_Phone.Visible = False
        ElseIf LForm_TBox_Phone.Text.Length > 10 AndAlso Not LForm_TBox_Phone.Text.StartsWith("0") Then
            ' If the entered phone number length is greater than 10 and doesn't start with 0, show an error message and hide the validation check mark
            LForm_ErrMsg_Phone.ForeColor = Color.Red
            LForm_ErrMsg_Phone.Text = "Phone number must not exceed 10 digits"
            LForm_ErrMsg_Phone.Visible = True
            LForm_ChkMark_Phone.Visible = False
        End If
    End Sub

    Private Sub LForm_TBox_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LForm_TBox_Phone.KeyPress
        ' Allow backspace key
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Check if the entered character is not a digit or if the length is already 11 and the number starts with 0,
        ' or if the length is already 10 and the number starts with any other number
        If Not Char.IsDigit(e.KeyChar) OrElse
       (LForm_TBox_Phone.Text.Length = 11 AndAlso LForm_TBox_Phone.Text.StartsWith("0")) OrElse
       (LForm_TBox_Phone.Text.Length = 10 AndAlso Not LForm_TBox_Phone.Text.StartsWith("0")) Then
            ' If any of the conditions are met, prevent the character from being entered into the text box
            e.Handled = True
        End If

        ' Hide the error message when a valid character is entered
        LForm_ErrMsg_Phone.Visible = False
    End Sub


    ' Form Validation for Phone number check End

    ' Form Validation for Add button click event

    Public Class Learner
        Public Property ID As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property DOB As Date
        Public Property Gender As String
        Public Property Email As String
        Public Property Phone As String
        Public Property Course As String
    End Class


    ' List to store learner data
    Private learners As New List(Of Learner)

    Private Sub Learners_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load learner data from file
        PopulateCourseComboBox()
        LoadLearnerDataFromFile()
    End Sub

    Private Sub LForm_Btn_Add_Click(sender As Object, e As EventArgs) Handles LForm_Btn_Add.Click
        Dim errorMessages As New List(Of String)

        ' Check if Enrollment ID is empty
        If String.IsNullOrWhiteSpace(LForm_TBox_ID.Text) Then
            errorMessages.Add("Enrollment ID is required")
            LForm_ErrMsg_ID.Visible = True
        Else
            LForm_ErrMsg_ID.Visible = False
        End If

        ' Check if First name is empty
        If String.IsNullOrWhiteSpace(LForm_TBox_Fname.Text) Then
            errorMessages.Add("First name is required")
            LForm_ErrMsg_Fname.Visible = True
        Else
            LForm_ErrMsg_Fname.Visible = False
        End If

        ' Check if Last name is empty
        If String.IsNullOrWhiteSpace(LForm_TBox_Lname.Text) Then
            errorMessages.Add("Last name is required")
            LForm_ErrMsg_Lname.Visible = True
        Else
            LForm_ErrMsg_Lname.Visible = False
        End If

        ' Check if Email ID is empty
        If String.IsNullOrWhiteSpace(LForm_TBox_Email.Text) Then
            errorMessages.Add("Email ID is required")
            LForm_ErrMsg_Email.Visible = True
        Else
            LForm_ErrMsg_Email.Visible = False
        End If

        ' Check if Phone number is empty
        If String.IsNullOrWhiteSpace(LForm_TBox_Phone.Text) Then
            errorMessages.Add("Phone number is required")
            LForm_ErrMsg_Phone.Visible = True
        Else
            LForm_ErrMsg_Phone.Visible = False
        End If

        ' Check if Date of Birth is empty
        If Lform_DateBox_DOB.Value = DateTime.MinValue Then
            errorMessages.Add("Date of Birth is required")
            LForm_ErrMsg_DOB.Visible = True
        Else
            LForm_ErrMsg_DOB.Visible = False
        End If

        ' Check if Course selection is empty
        If LForm_CBox_Course.SelectedIndex = -1 Then
            errorMessages.Add("Course selection is required")
            LForm_ErrMsg_Course.Visible = True
        Else
            LForm_ErrMsg_Course.Visible = False
        End If

        ' If there are any error messages, display them in a message box
        If errorMessages.Any() Then
            MessageBox.Show(String.Join(Environment.NewLine, errorMessages), "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' All mandatory fields are filled, proceed with adding the data

            ' Create a Learner object and populate it with form data
            Dim learnerData As New Learner()
            learnerData.ID = LForm_TBox_ID.Text
            learnerData.FirstName = LForm_TBox_Fname.Text
            learnerData.LastName = LForm_TBox_Lname.Text
            learnerData.DOB = Lform_DateBox_DOB.Value
            learnerData.Email = LForm_TBox_Email.Text
            learnerData.Phone = LForm_TBox_Phone.Text
            learnerData.Course = LForm_CBox_Course.SelectedItem.ToString()

            ' Check if Gender is empty
            If Not String.IsNullOrWhiteSpace(LForm_CBox_Gender.SelectedItem?.ToString()) Then
                learnerData.Gender = LForm_CBox_Gender.SelectedItem.ToString()
            End If

            ' Add data to list
            learners.Add(learnerData)

            ' Add data to DataGridView
            LearnersDGV.Rows.Add(learnerData.ID, learnerData.FirstName, learnerData.LastName, learnerData.DOB, learnerData.Gender, learnerData.Email, learnerData.Phone, learnerData.Course)

            ' Save learner data to file
            SaveLearnerDataToFile()

            MessageBox.Show("New Enrollment Added Successfully")
        End If
    End Sub

    ' Save learner data to file
    Private Sub SaveLearnerDataToFile()
        Try
            ' Serialize learner data to JSON
            Dim json As String = JsonConvert.SerializeObject(learners)

            ' Write JSON data to a text file
            File.WriteAllText("learners.json", json)
        Catch ex As Exception
            MessageBox.Show("Error saving data to file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Load learner data from file
    Private Sub LoadLearnerDataFromFile()
        Try
            ' Check if the file exists
            If File.Exists("learners.json") Then
                ' Read JSON data from the file
                Dim json As String = File.ReadAllText("learners.json")

                ' Deserialize JSON data to a list of learners
                learners = JsonConvert.DeserializeObject(Of List(Of Learner))(json)

                ' Populate DataGridView with learner data
                For Each learnerData In learners
                    LearnersDGV.Rows.Add(learnerData.ID, learnerData.FirstName, learnerData.LastName, learnerData.DOB, learnerData.Gender, learnerData.Email, learnerData.Phone, learnerData.Course)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Form Validation for Add button click event End

    ' Add array of items in combo box
    Private Sub PopulateCourseComboBox()
        Dim courseNames As New List(Of String)

        ' Read data from JSON file
        Dim jsonFilePath As String = "mg_courses.json"

        Try
            If File.Exists(jsonFilePath) Then
                ' Read all lines from JSON file
                Dim lines As String() = File.ReadAllLines(jsonFilePath)

                ' Extract course names from JSON data
                For Each line As String In lines
                    Dim jsonData As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(line)
                    courseNames.Add(jsonData("M_Courses_Cname").ToString())
                Next
            End If

            ' Add course names to LForm_CBox_Course ComboBox
            LForm_CBox_Course.Items.AddRange(courseNames.ToArray())
        Catch ex As Exception
            MessageBox.Show("Error occurred while reading data from JSON file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Add items in combobox end

    Private Sub LMini_Btn_Click(sender As Object, e As EventArgs) Handles LMini_Btn.Click
        ' Minimize the window
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub L_ReBtn_Click(sender As Object, e As EventArgs) Handles L_ReBtn.Click

        ' Clear text boxes
        LForm_TBox_ID.Text = ""
        LForm_TBox_Fname.Text = ""
        LForm_TBox_Lname.Text = ""
        LForm_TBox_Email.Text = ""
        LForm_TBox_Phone.Text = ""


        ' Clear combo boxes
        LForm_CBox_Course.SelectedIndex = -1
        LForm_CBox_Gender.SelectedIndex = -1

        ' Refresh the form
        Me.Refresh()

    End Sub



    Private Sub LMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles LMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class