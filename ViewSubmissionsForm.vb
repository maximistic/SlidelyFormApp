Public Class ViewSubmissionsForm
    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private WithEvents btnNext As Button
    Private WithEvents btnPrevious As Button
    Private lblName As Label
    Private lblEmail As Label
    Private lblPhone As Label
    Private lblGitHub As Label

    ' Constructor to initialize the form
    Public Sub New()
        InitializeComponent()
        ' Initialize other components or data as needed
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize submissions data (you need to populate this list with actual data)
        submissions = New List(Of Submission)()
        ' Populate submissions list with data from backend or wherever it's stored

        ' Show the first submission by default
        ShowSubmission(currentSubmissionIndex)
    End Sub

    Private Sub ShowSubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            lblName.Text = submission.Name
            lblEmail.Text = submission.Email
            lblPhone.Text = submission.Phone
            lblGitHub.Text = submission.GitHubRepo
        End If
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
End Class
