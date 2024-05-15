<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookLessons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookLessons))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BForm_Panel_Course = New Panel()
        BForm_Star_Course = New Label()
        BForm_Radio4_Course = New RadioButton()
        BForm_Radio3_Course = New RadioButton()
        BForm_Radio2_Course = New RadioButton()
        BForm_Radio1_Course = New RadioButton()
        BForm_ErrMsg_Course = New Label()
        BForm_lbl_Courses = New Label()
        BForm_TopPanel = New Panel()
        BForm_Btn_Cancel = New Button()
        BForm_Btn_Update = New Button()
        BForm_Btn_Book = New Button()
        BForm_Panel_BookDate = New Panel()
        BForm_DatePick_BookDate = New DateTimePicker()
        BForm_Star_BookDate = New Label()
        BForm_Lbl_BookDate = New Label()
        BForm_Panel_Tariff = New Panel()
        Tform_Lbl_Tariff = New Label()
        BForm_NumBox_Tariff = New NumericUpDown()
        TForm_ErrMsg_Tariff = New Label()
        BForm_Panel_TID = New Panel()
        BForm_ChkMark_TID = New PictureBox()
        BForm_TxtBox_TID = New TextBox()
        BForm_ErrMsg_TID = New Label()
        BForm_Star_TID = New Label()
        BForm_Lbl_TID = New Label()
        BForm_Panel_NumClasses = New Panel()
        BForm_NumBox_NClasses = New NumericUpDown()
        BForm_ErrMsg_NumClasses = New Label()
        BForm_Star_NumClasses = New Label()
        BForm_Lbl_NumClasses = New Label()
        BForm_Panel_TotalFee = New Panel()
        BForm_TBox_TotalFee = New TextBox()
        BForm_Star_TotalFee = New Label()
        BForm_Lbl_TotalFee = New Label()
        BForm_Panel_LID = New Panel()
        BForm_ChkMark_LID = New PictureBox()
        BForm_TxtBox_LID = New TextBox()
        BForm_ErrMsg_LID = New Label()
        TForm_Star_Fname = New Label()
        Bform_Lbl_LID = New Label()
        BForm_Panel_BookID = New Panel()
        BForm_ChkMark_BookID = New PictureBox()
        BForm_TBox_BookID = New TextBox()
        BForm_ErrMsg_BookID = New Label()
        BForm_Star_BookID = New Label()
        BForm_Lbl_BookID = New Label()
        BHeadULine_Title = New Panel()
        BMenuIcon_Trainers = New PictureBox()
        BookingDGV = New DataGridView()
        AppLogo = New PictureBox()
        B_Dashboard_Panel = New Panel()
        BookingDGV_Title = New Label()
        BHeadLbl_Title = New Label()
        BHeadIcon_Title = New PictureBox()
        BMenuIcon_Courses = New PictureBox()
        BMenuIcon_Dashboard = New PictureBox()
        BMenuIcon_Learners = New PictureBox()
        BMenuLbl_Learners = New Label()
        BMenuLbl_Dashboard = New Label()
        BMenuLbl_Courses = New Label()
        BMenuIcon_BookLessons = New PictureBox()
        BMenuLbl_BookLessons = New Label()
        BMenuLbl_Trainers = New Label()
        BMenuIcon_Logout = New PictureBox()
        B_Mini_Btn_Icon = New PictureBox()
        BCloseBtn_Icon = New PictureBox()
        BLogout_Btn = New Label()
        BookLesson_ID = New DataGridViewTextBoxColumn()
        BookLesson_LID = New DataGridViewTextBoxColumn()
        BookLesson_TID = New DataGridViewTextBoxColumn()
        BookLesson_NumClasses = New DataGridViewTextBoxColumn()
        BookLesson_Course = New DataGridViewTextBoxColumn()
        BookLesson_Tariff = New DataGridViewTextBoxColumn()
        BookLesson_TFee = New DataGridViewTextBoxColumn()
        BookLesson_BookDate = New DataGridViewTextBoxColumn()
        BForm_Panel_Course.SuspendLayout()
        BForm_TopPanel.SuspendLayout()
        BForm_Panel_BookDate.SuspendLayout()
        BForm_Panel_Tariff.SuspendLayout()
        CType(BForm_NumBox_Tariff, ComponentModel.ISupportInitialize).BeginInit()
        BForm_Panel_TID.SuspendLayout()
        CType(BForm_ChkMark_TID, ComponentModel.ISupportInitialize).BeginInit()
        BForm_Panel_NumClasses.SuspendLayout()
        CType(BForm_NumBox_NClasses, ComponentModel.ISupportInitialize).BeginInit()
        BForm_Panel_TotalFee.SuspendLayout()
        BForm_Panel_LID.SuspendLayout()
        CType(BForm_ChkMark_LID, ComponentModel.ISupportInitialize).BeginInit()
        BForm_Panel_BookID.SuspendLayout()
        CType(BForm_ChkMark_BookID, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_Trainers, ComponentModel.ISupportInitialize).BeginInit()
        CType(BookingDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppLogo, ComponentModel.ISupportInitialize).BeginInit()
        B_Dashboard_Panel.SuspendLayout()
        CType(BHeadIcon_Title, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_Courses, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_Dashboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_Learners, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_BookLessons, ComponentModel.ISupportInitialize).BeginInit()
        CType(BMenuIcon_Logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(B_Mini_Btn_Icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(BCloseBtn_Icon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BForm_Panel_Course
        ' 
        BForm_Panel_Course.Controls.Add(BForm_Star_Course)
        BForm_Panel_Course.Controls.Add(BForm_Radio4_Course)
        BForm_Panel_Course.Controls.Add(BForm_Radio3_Course)
        BForm_Panel_Course.Controls.Add(BForm_Radio2_Course)
        BForm_Panel_Course.Controls.Add(BForm_Radio1_Course)
        BForm_Panel_Course.Controls.Add(BForm_ErrMsg_Course)
        BForm_Panel_Course.Controls.Add(BForm_lbl_Courses)
        BForm_Panel_Course.Location = New Point(814, 16)
        BForm_Panel_Course.Name = "BForm_Panel_Course"
        BForm_Panel_Course.Size = New Size(358, 118)
        BForm_Panel_Course.TabIndex = 8
        ' 
        ' BForm_Star_Course
        ' 
        BForm_Star_Course.AutoSize = True
        BForm_Star_Course.Font = New Font("Segoe UI", 14F)
        BForm_Star_Course.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_Course.Location = New Point(87, 6)
        BForm_Star_Course.Name = "BForm_Star_Course"
        BForm_Star_Course.Size = New Size(20, 25)
        BForm_Star_Course.TabIndex = 12
        BForm_Star_Course.Text = "*"
        ' 
        ' BForm_Radio4_Course
        ' 
        BForm_Radio4_Course.AutoSize = True
        BForm_Radio4_Course.Font = New Font("Segoe UI", 10F)
        BForm_Radio4_Course.Location = New Point(220, 42)
        BForm_Radio4_Course.Name = "BForm_Radio4_Course"
        BForm_Radio4_Course.Size = New Size(86, 23)
        BForm_Radio4_Course.TabIndex = 11
        BForm_Radio4_Course.Text = "Test Prep."
        BForm_Radio4_Course.UseVisualStyleBackColor = True
        ' 
        ' BForm_Radio3_Course
        ' 
        BForm_Radio3_Course.AutoSize = True
        BForm_Radio3_Course.Font = New Font("Segoe UI", 10F)
        BForm_Radio3_Course.Location = New Point(120, 42)
        BForm_Radio3_Course.Name = "BForm_Radio3_Course"
        BForm_Radio3_Course.Size = New Size(83, 23)
        BForm_Radio3_Course.TabIndex = 10
        BForm_Radio3_Course.Text = "Pass Plus"
        BForm_Radio3_Course.UseVisualStyleBackColor = True
        ' 
        ' BForm_Radio2_Course
        ' 
        BForm_Radio2_Course.AutoSize = True
        BForm_Radio2_Course.Font = New Font("Segoe UI", 10F)
        BForm_Radio2_Course.Location = New Point(220, 4)
        BForm_Radio2_Course.Name = "BForm_Radio2_Course"
        BForm_Radio2_Course.Size = New Size(84, 23)
        BForm_Radio2_Course.TabIndex = 9
        BForm_Radio2_Course.Text = "Refresher"
        BForm_Radio2_Course.UseVisualStyleBackColor = True
        ' 
        ' BForm_Radio1_Course
        ' 
        BForm_Radio1_Course.AutoSize = True
        BForm_Radio1_Course.Checked = True
        BForm_Radio1_Course.FlatAppearance.CheckedBackColor = Color.Goldenrod
        BForm_Radio1_Course.Font = New Font("Segoe UI", 10F)
        BForm_Radio1_Course.Location = New Point(120, 4)
        BForm_Radio1_Course.Name = "BForm_Radio1_Course"
        BForm_Radio1_Course.Size = New Size(57, 23)
        BForm_Radio1_Course.TabIndex = 8
        BForm_Radio1_Course.TabStop = True
        BForm_Radio1_Course.Text = "Basic"
        BForm_Radio1_Course.UseVisualStyleBackColor = True
        ' 
        ' BForm_ErrMsg_Course
        ' 
        BForm_ErrMsg_Course.AutoSize = True
        BForm_ErrMsg_Course.Font = New Font("Segoe UI", 10F)
        BForm_ErrMsg_Course.ForeColor = Color.Red
        BForm_ErrMsg_Course.Location = New Point(120, 93)
        BForm_ErrMsg_Course.Name = "BForm_ErrMsg_Course"
        BForm_ErrMsg_Course.Size = New Size(222, 19)
        BForm_ErrMsg_Course.TabIndex = 2
        BForm_ErrMsg_Course.Text = "Select Course for Booking Lessons!"
        BForm_ErrMsg_Course.Visible = False
        ' 
        ' BForm_lbl_Courses
        ' 
        BForm_lbl_Courses.AutoSize = True
        BForm_lbl_Courses.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_lbl_Courses.Location = New Point(32, 6)
        BForm_lbl_Courses.Name = "BForm_lbl_Courses"
        BForm_lbl_Courses.Size = New Size(72, 17)
        BForm_lbl_Courses.TabIndex = 0
        BForm_lbl_Courses.Text = "Course: "
        ' 
        ' BForm_TopPanel
        ' 
        BForm_TopPanel.Controls.Add(BForm_Btn_Cancel)
        BForm_TopPanel.Controls.Add(BForm_Panel_Course)
        BForm_TopPanel.Controls.Add(BForm_Btn_Update)
        BForm_TopPanel.Controls.Add(BForm_Btn_Book)
        BForm_TopPanel.Controls.Add(BForm_Panel_BookDate)
        BForm_TopPanel.Controls.Add(BForm_Panel_Tariff)
        BForm_TopPanel.Controls.Add(BForm_Panel_TID)
        BForm_TopPanel.Controls.Add(BForm_Panel_NumClasses)
        BForm_TopPanel.Controls.Add(BForm_Panel_TotalFee)
        BForm_TopPanel.Controls.Add(BForm_Panel_LID)
        BForm_TopPanel.Controls.Add(BForm_Panel_BookID)
        BForm_TopPanel.Location = New Point(15, 90)
        BForm_TopPanel.Name = "BForm_TopPanel"
        BForm_TopPanel.Size = New Size(1192, 282)
        BForm_TopPanel.TabIndex = 22
        ' 
        ' BForm_Btn_Cancel
        ' 
        BForm_Btn_Cancel.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Btn_Cancel.FlatStyle = FlatStyle.Flat
        BForm_Btn_Cancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BForm_Btn_Cancel.ForeColor = Color.White
        BForm_Btn_Cancel.Location = New Point(1020, 221)
        BForm_Btn_Cancel.Name = "BForm_Btn_Cancel"
        BForm_Btn_Cancel.Size = New Size(144, 32)
        BForm_Btn_Cancel.TabIndex = 11
        BForm_Btn_Cancel.Text = "Cancel Booking"
        BForm_Btn_Cancel.UseVisualStyleBackColor = False
        ' 
        ' BForm_Btn_Update
        ' 
        BForm_Btn_Update.BackColor = Color.Green
        BForm_Btn_Update.FlatStyle = FlatStyle.Flat
        BForm_Btn_Update.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BForm_Btn_Update.ForeColor = Color.White
        BForm_Btn_Update.Location = New Point(917, 221)
        BForm_Btn_Update.Name = "BForm_Btn_Update"
        BForm_Btn_Update.Size = New Size(95, 32)
        BForm_Btn_Update.TabIndex = 10
        BForm_Btn_Update.Text = "Update"
        BForm_Btn_Update.UseVisualStyleBackColor = False
        ' 
        ' BForm_Btn_Book
        ' 
        BForm_Btn_Book.BackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BForm_Btn_Book.FlatStyle = FlatStyle.Flat
        BForm_Btn_Book.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BForm_Btn_Book.ForeColor = Color.White
        BForm_Btn_Book.Location = New Point(814, 221)
        BForm_Btn_Book.Name = "BForm_Btn_Book"
        BForm_Btn_Book.Size = New Size(95, 32)
        BForm_Btn_Book.TabIndex = 9
        BForm_Btn_Book.Text = "Book"
        BForm_Btn_Book.UseVisualStyleBackColor = False
        ' 
        ' BForm_Panel_BookDate
        ' 
        BForm_Panel_BookDate.Controls.Add(BForm_DatePick_BookDate)
        BForm_Panel_BookDate.Controls.Add(BForm_Star_BookDate)
        BForm_Panel_BookDate.Controls.Add(BForm_Lbl_BookDate)
        BForm_Panel_BookDate.Location = New Point(814, 140)
        BForm_Panel_BookDate.Name = "BForm_Panel_BookDate"
        BForm_Panel_BookDate.Size = New Size(358, 56)
        BForm_Panel_BookDate.TabIndex = 8
        ' 
        ' BForm_DatePick_BookDate
        ' 
        BForm_DatePick_BookDate.CalendarFont = New Font("Microsoft Sans Serif", 8.25F)
        BForm_DatePick_BookDate.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_DatePick_BookDate.Format = DateTimePickerFormat.Short
        BForm_DatePick_BookDate.Location = New Point(166, 3)
        BForm_DatePick_BookDate.MaxDate = New Date(2025, 5, 11, 0, 0, 0, 0)
        BForm_DatePick_BookDate.MinDate = New Date(2024, 5, 11, 0, 0, 0, 0)
        BForm_DatePick_BookDate.Name = "BForm_DatePick_BookDate"
        BForm_DatePick_BookDate.Size = New Size(184, 23)
        BForm_DatePick_BookDate.TabIndex = 5
        BForm_DatePick_BookDate.Value = New Date(2024, 5, 11, 0, 0, 0, 0)
        ' 
        ' BForm_Star_BookDate
        ' 
        BForm_Star_BookDate.AutoSize = True
        BForm_Star_BookDate.Font = New Font("Segoe UI", 14F)
        BForm_Star_BookDate.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_BookDate.Location = New Point(143, 3)
        BForm_Star_BookDate.Name = "BForm_Star_BookDate"
        BForm_Star_BookDate.Size = New Size(20, 25)
        BForm_Star_BookDate.TabIndex = 1
        BForm_Star_BookDate.Text = "*"
        ' 
        ' BForm_Lbl_BookDate
        ' 
        BForm_Lbl_BookDate.AutoSize = True
        BForm_Lbl_BookDate.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_Lbl_BookDate.Location = New Point(32, 6)
        BForm_Lbl_BookDate.Name = "BForm_Lbl_BookDate"
        BForm_Lbl_BookDate.Size = New Size(128, 17)
        BForm_Lbl_BookDate.TabIndex = 0
        BForm_Lbl_BookDate.Text = "Booking Date.: "
        ' 
        ' BForm_Panel_Tariff
        ' 
        BForm_Panel_Tariff.Controls.Add(Tform_Lbl_Tariff)
        BForm_Panel_Tariff.Controls.Add(BForm_NumBox_Tariff)
        BForm_Panel_Tariff.Controls.Add(TForm_ErrMsg_Tariff)
        BForm_Panel_Tariff.Location = New Point(18, 140)
        BForm_Panel_Tariff.Name = "BForm_Panel_Tariff"
        BForm_Panel_Tariff.Size = New Size(380, 56)
        BForm_Panel_Tariff.TabIndex = 7
        ' 
        ' Tform_Lbl_Tariff
        ' 
        Tform_Lbl_Tariff.AutoSize = True
        Tform_Lbl_Tariff.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        Tform_Lbl_Tariff.Location = New Point(15, 6)
        Tform_Lbl_Tariff.Name = "Tform_Lbl_Tariff"
        Tform_Lbl_Tariff.Size = New Size(144, 17)
        Tform_Lbl_Tariff.TabIndex = 6
        Tform_Lbl_Tariff.Text = "Tarrif/Hour (£): "
        ' 
        ' BForm_NumBox_Tariff
        ' 
        BForm_NumBox_Tariff.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BForm_NumBox_Tariff.ForeColor = Color.ForestGreen
        BForm_NumBox_Tariff.Increment = New Decimal(New Integer() {3, 0, 0, 0})
        BForm_NumBox_Tariff.Location = New Point(166, 4)
        BForm_NumBox_Tariff.Minimum = New Decimal(New Integer() {30, 0, 0, 0})
        BForm_NumBox_Tariff.Name = "BForm_NumBox_Tariff"
        BForm_NumBox_Tariff.Size = New Size(175, 25)
        BForm_NumBox_Tariff.TabIndex = 5
        BForm_NumBox_Tariff.TextAlign = HorizontalAlignment.Center
        BForm_NumBox_Tariff.Value = New Decimal(New Integer() {30, 0, 0, 0})
        ' 
        ' TForm_ErrMsg_Tariff
        ' 
        TForm_ErrMsg_Tariff.AutoSize = True
        TForm_ErrMsg_Tariff.Font = New Font("Segoe UI", 10F)
        TForm_ErrMsg_Tariff.ForeColor = Color.Red
        TForm_ErrMsg_Tariff.Location = New Point(162, 31)
        TForm_ErrMsg_Tariff.Name = "TForm_ErrMsg_Tariff"
        TForm_ErrMsg_Tariff.Size = New Size(199, 19)
        TForm_ErrMsg_Tariff.TabIndex = 2
        TForm_ErrMsg_Tariff.Text = "Enter Tariff per hour for course!"
        TForm_ErrMsg_Tariff.Visible = False
        ' 
        ' BForm_Panel_TID
        ' 
        BForm_Panel_TID.Controls.Add(BForm_ChkMark_TID)
        BForm_Panel_TID.Controls.Add(BForm_TxtBox_TID)
        BForm_Panel_TID.Controls.Add(BForm_ErrMsg_TID)
        BForm_Panel_TID.Controls.Add(BForm_Star_TID)
        BForm_Panel_TID.Controls.Add(BForm_Lbl_TID)
        BForm_Panel_TID.Location = New Point(18, 78)
        BForm_Panel_TID.Name = "BForm_Panel_TID"
        BForm_Panel_TID.Size = New Size(380, 56)
        BForm_Panel_TID.TabIndex = 5
        ' 
        ' BForm_ChkMark_TID
        ' 
        BForm_ChkMark_TID.BackColor = Color.Transparent
        BForm_ChkMark_TID.Image = CType(resources.GetObject("BForm_ChkMark_TID.Image"), Image)
        BForm_ChkMark_TID.Location = New Point(351, 5)
        BForm_ChkMark_TID.Name = "BForm_ChkMark_TID"
        BForm_ChkMark_TID.Size = New Size(20, 20)
        BForm_ChkMark_TID.SizeMode = PictureBoxSizeMode.StretchImage
        BForm_ChkMark_TID.TabIndex = 5
        BForm_ChkMark_TID.TabStop = False
        BForm_ChkMark_TID.Visible = False
        ' 
        ' BForm_TxtBox_TID
        ' 
        BForm_TxtBox_TID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_TxtBox_TID.Location = New Point(166, 4)
        BForm_TxtBox_TID.Name = "BForm_TxtBox_TID"
        BForm_TxtBox_TID.Size = New Size(175, 23)
        BForm_TxtBox_TID.TabIndex = 3
        ' 
        ' BForm_ErrMsg_TID
        ' 
        BForm_ErrMsg_TID.AutoSize = True
        BForm_ErrMsg_TID.Font = New Font("Segoe UI", 10F)
        BForm_ErrMsg_TID.ForeColor = Color.Red
        BForm_ErrMsg_TID.Location = New Point(162, 31)
        BForm_ErrMsg_TID.Name = "BForm_ErrMsg_TID"
        BForm_ErrMsg_TID.Size = New Size(145, 19)
        BForm_ErrMsg_TID.TabIndex = 2
        BForm_ErrMsg_TID.Text = "Enter Trainers ID here!"
        BForm_ErrMsg_TID.Visible = False
        ' 
        ' BForm_Star_TID
        ' 
        BForm_Star_TID.AutoSize = True
        BForm_Star_TID.Font = New Font("Segoe UI", 14F)
        BForm_Star_TID.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_TID.Location = New Point(144, 3)
        BForm_Star_TID.Name = "BForm_Star_TID"
        BForm_Star_TID.Size = New Size(20, 25)
        BForm_Star_TID.TabIndex = 1
        BForm_Star_TID.Text = "*"
        ' 
        ' BForm_Lbl_TID
        ' 
        BForm_Lbl_TID.AutoSize = True
        BForm_Lbl_TID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_Lbl_TID.Location = New Point(39, 6)
        BForm_Lbl_TID.Name = "BForm_Lbl_TID"
        BForm_Lbl_TID.Size = New Size(120, 17)
        BForm_Lbl_TID.TabIndex = 0
        BForm_Lbl_TID.Text = "Trainers ID.: "
        ' 
        ' BForm_Panel_NumClasses
        ' 
        BForm_Panel_NumClasses.Controls.Add(BForm_NumBox_NClasses)
        BForm_Panel_NumClasses.Controls.Add(BForm_ErrMsg_NumClasses)
        BForm_Panel_NumClasses.Controls.Add(BForm_Star_NumClasses)
        BForm_Panel_NumClasses.Controls.Add(BForm_Lbl_NumClasses)
        BForm_Panel_NumClasses.Location = New Point(421, 78)
        BForm_Panel_NumClasses.Name = "BForm_Panel_NumClasses"
        BForm_Panel_NumClasses.Size = New Size(379, 56)
        BForm_Panel_NumClasses.TabIndex = 6
        ' 
        ' BForm_NumBox_NClasses
        ' 
        BForm_NumBox_NClasses.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BForm_NumBox_NClasses.ForeColor = Color.ForestGreen
        BForm_NumBox_NClasses.Location = New Point(163, 5)
        BForm_NumBox_NClasses.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        BForm_NumBox_NClasses.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        BForm_NumBox_NClasses.Name = "BForm_NumBox_NClasses"
        BForm_NumBox_NClasses.Size = New Size(175, 25)
        BForm_NumBox_NClasses.TabIndex = 6
        BForm_NumBox_NClasses.TextAlign = HorizontalAlignment.Center
        BForm_NumBox_NClasses.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BForm_ErrMsg_NumClasses
        ' 
        BForm_ErrMsg_NumClasses.AutoSize = True
        BForm_ErrMsg_NumClasses.Font = New Font("Segoe UI", 10F)
        BForm_ErrMsg_NumClasses.ForeColor = Color.Red
        BForm_ErrMsg_NumClasses.Location = New Point(166, 31)
        BForm_ErrMsg_NumClasses.Name = "BForm_ErrMsg_NumClasses"
        BForm_ErrMsg_NumClasses.Size = New Size(188, 19)
        BForm_ErrMsg_NumClasses.TabIndex = 2
        BForm_ErrMsg_NumClasses.Text = "No. of Classes want to book !"
        BForm_ErrMsg_NumClasses.Visible = False
        ' 
        ' BForm_Star_NumClasses
        ' 
        BForm_Star_NumClasses.AutoSize = True
        BForm_Star_NumClasses.Font = New Font("Segoe UI", 14F)
        BForm_Star_NumClasses.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_NumClasses.Location = New Point(137, 3)
        BForm_Star_NumClasses.Name = "BForm_Star_NumClasses"
        BForm_Star_NumClasses.Size = New Size(20, 25)
        BForm_Star_NumClasses.TabIndex = 1
        BForm_Star_NumClasses.Text = "*"
        ' 
        ' BForm_Lbl_NumClasses
        ' 
        BForm_Lbl_NumClasses.AutoSize = True
        BForm_Lbl_NumClasses.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_Lbl_NumClasses.Location = New Point(17, 6)
        BForm_Lbl_NumClasses.Name = "BForm_Lbl_NumClasses"
        BForm_Lbl_NumClasses.Size = New Size(136, 17)
        BForm_Lbl_NumClasses.TabIndex = 0
        BForm_Lbl_NumClasses.Text = "No. of Classes: "
        ' 
        ' BForm_Panel_TotalFee
        ' 
        BForm_Panel_TotalFee.Controls.Add(BForm_TBox_TotalFee)
        BForm_Panel_TotalFee.Controls.Add(BForm_Star_TotalFee)
        BForm_Panel_TotalFee.Controls.Add(BForm_Lbl_TotalFee)
        BForm_Panel_TotalFee.Location = New Point(421, 140)
        BForm_Panel_TotalFee.Name = "BForm_Panel_TotalFee"
        BForm_Panel_TotalFee.Size = New Size(379, 56)
        BForm_Panel_TotalFee.TabIndex = 7
        ' 
        ' BForm_TBox_TotalFee
        ' 
        BForm_TBox_TotalFee.Font = New Font("Cascadia Code", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BForm_TBox_TotalFee.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BForm_TBox_TotalFee.Location = New Point(163, 3)
        BForm_TBox_TotalFee.Name = "BForm_TBox_TotalFee"
        BForm_TBox_TotalFee.Size = New Size(175, 23)
        BForm_TBox_TotalFee.TabIndex = 5
        BForm_TBox_TotalFee.TextAlign = HorizontalAlignment.Center
        ' 
        ' BForm_Star_TotalFee
        ' 
        BForm_Star_TotalFee.AutoSize = True
        BForm_Star_TotalFee.Font = New Font("Segoe UI", 14F)
        BForm_Star_TotalFee.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_TotalFee.Location = New Point(137, 3)
        BForm_Star_TotalFee.Name = "BForm_Star_TotalFee"
        BForm_Star_TotalFee.Size = New Size(20, 25)
        BForm_Star_TotalFee.TabIndex = 1
        BForm_Star_TotalFee.Text = "*"
        ' 
        ' BForm_Lbl_TotalFee
        ' 
        BForm_Lbl_TotalFee.AutoSize = True
        BForm_Lbl_TotalFee.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_Lbl_TotalFee.Location = New Point(49, 6)
        BForm_Lbl_TotalFee.Name = "BForm_Lbl_TotalFee"
        BForm_Lbl_TotalFee.Size = New Size(104, 17)
        BForm_Lbl_TotalFee.TabIndex = 0
        BForm_Lbl_TotalFee.Text = "Total Fee.: "
        ' 
        ' BForm_Panel_LID
        ' 
        BForm_Panel_LID.Controls.Add(BForm_ChkMark_LID)
        BForm_Panel_LID.Controls.Add(BForm_TxtBox_LID)
        BForm_Panel_LID.Controls.Add(BForm_ErrMsg_LID)
        BForm_Panel_LID.Controls.Add(TForm_Star_Fname)
        BForm_Panel_LID.Controls.Add(Bform_Lbl_LID)
        BForm_Panel_LID.Location = New Point(421, 16)
        BForm_Panel_LID.Name = "BForm_Panel_LID"
        BForm_Panel_LID.Size = New Size(379, 56)
        BForm_Panel_LID.TabIndex = 1
        ' 
        ' BForm_ChkMark_LID
        ' 
        BForm_ChkMark_LID.BackColor = Color.Transparent
        BForm_ChkMark_LID.Image = CType(resources.GetObject("BForm_ChkMark_LID.Image"), Image)
        BForm_ChkMark_LID.Location = New Point(351, 6)
        BForm_ChkMark_LID.Name = "BForm_ChkMark_LID"
        BForm_ChkMark_LID.Size = New Size(20, 20)
        BForm_ChkMark_LID.SizeMode = PictureBoxSizeMode.StretchImage
        BForm_ChkMark_LID.TabIndex = 5
        BForm_ChkMark_LID.TabStop = False
        BForm_ChkMark_LID.Visible = False
        ' 
        ' BForm_TxtBox_LID
        ' 
        BForm_TxtBox_LID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_TxtBox_LID.Location = New Point(163, 5)
        BForm_TxtBox_LID.Name = "BForm_TxtBox_LID"
        BForm_TxtBox_LID.Size = New Size(175, 23)
        BForm_TxtBox_LID.TabIndex = 3
        ' 
        ' BForm_ErrMsg_LID
        ' 
        BForm_ErrMsg_LID.AutoSize = True
        BForm_ErrMsg_LID.Font = New Font("Segoe UI", 10F)
        BForm_ErrMsg_LID.ForeColor = Color.Red
        BForm_ErrMsg_LID.Location = New Point(166, 31)
        BForm_ErrMsg_LID.Name = "BForm_ErrMsg_LID"
        BForm_ErrMsg_LID.Size = New Size(150, 19)
        BForm_ErrMsg_LID.TabIndex = 2
        BForm_ErrMsg_LID.Text = "Enter Learners ID here!"
        BForm_ErrMsg_LID.Visible = False
        ' 
        ' TForm_Star_Fname
        ' 
        TForm_Star_Fname.AutoSize = True
        TForm_Star_Fname.Font = New Font("Segoe UI", 14F)
        TForm_Star_Fname.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        TForm_Star_Fname.Location = New Point(137, 3)
        TForm_Star_Fname.Name = "TForm_Star_Fname"
        TForm_Star_Fname.Size = New Size(20, 25)
        TForm_Star_Fname.TabIndex = 1
        TForm_Star_Fname.Text = "*"
        ' 
        ' Bform_Lbl_LID
        ' 
        Bform_Lbl_LID.AutoSize = True
        Bform_Lbl_LID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        Bform_Lbl_LID.Location = New Point(33, 6)
        Bform_Lbl_LID.Name = "Bform_Lbl_LID"
        Bform_Lbl_LID.Size = New Size(120, 17)
        Bform_Lbl_LID.TabIndex = 0
        Bform_Lbl_LID.Text = "Learners ID.: "
        ' 
        ' BForm_Panel_BookID
        ' 
        BForm_Panel_BookID.Controls.Add(BForm_ChkMark_BookID)
        BForm_Panel_BookID.Controls.Add(BForm_TBox_BookID)
        BForm_Panel_BookID.Controls.Add(BForm_ErrMsg_BookID)
        BForm_Panel_BookID.Controls.Add(BForm_Star_BookID)
        BForm_Panel_BookID.Controls.Add(BForm_Lbl_BookID)
        BForm_Panel_BookID.Location = New Point(18, 16)
        BForm_Panel_BookID.Name = "BForm_Panel_BookID"
        BForm_Panel_BookID.Size = New Size(380, 56)
        BForm_Panel_BookID.TabIndex = 0
        ' 
        ' BForm_ChkMark_BookID
        ' 
        BForm_ChkMark_BookID.BackColor = Color.Transparent
        BForm_ChkMark_BookID.Image = CType(resources.GetObject("BForm_ChkMark_BookID.Image"), Image)
        BForm_ChkMark_BookID.Location = New Point(351, 5)
        BForm_ChkMark_BookID.Name = "BForm_ChkMark_BookID"
        BForm_ChkMark_BookID.Size = New Size(20, 20)
        BForm_ChkMark_BookID.SizeMode = PictureBoxSizeMode.StretchImage
        BForm_ChkMark_BookID.TabIndex = 4
        BForm_ChkMark_BookID.TabStop = False
        BForm_ChkMark_BookID.Visible = False
        ' 
        ' BForm_TBox_BookID
        ' 
        BForm_TBox_BookID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold)
        BForm_TBox_BookID.Location = New Point(166, 4)
        BForm_TBox_BookID.Name = "BForm_TBox_BookID"
        BForm_TBox_BookID.Size = New Size(175, 23)
        BForm_TBox_BookID.TabIndex = 3
        ' 
        ' BForm_ErrMsg_BookID
        ' 
        BForm_ErrMsg_BookID.AutoSize = True
        BForm_ErrMsg_BookID.Font = New Font("Segoe UI", 10F)
        BForm_ErrMsg_BookID.ForeColor = Color.Red
        BForm_ErrMsg_BookID.Location = New Point(162, 31)
        BForm_ErrMsg_BookID.Name = "BForm_ErrMsg_BookID"
        BForm_ErrMsg_BookID.Size = New Size(179, 19)
        BForm_ErrMsg_BookID.TabIndex = 2
        BForm_ErrMsg_BookID.Text = "Enter New Booking ID here!"
        BForm_ErrMsg_BookID.Visible = False
        ' 
        ' BForm_Star_BookID
        ' 
        BForm_Star_BookID.AutoSize = True
        BForm_Star_BookID.Font = New Font("Segoe UI", 14F)
        BForm_Star_BookID.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        BForm_Star_BookID.Location = New Point(144, 3)
        BForm_Star_BookID.Name = "BForm_Star_BookID"
        BForm_Star_BookID.Size = New Size(20, 25)
        BForm_Star_BookID.TabIndex = 1
        BForm_Star_BookID.Text = "*"
        ' 
        ' BForm_Lbl_BookID
        ' 
        BForm_Lbl_BookID.AutoSize = True
        BForm_Lbl_BookID.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BForm_Lbl_BookID.ForeColor = SystemColors.ControlText
        BForm_Lbl_BookID.Location = New Point(47, 6)
        BForm_Lbl_BookID.Name = "BForm_Lbl_BookID"
        BForm_Lbl_BookID.Size = New Size(112, 17)
        BForm_Lbl_BookID.TabIndex = 0
        BForm_Lbl_BookID.Text = "Booking ID.: "
        ' 
        ' BHeadULine_Title
        ' 
        BHeadULine_Title.BackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BHeadULine_Title.Location = New Point(10, 55)
        BHeadULine_Title.Name = "BHeadULine_Title"
        BHeadULine_Title.Size = New Size(1200, 2)
        BHeadULine_Title.TabIndex = 21
        ' 
        ' BMenuIcon_Trainers
        ' 
        BMenuIcon_Trainers.BackColor = Color.Transparent
        BMenuIcon_Trainers.Image = CType(resources.GetObject("BMenuIcon_Trainers.Image"), Image)
        BMenuIcon_Trainers.Location = New Point(599, 732)
        BMenuIcon_Trainers.Name = "BMenuIcon_Trainers"
        BMenuIcon_Trainers.Size = New Size(40, 40)
        BMenuIcon_Trainers.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_Trainers.TabIndex = 68
        BMenuIcon_Trainers.TabStop = False
        ' 
        ' BookingDGV
        ' 
        BookingDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BookingDGV.BackgroundColor = Color.GhostWhite
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        DataGridViewCellStyle2.Font = New Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BookingDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BookingDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BookingDGV.Columns.AddRange(New DataGridViewColumn() {BookLesson_ID, BookLesson_LID, BookLesson_TID, BookLesson_NumClasses, BookLesson_Course, BookLesson_Tariff, BookLesson_TFee, BookLesson_BookDate})
        BookingDGV.Location = New Point(14, 416)
        BookingDGV.Name = "BookingDGV"
        BookingDGV.Size = New Size(1192, 231)
        BookingDGV.TabIndex = 23
        ' 
        ' AppLogo
        ' 
        AppLogo.BackColor = Color.Transparent
        AppLogo.Image = CType(resources.GetObject("AppLogo.Image"), Image)
        AppLogo.Location = New Point(11, 10)
        AppLogo.Name = "AppLogo"
        AppLogo.Size = New Size(297, 50)
        AppLogo.SizeMode = PictureBoxSizeMode.StretchImage
        AppLogo.TabIndex = 61
        AppLogo.TabStop = False
        ' 
        ' B_Dashboard_Panel
        ' 
        B_Dashboard_Panel.BackColor = Color.FromArgb(CByte(225), CByte(209), CByte(252))
        B_Dashboard_Panel.Controls.Add(BookingDGV_Title)
        B_Dashboard_Panel.Controls.Add(BookingDGV)
        B_Dashboard_Panel.Controls.Add(BForm_TopPanel)
        B_Dashboard_Panel.Controls.Add(BHeadULine_Title)
        B_Dashboard_Panel.Controls.Add(BHeadLbl_Title)
        B_Dashboard_Panel.Controls.Add(BHeadIcon_Title)
        B_Dashboard_Panel.Location = New Point(10, 62)
        B_Dashboard_Panel.Name = "B_Dashboard_Panel"
        B_Dashboard_Panel.Size = New Size(1220, 662)
        B_Dashboard_Panel.TabIndex = 60
        ' 
        ' BookingDGV_Title
        ' 
        BookingDGV_Title.AutoSize = True
        BookingDGV_Title.BackColor = Color.Transparent
        BookingDGV_Title.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        BookingDGV_Title.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BookingDGV_Title.Location = New Point(529, 389)
        BookingDGV_Title.Name = "BookingDGV_Title"
        BookingDGV_Title.Size = New Size(163, 21)
        BookingDGV_Title.TabIndex = 24
        BookingDGV_Title.Text = "All Booking Records"
        ' 
        ' BHeadLbl_Title
        ' 
        BHeadLbl_Title.AutoSize = True
        BHeadLbl_Title.BackColor = Color.Transparent
        BHeadLbl_Title.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BHeadLbl_Title.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BHeadLbl_Title.Location = New Point(68, 22)
        BHeadLbl_Title.Name = "BHeadLbl_Title"
        BHeadLbl_Title.Size = New Size(219, 32)
        BHeadLbl_Title.TabIndex = 20
        BHeadLbl_Title.Text = "Manage Bookings"
        ' 
        ' BHeadIcon_Title
        ' 
        BHeadIcon_Title.BackColor = Color.Transparent
        BHeadIcon_Title.Image = CType(resources.GetObject("BHeadIcon_Title.Image"), Image)
        BHeadIcon_Title.Location = New Point(26, 15)
        BHeadIcon_Title.Name = "BHeadIcon_Title"
        BHeadIcon_Title.Size = New Size(40, 40)
        BHeadIcon_Title.SizeMode = PictureBoxSizeMode.StretchImage
        BHeadIcon_Title.TabIndex = 19
        BHeadIcon_Title.TabStop = False
        ' 
        ' BMenuIcon_Courses
        ' 
        BMenuIcon_Courses.BackColor = Color.Transparent
        BMenuIcon_Courses.Image = CType(resources.GetObject("BMenuIcon_Courses.Image"), Image)
        BMenuIcon_Courses.Location = New Point(753, 728)
        BMenuIcon_Courses.Name = "BMenuIcon_Courses"
        BMenuIcon_Courses.Size = New Size(44, 44)
        BMenuIcon_Courses.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_Courses.TabIndex = 70
        BMenuIcon_Courses.TabStop = False
        ' 
        ' BMenuIcon_Dashboard
        ' 
        BMenuIcon_Dashboard.BackColor = Color.Transparent
        BMenuIcon_Dashboard.Image = CType(resources.GetObject("BMenuIcon_Dashboard.Image"), Image)
        BMenuIcon_Dashboard.Location = New Point(291, 734)
        BMenuIcon_Dashboard.Name = "BMenuIcon_Dashboard"
        BMenuIcon_Dashboard.Size = New Size(40, 40)
        BMenuIcon_Dashboard.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_Dashboard.TabIndex = 64
        BMenuIcon_Dashboard.TabStop = False
        ' 
        ' BMenuIcon_Learners
        ' 
        BMenuIcon_Learners.BackColor = Color.Transparent
        BMenuIcon_Learners.Image = CType(resources.GetObject("BMenuIcon_Learners.Image"), Image)
        BMenuIcon_Learners.Location = New Point(445, 732)
        BMenuIcon_Learners.Name = "BMenuIcon_Learners"
        BMenuIcon_Learners.Size = New Size(40, 40)
        BMenuIcon_Learners.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_Learners.TabIndex = 66
        BMenuIcon_Learners.TabStop = False
        ' 
        ' BMenuLbl_Learners
        ' 
        BMenuLbl_Learners.AutoSize = True
        BMenuLbl_Learners.BackColor = Color.Transparent
        BMenuLbl_Learners.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BMenuLbl_Learners.ForeColor = Color.White
        BMenuLbl_Learners.Location = New Point(428, 771)
        BMenuLbl_Learners.Name = "BMenuLbl_Learners"
        BMenuLbl_Learners.Size = New Size(74, 21)
        BMenuLbl_Learners.TabIndex = 67
        BMenuLbl_Learners.Text = "Learners"
        ' 
        ' BMenuLbl_Dashboard
        ' 
        BMenuLbl_Dashboard.AutoSize = True
        BMenuLbl_Dashboard.BackColor = Color.Transparent
        BMenuLbl_Dashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BMenuLbl_Dashboard.ForeColor = Color.White
        BMenuLbl_Dashboard.Location = New Point(265, 771)
        BMenuLbl_Dashboard.Name = "BMenuLbl_Dashboard"
        BMenuLbl_Dashboard.Size = New Size(93, 21)
        BMenuLbl_Dashboard.TabIndex = 65
        BMenuLbl_Dashboard.Text = "Dashboard"
        ' 
        ' BMenuLbl_Courses
        ' 
        BMenuLbl_Courses.AutoSize = True
        BMenuLbl_Courses.BackColor = Color.Transparent
        BMenuLbl_Courses.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BMenuLbl_Courses.ForeColor = Color.White
        BMenuLbl_Courses.Location = New Point(741, 771)
        BMenuLbl_Courses.Name = "BMenuLbl_Courses"
        BMenuLbl_Courses.Size = New Size(69, 21)
        BMenuLbl_Courses.TabIndex = 71
        BMenuLbl_Courses.Text = "Courses"
        ' 
        ' BMenuIcon_BookLessons
        ' 
        BMenuIcon_BookLessons.BackColor = Color.Transparent
        BMenuIcon_BookLessons.Image = CType(resources.GetObject("BMenuIcon_BookLessons.Image"), Image)
        BMenuIcon_BookLessons.Location = New Point(911, 730)
        BMenuIcon_BookLessons.Name = "BMenuIcon_BookLessons"
        BMenuIcon_BookLessons.Size = New Size(40, 40)
        BMenuIcon_BookLessons.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_BookLessons.TabIndex = 72
        BMenuIcon_BookLessons.TabStop = False
        ' 
        ' BMenuLbl_BookLessons
        ' 
        BMenuLbl_BookLessons.AutoSize = True
        BMenuLbl_BookLessons.BackColor = Color.Transparent
        BMenuLbl_BookLessons.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BMenuLbl_BookLessons.ForeColor = Color.White
        BMenuLbl_BookLessons.Location = New Point(876, 771)
        BMenuLbl_BookLessons.Name = "BMenuLbl_BookLessons"
        BMenuLbl_BookLessons.Size = New Size(111, 21)
        BMenuLbl_BookLessons.TabIndex = 73
        BMenuLbl_BookLessons.Text = "Book Lessons"
        ' 
        ' BMenuLbl_Trainers
        ' 
        BMenuLbl_Trainers.AutoSize = True
        BMenuLbl_Trainers.BackColor = Color.Transparent
        BMenuLbl_Trainers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BMenuLbl_Trainers.ForeColor = Color.White
        BMenuLbl_Trainers.Location = New Point(584, 771)
        BMenuLbl_Trainers.Name = "BMenuLbl_Trainers"
        BMenuLbl_Trainers.Size = New Size(70, 21)
        BMenuLbl_Trainers.TabIndex = 69
        BMenuLbl_Trainers.Text = "Trainers"
        ' 
        ' BMenuIcon_Logout
        ' 
        BMenuIcon_Logout.BackColor = Color.Transparent
        BMenuIcon_Logout.Image = CType(resources.GetObject("BMenuIcon_Logout.Image"), Image)
        BMenuIcon_Logout.Location = New Point(10, 760)
        BMenuIcon_Logout.Name = "BMenuIcon_Logout"
        BMenuIcon_Logout.Size = New Size(30, 30)
        BMenuIcon_Logout.SizeMode = PictureBoxSizeMode.StretchImage
        BMenuIcon_Logout.TabIndex = 74
        BMenuIcon_Logout.TabStop = False
        ' 
        ' B_Mini_Btn_Icon
        ' 
        B_Mini_Btn_Icon.BackColor = Color.Transparent
        B_Mini_Btn_Icon.Image = CType(resources.GetObject("B_Mini_Btn_Icon.Image"), Image)
        B_Mini_Btn_Icon.Location = New Point(1178, 18)
        B_Mini_Btn_Icon.Name = "B_Mini_Btn_Icon"
        B_Mini_Btn_Icon.Size = New Size(20, 8)
        B_Mini_Btn_Icon.SizeMode = PictureBoxSizeMode.StretchImage
        B_Mini_Btn_Icon.TabIndex = 75
        B_Mini_Btn_Icon.TabStop = False
        ' 
        ' BCloseBtn_Icon
        ' 
        BCloseBtn_Icon.BackColor = Color.Transparent
        BCloseBtn_Icon.Image = CType(resources.GetObject("BCloseBtn_Icon.Image"), Image)
        BCloseBtn_Icon.InitialImage = CType(resources.GetObject("BCloseBtn_Icon.InitialImage"), Image)
        BCloseBtn_Icon.Location = New Point(1214, 9)
        BCloseBtn_Icon.Name = "BCloseBtn_Icon"
        BCloseBtn_Icon.Size = New Size(14, 14)
        BCloseBtn_Icon.SizeMode = PictureBoxSizeMode.StretchImage
        BCloseBtn_Icon.TabIndex = 76
        BCloseBtn_Icon.TabStop = False
        ' 
        ' BLogout_Btn
        ' 
        BLogout_Btn.AutoSize = True
        BLogout_Btn.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        BLogout_Btn.ForeColor = Color.White
        BLogout_Btn.Location = New Point(41, 765)
        BLogout_Btn.Name = "BLogout_Btn"
        BLogout_Btn.Size = New Size(57, 20)
        BLogout_Btn.TabIndex = 77
        BLogout_Btn.Text = "Loguot"
        ' 
        ' BookLesson_ID
        ' 
        BookLesson_ID.FillWeight = 40.60914F
        BookLesson_ID.HeaderText = "B.ID"
        BookLesson_ID.Name = "BookLesson_ID"
        ' 
        ' BookLesson_LID
        ' 
        BookLesson_LID.FillWeight = 108.484406F
        BookLesson_LID.HeaderText = "Learners ID"
        BookLesson_LID.Name = "BookLesson_LID"
        ' 
        ' BookLesson_TID
        ' 
        BookLesson_TID.FillWeight = 108.484406F
        BookLesson_TID.HeaderText = "Trainers ID"
        BookLesson_TID.Name = "BookLesson_TID"
        ' 
        ' BookLesson_NumClasses
        ' 
        BookLesson_NumClasses.FillWeight = 108.484406F
        BookLesson_NumClasses.HeaderText = "No.of_Classes."
        BookLesson_NumClasses.Name = "BookLesson_NumClasses"
        ' 
        ' BookLesson_Course
        ' 
        BookLesson_Course.FillWeight = 108.484406F
        BookLesson_Course.HeaderText = "Course"
        BookLesson_Course.Name = "BookLesson_Course"
        ' 
        ' BookLesson_Tariff
        ' 
        BookLesson_Tariff.FillWeight = 108.484406F
        BookLesson_Tariff.HeaderText = "Tarrif/Hour"
        BookLesson_Tariff.Name = "BookLesson_Tariff"
        ' 
        ' BookLesson_TFee
        ' 
        BookLesson_TFee.FillWeight = 108.484406F
        BookLesson_TFee.HeaderText = "Total Fee"
        BookLesson_TFee.Name = "BookLesson_TFee"
        ' 
        ' BookLesson_BookDate
        ' 
        BookLesson_BookDate.FillWeight = 108.484406F
        BookLesson_BookDate.HeaderText = "Booking Date"
        BookLesson_BookDate.Name = "BookLesson_BookDate"
        ' 
        ' BookLessons
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1240, 800)
        ControlBox = False
        Controls.Add(BLogout_Btn)
        Controls.Add(BCloseBtn_Icon)
        Controls.Add(B_Mini_Btn_Icon)
        Controls.Add(BMenuIcon_Trainers)
        Controls.Add(AppLogo)
        Controls.Add(B_Dashboard_Panel)
        Controls.Add(BMenuIcon_Courses)
        Controls.Add(BMenuIcon_Dashboard)
        Controls.Add(BMenuIcon_Learners)
        Controls.Add(BMenuLbl_Learners)
        Controls.Add(BMenuLbl_Dashboard)
        Controls.Add(BMenuLbl_Courses)
        Controls.Add(BMenuIcon_BookLessons)
        Controls.Add(BMenuLbl_BookLessons)
        Controls.Add(BMenuLbl_Trainers)
        Controls.Add(BMenuIcon_Logout)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BookLessons"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BookLessons"
        BForm_Panel_Course.ResumeLayout(False)
        BForm_Panel_Course.PerformLayout()
        BForm_TopPanel.ResumeLayout(False)
        BForm_Panel_BookDate.ResumeLayout(False)
        BForm_Panel_BookDate.PerformLayout()
        BForm_Panel_Tariff.ResumeLayout(False)
        BForm_Panel_Tariff.PerformLayout()
        CType(BForm_NumBox_Tariff, ComponentModel.ISupportInitialize).EndInit()
        BForm_Panel_TID.ResumeLayout(False)
        BForm_Panel_TID.PerformLayout()
        CType(BForm_ChkMark_TID, ComponentModel.ISupportInitialize).EndInit()
        BForm_Panel_NumClasses.ResumeLayout(False)
        BForm_Panel_NumClasses.PerformLayout()
        CType(BForm_NumBox_NClasses, ComponentModel.ISupportInitialize).EndInit()
        BForm_Panel_TotalFee.ResumeLayout(False)
        BForm_Panel_TotalFee.PerformLayout()
        BForm_Panel_LID.ResumeLayout(False)
        BForm_Panel_LID.PerformLayout()
        CType(BForm_ChkMark_LID, ComponentModel.ISupportInitialize).EndInit()
        BForm_Panel_BookID.ResumeLayout(False)
        BForm_Panel_BookID.PerformLayout()
        CType(BForm_ChkMark_BookID, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_Trainers, ComponentModel.ISupportInitialize).EndInit()
        CType(BookingDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(AppLogo, ComponentModel.ISupportInitialize).EndInit()
        B_Dashboard_Panel.ResumeLayout(False)
        B_Dashboard_Panel.PerformLayout()
        CType(BHeadIcon_Title, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_Courses, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_Dashboard, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_Learners, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_BookLessons, ComponentModel.ISupportInitialize).EndInit()
        CType(BMenuIcon_Logout, ComponentModel.ISupportInitialize).EndInit()
        CType(B_Mini_Btn_Icon, ComponentModel.ISupportInitialize).EndInit()
        CType(BCloseBtn_Icon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BForm_Panel_Course As Panel
    Friend WithEvents BForm_ErrMsg_Course As Label
    Friend WithEvents BForm_lbl_Courses As Label
    Friend WithEvents BForm_TopPanel As Panel
    Friend WithEvents BForm_Btn_Update As Button
    Friend WithEvents BForm_Btn_Book As Button
    Friend WithEvents BForm_Panel_BookDate As Panel
    Friend WithEvents BForm_Star_BookDate As Label
    Friend WithEvents BForm_Lbl_BookDate As Label
    Friend WithEvents BForm_Panel_Tariff As Panel
    Friend WithEvents Tform_Lbl_Tariff As Label
    Friend WithEvents BForm_NumBox_Tariff As NumericUpDown
    Friend WithEvents TForm_ErrMsg_Tariff As Label
    Friend WithEvents BForm_Panel_TID As Panel
    Friend WithEvents BForm_ErrMsg_TID As Label
    Friend WithEvents BForm_Star_TID As Label
    Friend WithEvents BForm_Lbl_TID As Label
    Friend WithEvents BForm_Panel_NumClasses As Panel
    Friend WithEvents BForm_ErrMsg_NumClasses As Label
    Friend WithEvents BForm_Star_NumClasses As Label
    Friend WithEvents BForm_Lbl_NumClasses As Label
    Friend WithEvents BForm_Panel_TotalFee As Panel
    Friend WithEvents BForm_TBox_TotalFee As TextBox
    Friend WithEvents BForm_Star_TotalFee As Label
    Friend WithEvents BForm_Lbl_TotalFee As Label
    Friend WithEvents BForm_Panel_LID As Panel
    Friend WithEvents BForm_ErrMsg_LID As Label
    Friend WithEvents TForm_Star_Fname As Label
    Friend WithEvents Bform_Lbl_LID As Label
    Friend WithEvents BForm_Panel_BookID As Panel
    Friend WithEvents BForm_ChkMark_BookID As PictureBox
    Friend WithEvents BForm_TBox_BookID As TextBox
    Friend WithEvents BForm_ErrMsg_BookID As Label
    Friend WithEvents BForm_Star_BookID As Label
    Friend WithEvents BForm_Lbl_BookID As Label
    Friend WithEvents BHeadULine_Title As Panel
    Friend WithEvents BMenuIcon_Trainers As PictureBox
    Friend WithEvents BookingDGV As DataGridView
    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents B_Dashboard_Panel As Panel
    Friend WithEvents BookingDGV_Title As Label
    Friend WithEvents BHeadLbl_Title As Label
    Friend WithEvents BHeadIcon_Title As PictureBox
    Friend WithEvents BMenuIcon_Courses As PictureBox
    Friend WithEvents BMenuIcon_Dashboard As PictureBox
    Friend WithEvents BMenuIcon_Learners As PictureBox
    Friend WithEvents BMenuLbl_Learners As Label
    Friend WithEvents BMenuLbl_Dashboard As Label
    Friend WithEvents BMenuLbl_Courses As Label
    Friend WithEvents BMenuIcon_BookLessons As PictureBox
    Friend WithEvents BMenuLbl_BookLessons As Label
    Friend WithEvents BMenuLbl_Trainers As Label
    Friend WithEvents BMenuIcon_Logout As PictureBox
    Friend WithEvents BForm_Radio1_Course As RadioButton
    Friend WithEvents BForm_Radio4_Course As RadioButton
    Friend WithEvents BForm_Radio3_Course As RadioButton
    Friend WithEvents BForm_Radio2_Course As RadioButton
    Friend WithEvents BForm_DatePick_BookDate As DateTimePicker
    Friend WithEvents BForm_Star_Course As Label
    Friend WithEvents BForm_NumBox_NClasses As NumericUpDown
    Friend WithEvents B_Mini_Btn_Icon As PictureBox
    Friend WithEvents BForm_ChkMark_TID As PictureBox
    Friend WithEvents BForm_TxtBox_TID As TextBox
    Friend WithEvents BForm_TxtBox_LID As TextBox
    Friend WithEvents BCloseBtn_Icon As PictureBox
    Friend WithEvents BForm_Btn_Cancel As Button
    Friend WithEvents BLogout_Btn As Label
    Friend WithEvents BForm_ChkMark_LID As PictureBox
    Friend WithEvents BookLesson_ID As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_LID As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_TID As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_NumClasses As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_Course As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_Tariff As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_TFee As DataGridViewTextBoxColumn
    Friend WithEvents BookLesson_BookDate As DataGridViewTextBoxColumn
End Class
