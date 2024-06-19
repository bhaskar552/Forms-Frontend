Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim newSubmission As New With {
                .name = txtName.Text,
                .email = txtEmail.Text,
                .phone = txtPhoneNumber.Text,
                .github_link = txtGithubLink.Text,
                .stopwatch_time = lblStopwatchTime.Text
            }

            ' Serialize newSubmission object to JSON
            Dim jsonSubmission As String = JsonConvert.SerializeObject(newSubmission)

            ' URL of your backend endpoint
            Dim apiUrl As String = "http://localhost:3000/submit"

            ' HttpClient setup
            Using httpClient As New HttpClient()
                ' Set headers
                httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                ' Create HTTP content with JSON
                Dim content As New StringContent(jsonSubmission, Encoding.UTF8, "application/json")

                ' Send POST request asynchronously
                Dim response As HttpResponseMessage = Await httpClient.PostAsync(apiUrl, content)

                ' Check response status
                If response.IsSuccessStatusCode Then
                    ' Request successful
                    MessageBox.Show("Submission successful!")
                Else
                    ' Request failed
                    MessageBox.Show("Error submitting data: " & response.ReasonPhrase)
                End If
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("An error occurred: " & ex.Message)
            Debug.WriteLine(ex.StackTrace) ' Output exception stack trace to debug console
        End Try
    End Sub



    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub txtPhoneNumber_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub

    Private Sub lblStopwatchTime_Click(sender As Object, e As EventArgs) Handles lblStopwatchTime.Click

    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.T
                    btnToggleStopwatch.PerformClick()
                Case Keys.S
                    btnSubmit.PerformClick()
            End Select
        End If
    End Sub

    Private Sub btnToggleStopwatch_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles btnToggleStopwatch.PreviewKeyDown

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
