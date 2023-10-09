<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.tbRegUsername = New System.Windows.Forms.TextBox()
        Me.tbRegPassword = New System.Windows.Forms.TextBox()
        Me.tbCapCounter = New System.Windows.Forms.TextBox()
        Me.tbNumCounter = New System.Windows.Forms.TextBox()
        Me.tbRegPassStrength = New System.Windows.Forms.Label()
        Me.PasswordChecker = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.BackgroundImage = Global.FarmingSimulation__v1._0_.My.Resources.Resources.testing
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.Location = New System.Drawing.Point(121, 427)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(236, 153)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.BackgroundImage = Global.FarmingSimulation__v1._0_.My.Resources.Resources.wow1
        Me.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.Location = New System.Drawing.Point(651, 476)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(242, 157)
        Me.btnLogIn.TabIndex = 1
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'tbRegUsername
        '
        Me.tbRegUsername.Location = New System.Drawing.Point(363, 459)
        Me.tbRegUsername.Name = "tbRegUsername"
        Me.tbRegUsername.Size = New System.Drawing.Size(183, 22)
        Me.tbRegUsername.TabIndex = 2
        Me.tbRegUsername.Visible = False
        '
        'tbRegPassword
        '
        Me.tbRegPassword.Location = New System.Drawing.Point(573, 583)
        Me.tbRegPassword.Name = "tbRegPassword"
        Me.tbRegPassword.Size = New System.Drawing.Size(178, 22)
        Me.tbRegPassword.TabIndex = 3
        Me.tbRegPassword.Visible = False
        '
        'tbCapCounter
        '
        Me.tbCapCounter.Location = New System.Drawing.Point(803, 474)
        Me.tbCapCounter.Name = "tbCapCounter"
        Me.tbCapCounter.Size = New System.Drawing.Size(178, 22)
        Me.tbCapCounter.TabIndex = 4
        Me.tbCapCounter.Visible = False
        '
        'tbNumCounter
        '
        Me.tbNumCounter.Location = New System.Drawing.Point(803, 502)
        Me.tbNumCounter.Name = "tbNumCounter"
        Me.tbNumCounter.Size = New System.Drawing.Size(178, 22)
        Me.tbNumCounter.TabIndex = 5
        Me.tbNumCounter.Visible = False
        '
        'tbRegPassStrength
        '
        Me.tbRegPassStrength.AutoSize = True
        Me.tbRegPassStrength.Location = New System.Drawing.Point(777, 583)
        Me.tbRegPassStrength.Name = "tbRegPassStrength"
        Me.tbRegPassStrength.Size = New System.Drawing.Size(0, 16)
        Me.tbRegPassStrength.TabIndex = 6
        Me.tbRegPassStrength.Visible = False
        '
        'PasswordChecker
        '
        Me.PasswordChecker.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(573, 611)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(178, 29)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(849, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.FarmingSimulation__v1._0_.My.Resources.Resources.NewLogo1
        Me.ClientSize = New System.Drawing.Size(993, 661)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbRegPassStrength)
        Me.Controls.Add(Me.tbNumCounter)
        Me.Controls.Add(Me.tbCapCounter)
        Me.Controls.Add(Me.tbRegPassword)
        Me.Controls.Add(Me.tbRegUsername)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnRegister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents tbRegUsername As TextBox
    Friend WithEvents tbRegPassword As TextBox
    Friend WithEvents tbCapCounter As TextBox
    Friend WithEvents tbNumCounter As TextBox
    Friend WithEvents tbRegPassStrength As Label
    Public WithEvents PasswordChecker As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
End Class
