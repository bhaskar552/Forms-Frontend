<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtPhoneNumber = New TextBox()
        txtStopwatchTime = New TextBox()
        txtEmail = New TextBox()
        txtGithubLink = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        random = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnDelete = New Button()
        btnSubmitChanges = New Button()
        ToolTip1 = New ToolTip(components)
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.LightGray
        txtName.Location = New Point(157, 90)
        txtName.Name = "txtName"
        txtName.Size = New Size(246, 27)
        txtName.TabIndex = 0
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.LightGray
        txtPhoneNumber.Location = New Point(157, 206)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(246, 27)
        txtPhoneNumber.TabIndex = 1
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.LightGray
        txtStopwatchTime.Location = New Point(157, 312)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(246, 27)
        txtStopwatchTime.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.LightGray
        txtEmail.Location = New Point(157, 147)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(246, 27)
        txtEmail.TabIndex = 3
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.LightGray
        txtGithubLink.Location = New Point(157, 262)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(246, 27)
        txtGithubLink.TabIndex = 4
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.Location = New Point(24, 372)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(171, 29)
        btnPrevious.TabIndex = 6
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnNext.Location = New Point(201, 372)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(202, 29)
        btnNext.TabIndex = 7
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' random
        ' 
        random.AutoSize = True
        random.Location = New Point(70, 93)
        random.Name = "random"
        random.Size = New Size(49, 20)
        random.TabIndex = 8
        random.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(52, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 20)
        Label3.TabIndex = 10
        Label3.Text = "Bhaskar Das , Slidely Task 2, View Submissions"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(73, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 11
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 20)
        Label5.TabIndex = 12
        Label5.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(24, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 20)
        Label6.TabIndex = 13
        Label6.Text = "Github link task 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 319)
        Label7.Name = "Label7"
        Label7.Size = New Size(113, 20)
        Label7.TabIndex = 14
        Label7.Text = "Stopwatch time"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(24, 407)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(171, 31)
        btnDelete.TabIndex = 15
        btnDelete.Text = "DELETE (CTRL+D)"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSubmitChanges
        ' 
        btnSubmitChanges.BackColor = Color.Lime
        btnSubmitChanges.Location = New Point(201, 407)
        btnSubmitChanges.Name = "btnSubmitChanges"
        btnSubmitChanges.Size = New Size(202, 31)
        btnSubmitChanges.TabIndex = 16
        btnSubmitChanges.Text = "SUBMIT (CTRL+S)"
        ToolTip1.SetToolTip(btnSubmitChanges, "If you make any changes to the records, the 'Submit' button will appear. Press the 'Submit' button to save your changes.")
        btnSubmitChanges.UseVisualStyleBackColor = False
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipTitle = "Message"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(137, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 20)
        Label1.TabIndex = 17
        Label1.Text = "View , Edit and Delete "
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(430, 450)
        Controls.Add(Label1)
        Controls.Add(btnSubmitChanges)
        Controls.Add(btnDelete)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(random)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtGithubLink)
        Controls.Add(txtEmail)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents random As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSubmitChanges As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
End Class
