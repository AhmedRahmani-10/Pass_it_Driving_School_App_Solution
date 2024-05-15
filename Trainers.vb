
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

    ' form boxes check code


    ' Form Validation Learners ID check

    Private Sub TForm_TBox_ID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TForm_TBox_ID.KeyPress
        ' Make the error message label visible
        TForm_ErrMsg_ID.Visible = True

        If String.IsNullOrEmpty(TForm_TBox_ID.Text & e.KeyChar) Then
            ' If empty, hide the checkmark
            TForm_ChkMark_ID.Visible = False
        Else
            ' Check if the key pressed is a digit, backspace, or delete
            If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
                ' If the key is not a digit and not a control key (like backspace or delete), then it's an invalid input
                ' Set the error message in red color
                TForm_ErrMsg_ID.ForeColor = Color.Red
                TForm_ErrMsg_ID.Text = "Invalid input. Please enter only numbers between 100 and 999."
                e.Handled = True ' Prevent the input from being entered into the text box
                TForm_ChkMark_ID.Visible = False
            Else
                ' If the key is a digit, backspace, or delete, check the validity of the input
                Dim input As Integer
                If Integer.TryParse(TForm_TBox_ID.Text & e.KeyChar, input) OrElse e.KeyChar = ChrW(Keys.Back) Then
                    ' If the input can be parsed as an integer or it's a backspace, continue validation
                    If input >= 100 AndAlso input <= 999 OrElse e.KeyChar = ChrW(Keys.Back) Then
                        ' If the input is within the range or it's a backspace, hide the error message
                        TForm_ErrMsg_ID.Visible = False
                        ' If the input is within the range, set the check mark visibility to true
                        TForm_ChkMark_ID.Visible = input >= 100 AndAlso input <= 999
                    Else
                        ' If the input is not within the range and it's not a backspace, show error message and hide check mark
                        TForm_ErrMsg_ID.ForeColor = Color.Red
                        TForm_ErrMsg_ID.Text = "Input must be between 100 and 999."
                        TForm_ChkMark_ID.Visible = False
                    End If
                Else
                    ' If the input cannot be parsed as an integer and it's not a backspace, show error message and hide check mark
                    TForm_ErrMsg_ID.ForeColor = Color.Red
                    TForm_ErrMsg_ID.Text = "Invalid input. Please enter only numbers."
                    TForm_ChkMark_ID.Visible = False
                End If
            End If
        End If


    End Sub

    ' Form Validation Learners ID check End


    ' Form Validation First Name TextBox check

    Private Sub TForm_TBox_Fname_TextChanged(sender As Object, e As EventArgs) Handles TForm_TBox_Fname.TextChanged
        If String.IsNullOrWhiteSpace(TForm_TBox_Fname.Text) Then
            ' If the text box is empty or contains only white spaces, hide the check mark
            TForm_ChkMark_Fname.Visible = False
            ' Hide the error message
            TForm_ErrMsg_Fname.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(TForm_TBox_Fname.Text, "^[a-zA-Z]*$") AndAlso TForm_TBox_Fname.Text.Length <= 18 Then
            ' If the text contains only alphabets and is within 18 characters, show the check mark and hide the error message
            TForm_ChkMark_Fname.Visible = True
            TForm_ErrMsg_Fname.Visible = False
        ElseIf TForm_TBox_Fname.Text.Length > 18 Then
            ' If the length of text is greater than 18, show an error message and hide the check mark
            TForm_ErrMsg_Fname.ForeColor = Color.Red
            TForm_ErrMsg_Fname.Text = "Maximum length is 18 characters"
            TForm_ErrMsg_Fname.Visible = True
            TForm_ChkMark_Fname.Visible = False
        Else
            ' If the text contains other characters than alphabets, show an error message and hide the check mark
            TForm_ErrMsg_Fname.ForeColor = Color.Red
            TForm_ErrMsg_Fname.Text = "Please enter First name"
            TForm_ErrMsg_Fname.Visible = True
            TForm_ChkMark_Fname.Visible = False
        End If
    End Sub

    Private Sub TForm_TBox_Fname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TForm_TBox_Fname.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a letter, show an error message and prevent it from being entered into the text box
            TForm_ErrMsg_Fname.ForeColor = Color.Red
            TForm_ErrMsg_Fname.Text = "Only alphabet characters are allowed"
            TForm_ErrMsg_Fname.Visible = True
            e.Handled = True
        Else
            ' If it's a letter or a control character, hide the error message
            TForm_ErrMsg_Fname.Visible = False
        End If
    End Sub

    ' Form Validation First Name TextBox check End

    ' Form Validation Last Name TextBox check 

    Private Sub TForm_TBox_Lname_TextChanged(sender As Object, e As EventArgs) Handles TForm_TBox_Lname.TextChanged
        If String.IsNullOrWhiteSpace(TForm_TBox_Lname.Text) Then
            ' If the text box is empty or contains only white spaces, hide the check mark
            TForm_ChkMark_Lname.Visible = False
            ' Hide the error message
            TForm_ErrMsg_Lname.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(TForm_TBox_Lname.Text, "^[a-zA-Z]*$") AndAlso TForm_TBox_Lname.Text.Length <= 18 Then
            ' If the text contains only alphabets and is within 18 characters, show the check mark and hide the error message
            TForm_ChkMark_Lname.Visible = True
            TForm_ErrMsg_Lname.Visible = False
        ElseIf TForm_TBox_Lname.Text.Length > 18 Then
            ' If the length of text is greater than 18, show an error message and hide the check mark
            TForm_ErrMsg_Lname.ForeColor = Color.Red
            TForm_ErrMsg_Lname.Text = "Maximum length is 18 characters"
            TForm_ErrMsg_Lname.Visible = True
            TForm_ChkMark_Lname.Visible = False
        Else
            ' If the text contains other characters than alphabets, show an error message and hide the check mark
            TForm_ErrMsg_Lname.ForeColor = Color.Red
            TForm_ErrMsg_Lname.Text = "Please enter Last name"
            TForm_ErrMsg_Lname.Visible = True
            TForm_ChkMark_Lname.Visible = False
        End If
    End Sub

    Private Sub TForm_TBox_Lname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TForm_TBox_Lname.KeyPress
        ' Check if the entered character is not a letter
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not a letter, show an error message and prevent it from being entered into the text box
            TForm_ErrMsg_Lname.ForeColor = Color.Red
            TForm_ErrMsg_Lname.Text = "Only alphabet characters are allowed"
            TForm_ErrMsg_Lname.Visible = True
            e.Handled = True
        Else
            ' If it's a letter or a control character, hide the error message
            TForm_ErrMsg_Lname.Visible = False
        End If
    End Sub

    ' Form Validation for Last Name TextBox check End

    ' Form Validation for Email check

    Private Sub TForm_TBox_Email_TextChanged(sender As Object, e As EventArgs) Handles TForm_TBox_Email.TextChanged
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        If String.IsNullOrWhiteSpace(TForm_TBox_Email.Text) Then
            ' If the text box is empty or contains only white spaces, hide the validation check mark
            TForm_ChkMark_Email.Visible = False
            ' Hide the error message
            TForm_ErrMsg_Email.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(TForm_TBox_Email.Text, emailPattern) Then
            ' If the entered email matches the email pattern, show the validation check mark and hide the error message
            TForm_ChkMark_Email.Visible = True
            TForm_ErrMsg_Email.Visible = False
        Else
            ' If the entered email does not match the email pattern, show an error message and hide the validation check mark
            TForm_ErrMsg_Email.ForeColor = Color.Red
            TForm_ErrMsg_Email.Text = "Please enter a valid email address"
            TForm_ErrMsg_Email.Visible = True
            TForm_ChkMark_Email.Visible = False
        End If
    End Sub

    ' Form Validation for Email check End

    ' Form Validation for Phone number check 

    Private Sub TForm_TBox_Phone_TextChanged(sender As Object, e As EventArgs) Handles TForm_TBox_Phone.TextChanged
        Dim phoneNumberPattern As String = "^0\d{10}$|^[1-9]\d{9}$"

        If String.IsNullOrWhiteSpace(TForm_TBox_Phone.Text) Then
            ' If the text box is empty or contains only white spaces, hide the validation check mark
            TForm_ChkMark_Phone.Visible = False
            ' Hide the error message
            TForm_ErrMsg_Phone.Visible = False
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(TForm_TBox_Phone.Text, phoneNumberPattern) Then
            ' If the entered phone number matches the phone number pattern, show the validation check mark and hide the error message
            TForm_ChkMark_Phone.Visible = True
            TForm_ErrMsg_Phone.Visible = False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(TForm_TBox_Phone.Text, "^\d+$") Then
            ' If the entered phone number contains non-numeric characters, show an error message and hide the validation check mark
            TForm_ErrMsg_Phone.ForeColor = Color.Red
            TForm_ErrMsg_Phone.Text = "Phone number must contain only numbers"
            TForm_ErrMsg_Phone.Visible = True
            TForm_ChkMark_Phone.Visible = False
        ElseIf TForm_TBox_Phone.Text.Length > 11 Then
            ' If the entered phone number length is greater than 11, show an error message and hide the validation check mark
            TForm_ErrMsg_Phone.ForeColor = Color.Red
            TForm_ErrMsg_Phone.Text = "Phone number must not exceed 11 digits"
            TForm_ErrMsg_Phone.Visible = True
            TForm_ChkMark_Phone.Visible = False
        ElseIf TForm_TBox_Phone.Text.Length > 10 AndAlso Not TForm_TBox_Phone.Text.StartsWith("0") Then
            ' If the entered phone number length is greater than 10 and doesn't start with 0, show an error message and hide the validation check mark
            TForm_ErrMsg_Phone.ForeColor = Color.Red
            TForm_ErrMsg_Phone.Text = "Phone number must not exceed 10 digits"
            TForm_ErrMsg_Phone.Visible = True
            TForm_ChkMark_Phone.Visible = False
        End If
    End Sub

    Private Sub TForm_TBox_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TForm_TBox_Phone.KeyPress
        ' Allow backspace key
        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        ' Check if the entered character is not a digit or if the length is already 11 and the number starts with 0,
        ' or if the length is already 10 and the number starts with any other number
        If Not Char.IsDigit(e.KeyChar) OrElse
       (TForm_TBox_Phone.Text.Length = 11 AndAlso TForm_TBox_Phone.Text.StartsWith("0")) OrElse
       (TForm_TBox_Phone.Text.Length = 10 AndAlso Not TForm_TBox_Phone.Text.StartsWith("0")) Then
            ' If any of the conditions are met, prevent the character from being entered into the text box
            e.Handled = True
        End If

        ' Hide the error message when a valid character is entered
        TForm_ErrMsg_Phone.Visible = False
    End Sub


    ' Form Validation for Phone number check End


    ' form boxes check code End

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

    Private trainers As New List(Of Trainer)

    Private Sub TForm_Btn_Add_Click(sender As Object, e As EventArgs) Handles TForm_Btn_Add.Click
        Dim errorMessages As New List(Of String)

        ' Check if Enrollment ID is empty
        If String.IsNullOrWhiteSpace(TForm_TBox_ID.Text) Then
            errorMessages.Add("Enrollment ID is required")
            TForm_ErrMsg_ID.Visible = True
        Else
            TForm_ErrMsg_ID.Visible = False
        End If

        ' Check if First name is empty
        If String.IsNullOrWhiteSpace(TForm_TBox_Fname.Text) Then
            errorMessages.Add("First name is required")
            TForm_ErrMsg_Fname.Visible = True
        Else
            TForm_ErrMsg_Fname.Visible = False
        End If

        ' Check if Last name is empty
        If String.IsNullOrWhiteSpace(TForm_TBox_Lname.Text) Then
            errorMessages.Add("Last name is required")
            TForm_ErrMsg_Lname.Visible = True
        Else
            TForm_ErrMsg_Lname.Visible = False
        End If

        ' Check if Email ID is empty
        If String.IsNullOrWhiteSpace(TForm_TBox_Email.Text) Then
            errorMessages.Add("Email ID is required")
            TForm_ErrMsg_Email.Visible = True
        Else
            TForm_ErrMsg_Email.Visible = False
        End If

        ' Check if Phone number is empty
        If String.IsNullOrWhiteSpace(TForm_TBox_Phone.Text) Then
            errorMessages.Add("Phone number is required")
            TForm_ErrMsg_Phone.Visible = True
        Else
            TForm_ErrMsg_Phone.Visible = False
        End If

        ' Check if Date of Birth is empty
        If TForm_DateBox_DOB.Value = DateTime.MinValue Then
            errorMessages.Add("Date of Birth is required")
            TForm_ErrMsg_DOB.Visible = True
        Else
            TForm_ErrMsg_DOB.Visible = False
        End If

        Dim tariff As Decimal
        If Not String.IsNullOrWhiteSpace(TForm_NumBox_Tariff.Text) Then
            If Decimal.TryParse(TForm_NumBox_Tariff.Text, tariff) Then
                ' Tariff extracted successfully
            Else
                ' Display error message if the input is not a valid decimal number
                MessageBox.Show("Tariff must be a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Exit the sub to prevent further execution
            End If
        Else
            ' Set default value for tariff if number box is empty
            tariff = 30
        End If

        ' Check if courses are empty
        Dim selectedValues As String = ""

        ' Check if any checkboxes are checked
        If TForm_ChkBox1_Teaches.Checked OrElse TForm_ChkBox2_Teaches.Checked OrElse TForm_ChkBox3_Teaches.Checked OrElse TForm_ChkBox4_Teaches.Checked Then
            ' At least one checkbox is checked, so concatenate their values
            If TForm_ChkBox1_Teaches.Checked Then
                selectedValues &= "Basic" ' Replace "Value1" with the actual value you want to store
                selectedValues &= ","
            End If

            If TForm_ChkBox2_Teaches.Checked Then
                selectedValues &= "Refresher" ' Replace "Value2" with the actual value you want to store
                selectedValues &= ","
            End If

            If TForm_ChkBox3_Teaches.Checked Then
                selectedValues &= "Pass Plus" ' Replace "Value3" with the actual value you want to store
                selectedValues &= ","
            End If

            If TForm_ChkBox4_Teaches.Checked Then
                selectedValues &= "Test Day" ' Replace "Value4" with the actual value you want to store
                selectedValues &= ","
            End If

            ' Remove the trailing comma if there are any selected values
            If selectedValues <> "" Then
                selectedValues = selectedValues.TrimEnd(","c)
            End If
        Else
            ' No checkboxes are checked, set selectedValues to an empty string or handle it accordingly
            selectedValues = ""
        End If



        ' If there are any error messages, display them in a message box
        If errorMessages.Any() Then
            MessageBox.Show(String.Join(Environment.NewLine, errorMessages), "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' All mandatory fields are filled, proceed with adding the data
            ' Create a Trainer object and populate it with form data
            Dim trainerData As New Trainer()
            trainerData.ID = TForm_TBox_ID.Text
            trainerData.FirstName = TForm_TBox_Fname.Text
            trainerData.LastName = TForm_TBox_Lname.Text
            trainerData.DOB = TForm_DateBox_DOB.Value
            trainerData.Email = TForm_TBox_Email.Text
            trainerData.Phone = TForm_TBox_Phone.Text
            trainerData.Tariff = If(Decimal.TryParse(TForm_NumBox_Tariff.Text, trainerData.Tariff), trainerData.Tariff, 30) ' Default to 30 if parsing fails
            trainerData.Teaches = selectedValues.Split(","c).ToList()


            ' Check if Gender is empty
            If Not String.IsNullOrWhiteSpace(TForm_CBox_Gender.SelectedItem?.ToString()) Then
                trainerData.Gender = TForm_CBox_Gender.SelectedItem.ToString()
            End If

            ' Add data to list
            trainers.Add(trainerData)

            ' Add data to DataGridView
            'TrainersDGV.Rows.Add(trainerData.ID, trainerData.FirstName, trainerData.LastName, trainerData.DOB, trainerData.Gender, trainerData.Email, trainerData.Phone, selectedValues)

            ' Add data to DataGridView
            TrainersDGV.Rows.Add(trainerData.ID, trainerData.FirstName, trainerData.LastName, trainerData.Gender, trainerData.Email, trainerData.Phone, trainerData.DOB, trainerData.Tariff, selectedValues)

            ' Save trainer data to file
            SavetrainerDataToFile()

            ' Display a message indicating that the data has been successfully added
            MessageBox.Show("New Enrollment Added Successfully")

            ' Clear the form fields after adding the data
            'ClearFormFields()

        End If
    End Sub

    Private Sub SavetrainerDataToFile()
        ' Serialize the trainers list to JSON
        Dim json As String = JsonConvert.SerializeObject(trainers, Formatting.Indented)

        ' Specify the file path
        Dim filePath As String = "trainers.json"

        ' Write the JSON data to the file
        System.IO.File.WriteAllText(filePath, json)

    End Sub


    Private Sub ClearFormFields()
        ' Clear form fields
        ' Clear all textboxes, checkboxes, etc.
        TForm_TBox_ID.Text = ""
        TForm_TBox_Fname.Text = ""
        TForm_TBox_Lname.Text = ""
        TForm_TBox_Email.Text = ""
        TForm_TBox_Phone.Text = ""

        ' Clear combo box selection
        TForm_CBox_Gender.SelectedIndex = -1

        ' Uncheck checkboxes
        TForm_ChkBox1_Teaches.Checked = False
        TForm_ChkBox2_Teaches.Checked = False
        TForm_ChkBox3_Teaches.Checked = False
        TForm_ChkBox4_Teaches.Checked = False

        ' Hide any error messages or check marks
        TForm_ErrMsg_ID.Visible = False
        TForm_ErrMsg_Fname.Visible = False
        ' Add more lines if you have more error messages
        TForm_ChkMark_ID.Visible = False
        TForm_ChkMark_Fname.Visible = False
        ' Add more lines if you have more check marks


    End Sub

    ' form datagrid view

    Private Sub trainers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load trainer data from file
        LoadTrainerDataFromFile()
    End Sub

    Private Sub LoadTrainerDataFromFile()
        Dim filePath As String = "trainers.json"

        ' Check if the file exists
        If System.IO.File.Exists(filePath) Then
            ' Read the JSON data from the file
            Dim json As String = System.IO.File.ReadAllText(filePath)

            ' Deserialize JSON to list of trainers
            trainers = JsonConvert.DeserializeObject(Of List(Of Trainer))(json)

            ' Display the data in the DataGridView
            DisplayTrainerDataInDataGridView()
        End If
    End Sub

    Private Sub DisplayTrainerDataInDataGridView()
        TrainersDGV.Rows.Clear()

        For Each trainer In trainers
            Dim teaches As String = String.Join(", ", trainer.Teaches)

            TrainersDGV.Rows.Add(trainer.ID, trainer.FirstName, trainer.LastName,
                             trainer.Gender, trainer.Email, trainer.Phone,
                             trainer.DOB, trainer.Tariff, teaches)
        Next
    End Sub


    ' form datagrid view end

    Private Sub TMenuIcon_Logout_Click(sender As Object, e As EventArgs) Handles TMenuIcon_Logout.Click
        ' Perform logout actions here (if any), such as clearing session data, etc.

        ' Hide the current dashboard form
        Me.Hide()

        ' Show the login form again
        Dim loginForm As New login()
        loginForm.Show()
    End Sub

    ' form validation and submission END

    ' form update function again

    Private Sub TrainersDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TrainersDGV.CellClick
        ' Check if the clicked cell is not the header cell and a row is selected
        If e.RowIndex >= 0 AndAlso TrainersDGV.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim selectedIndex As Integer = TrainersDGV.SelectedRows(0).Index

            ' Populate the data of the selected row into their respective fields on the form
            Dim selectedTrainer As Trainer = trainers(selectedIndex)
            TForm_TBox_ID.Text = selectedTrainer.ID
            TForm_TBox_Fname.Text = selectedTrainer.FirstName
            TForm_TBox_Lname.Text = selectedTrainer.LastName
            TForm_CBox_Gender.SelectedItem = selectedTrainer.Gender
            TForm_TBox_Email.Text = selectedTrainer.Email
            TForm_TBox_Phone.Text = selectedTrainer.Phone
            TForm_DateBox_DOB.Value = selectedTrainer.DOB
            TForm_NumBox_Tariff.Text = selectedTrainer.Tariff.ToString()
            ' Update other fields similarly...

            ' Update other fields similarly...

            ' Populate the checkbox values
            TForm_ChkBox1_Teaches.Checked = selectedTrainer.Teaches.Contains("Basic") OrElse selectedTrainer.Teaches.Contains("Value1")
            TForm_ChkBox2_Teaches.Checked = selectedTrainer.Teaches.Contains("Refresher") OrElse selectedTrainer.Teaches.Contains("Value2")
            TForm_ChkBox3_Teaches.Checked = selectedTrainer.Teaches.Contains("Pass Plus")
            TForm_ChkBox4_Teaches.Checked = selectedTrainer.Teaches.Contains("Test Day")


        End If
    End Sub


    Private Sub TForm_Btn_Update_Click(sender As Object, e As EventArgs) Handles TForm_Btn_Update.Click
        ' Check if any row is selected in the DataGridView
        If TrainersDGV.SelectedRows.Count = 0 Then
            ' If no rows are selected, show a message box
            MessageBox.Show("Please select a row in the table.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub ' Exit the sub to prevent further execution
        End If

        ' Get the index of the selected row
        Dim selectedIndex As Integer = TrainersDGV.SelectedRows(0).Index

        ' Check if the clicked row index is valid
        If selectedIndex >= 0 AndAlso selectedIndex < trainers.Count Then
            ' Populate the data of the selected row into their respective fields on the form
            Dim selectedTrainer As Trainer = trainers(selectedIndex)
            selectedTrainer.ID = TForm_TBox_ID.Text
            selectedTrainer.FirstName = TForm_TBox_Fname.Text
            selectedTrainer.LastName = TForm_TBox_Lname.Text
            selectedTrainer.Gender = If(TForm_CBox_Gender.SelectedItem IsNot Nothing, TForm_CBox_Gender.SelectedItem.ToString(), "")
            selectedTrainer.Email = TForm_TBox_Email.Text
            selectedTrainer.Phone = TForm_TBox_Phone.Text
            selectedTrainer.DOB = TForm_DateBox_DOB.Value
            If Decimal.TryParse(TForm_NumBox_Tariff.Text, selectedTrainer.Tariff) Then
                ' Tariff extracted successfully
            Else
                ' Display error message if the input is not a valid decimal number
                MessageBox.Show("Tariff must be a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub ' Exit the sub to prevent further execution
            End If


            ' Update the selected values based on the checkboxes
            Dim selectedValues As String = ""
            If TForm_ChkBox1_Teaches.Checked Then
                selectedValues &= "Basic,"
            End If
            If TForm_ChkBox2_Teaches.Checked Then
                selectedValues &= "Refresher,"
            End If
            If TForm_ChkBox3_Teaches.Checked Then
                selectedValues &= "Pass Plus,"
            End If
            If TForm_ChkBox4_Teaches.Checked Then
                selectedValues &= "Test Day,"
            End If

            ' Remove the trailing comma if there are any selected values
            If selectedValues <> "" Then
                selectedValues = selectedValues.TrimEnd(","c)
            End If

            ' Assign the updated selected values to the trainer object
            selectedTrainer.Teaches = selectedValues.Split(","c).ToList()


            ' Serialize the trainers list to JSON
            Dim json As String = JsonConvert.SerializeObject(trainers, Formatting.Indented)

            ' Specify the file path
            Dim filePath As String = "trainers.json"

            ' Write the JSON data to the file
            System.IO.File.WriteAllText(filePath, json)

            ' Refresh the DataGridView to display the updated values
            LoadTrainerDataFromFile()

            ' Display a message indicating that the data has been successfully updated
            MessageBox.Show("Trainer data updated successfully")

        Else
            ' If no row is selected, display an error message
            MessageBox.Show("Please select a row to update", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear the form fields after updating
        ClearFormFields()

    End Sub


    ' form update function again END


    'form delete function here

    Private Sub TForm_Btn_Delete_Click(sender As Object, e As EventArgs) Handles TForm_Btn_Delete.Click
        ' Check if any row is selected in the DataGridView
        If TrainersDGV.SelectedRows.Count = 0 Then
            ' If no rows are selected, show a message box
            MessageBox.Show("Please select a row in the table.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub ' Exit the sub to prevent further execution
        End If

        ' Get the index of the selected row
        Dim selectedIndex As Integer = TrainersDGV.SelectedRows(0).Index

        ' Check if the clicked row index is valid
        If selectedIndex >= 0 AndAlso selectedIndex < trainers.Count Then
            ' Remove the selected trainer from the trainers list
            trainers.RemoveAt(selectedIndex)

            ' Serialize the updated trainers list to JSON
            Dim json As String = JsonConvert.SerializeObject(trainers, Formatting.Indented)

            ' Specify the file path
            Dim filePath As String = "trainers.json"

            ' Write the JSON data to the file
            System.IO.File.WriteAllText(filePath, json)

            ' Refresh the DataGridView to display the updated values
            DisplayTrainerDataInDataGridView()



            ' Display a message indicating that the row has been deleted successfully
            MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Clear the form fields
        ClearFormFields()
    End Sub

    Private Sub TCloseBtn_Icon_Click_1(sender As Object, e As EventArgs) Handles TCloseBtn_Icon.Click
        Me.Hide()
    End Sub

    ' form delete function END


End Class