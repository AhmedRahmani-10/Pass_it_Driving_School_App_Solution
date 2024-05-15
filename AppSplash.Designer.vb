<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppSplash
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppSplash))
        Timer1 = New Timer(components)
        LoadingBar = New ProgressBar()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' LoadingBar
        ' 
        LoadingBar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LoadingBar.Dock = DockStyle.Bottom
        LoadingBar.ForeColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        LoadingBar.Location = New Point(0, 387)
        LoadingBar.Margin = New Padding(3, 2, 3, 2)
        LoadingBar.Name = "LoadingBar"
        LoadingBar.Size = New Size(614, 6)
        LoadingBar.Style = ProgressBarStyle.Continuous
        LoadingBar.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(146, 11)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 300)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' AppSplash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(614, 393)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(LoadingBar)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "AppSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AppSplash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
End Class
