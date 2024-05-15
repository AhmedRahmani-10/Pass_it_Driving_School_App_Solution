
Imports Newtonsoft.Json ' Import Newtonsoft.Json for JSON parsing
Imports System.IO

Public Class BookLessons
    Private Sub TCloseBtn_Icon_Click(sender As Object, e As EventArgs)
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

    Private Sub B_RefreshBtn_Click(sender As Object, e As EventArgs)
        Refresh()
    End Sub

    Private Sub BMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles BMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub


    ' Booking ID check and validation code here


    Private Sub BForm_TBox_BookID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BForm_TBox_BookID.KeyPress
        ' Make the error message label visible
        BForm_ErrMsg_BookID.Visible = True

        If String.IsNullOrEmpty(BForm_TBox_BookID.Text & e.KeyChar) Then
            ' If empty, hide the checkmark
            BForm_ChkMark_BookID.Visible = False
        Else
            ' Check if the key pressed is a digit, backspace, or delete
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                ' If the key is not a digit and not a control key (like backspace or delete), then it's an invalid input
                ' Set the error message in red color
                BForm_ErrMsg_BookID.ForeColor = Color.Red
                BForm_ErrMsg_BookID.Text = "Invalid input. Please enter only numbers between 100 and 999."
                e.Handled = True ' Prevent the input from being entered into the text box
                BForm_ChkMark_BookID.Visible = False
            Else
                ' If the key is a digit, backspace, or delete, check the validity of the input
                Dim input As Integer
                If Integer.TryParse(BForm_TBox_BookID.Text & e.KeyChar, input) OrElse e.KeyChar = ChrW(Keys.Back) Then
                    ' If the input can be parsed as an integer or it's a backspace, continue validation
                    If input >= 100 AndAlso input <= 999 OrElse e.KeyChar = ChrW(Keys.Back) Then
                        ' If the input is within the range or it's a backspace, hide the error message
                        BForm_ErrMsg_BookID.Visible = False
                        ' If the input is within the range, set the check mark visibility to true
                        BForm_ChkMark_BookID.Visible = input >= 100 AndAlso input <= 999
                    Else
                        ' If the input is not within the range and it's not a backspace, show error message and hide check mark
                        BForm_ErrMsg_BookID.ForeColor = Color.Red
                        BForm_ErrMsg_BookID.Text = "Input must be between 100 and 999."
                        BForm_ChkMark_BookID.Visible = False
                    End If
                Else
                    ' If the input cannot be parsed as an integer and it's not a backspace, show error message and hide check mark
                    BForm_ErrMsg_BookID.ForeColor = Color.Red
                    BForm_ErrMsg_BookID.Text = "Invalid input. Please enter only numbers."
                    BForm_ChkMark_BookID.Visible = False
                End If
            End If
        End If


    End Sub


    ' Booking ID check and validation code END


    ' Load Trainer data from trainers.json in the booklesson dropdowns

    ' check LID text box valid or not


    Private Sub BForm_TxtBox_LID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BForm_TxtBox_LID.KeyPress
        ' Make the error message label visible
        BForm_ErrMsg_LID.Visible = True

        If String.IsNullOrEmpty(BForm_TxtBox_LID.Text & e.KeyChar) Then
            ' If empty, hide the checkmark
            BForm_ChkMark_LID.Visible = False
        Else
            ' Check if the key pressed is a digit, backspace, or delete
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                ' If the key is not a digit and not a control key (like backspace or delete), then it's an invalid input
                ' Set the error message in red color
                BForm_ErrMsg_LID.ForeColor = Color.Red
                BForm_ErrMsg_LID.Text = "Invalid input. Please enter only numbers between 100 and 999."
                e.Handled = True ' Prevent the input from being entered into the text box
                BForm_ChkMark_LID.Visible = False
            Else
                ' If the key is a digit, backspace, or delete, check the validity of the input
                Dim input As Integer
                If Integer.TryParse(BForm_TxtBox_LID.Text & e.KeyChar, input) OrElse e.KeyChar = ChrW(Keys.Back) Then
                    ' If the input can be parsed as an integer or it's a backspace, continue validation
                    If input >= 100 AndAlso input <= 999 OrElse e.KeyChar = ChrW(Keys.Back) Then
                        ' If the input is within the range or it's a backspace, hide the error message
                        BForm_ErrMsg_LID.Visible = False
                        ' If the input is within the range, set the check mark visibility to true
                        BForm_ChkMark_LID.Visible = input >= 100 AndAlso input <= 999
                    Else
                        ' If the input is not within the range and it's not a backspace, show error message and hide check mark
                        BForm_ErrMsg_LID.ForeColor = Color.Red
                        BForm_ErrMsg_LID.Text = "Input must be between 100 and 999."
                        BForm_ChkMark_LID.Visible = False
                    End If
                Else
                    ' If the input cannot be parsed as an integer and it's not a backspace, show error message and hide check mark
                    BForm_ErrMsg_LID.ForeColor = Color.Red
                    BForm_ErrMsg_LID.Text = "Invalid input. Please enter only numbers."
                    BForm_ChkMark_LID.Visible = False
                End If
            End If
        End If


    End Sub

    ' TID text box check validation



    Private Sub BForm_TxtBox_TID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BForm_TxtBox_TID.KeyPress
        ' Make the error message label visible
        BForm_ErrMsg_TID.Visible = True

        If String.IsNullOrEmpty(BForm_TxtBox_TID.Text & e.KeyChar) Then
            ' If empty, hide the checkmark
            BForm_ChkMark_TID.Visible = False
        Else
            ' Check if the key pressed is a digit, backspace, or delete
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                ' If the key is not a digit and not a control key (like backspace or delete), then it's an invalid input
                ' Set the error message in red color
                BForm_ErrMsg_TID.ForeColor = Color.Red
                BForm_ErrMsg_TID.Text = "Invalid input. Please enter only numbers between 100 and 999."
                e.Handled = True ' Prevent the input from being entered into the text box
                BForm_ChkMark_TID.Visible = False
            Else
                ' If the key is a digit, backspace, or delete, check the validity of the input
                Dim input As Integer
                If Integer.TryParse(BForm_TxtBox_TID.Text & e.KeyChar, input) OrElse e.KeyChar = ChrW(Keys.Back) Then
                    ' If the input can be parsed as an integer or it's a backspace, continue validation
                    If input >= 100 AndAlso input <= 999 OrElse e.KeyChar = ChrW(Keys.Back) Then
                        ' If the input is within the range or it's a backspace, hide the error message
                        BForm_ErrMsg_TID.Visible = False
                        ' If the input is within the range, set the check mark visibility to true
                        BForm_ChkMark_TID.Visible = input >= 100 AndAlso input <= 999
                    Else
                        ' If the input is not within the range and it's not a backspace, show error message and hide check mark
                        BForm_ErrMsg_TID.ForeColor = Color.Red
                        BForm_ErrMsg_TID.Text = "Input must be between 100 and 999."
                        BForm_ChkMark_TID.Visible = False
                    End If
                Else
                    ' If the input cannot be parsed as an integer and it's not a backspace, show error message and hide check mark
                    BForm_ErrMsg_TID.ForeColor = Color.Red
                    BForm_ErrMsg_TID.Text = "Invalid input. Please enter only numbers."
                    BForm_ChkMark_TID.Visible = False
                End If
            End If
        End If


    End Sub


    ' Total fee Calculation and text box change code

    Private Sub BForm_NumBox_NClasses_TextChanged(sender As Object, e As EventArgs) Handles BForm_NumBox_NClasses.TextChanged, BForm_NumBox_Tariff.TextChanged
        ' Calculate total fee based on the values in BForm_NumBox_NClasses and BForm_NumBox_Tariff
        Dim numClasses As Integer
        Dim tariff As Decimal

        ' Attempt to parse the text in BForm_NumBox_NClasses as an integer
        If Integer.TryParse(BForm_NumBox_NClasses.Text, numClasses) AndAlso Decimal.TryParse(BForm_NumBox_Tariff.Text, tariff) Then
            ' Calculate the total fee
            Dim totalFee As Decimal = numClasses * tariff

            ' Update the text of BForm_TBox_TotalFee
            BForm_TBox_TotalFee.Text = totalFee.ToString()
        Else
            ' Handle cases where the input cannot be parsed as numeric
            BForm_TBox_TotalFee.Text = "Invalid input"
        End If
    End Sub


    Private Sub BForm_Btn_Book_Click(sender As Object, e As EventArgs) Handles BForm_Btn_Book.Click
        ' Check if BookID is empty
        If String.IsNullOrEmpty(BForm_TBox_BookID.Text.Trim()) Then
            BForm_ErrMsg_BookID.Visible = True
            MessageBox.Show("Please enter a value for BookID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            BForm_ErrMsg_BookID.Visible = False
        End If

        ' Check if LID is empty
        If String.IsNullOrEmpty(BForm_TxtBox_LID.Text.Trim()) Then
            BForm_ErrMsg_LID.Visible = True
            MessageBox.Show("Please enter a value for LID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            BForm_ErrMsg_LID.Visible = False
        End If

        ' Check if TID is empty
        If String.IsNullOrEmpty(BForm_TxtBox_TID.Text.Trim()) Then
            BForm_ErrMsg_TID.Visible = True
            MessageBox.Show("Please enter a value for TID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            BForm_ErrMsg_TID.Visible = False
        End If

        ' Create a new object to hold the data
        Dim bookingData As New With {
        .BookLesson_ID = BForm_TBox_BookID.Text,
        .BookLesson_LID = BForm_TxtBox_LID.Text,
        .BookLesson_TID = BForm_TxtBox_TID.Text,
        .BookLesson_NumClasses = BForm_NumBox_NClasses.Text,
        .BookLesson_Course = If(BForm_Radio1_Course.Checked, "Basic",
                              If(BForm_Radio2_Course.Checked, "Refresher",
                              If(BForm_Radio3_Course.Checked, "Pass Plus",
                              If(BForm_Radio4_Course.Checked, "Test Prep", "")))),
        .BookLesson_Tariff = BForm_NumBox_Tariff.Text,
        .BookLesson_TFee = BForm_TBox_TotalFee.Text,
        .BookLesson_BookDate = BForm_DatePick_BookDate.Value.ToString("yyyy-MM-dd")
        }

        ' Serialize the object to JSON
        Dim jsonBookingData As String = JsonConvert.SerializeObject(bookingData)

        ' Append the JSON data to the file
        Dim jsonFilePath As String = "book_lessons.json"
        Try
            Using writer As StreamWriter = File.AppendText(jsonFilePath)
                writer.WriteLine(jsonBookingData)
            End Using
            MessageBox.Show("Booking successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("An error occurred while writing data to the JSON file: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LoadBookingDataFromFile()

    End Sub

    Public Class Booking
        Public Property BookLesson_ID As String
        Public Property BookLesson_LID As String
        Public Property BookLesson_TID As String
        Public Property BookLesson_NumClasses As String
        Public Property BookLesson_Course As String
        Public Property BookLesson_Tariff As String
        Public Property BookLesson_TFee As String
        Public Property BookLesson_BookDate As String
    End Class


    Private Sub BookLessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load book lessons data from file
        LoadBookingDataFromFile()
    End Sub

    Private Sub LoadBookingDataFromFile()
        Try
            ' Check if the file exists
            If File.Exists("book_lessons.json") Then
                ' Read JSON data from the file
                Dim jsonLines As String() = File.ReadAllLines("book_lessons.json")

                ' Clear existing rows
                BookingDGV.Rows.Clear()

                ' Populate DataGridView with booking data
                For Each jsonLine As String In jsonLines
                    Dim bookingData = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(jsonLine)
                    Dim row As New List(Of String)

                    ' Add property values to the row
                    row.Add(bookingData("BookLesson_ID"))
                    row.Add(bookingData("BookLesson_LID"))
                    row.Add(bookingData("BookLesson_TID"))
                    row.Add(bookingData("BookLesson_NumClasses"))
                    row.Add(bookingData("BookLesson_Course"))
                    row.Add(bookingData("BookLesson_Tariff"))
                    row.Add(bookingData("BookLesson_TFee"))
                    row.Add(bookingData("BookLesson_BookDate"))

                    BookingDGV.Rows.Add(row.ToArray())
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data from file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BCloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles BCloseBtn_Icon.Click
        Me.Hide()
    End Sub
End Class
