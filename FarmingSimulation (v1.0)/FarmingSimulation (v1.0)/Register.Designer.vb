<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Me.tbRegPassword = New System.Windows.Forms.TextBox()
        Me.tbRegPassStrength = New System.Windows.Forms.TextBox()
        Me.tbCapCounter = New System.Windows.Forms.TextBox()
        Me.tbNumCounter = New System.Windows.Forms.TextBox()
        Me.PasswordChecker = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'tbRegPassword
        '
        Me.tbRegPassword.Location = New System.Drawing.Point(45, 126)
        Me.tbRegPassword.Name = "tbRegPassword"
        Me.tbRegPassword.Size = New System.Drawing.Size(227, 22)
        Me.tbRegPassword.TabIndex = 0
        '
        'tbRegPassStrength
        '
        Me.tbRegPassStrength.Location = New System.Drawing.Point(45, 154)
        Me.tbRegPassStrength.Name = "tbRegPassStrength"
        Me.tbRegPassStrength.Size = New System.Drawing.Size(227, 22)
        Me.tbRegPassStrength.TabIndex = 1
        '
        'tbCapCounter
        '
        Me.tbCapCounter.Location = New System.Drawing.Point(45, 429)
        Me.tbCapCounter.Name = "tbCapCounter"
        Me.tbCapCounter.Size = New System.Drawing.Size(227, 22)
        Me.tbCapCounter.TabIndex = 2
        Me.tbCapCounter.Visible = False
        '
        'tbNumCounter
        '
        Me.tbNumCounter.Location = New System.Drawing.Point(45, 457)
        Me.tbNumCounter.Name = "tbNumCounter"
        Me.tbNumCounter.Size = New System.Drawing.Size(227, 22)
        Me.tbNumCounter.TabIndex = 3
        Me.tbNumCounter.Visible = False
        '
        'PasswordChecker
        '
        Me.PasswordChecker.Interval = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(45, 182)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(227, 31)
        Me.ProgressBar1.TabIndex = 4
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmingSimulation__v1._0_.My.Resources.Resources.gray2
        Me.ClientSize = New System.Drawing.Size(572, 529)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbNumCounter)
        Me.Controls.Add(Me.tbCapCounter)
        Me.Controls.Add(Me.tbRegPassStrength)
        Me.Controls.Add(Me.tbRegPassword)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbRegPassword As TextBox
    Friend WithEvents tbRegPassStrength As TextBox
    Friend WithEvents tbCapCounter As TextBox
    Friend WithEvents tbNumCounter As TextBox
    Friend WithEvents PasswordChecker As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
