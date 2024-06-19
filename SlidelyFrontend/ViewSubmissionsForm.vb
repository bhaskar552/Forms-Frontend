Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm

    Private submissions As New List(Of Submission)()
    Private ReadOnly apiUrl As String = "http://localhost:3000/"
    Private currentIndex As Integer = 0
    Private changesMade As Boolean = False ' Flag to track changes

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Await LoadSubmissionsAsync()
            currentIndex = 0
            LoadAndDisplaySubmission(currentIndex)
        Catch ex As Exception
            MessageBox.Show($"An error occurred while loading submissions: {ex.Message}")
        End Try
    End Sub

    Private Async Function LoadSubmissionsAsync() As Task
        Using httpClient As New HttpClient()
            Try
                While True
                    Dim response As HttpResponseMessage = Await httpClient.GetAsync($"{apiUrl}read/?index={currentIndex}")

                    If response.IsSuccessStatusCode Then
                        Dim jsonContent As String = Await response.Content.ReadAsStringAsync()
                        Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonContent)

                        ' Assign lowercase properties directly
                        submission.name = submission.name.ToLower()
                        submission.email = submission.email.ToLower()
                        submission.phone = submission.phone.ToLower()
                        submission.github_link = submission.github_link.ToLower()
                        submission.stopwatch_time = submission.stopwatch_time.ToLower()

                        submissions.Add(submission)
                        currentIndex += 1 ' Increment index for the next request
                    ElseIf response.StatusCode = Net.HttpStatusCode.NotFound Then
                        Exit While ' Exit loop if 404 is received
                    Else
                        ' Handle other HTTP status codes if needed
                        MessageBox.Show($"Error loading data: {response.ReasonPhrase}")
                        Exit While
                    End If
                End While

                ' Check if submissions list is empty after loading
                If submissions.Count = 0 Then
                    MessageBox.Show("No submissions available.", "No Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show($"An error occurred while loading submissions: {ex.Message}")
            End Try
        End Using ' Dispose HttpClient when done
    End Function

    Private Async Sub DeleteSubmission()
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Using httpClient As New HttpClient()
                    Try
                        Dim response As HttpResponseMessage = Await httpClient.DeleteAsync($"{apiUrl}delete/?index={currentIndex}")

                        If response.IsSuccessStatusCode Then
                            submissions.RemoveAt(currentIndex)

                            If submissions.Count = 0 Then
                                MessageBox.Show("No more submissions left. Closing the form.", "No Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            Else
                                If currentIndex >= submissions.Count Then
                                    currentIndex = submissions.Count - 1
                                End If

                                LoadAndDisplaySubmission(currentIndex)
                                MessageBox.Show("Submission deleted successfully.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            MessageBox.Show($"Error deleting submission: {response.ReasonPhrase}")
                        End If
                    Catch ex As Exception
                        MessageBox.Show($"An error occurred while deleting the submission: {ex.Message}")
                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadAndDisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            LoadAndDisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteSubmission()
    End Sub

    Private Async Sub btnSubmitChanges_Click(sender As Object, e As EventArgs) Handles btnSubmitChanges.Click
        If currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim submissionToUpdate As Submission = submissions(currentIndex)

            ' Assuming text boxes are used to edit the data
            submissionToUpdate.name = txtName.Text.ToLower()
            submissionToUpdate.email = txtEmail.Text.ToLower()
            submissionToUpdate.phone = txtPhoneNumber.Text.ToLower()
            submissionToUpdate.github_link = txtGithubLink.Text.ToLower()
            submissionToUpdate.stopwatch_time = txtStopwatchTime.Text.ToLower()

            ' Perform PUT request
            Using httpClient As New HttpClient()
                Dim jsonContent As String = JsonConvert.SerializeObject(submissionToUpdate)
                Dim httpContent As New StringContent(jsonContent, Encoding.UTF8, "application/json")

                Try
                    MessageBox.Show("Submitting changes...") ' Debugging message
                    Dim response As HttpResponseMessage = Await httpClient.PutAsync($"{apiUrl}edit?index={currentIndex}", httpContent)

                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Changes submitted successfully.", "Submission Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        changesMade = False ' Reset changes flag after successful submission
                        UpdateSubmitButtonVisibility() ' Update submit button visibility
                    Else
                        MessageBox.Show($"Error submitting changes: {response.ReasonPhrase}")
                    End If
                Catch ex As Exception
                    MessageBox.Show($"An error occurred while submitting changes: {ex.Message}")
                End Try
            End Using
        End If
    End Sub

    Private Async Sub LoadAndDisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            ' Assign lowercase properties directly for display
            txtName.Text = submissions(index).name
            txtEmail.Text = submissions(index).email
            txtPhoneNumber.Text = submissions(index).phone
            txtGithubLink.Text = submissions(index).github_link
            txtStopwatchTime.Text = submissions(index).stopwatch_time

            ' Reset changes flag
            changesMade = False
        Else
            ' Clear fields if no submissions or index is out of range
            txtName.Clear()
            txtEmail.Clear()
            txtPhoneNumber.Clear()
            txtGithubLink.Clear()
            txtStopwatchTime.Clear()
        End If

        UpdateSubmitButtonVisibility()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged,
                                                                               txtEmail.TextChanged,
                                                                               txtPhoneNumber.TextChanged,
                                                                               txtGithubLink.TextChanged,
                                                                               txtStopwatchTime.TextChanged
        changesMade = True
        UpdateSubmitButtonVisibility()
    End Sub

    Private Sub UpdateSubmitButtonVisibility()
        btnSubmitChanges.Visible = changesMade
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    btnPrevious.PerformClick()
                Case Keys.N
                    btnNext.PerformClick()
                Case Keys.D
                    btnDelete.PerformClick()
                Case Keys.S
                    btnSubmitChanges.PerformClick()
            End Select
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub
End Class

Public Class Submission
    Public Property id As Integer
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
