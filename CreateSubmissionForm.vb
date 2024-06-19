Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchElapsed As TimeSpan = TimeSpan.Zero

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
        ' Send this data to backend or save to a database, etc.

        ' Optionally, reset form fields or perform other actions after submission
        ResetForm()
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
End Class
