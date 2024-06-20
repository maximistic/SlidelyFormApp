Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubRepo As String

    ' Constructor to initialize the properties
    Public Sub New(name As String, email As String, phone As String, gitHubRepo As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GitHubRepo = gitHubRepo
    End Sub
End Class
