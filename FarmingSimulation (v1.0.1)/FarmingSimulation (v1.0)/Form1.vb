Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim passwordCheck As String = ""
    Dim CC As Integer

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.FlatAppearance.BorderSize = 0
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.FlatAppearance.BorderSize = 0
    End Sub

    Sub Register()
        PasswordChecker.Start()

        btnRegister.Visible = False
        btnLogIn.Visible = False
        tbRegUsername.Visible = True
        tbRegPassword.Visible = True
        ProgressBar1.Visible = True
        BackgroundImage = Image.FromFile("C:\Visual Basic\Images\userPass.jpg")


    End Sub

    Private Sub PasswordChecker_Tick(sender As Object, e As EventArgs) Handles PasswordChecker.Tick
        passwordCheck = tbRegPassword.Text
        passwordStrength()

        If tbRegPassword.Text = Nothing Then ' Nothing results in no progress bar
            tbRegPassStrength.Text = Nothing
            ProgressBar1.Value = 0
        Else
            tbRegPassStrength.Text = "Low"
        End If



        Dim capitalCounter As Integer = 0
        Dim numCounter As Integer = 0
        Dim lenPassword As Integer = Len(passwordCheck)

        For i = 1 To lenPassword
            If Asc(Mid(passwordCheck, i, 1)) >= 65 And Asc(Mid(passwordCheck, i, 1)) <= 90 And lenPassword > 3 Then ' Searching the password for uppercase letters (in order for password to be medium+)
                capitalCounter = capitalCounter + 1
            End If
            If Asc(Mid(passwordCheck, i, 1)) >= 48 And Asc(Mid(passwordCheck, i, 1)) <= 57 Then ' Searching the password for numbers so the password progress bar can be high
                numCounter = numCounter + 1
            End If
        Next


        ' Checking and outputting the password strength status
        tbCapCounter.Text = capitalCounter
        tbNumCounter.Text = numCounter
        If tbCapCounter.Text >= 1 Or tbNumCounter.Text >= 2 Then
            tbRegPassStrength.Text = "Medium"
            If tbCapCounter.Text >= 1 Then
                If tbNumCounter.Text >= 2 Then
                    tbRegPassStrength.Text = "High"
                End If
            ElseIf tbNumCounter.Text >= 2 Then
                If tbCapCounter.Text >= 1 Then
                    tbRegPassStrength.Text = "High"
                End If
            End If
        End If

    End Sub

    Function passwordStrength() ' Progress bar checker
        If tbRegPassStrength.Text = "Low" Then
            ProgressBar1.Value = 33
        ElseIf tbRegPassStrength.Text = "Medium" Then
            ProgressBar1.Value = 66
        ElseIf tbRegPassStrength.Text = "High" Then
            ProgressBar1.Value = 100
        End If


    End Function
End Class
