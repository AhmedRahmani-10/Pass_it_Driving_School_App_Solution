<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        LoginSide_pic = New PictureBox()
        loginSide = New Panel()
        ProjectByLabel = New Label()
        PictureBox1 = New PictureBox()
        AdminLoginLabel = New Label()
        Panel1 = New Panel()
        LoginForm_User_Text = New TextBox()
        PictureBox2 = New PictureBox()
        LoginForm_Pass_Text = New TextBox()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        LoginForm_Btn = New Button()
        LoginForm_errMsg_Text = New Label()
        project_year = New Label()
        CType(LoginSide_pic, ComponentModel.ISupportInitialize).BeginInit()
        loginSide.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' LoginSide_pic
        ' 
        LoginSide_pic.BackColor = Color.Transparent
        LoginSide_pic.Image = CType(resources.GetObject("LoginSide_pic.Image"), Image)
        LoginSide_pic.Location = New Point(14, 73)
        LoginSide_pic.Margin = New Padding(3, 2, 3, 2)
        LoginSide_pic.Name = "LoginSide_pic"
        LoginSide_pic.Size = New Size(300, 300)
        LoginSide_pic.SizeMode = PictureBoxSizeMode.StretchImage
        LoginSide_pic.TabIndex = 0
        LoginSide_pic.TabStop = False
        ' 
        ' loginSide
        ' 
        loginSide.BackgroundImage = CType(resources.GetObject("loginSide.BackgroundImage"), Image)
        loginSide.BackgroundImageLayout = ImageLayout.Stretch
        loginSide.Controls.Add(project_year)
        loginSide.Controls.Add(ProjectByLabel)
        loginSide.Controls.Add(LoginSide_pic)
        loginSide.Dock = DockStyle.Left
        loginSide.Location = New Point(0, 0)
        loginSide.Margin = New Padding(3, 2, 3, 2)
        loginSide.Name = "loginSide"
        loginSide.Size = New Size(350, 476)
        loginSide.TabIndex = 1
        ' 
        ' ProjectByLabel
        ' 
        ProjectByLabel.AutoSize = True
        ProjectByLabel.BackColor = Color.Transparent
        ProjectByLabel.Font = New Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProjectByLabel.ForeColor = Color.DimGray
        ProjectByLabel.Location = New Point(39, 418)
        ProjectByLabel.Name = "ProjectByLabel"
        ProjectByLabel.Size = New Size(265, 19)
        ProjectByLabel.TabIndex = 3
        ProjectByLabel.Text = "A Project of UCB Masters CS Dept."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(664, 11)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' AdminLoginLabel
        ' 
        AdminLoginLabel.AutoSize = True
        AdminLoginLabel.BackColor = Color.Transparent
        AdminLoginLabel.Font = New Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AdminLoginLabel.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        AdminLoginLabel.Location = New Point(453, 102)
        AdminLoginLabel.Name = "AdminLoginLabel"
        AdminLoginLabel.Size = New Size(148, 28)
        AdminLoginLabel.TabIndex = 3
        AdminLoginLabel.Text = "Admin Login"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LoginForm_User_Text)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(381, 182)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 44)
        Panel1.TabIndex = 4
        ' 
        ' LoginForm_User_Text
        ' 
        LoginForm_User_Text.Font = New Font("Cascadia Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginForm_User_Text.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        LoginForm_User_Text.Location = New Point(42, 7)
        LoginForm_User_Text.Margin = New Padding(5)
        LoginForm_User_Text.Name = "LoginForm_User_Text"
        LoginForm_User_Text.Size = New Size(232, 30)
        LoginForm_User_Text.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(6, 9)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' LoginForm_Pass_Text
        ' 
        LoginForm_Pass_Text.Font = New Font("Cascadia Mono", 14.25F, FontStyle.Bold)
        LoginForm_Pass_Text.ForeColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        LoginForm_Pass_Text.Location = New Point(43, 8)
        LoginForm_Pass_Text.Margin = New Padding(5)
        LoginForm_Pass_Text.Name = "LoginForm_Pass_Text"
        LoginForm_Pass_Text.PasswordChar = "•"c
        LoginForm_Pass_Text.Size = New Size(232, 30)
        LoginForm_Pass_Text.TabIndex = 6
        LoginForm_Pass_Text.UseSystemPasswordChar = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(6, 9)
        PictureBox3.Margin = New Padding(3, 2, 3, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(LoginForm_Pass_Text)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(381, 238)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(293, 44)
        Panel2.TabIndex = 5
        ' 
        ' LoginForm_Btn
        ' 
        LoginForm_Btn.BackColor = Color.FromArgb(CByte(113), CByte(42), CByte(251))
        LoginForm_Btn.FlatAppearance.BorderSize = 0
        LoginForm_Btn.FlatStyle = FlatStyle.Flat
        LoginForm_Btn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginForm_Btn.ForeColor = Color.White
        LoginForm_Btn.Location = New Point(423, 318)
        LoginForm_Btn.Margin = New Padding(3, 2, 3, 2)
        LoginForm_Btn.Name = "LoginForm_Btn"
        LoginForm_Btn.Size = New Size(231, 34)
        LoginForm_Btn.TabIndex = 6
        LoginForm_Btn.Text = "Login"
        LoginForm_Btn.UseVisualStyleBackColor = False
        ' 
        ' LoginForm_errMsg_Text
        ' 
        LoginForm_errMsg_Text.AutoSize = True
        LoginForm_errMsg_Text.Font = New Font("Segoe UI", 12F)
        LoginForm_errMsg_Text.ForeColor = Color.Red
        LoginForm_errMsg_Text.Location = New Point(419, 285)
        LoginForm_errMsg_Text.Name = "LoginForm_errMsg_Text"
        LoginForm_errMsg_Text.Size = New Size(253, 21)
        LoginForm_errMsg_Text.TabIndex = 7
        LoginForm_errMsg_Text.Text = "Incorrect Username or Password ...!"
        LoginForm_errMsg_Text.Visible = False
        ' 
        ' project_year
        ' 
        project_year.AutoSize = True
        project_year.BackColor = Color.Transparent
        project_year.Font = New Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        project_year.ForeColor = SystemColors.ControlDarkDark
        project_year.Location = New Point(130, 444)
        project_year.Name = "project_year"
        project_year.Size = New Size(82, 21)
        project_year.TabIndex = 4
        project_year.Text = "MAY 2024"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(225), CByte(209), CByte(252))
        ClientSize = New Size(700, 476)
        Controls.Add(LoginForm_errMsg_Text)
        Controls.Add(LoginForm_Btn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(AdminLoginLabel)
        Controls.Add(PictureBox1)
        Controls.Add(loginSide)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "login"
        CType(LoginSide_pic, ComponentModel.ISupportInitialize).EndInit()
        loginSide.ResumeLayout(False)
        loginSide.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginSide_pic As PictureBox
    Friend WithEvents loginSide As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AdminLoginLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LoginForm_User_Text As TextBox
    Friend WithEvents LoginForm_Pass_Text As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LoginForm_Btn As Button
    Friend WithEvents ProjectByLabel As Label
    Friend WithEvents LoginForm_errMsg_Text As Label
    Friend WithEvents project_year As Label
End Class
