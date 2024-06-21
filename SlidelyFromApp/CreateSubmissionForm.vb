Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    Private stopwatchRunning As Boolean = False
    Private stopwatchElapsed As TimeSpan = TimeSpan.Zero

    ' Declare controls
    Private WithEvents lblName As Label
    Private WithEvents lblEmail As Label
    Private WithEvents lblPhone As Label
    Private WithEvents lblGitHub As Label
    Private WithEvents txtName As TextBox
    Private WithEvents txtEmail As TextBox
    Private WithEvents txtPhone As TextBox
    Private WithEvents txtGitHub As TextBox
    Private WithEvents lblStopwatch As Label
    Private WithEvents btnToggleStopwatch As Button
    Private WithEvents btnSubmit As Button
    Private WithEvents components As System.ComponentModel.IContainer
    Friend WithEvents lblTitle As Label
    Private WithEvents Timer1 As Timer

    ' Constructor
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    ' Initialize components method
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(12, 106)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(70, 25)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(12, 148)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(66, 25)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPhone.Location = New System.Drawing.Point(12, 196)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(115, 25)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGitHub
        '
        Me.lblGitHub.AutoSize = True
        Me.lblGitHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGitHub.Location = New System.Drawing.Point(12, 239)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(113, 25)
        Me.lblGitHub.TabIndex = 3
        Me.lblGitHub.Text = "GitHub Link"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(242, 106)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 22)
        Me.txtName.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(242, 148)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 22)
        Me.txtEmail.TabIndex = 5
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(242, 200)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(300, 22)
        Me.txtPhone.TabIndex = 6
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(242, 243)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(300, 22)
        Me.txtGitHub.TabIndex = 7
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblStopwatch.Location = New System.Drawing.Point(436, 315)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(90, 25)
        Me.lblStopwatch.TabIndex = 8
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Khaki
        Me.btnToggleStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(12, 312)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(347, 35)
        Me.btnToggleStopwatch.TabIndex = 9
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH (Ctrl + T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(12, 376)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(530, 35)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT (Ctrl + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(87, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(423, 25)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "John Doe, Slidely Task 2 - Create Submissions"
        '
        'CreateSubmissionForm
        '
        Me.ClientSize = New System.Drawing.Size(582, 453)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        stopwatchRunning = Not stopwatchRunning

        If stopwatchRunning Then
            Timer1.Start()
            btnToggleStopwatch.Text = "PAUSE STOPWATCH"
        Else
            Timer1.Stop()
            btnToggleStopwatch.Text = "RESUME STOPWATCH"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchElapsed = stopwatchElapsed.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = stopwatchElapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Handle submission to backend here
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubRepo As String = txtGitHub.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        ' Send this data to backend or save to a database, etc.
        SubmitData(name, email, phone, githubRepo, stopwatchTime)

        ' Optionally, reset form fields or perform other actions after submission
        ResetForm()
    End Sub

    Private Async Sub SubmitData(name As String, email As String, phone As String, githubRepo As String, stopwatchTime As String)
        Try
            Dim client As New HttpClient()
            Dim submission As New With {
                .name = name,
                .email = email,
                .phone = phone,
                .github_link = githubRepo,
                .stopwatch_time = stopwatchTime
            }
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed: " & response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("Error submitting data: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        ' Reset form fields and stopwatch display
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGitHub.Text = ""
        lblStopwatch.Text = "00:00:00"
        stopwatchElapsed = TimeSpan.Zero
        stopwatchRunning = False
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH"
        Timer1.Stop()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        ' Handle text change event if needed
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form load event handler
    End Sub

    Private Sub lblStopwatch_Click(sender As Object, e As EventArgs) Handles lblStopwatch.Click
        ' Handle label click event if needed
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
