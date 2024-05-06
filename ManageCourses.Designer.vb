<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageCourses))
        MCMenuIcon_Trainers = New PictureBox()
        MCCloseBtn_Icon = New PictureBox()
        AppLogoTitle = New PictureBox()
        AppLogo = New PictureBox()
        MC_Dashboard_Panel = New Panel()
        MC_Refresh_Btn = New PictureBox()
        ManageCoursesDGV_Title = New Label()
        ManageCoursesDGV = New DataGridView()
        M_Courses_ID = New DataGridViewTextBoxColumn()
        M_Courses_Cname = New DataGridViewTextBoxColumn()
        M_Courses_Desc = New DataGridViewTextBoxColumn()
        MCForm_TopPanel = New Panel()
        MCForm_Btn_Update = New Button()
        MCForm_Btn_Add = New Button()
        MCForm_Panel_CName = New Panel()
        MCForm_TBox_CName = New TextBox()
        MCForm_ChkMark_CName = New PictureBox()
        MCForm_ErrMsg_CName = New Label()
        MCForm_Star_CName = New Label()
        MC_Form_Lbl_CName = New Label()
        MCForm_Panel_Desc = New Panel()
        MCForm_TBox_Desc = New TextBox()
        MCForm_Lbl_Desc = New Label()
        MCForm_Panel_ID = New Panel()
        MCForm_ChkMark_ID = New PictureBox()
        MCForm_TBox_ID = New TextBox()
        MCForm_ErrMsg_ID = New Label()
        MCForm_Star_ID = New Label()
        MCForm_Lbl_ID = New Label()
        MCHeadULine_Title = New Panel()
        MCHeadLbl_Title = New Label()
        MCHeadIcon_Title = New PictureBox()
        MCMenuLbl_Learners = New Label()
        MCMenuLbl_Dashboard = New Label()
        MCMenuIcon_Dashboard = New PictureBox()
        MCMenuIcon_Learners = New PictureBox()
        MCMenuIcon_Courses = New PictureBox()
        MCMenuLbl_Courses = New Label()
        MCMenuIcon_BookLessons = New PictureBox()
        MCMenuIcon_Logout = New PictureBox()
        MCMenuLbl_Trainers = New Label()
        MCMenuLbl_BookLessons = New Label()
        MG_Mini_Btn_Icon = New PictureBox()
        CType(MCMenuIcon_Trainers, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCCloseBtn_Icon, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppLogoTitle, ComponentModel.ISupportInitialize).BeginInit()
        CType(AppLogo, ComponentModel.ISupportInitialize).BeginInit()
        MC_Dashboard_Panel.SuspendLayout()
        CType(MC_Refresh_Btn, ComponentModel.ISupportInitialize).BeginInit()
        CType(ManageCoursesDGV, ComponentModel.ISupportInitialize).BeginInit()
        MCForm_TopPanel.SuspendLayout()
        MCForm_Panel_CName.SuspendLayout()
        CType(MCForm_ChkMark_CName, ComponentModel.ISupportInitialize).BeginInit()
        MCForm_Panel_Desc.SuspendLayout()
        MCForm_Panel_ID.SuspendLayout()
        CType(MCForm_ChkMark_ID, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCHeadIcon_Title, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCMenuIcon_Dashboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCMenuIcon_Learners, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCMenuIcon_Courses, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCMenuIcon_BookLessons, ComponentModel.ISupportInitialize).BeginInit()
        CType(MCMenuIcon_Logout, ComponentModel.ISupportInitialize).BeginInit()
        CType(MG_Mini_Btn_Icon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MCMenuIcon_Trainers
        ' 
        MCMenuIcon_Trainers.BackColor = Color.Transparent
        MCMenuIcon_Trainers.Image = CType(resources.GetObject("MCMenuIcon_Trainers.Image"), Image)
        MCMenuIcon_Trainers.Location = New Point(605, 734)
        MCMenuIcon_Trainers.Name = "MCMenuIcon_Trainers"
        MCMenuIcon_Trainers.Size = New Size(32, 32)
        MCMenuIcon_Trainers.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_Trainers.TabIndex = 68
        MCMenuIcon_Trainers.TabStop = False
        ' 
        ' MCCloseBtn_Icon
        ' 
        MCCloseBtn_Icon.BackColor = Color.Transparent
        MCCloseBtn_Icon.Image = CType(resources.GetObject("MCCloseBtn_Icon.Image"), Image)
        MCCloseBtn_Icon.Location = New Point(1214, 9)
        MCCloseBtn_Icon.Name = "MCCloseBtn_Icon"
        MCCloseBtn_Icon.Size = New Size(14, 14)
        MCCloseBtn_Icon.SizeMode = PictureBoxSizeMode.StretchImage
        MCCloseBtn_Icon.TabIndex = 63
        MCCloseBtn_Icon.TabStop = False
        ' 
        ' AppLogoTitle
        ' 
        AppLogoTitle.BackColor = Color.Transparent
        AppLogoTitle.Image = CType(resources.GetObject("AppLogoTitle.Image"), Image)
        AppLogoTitle.Location = New Point(395, 20)
        AppLogoTitle.Name = "AppLogoTitle"
        AppLogoTitle.Size = New Size(444, 36)
        AppLogoTitle.SizeMode = PictureBoxSizeMode.StretchImage
        AppLogoTitle.TabIndex = 62
        AppLogoTitle.TabStop = False
        ' 
        ' AppLogo
        ' 
        AppLogo.BackColor = Color.Transparent
        AppLogo.Image = CType(resources.GetObject("AppLogo.Image"), Image)
        AppLogo.Location = New Point(10, 9)
        AppLogo.Name = "AppLogo"
        AppLogo.Size = New Size(167, 47)
        AppLogo.SizeMode = PictureBoxSizeMode.StretchImage
        AppLogo.TabIndex = 61
        AppLogo.TabStop = False
        ' 
        ' MC_Dashboard_Panel
        ' 
        MC_Dashboard_Panel.BackColor = Color.FromArgb(CByte(249), CByte(255), CByte(238))
        MC_Dashboard_Panel.Controls.Add(MC_Refresh_Btn)
        MC_Dashboard_Panel.Controls.Add(ManageCoursesDGV_Title)
        MC_Dashboard_Panel.Controls.Add(ManageCoursesDGV)
        MC_Dashboard_Panel.Controls.Add(MCForm_TopPanel)
        MC_Dashboard_Panel.Controls.Add(MCHeadULine_Title)
        MC_Dashboard_Panel.Controls.Add(MCHeadLbl_Title)
        MC_Dashboard_Panel.Controls.Add(MCHeadIcon_Title)
        MC_Dashboard_Panel.Location = New Point(10, 62)
        MC_Dashboard_Panel.Name = "MC_Dashboard_Panel"
        MC_Dashboard_Panel.Size = New Size(1220, 662)
        MC_Dashboard_Panel.TabIndex = 60
        ' 
        ' MC_Refresh_Btn
        ' 
        MC_Refresh_Btn.BackColor = Color.Transparent
        MC_Refresh_Btn.Image = CType(resources.GetObject("MC_Refresh_Btn.Image"), Image)
        MC_Refresh_Btn.Location = New Point(1186, 15)
        MC_Refresh_Btn.Name = "MC_Refresh_Btn"
        MC_Refresh_Btn.Size = New Size(20, 20)
        MC_Refresh_Btn.SizeMode = PictureBoxSizeMode.StretchImage
        MC_Refresh_Btn.TabIndex = 25
        MC_Refresh_Btn.TabStop = False
        ' 
        ' ManageCoursesDGV_Title
        ' 
        ManageCoursesDGV_Title.AutoSize = True
        ManageCoursesDGV_Title.BackColor = Color.Transparent
        ManageCoursesDGV_Title.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ManageCoursesDGV_Title.ForeColor = Color.FromArgb(CByte(72), CByte(113), CByte(232))
        ManageCoursesDGV_Title.Location = New Point(531, 389)
        ManageCoursesDGV_Title.Name = "ManageCoursesDGV_Title"
        ManageCoursesDGV_Title.Size = New Size(159, 21)
        ManageCoursesDGV_Title.TabIndex = 24
        ManageCoursesDGV_Title.Text = "All Trainers Records"
        ' 
        ' ManageCoursesDGV
        ' 
        ManageCoursesDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ManageCoursesDGV.BackgroundColor = SystemColors.ControlLight
        ManageCoursesDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ManageCoursesDGV.Columns.AddRange(New DataGridViewColumn() {M_Courses_ID, M_Courses_Cname, M_Courses_Desc})
        ManageCoursesDGV.Location = New Point(14, 416)
        ManageCoursesDGV.Name = "ManageCoursesDGV"
        ManageCoursesDGV.Size = New Size(1192, 231)
        ManageCoursesDGV.TabIndex = 23
        ' 
        ' M_Courses_ID
        ' 
        M_Courses_ID.FillWeight = 44.07121F
        M_Courses_ID.HeaderText = "Course ID"
        M_Courses_ID.MinimumWidth = 10
        M_Courses_ID.Name = "M_Courses_ID"
        ' 
        ' M_Courses_Cname
        ' 
        M_Courses_Cname.FillWeight = 60.9137039F
        M_Courses_Cname.HeaderText = "Course Name"
        M_Courses_Cname.MinimumWidth = 10
        M_Courses_Cname.Name = "M_Courses_Cname"
        ' 
        ' M_Courses_Desc
        ' 
        M_Courses_Desc.FillWeight = 195.0151F
        M_Courses_Desc.HeaderText = "Last Name"
        M_Courses_Desc.MinimumWidth = 10
        M_Courses_Desc.Name = "M_Courses_Desc"
        ' 
        ' MCForm_TopPanel
        ' 
        MCForm_TopPanel.Controls.Add(MCForm_Btn_Update)
        MCForm_TopPanel.Controls.Add(MCForm_Btn_Add)
        MCForm_TopPanel.Controls.Add(MCForm_Panel_CName)
        MCForm_TopPanel.Controls.Add(MCForm_Panel_Desc)
        MCForm_TopPanel.Controls.Add(MCForm_Panel_ID)
        MCForm_TopPanel.Location = New Point(15, 90)
        MCForm_TopPanel.Name = "MCForm_TopPanel"
        MCForm_TopPanel.Size = New Size(1192, 282)
        MCForm_TopPanel.TabIndex = 22
        ' 
        ' MCForm_Btn_Update
        ' 
        MCForm_Btn_Update.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        MCForm_Btn_Update.FlatStyle = FlatStyle.Flat
        MCForm_Btn_Update.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MCForm_Btn_Update.ForeColor = Color.White
        MCForm_Btn_Update.Location = New Point(1039, 75)
        MCForm_Btn_Update.Name = "MCForm_Btn_Update"
        MCForm_Btn_Update.Size = New Size(95, 32)
        MCForm_Btn_Update.TabIndex = 10
        MCForm_Btn_Update.Text = "Update"
        MCForm_Btn_Update.UseVisualStyleBackColor = False
        ' 
        ' MCForm_Btn_Add
        ' 
        MCForm_Btn_Add.BackColor = Color.FromArgb(CByte(72), CByte(113), CByte(232))
        MCForm_Btn_Add.FlatStyle = FlatStyle.Flat
        MCForm_Btn_Add.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        MCForm_Btn_Add.ForeColor = Color.White
        MCForm_Btn_Add.Location = New Point(933, 75)
        MCForm_Btn_Add.Name = "MCForm_Btn_Add"
        MCForm_Btn_Add.Size = New Size(95, 32)
        MCForm_Btn_Add.TabIndex = 9
        MCForm_Btn_Add.Text = "Add"
        MCForm_Btn_Add.UseVisualStyleBackColor = False
        ' 
        ' MCForm_Panel_CName
        ' 
        MCForm_Panel_CName.Controls.Add(MCForm_TBox_CName)
        MCForm_Panel_CName.Controls.Add(MCForm_ChkMark_CName)
        MCForm_Panel_CName.Controls.Add(MCForm_ErrMsg_CName)
        MCForm_Panel_CName.Controls.Add(MCForm_Star_CName)
        MCForm_Panel_CName.Controls.Add(MC_Form_Lbl_CName)
        MCForm_Panel_CName.Location = New Point(18, 78)
        MCForm_Panel_CName.Name = "MCForm_Panel_CName"
        MCForm_Panel_CName.Size = New Size(358, 56)
        MCForm_Panel_CName.TabIndex = 6
        ' 
        ' MCForm_TBox_CName
        ' 
        MCForm_TBox_CName.Font = New Font("Segoe UI", 10F)
        MCForm_TBox_CName.Location = New Point(120, 6)
        MCForm_TBox_CName.Name = "MCForm_TBox_CName"
        MCForm_TBox_CName.Size = New Size(200, 25)
        MCForm_TBox_CName.TabIndex = 5
        ' 
        ' MCForm_ChkMark_CName
        ' 
        MCForm_ChkMark_CName.BackColor = Color.Transparent
        MCForm_ChkMark_CName.Image = CType(resources.GetObject("MCForm_ChkMark_CName.Image"), Image)
        MCForm_ChkMark_CName.Location = New Point(329, 5)
        MCForm_ChkMark_CName.Name = "MCForm_ChkMark_CName"
        MCForm_ChkMark_CName.Size = New Size(20, 20)
        MCForm_ChkMark_CName.SizeMode = PictureBoxSizeMode.StretchImage
        MCForm_ChkMark_CName.TabIndex = 4
        MCForm_ChkMark_CName.TabStop = False
        MCForm_ChkMark_CName.Visible = False
        ' 
        ' MCForm_ErrMsg_CName
        ' 
        MCForm_ErrMsg_CName.AutoSize = True
        MCForm_ErrMsg_CName.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MCForm_ErrMsg_CName.ForeColor = Color.Red
        MCForm_ErrMsg_CName.Location = New Point(120, 31)
        MCForm_ErrMsg_CName.Name = "MCForm_ErrMsg_CName"
        MCForm_ErrMsg_CName.Size = New Size(194, 17)
        MCForm_ErrMsg_CName.TabIndex = 2
        MCForm_ErrMsg_CName.Text = "enter course name in this box ..."
        MCForm_ErrMsg_CName.Visible = False
        ' 
        ' MCForm_Star_CName
        ' 
        MCForm_Star_CName.AutoSize = True
        MCForm_Star_CName.Font = New Font("Segoe UI", 14F)
        MCForm_Star_CName.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        MCForm_Star_CName.Location = New Point(96, 3)
        MCForm_Star_CName.Name = "MCForm_Star_CName"
        MCForm_Star_CName.Size = New Size(20, 25)
        MCForm_Star_CName.TabIndex = 1
        MCForm_Star_CName.Text = "*"
        ' 
        ' MC_Form_Lbl_CName
        ' 
        MC_Form_Lbl_CName.AutoSize = True
        MC_Form_Lbl_CName.Font = New Font("Segoe UI", 10F)
        MC_Form_Lbl_CName.Location = New Point(3, 6)
        MC_Form_Lbl_CName.Name = "MC_Form_Lbl_CName"
        MC_Form_Lbl_CName.Size = New Size(103, 19)
        MC_Form_Lbl_CName.TabIndex = 0
        MC_Form_Lbl_CName.Text = "Course Name : "
        ' 
        ' MCForm_Panel_Desc
        ' 
        MCForm_Panel_Desc.Controls.Add(MCForm_TBox_Desc)
        MCForm_Panel_Desc.Controls.Add(MCForm_Lbl_Desc)
        MCForm_Panel_Desc.Location = New Point(416, 16)
        MCForm_Panel_Desc.Name = "MCForm_Panel_Desc"
        MCForm_Panel_Desc.Size = New Size(506, 118)
        MCForm_Panel_Desc.TabIndex = 1
        ' 
        ' MCForm_TBox_Desc
        ' 
        MCForm_TBox_Desc.Font = New Font("Segoe UI", 12F)
        MCForm_TBox_Desc.Location = New Point(100, 3)
        MCForm_TBox_Desc.Multiline = True
        MCForm_TBox_Desc.Name = "MCForm_TBox_Desc"
        MCForm_TBox_Desc.Size = New Size(360, 90)
        MCForm_TBox_Desc.TabIndex = 3
        ' 
        ' MCForm_Lbl_Desc
        ' 
        MCForm_Lbl_Desc.AutoSize = True
        MCForm_Lbl_Desc.Font = New Font("Segoe UI", 10F)
        MCForm_Lbl_Desc.Location = New Point(10, 6)
        MCForm_Lbl_Desc.Name = "MCForm_Lbl_Desc"
        MCForm_Lbl_Desc.Size = New Size(89, 19)
        MCForm_Lbl_Desc.TabIndex = 0
        MCForm_Lbl_Desc.Text = "Description : "
        ' 
        ' MCForm_Panel_ID
        ' 
        MCForm_Panel_ID.Controls.Add(MCForm_ChkMark_ID)
        MCForm_Panel_ID.Controls.Add(MCForm_TBox_ID)
        MCForm_Panel_ID.Controls.Add(MCForm_ErrMsg_ID)
        MCForm_Panel_ID.Controls.Add(MCForm_Star_ID)
        MCForm_Panel_ID.Controls.Add(MCForm_Lbl_ID)
        MCForm_Panel_ID.Location = New Point(18, 16)
        MCForm_Panel_ID.Name = "MCForm_Panel_ID"
        MCForm_Panel_ID.Size = New Size(358, 56)
        MCForm_Panel_ID.TabIndex = 0
        ' 
        ' MCForm_ChkMark_ID
        ' 
        MCForm_ChkMark_ID.BackColor = Color.Transparent
        MCForm_ChkMark_ID.Image = CType(resources.GetObject("MCForm_ChkMark_ID.Image"), Image)
        MCForm_ChkMark_ID.Location = New Point(329, 5)
        MCForm_ChkMark_ID.Name = "MCForm_ChkMark_ID"
        MCForm_ChkMark_ID.Size = New Size(20, 20)
        MCForm_ChkMark_ID.SizeMode = PictureBoxSizeMode.StretchImage
        MCForm_ChkMark_ID.TabIndex = 4
        MCForm_ChkMark_ID.TabStop = False
        MCForm_ChkMark_ID.Visible = False
        ' 
        ' MCForm_TBox_ID
        ' 
        MCForm_TBox_ID.Font = New Font("Segoe UI", 10F)
        MCForm_TBox_ID.Location = New Point(120, 3)
        MCForm_TBox_ID.Name = "MCForm_TBox_ID"
        MCForm_TBox_ID.Size = New Size(200, 25)
        MCForm_TBox_ID.TabIndex = 3
        ' 
        ' MCForm_ErrMsg_ID
        ' 
        MCForm_ErrMsg_ID.AutoSize = True
        MCForm_ErrMsg_ID.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MCForm_ErrMsg_ID.ForeColor = Color.Red
        MCForm_ErrMsg_ID.Location = New Point(120, 31)
        MCForm_ErrMsg_ID.Name = "MCForm_ErrMsg_ID"
        MCForm_ErrMsg_ID.Size = New Size(167, 17)
        MCForm_ErrMsg_ID.TabIndex = 2
        MCForm_ErrMsg_ID.Text = "enter new course ID here ..."
        MCForm_ErrMsg_ID.Visible = False
        ' 
        ' MCForm_Star_ID
        ' 
        MCForm_Star_ID.AutoSize = True
        MCForm_Star_ID.Font = New Font("Segoe UI", 14F)
        MCForm_Star_ID.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        MCForm_Star_ID.Location = New Point(96, 3)
        MCForm_Star_ID.Name = "MCForm_Star_ID"
        MCForm_Star_ID.Size = New Size(20, 25)
        MCForm_Star_ID.TabIndex = 1
        MCForm_Star_ID.Text = "*"
        ' 
        ' MCForm_Lbl_ID
        ' 
        MCForm_Lbl_ID.AutoSize = True
        MCForm_Lbl_ID.Font = New Font("Segoe UI", 10F)
        MCForm_Lbl_ID.Location = New Point(22, 6)
        MCForm_Lbl_ID.Name = "MCForm_Lbl_ID"
        MCForm_Lbl_ID.Size = New Size(84, 19)
        MCForm_Lbl_ID.TabIndex = 0
        MCForm_Lbl_ID.Text = "Course ID. : "
        ' 
        ' MCHeadULine_Title
        ' 
        MCHeadULine_Title.BackColor = Color.Gold
        MCHeadULine_Title.Location = New Point(10, 55)
        MCHeadULine_Title.Name = "MCHeadULine_Title"
        MCHeadULine_Title.Size = New Size(1200, 2)
        MCHeadULine_Title.TabIndex = 21
        ' 
        ' MCHeadLbl_Title
        ' 
        MCHeadLbl_Title.AutoSize = True
        MCHeadLbl_Title.BackColor = Color.Transparent
        MCHeadLbl_Title.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCHeadLbl_Title.ForeColor = Color.FromArgb(CByte(72), CByte(113), CByte(232))
        MCHeadLbl_Title.Location = New Point(68, 17)
        MCHeadLbl_Title.Name = "MCHeadLbl_Title"
        MCHeadLbl_Title.Size = New Size(174, 30)
        MCHeadLbl_Title.TabIndex = 20
        MCHeadLbl_Title.Text = "Manage Courses"
        ' 
        ' MCHeadIcon_Title
        ' 
        MCHeadIcon_Title.BackColor = Color.Transparent
        MCHeadIcon_Title.Image = CType(resources.GetObject("MCHeadIcon_Title.Image"), Image)
        MCHeadIcon_Title.Location = New Point(26, 15)
        MCHeadIcon_Title.Name = "MCHeadIcon_Title"
        MCHeadIcon_Title.Size = New Size(32, 32)
        MCHeadIcon_Title.SizeMode = PictureBoxSizeMode.StretchImage
        MCHeadIcon_Title.TabIndex = 19
        MCHeadIcon_Title.TabStop = False
        ' 
        ' MCMenuLbl_Learners
        ' 
        MCMenuLbl_Learners.AutoSize = True
        MCMenuLbl_Learners.BackColor = Color.Transparent
        MCMenuLbl_Learners.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCMenuLbl_Learners.ForeColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        MCMenuLbl_Learners.Location = New Point(429, 771)
        MCMenuLbl_Learners.Name = "MCMenuLbl_Learners"
        MCMenuLbl_Learners.Size = New Size(74, 21)
        MCMenuLbl_Learners.TabIndex = 67
        MCMenuLbl_Learners.Text = "Learners"
        ' 
        ' MCMenuLbl_Dashboard
        ' 
        MCMenuLbl_Dashboard.AutoSize = True
        MCMenuLbl_Dashboard.BackColor = Color.Transparent
        MCMenuLbl_Dashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCMenuLbl_Dashboard.ForeColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        MCMenuLbl_Dashboard.Location = New Point(265, 771)
        MCMenuLbl_Dashboard.Name = "MCMenuLbl_Dashboard"
        MCMenuLbl_Dashboard.Size = New Size(93, 21)
        MCMenuLbl_Dashboard.TabIndex = 65
        MCMenuLbl_Dashboard.Text = "Dashboard"
        ' 
        ' MCMenuIcon_Dashboard
        ' 
        MCMenuIcon_Dashboard.BackColor = Color.Transparent
        MCMenuIcon_Dashboard.Image = CType(resources.GetObject("MCMenuIcon_Dashboard.Image"), Image)
        MCMenuIcon_Dashboard.Location = New Point(295, 734)
        MCMenuIcon_Dashboard.Name = "MCMenuIcon_Dashboard"
        MCMenuIcon_Dashboard.Size = New Size(32, 32)
        MCMenuIcon_Dashboard.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_Dashboard.TabIndex = 64
        MCMenuIcon_Dashboard.TabStop = False
        ' 
        ' MCMenuIcon_Learners
        ' 
        MCMenuIcon_Learners.BackColor = Color.Transparent
        MCMenuIcon_Learners.Image = CType(resources.GetObject("MCMenuIcon_Learners.Image"), Image)
        MCMenuIcon_Learners.Location = New Point(450, 734)
        MCMenuIcon_Learners.Name = "MCMenuIcon_Learners"
        MCMenuIcon_Learners.Size = New Size(32, 32)
        MCMenuIcon_Learners.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_Learners.TabIndex = 66
        MCMenuIcon_Learners.TabStop = False
        ' 
        ' MCMenuIcon_Courses
        ' 
        MCMenuIcon_Courses.BackColor = Color.Transparent
        MCMenuIcon_Courses.Image = CType(resources.GetObject("MCMenuIcon_Courses.Image"), Image)
        MCMenuIcon_Courses.Location = New Point(760, 734)
        MCMenuIcon_Courses.Name = "MCMenuIcon_Courses"
        MCMenuIcon_Courses.Size = New Size(32, 32)
        MCMenuIcon_Courses.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_Courses.TabIndex = 70
        MCMenuIcon_Courses.TabStop = False
        ' 
        ' MCMenuLbl_Courses
        ' 
        MCMenuLbl_Courses.AutoSize = True
        MCMenuLbl_Courses.BackColor = Color.Transparent
        MCMenuLbl_Courses.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCMenuLbl_Courses.ForeColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        MCMenuLbl_Courses.Location = New Point(742, 771)
        MCMenuLbl_Courses.Name = "MCMenuLbl_Courses"
        MCMenuLbl_Courses.Size = New Size(69, 21)
        MCMenuLbl_Courses.TabIndex = 71
        MCMenuLbl_Courses.Text = "Courses"
        ' 
        ' MCMenuIcon_BookLessons
        ' 
        MCMenuIcon_BookLessons.BackColor = Color.Transparent
        MCMenuIcon_BookLessons.Image = CType(resources.GetObject("MCMenuIcon_BookLessons.Image"), Image)
        MCMenuIcon_BookLessons.Location = New Point(915, 734)
        MCMenuIcon_BookLessons.Name = "MCMenuIcon_BookLessons"
        MCMenuIcon_BookLessons.Size = New Size(32, 32)
        MCMenuIcon_BookLessons.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_BookLessons.TabIndex = 72
        MCMenuIcon_BookLessons.TabStop = False
        ' 
        ' MCMenuIcon_Logout
        ' 
        MCMenuIcon_Logout.BackColor = Color.Transparent
        MCMenuIcon_Logout.Image = CType(resources.GetObject("MCMenuIcon_Logout.Image"), Image)
        MCMenuIcon_Logout.Location = New Point(10, 760)
        MCMenuIcon_Logout.Name = "MCMenuIcon_Logout"
        MCMenuIcon_Logout.Size = New Size(24, 24)
        MCMenuIcon_Logout.SizeMode = PictureBoxSizeMode.StretchImage
        MCMenuIcon_Logout.TabIndex = 74
        MCMenuIcon_Logout.TabStop = False
        ' 
        ' MCMenuLbl_Trainers
        ' 
        MCMenuLbl_Trainers.AutoSize = True
        MCMenuLbl_Trainers.BackColor = Color.Transparent
        MCMenuLbl_Trainers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCMenuLbl_Trainers.ForeColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        MCMenuLbl_Trainers.Location = New Point(586, 771)
        MCMenuLbl_Trainers.Name = "MCMenuLbl_Trainers"
        MCMenuLbl_Trainers.Size = New Size(70, 21)
        MCMenuLbl_Trainers.TabIndex = 69
        MCMenuLbl_Trainers.Text = "Trainers"
        ' 
        ' MCMenuLbl_BookLessons
        ' 
        MCMenuLbl_BookLessons.AutoSize = True
        MCMenuLbl_BookLessons.BackColor = Color.Transparent
        MCMenuLbl_BookLessons.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MCMenuLbl_BookLessons.ForeColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        MCMenuLbl_BookLessons.Location = New Point(876, 771)
        MCMenuLbl_BookLessons.Name = "MCMenuLbl_BookLessons"
        MCMenuLbl_BookLessons.Size = New Size(111, 21)
        MCMenuLbl_BookLessons.TabIndex = 73
        MCMenuLbl_BookLessons.Text = "Book Lessons"
        ' 
        ' MG_Mini_Btn_Icon
        ' 
        MG_Mini_Btn_Icon.BackColor = Color.Transparent
        MG_Mini_Btn_Icon.Image = CType(resources.GetObject("MG_Mini_Btn_Icon.Image"), Image)
        MG_Mini_Btn_Icon.Location = New Point(1166, 6)
        MG_Mini_Btn_Icon.Name = "MG_Mini_Btn_Icon"
        MG_Mini_Btn_Icon.Size = New Size(36, 29)
        MG_Mini_Btn_Icon.SizeMode = PictureBoxSizeMode.StretchImage
        MG_Mini_Btn_Icon.TabIndex = 75
        MG_Mini_Btn_Icon.TabStop = False
        ' 
        ' ManageCourses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        ClientSize = New Size(1240, 800)
        Controls.Add(MG_Mini_Btn_Icon)
        Controls.Add(MCMenuIcon_Trainers)
        Controls.Add(MCCloseBtn_Icon)
        Controls.Add(AppLogoTitle)
        Controls.Add(AppLogo)
        Controls.Add(MC_Dashboard_Panel)
        Controls.Add(MCMenuLbl_Learners)
        Controls.Add(MCMenuLbl_Dashboard)
        Controls.Add(MCMenuIcon_Dashboard)
        Controls.Add(MCMenuIcon_Learners)
        Controls.Add(MCMenuIcon_Courses)
        Controls.Add(MCMenuLbl_Courses)
        Controls.Add(MCMenuIcon_BookLessons)
        Controls.Add(MCMenuIcon_Logout)
        Controls.Add(MCMenuLbl_Trainers)
        Controls.Add(MCMenuLbl_BookLessons)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ManageCourses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Courses"
        CType(MCMenuIcon_Trainers, ComponentModel.ISupportInitialize).EndInit()
        CType(MCCloseBtn_Icon, ComponentModel.ISupportInitialize).EndInit()
        CType(AppLogoTitle, ComponentModel.ISupportInitialize).EndInit()
        CType(AppLogo, ComponentModel.ISupportInitialize).EndInit()
        MC_Dashboard_Panel.ResumeLayout(False)
        MC_Dashboard_Panel.PerformLayout()
        CType(MC_Refresh_Btn, ComponentModel.ISupportInitialize).EndInit()
        CType(ManageCoursesDGV, ComponentModel.ISupportInitialize).EndInit()
        MCForm_TopPanel.ResumeLayout(False)
        MCForm_Panel_CName.ResumeLayout(False)
        MCForm_Panel_CName.PerformLayout()
        CType(MCForm_ChkMark_CName, ComponentModel.ISupportInitialize).EndInit()
        MCForm_Panel_Desc.ResumeLayout(False)
        MCForm_Panel_Desc.PerformLayout()
        MCForm_Panel_ID.ResumeLayout(False)
        MCForm_Panel_ID.PerformLayout()
        CType(MCForm_ChkMark_ID, ComponentModel.ISupportInitialize).EndInit()
        CType(MCHeadIcon_Title, ComponentModel.ISupportInitialize).EndInit()
        CType(MCMenuIcon_Dashboard, ComponentModel.ISupportInitialize).EndInit()
        CType(MCMenuIcon_Learners, ComponentModel.ISupportInitialize).EndInit()
        CType(MCMenuIcon_Courses, ComponentModel.ISupportInitialize).EndInit()
        CType(MCMenuIcon_BookLessons, ComponentModel.ISupportInitialize).EndInit()
        CType(MCMenuIcon_Logout, ComponentModel.ISupportInitialize).EndInit()
        CType(MG_Mini_Btn_Icon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MCMenuIcon_Trainers As PictureBox
    Friend WithEvents MCCloseBtn_Icon As PictureBox
    Friend WithEvents AppLogoTitle As PictureBox
    Friend WithEvents AppLogo As PictureBox
    Friend WithEvents MC_Dashboard_Panel As Panel
    Friend WithEvents ManageCoursesDGV_Title As Label
    Friend WithEvents ManageCoursesDGV As DataGridView
    Friend WithEvents MCForm_TopPanel As Panel
    Friend WithEvents MCForm_Btn_Update As Button
    Friend WithEvents MCForm_Btn_Add As Button
    Friend WithEvents MCForm_Panel_CName As Panel
    Friend WithEvents MCForm_ChkMark_CName As PictureBox
    Friend WithEvents MCForm_ErrMsg_CName As Label
    Friend WithEvents MCForm_Star_CName As Label
    Friend WithEvents MC_Form_Lbl_CName As Label
    Friend WithEvents MCForm_Panel_Desc As Panel
    Friend WithEvents MCForm_TBox_Desc As TextBox
    Friend WithEvents MCForm_Lbl_Desc As Label
    Friend WithEvents MCForm_Panel_ID As Panel
    Friend WithEvents MCForm_ChkMark_ID As PictureBox
    Friend WithEvents MCForm_TBox_ID As TextBox
    Friend WithEvents MCForm_ErrMsg_ID As Label
    Friend WithEvents MCForm_Star_ID As Label
    Friend WithEvents MCForm_Lbl_ID As Label
    Friend WithEvents MCHeadULine_Title As Panel
    Friend WithEvents MCHeadLbl_Title As Label
    Friend WithEvents MCHeadIcon_Title As PictureBox
    Friend WithEvents MCMenuLbl_Learners As Label
    Friend WithEvents MCMenuLbl_Dashboard As Label
    Friend WithEvents MCMenuIcon_Dashboard As PictureBox
    Friend WithEvents MCMenuIcon_Learners As PictureBox
    Friend WithEvents MCMenuIcon_Courses As PictureBox
    Friend WithEvents MCMenuLbl_Courses As Label
    Friend WithEvents MCMenuIcon_BookLessons As PictureBox
    Friend WithEvents MCMenuIcon_Logout As PictureBox
    Friend WithEvents MCMenuLbl_Trainers As Label
    Friend WithEvents MCMenuLbl_BookLessons As Label
    Friend WithEvents MCForm_TBox_CName As TextBox
    Friend WithEvents M_Courses_ID As DataGridViewTextBoxColumn
    Friend WithEvents M_Courses_Cname As DataGridViewTextBoxColumn
    Friend WithEvents M_Courses_Desc As DataGridViewTextBoxColumn
    Friend WithEvents MG_Mini_Btn_Icon As PictureBox
    Friend WithEvents MC_Refresh_Btn As PictureBox
End Class
