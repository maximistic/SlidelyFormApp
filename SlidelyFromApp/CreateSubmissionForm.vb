Imports System.IO
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private WithEvents btnNext As Button
    Private WithEvents btnPrevious As Button


    Private lblName As Label
    Private lblEmail As Label
    Private lblPhone As Label
    Private lblGitHub As Label

    Private txtName As TextBox
    Private txtEmail As TextBox
    Private txtPhone As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents TextBox1 As TextBox
    Friend WithEvents lblTitle As Label
    Private WithEvents Button1 As Button
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Button2 As Button
    Private txtGitHub As TextBox

    Public Sub New()
        InitializeComponent()
        FetchSubmissions()
    End Sub

    Private Sub FetchSubmissions()
        Try
            Dim jsonFilePath As String = "backend\src\db.json"
            Dim jsonData As String = File.ReadAllText(jsonFilePath)
            Dim rootObject As RootObject = JsonConvert.DeserializeObject(Of RootObject)(jsonData)
            submissions = rootObject.Submissions
            ShowSubmission(currentSubmissionIndex)
        Catch ex As Exception
            MessageBox.Show("Error fetching submissions: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowSubmission(index As Integer)
        If submissions IsNot Nothing AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GitHubLink
            TextBox1.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblName.Location = New System.Drawing.Point(22, 126)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 20)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(22, 168)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 20)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblPhone.Location = New System.Drawing.Point(22, 206)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(147, 20)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Number "
        '
        'lblGitHub
        '
        Me.lblGitHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGitHub.Location = New System.Drawing.Point(22, 245)
        Me.lblGitHub.Name = "lblGitHub"
        Me.lblGitHub.Size = New System.Drawing.Size(100, 20)
        Me.lblGitHub.TabIndex = 4
        Me.lblGitHub.Text = "GitHub link"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(220, 124)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(300, 22)
        Me.txtName.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(220, 168)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(300, 22)
        Me.txtEmail.TabIndex = 2
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(220, 204)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(300, 22)
        Me.txtPhone.TabIndex = 1
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(220, 245)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New System.Drawing.Size(300, 22)
        Me.txtGitHub.TabIndex = 0
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Khaki
        Me.btnPrevious.Location = New System.Drawing.Point(12, 345)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(250, 42)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "Previous (Ctrl + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnNext.Location = New System.Drawing.Point(270, 345)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(250, 42)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next (Ctrl + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 53)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "StopWatch Time "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 295)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(300, 22)
        Me.TextBox1.TabIndex = 9
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(68, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(407, 25)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "John Doe, Slidely Task 2 - View Submissions"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(131, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Delete (Ctrl + D)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()

        ' TextBox2
        Me.TextBox2.Location = New System.Drawing.Point(27, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(300, 22)
        Me.Controls.Add(Me.TextBox2)

        ' Button2
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.Location = New System.Drawing.Point(333, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 42)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Search (Ctrl + S)"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Controls.Add(Me.Button2)

        '
        'ViewSubmissionsForm
        '
        Me.ClientSize = New System.Drawing.Size(532, 453)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblGitHub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentSubmissionIndex < submissions.Count - 1 Then
            currentSubmissionIndex += 1
            ShowSubmission(currentSubmissionIndex)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentSubmissionIndex > 0 Then
            currentSubmissionIndex -= 1
            ShowSubmission(currentSubmissionIndex)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteCurrentSubmission()
    End Sub

    Private Sub DeleteCurrentSubmission()
        Try
            If submissions IsNot Nothing AndAlso currentSubmissionIndex >= 0 AndAlso currentSubmissionIndex < submissions.Count Then
                submissions.RemoveAt(currentSubmissionIndex)

                ' Serialize updated submissions back to JSON
                Dim rootObject As New RootObject()
                rootObject.Submissions = submissions

                Dim jsonOutput As String = JsonConvert.SerializeObject(rootObject, Formatting.Indented)
                Dim jsonFilePath As String = "backend\src\db.json"
                File.WriteAllText(jsonFilePath, jsonOutput)

                ' Show next submission after deletion
                If currentSubmissionIndex >= submissions.Count Then
                    currentSubmissionIndex = submissions.Count - 1
                End If
                ShowSubmission(currentSubmissionIndex)

                ' Show deletion confirmation message
                MessageBox.Show("Submission deleted successfully.", "Deletion Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting submission: " & ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim searchText As String = TextBox2.Text.Trim()
        If Not String.IsNullOrEmpty(searchText) Then
            Dim foundIndex As Integer = FindSubmissionByEmail(searchText)
            If foundIndex <> -1 Then
                currentSubmissionIndex = foundIndex
                ShowSubmission(currentSubmissionIndex)
            Else
                MessageBox.Show($"Submission with email '{searchText}' not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please enter an email to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function FindSubmissionByEmail(email As String) As Integer
        If submissions IsNot Nothing Then
            For i As Integer = 0 To submissions.Count - 1
                If String.Equals(submissions(i).Email, email, StringComparison.OrdinalIgnoreCase) Then
                    Return i
                End If
            Next
        End If
        Return -1
    End Function


    ' Define the Submission class and the RootObject class
    Public Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        <JsonProperty("github_link")>
        Public Property GitHubLink As String
        <JsonProperty("stopwatch_time")>
        Public Property StopwatchTime As String
    End Class

    Public Class RootObject
        Public Property Submissions As List(Of Submission)
    End Class

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.D) Then
            Button1.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
