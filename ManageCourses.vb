Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class ManageCourses
    Private Sub MCCloseBtn_Icon_Click(sender As Object, e As EventArgs) Handles MCCloseBtn_Icon.Click
        Me.Hide()
    End Sub

    ' Menu Icon Click Events
    Private Sub CMenuIcon_Dashboard_Click(sender As Object, e As EventArgs) Handles MCMenuIcon_Dashboard.Click
        NavigateToForm("Dashboard")
    End Sub

    Private Sub CMenuIcon_Learners_Click(sender As Object, e As EventArgs) Handles MCMenuIcon_Learners.Click
        NavigateToForm("Learners")
    End Sub

    Private Sub CMenuIcon_Trainers_Click(sender As Object, e As EventArgs) Handles MCMenuIcon_Trainers.Click
        NavigateToForm("Trainers")
    End Sub

    Private Sub CMenuIcon_BookLessons_Click(sender As Object, e As EventArgs) Handles MCMenuIcon_BookLessons.Click
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

    ' Menu Icon Click Events END

    ' Course ID Validation here

    Private Sub MCForm_TBox_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MCForm_TBox_ID.KeyPress
        ' Allowing only numbers, Backspace, and Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Delete) Then
            e.Handled = True
            MCForm_ErrMsg_ID.Visible = True ' Show error message when non-digit character is entered
        Else
            MCForm_ErrMsg_ID.Visible = False ' Hide error message when digit character is entered
        End If
    End Sub

    Private Sub MCForm_TBox_ID_TextChanged(sender As Object, e As EventArgs) Handles MCForm_TBox_ID.TextChanged
        ' Check if the textbox is not empty
        If MCForm_TBox_ID.Text <> "" Then
            ' Regular expression to allow only numbers
            Dim regex As New Regex("^[0-9]+$")

            ' Check if the input matches the pattern
            If regex.IsMatch(MCForm_TBox_ID.Text) Then
                ' If it's a valid input, hide error message and show checkmark
                MCForm_ErrMsg_ID.Visible = False
                MCForm_ChkMark_ID.Visible = True
            Else
                ' If it's not valid, show error message and hide checkmark
                MCForm_ErrMsg_ID.Visible = True
                MCForm_ChkMark_ID.Visible = False
            End If
        Else
            ' If textbox is empty, hide error message
            MCForm_ErrMsg_ID.Visible = False
            MCForm_ChkMark_ID.Visible = False
            ' Checkmark visibility should depend on whether the textbox has valid input, so leave it unchanged
        End If
    End Sub


    ' Course ID Validation END here


    ' Course Name Validation here

    Private Sub MCForm_TBox_CName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MCForm_TBox_CName.KeyPress
        ' Allowing only alphabets, space, backspace, hyphen, underscore
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = " "c AndAlso Not e.KeyChar = "-"c AndAlso Not e.KeyChar = "_"c AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Delete) Then
            e.Handled = True
            MCForm_ErrMsg_CName.Visible = True ' Show error message when invalid character is entered
        Else
            MCForm_ErrMsg_CName.Visible = False ' Hide error message when valid character is entered
        End If
    End Sub

    Private Sub MCForm_TBox_CName_TextChanged(sender As Object, e As EventArgs) Handles MCForm_TBox_CName.TextChanged
        ' Check if the textbox is not empty
        If MCForm_TBox_CName.Text <> "" Then
            ' Regular expression to allow only alphabets, space, hyphen, and underscore
            Dim regex As New Regex("^[A-Za-z -_]+$")

            ' Check if the input matches the pattern
            If regex.IsMatch(MCForm_TBox_CName.Text) Then
                ' If it's a valid input, hide error message and show checkmark
                MCForm_ErrMsg_CName.Visible = False
                MCForm_ChkMark_CName.Visible = True
            Else
                ' If it's not valid, show error message and hide checkmark
                MCForm_ErrMsg_CName.Visible = True
                MCForm_ChkMark_CName.Visible = False
            End If
        Else
            ' If textbox is empty, hide error message
            MCForm_ErrMsg_CName.Visible = False
            MCForm_ChkMark_CName.Visible = False
            ' Checkmark visibility should depend on whether the textbox has valid input, so leave it unchanged
        End If
    End Sub


    ' Course Name Validation END here

    ' Add Button Click Event Check

    Private Sub MCForm_Btn_Add_Click(sender As Object, e As EventArgs) Handles MCForm_Btn_Add.Click
        Dim errorMessage As String = ""

        ' Check if Course ID is empty
        If MCForm_TBox_ID.Text.Trim() = "" Then
            errorMessage &= "Course ID can not be empty." & vbCrLf
        End If

        ' Check if Course Name is empty
        If MCForm_TBox_CName.Text.Trim() = "" Then
            errorMessage &= "Course Name can not be empty." & vbCrLf
        End If

        ' If there are any error messages, show them in a message box
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' If everything is correct, proceed to save the data and display in DataGridView
            Dim courseID As String = MCForm_TBox_ID.Text.Trim()
            Dim courseName As String = MCForm_TBox_CName.Text.Trim()
            Dim courseDesc As String = MCForm_TBox_Desc.Text.Trim()

            ' Save data to mg_courses.json
            SaveDataToJsonFile(courseID, courseName, courseDesc)

            ' Display data in DataGridView
            DisplayDataInDataGridView()
        End If
    End Sub

    Private Sub SaveDataToJsonFile(courseID As String, courseName As String, courseDesc As String)
        ' Write data to JSON file
        Dim jsonFilePath As String = "mg_courses.json"
        Dim jsonData As String = "{""M_Courses_ID"": """ & courseID & """, ""M_Courses_Cname"": """ & courseName & """, ""M_Courses_Desc"": """ & courseDesc & """}"

        Try
            ' Append data to JSON file
            Using writer As StreamWriter = File.AppendText(jsonFilePath)
                writer.WriteLine(jsonData)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving data to JSON file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisplayDataInDataGridView()
        ' Read data from JSON file and display in DataGridView
        Dim jsonFilePath As String = "mg_courses.json"
        Dim dataTable As New DataTable()

        ' Assuming JSON file has an array of objects
        Try
            If File.Exists(jsonFilePath) Then
                ' Read all lines from JSON file
                Dim lines As String() = File.ReadAllLines(jsonFilePath)

                ' Clear existing rows in DataGridView
                ManageCoursesDGV.Rows.Clear()

                For Each line As String In lines
                    Dim jsonData As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(line)
                    ' Add data to DataGridView
                    ManageCoursesDGV.Rows.Add(jsonData("M_Courses_ID"), jsonData("M_Courses_Cname"), jsonData("M_Courses_Desc"))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred while reading data from JSON file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ManageCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayDataInDataGridView()
    End Sub

    ' Add Button Click Event Check END

    ' Update Button Click Event 

    Private Sub MCForm_Btn_Update_Click(sender As Object, e As EventArgs) Handles MCForm_Btn_Update.Click
        ' Check if a row is selected
        If ManageCoursesDGV.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = ManageCoursesDGV.SelectedRows(0)

            ' Get the original Course ID from the selected row
            Dim originalCourseID As String = selectedRow.Cells("M_Courses_ID").Value.ToString()

            ' Get the new data from the text boxes
            Dim newCourseID As String = MCForm_TBox_ID.Text.Trim()
            Dim newCourseName As String = MCForm_TBox_CName.Text.Trim()
            Dim newCourseDesc As String = MCForm_TBox_Desc.Text.Trim()

            ' Update the data in the JSON file
            UpdateDataInJsonFile(originalCourseID, newCourseID, newCourseName, newCourseDesc)

            ' Display a message indicating successful update
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the text boxes
            MCForm_TBox_ID.Text = ""
            MCForm_TBox_CName.Text = ""
            MCForm_TBox_Desc.Text = ""

            ' Refresh the DataGridView to reflect the changes
            DisplayDataInDataGridView()
        Else
            MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub ManageCoursesDGV_SelectionChanged(sender As Object, e As EventArgs) Handles ManageCoursesDGV.SelectionChanged
        ' Update the text boxes with the data from the selected row
        If ManageCoursesDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ManageCoursesDGV.SelectedRows(0)
            MCForm_TBox_ID.Text = selectedRow.Cells("M_Courses_ID").Value.ToString()
            MCForm_TBox_CName.Text = selectedRow.Cells("M_Courses_Cname").Value.ToString()
            MCForm_TBox_Desc.Text = selectedRow.Cells("M_Courses_Desc").Value.ToString()
        End If
    End Sub

    Private Sub UpdateDataInJsonFile(originalCourseID As String, newCourseID As String, newCourseName As String, newCourseDesc As String)
        ' Read existing data from JSON file
        Dim jsonFilePath As String = "mg_courses.json"

        Try
            If File.Exists(jsonFilePath) Then
                ' Read all lines from JSON file
                Dim lines As String() = File.ReadAllLines(jsonFilePath)

                ' Modify the data in memory
                For i As Integer = 0 To lines.Length - 1
                    Dim jsonData As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(lines(i))
                    If jsonData("M_Courses_ID").ToString() = originalCourseID Then
                        jsonData("M_Courses_ID") = newCourseID ' Update the Course ID
                        jsonData("M_Courses_Cname") = newCourseName
                        jsonData("M_Courses_Desc") = newCourseDesc
                        lines(i) = Newtonsoft.Json.JsonConvert.SerializeObject(jsonData)
                        Exit For
                    End If
                Next

                ' Write the modified data back to the JSON file
                File.WriteAllLines(jsonFilePath, lines)
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred while saving updated data to JSON file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MG_Mini_Btn_Icon_Click(sender As Object, e As EventArgs) Handles MG_Mini_Btn_Icon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    ' Update Button Click Event END

    Private Sub MC_Refresh_Btn_Click(sender As Object, e As EventArgs) Handles MC_Refresh_Btn.Click
        MCForm_TBox_ID.Text = ""
        MCForm_TBox_CName.Text = ""
        MCForm_TBox_Desc.Text = ""
        Me.Refresh()
    End Sub

    Private Sub MCMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles MCMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub
End Class