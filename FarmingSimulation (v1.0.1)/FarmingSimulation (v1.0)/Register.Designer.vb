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
        Me.tbRegSubmit = New System.Windows.Forms.Button()
        Me.tbRegUsername = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New FarmingSimulation__v1._0_.Database1DataSet()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbRegPassword
        '
        Me.tbRegPassword.Location = New System.Drawing.Point(45, 136)
        Me.tbRegPassword.Name = "tbRegPassword"
        Me.tbRegPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbRegPassword.Size = New System.Drawing.Size(227, 22)
        Me.tbRegPassword.TabIndex = 0
        '
        'tbRegPassStrength
        '
        Me.tbRegPassStrength.Location = New System.Drawing.Point(45, 229)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(45, 192)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(227, 31)
        Me.ProgressBar1.TabIndex = 4
        '
        'tbRegSubmit
        '
        Me.tbRegSubmit.Location = New System.Drawing.Point(325, 136)
        Me.tbRegSubmit.Name = "tbRegSubmit"
        Me.tbRegSubmit.Size = New System.Drawing.Size(198, 87)
        Me.tbRegSubmit.TabIndex = 5
        Me.tbRegSubmit.Text = "Button1"
        Me.tbRegSubmit.UseVisualStyleBackColor = True
        '
        'tbRegUsername
        '
        Me.tbRegUsername.Location = New System.Drawing.Point(45, 108)
        Me.tbRegUsername.Name = "tbRegUsername"
        Me.tbRegUsername.Size = New System.Drawing.Size(227, 22)
        Me.tbRegUsername.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.Database1DataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(325, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(198, 258)
        Me.DataGridView1.TabIndex = 7
        '
        'Database1DataSetBindingSource
        '
        Me.Database1DataSetBindingSource.DataSource = Me.Database1DataSet
        Me.Database1DataSetBindingSource.Position = 0
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(362, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 20)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FarmingSimulation__v1._0_.My.Resources.Resources.gray2
        Me.ClientSize = New System.Drawing.Size(572, 529)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.tbRegUsername)
        Me.Controls.Add(Me.tbRegSubmit)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.tbNumCounter)
        Me.Controls.Add(Me.tbCapCounter)
        Me.Controls.Add(Me.tbRegPassStrength)
        Me.Controls.Add(Me.tbRegPassword)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbRegPassword As TextBox
    Friend WithEvents tbRegPassStrength As TextBox
    Friend WithEvents tbCapCounter As TextBox
    Friend WithEvents tbNumCounter As TextBox
    Friend WithEvents PasswordChecker As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tbRegSubmit As Button
    Friend WithEvents tbRegUsername As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSetBindingSource As BindingSource
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents CheckBox1 As CheckBox
End Class
