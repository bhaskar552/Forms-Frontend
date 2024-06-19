<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        txtGithubLink = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        btnToggleStopwatch = New Button()
        Label1 = New Label()
        btnSubmit = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStopwatchTime = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label5 = New Label()
        ToolTip1 = New ToolTip(components)
        ToolTip2 = New ToolTip(components)
        ToolTip3 = New ToolTip(components)
        ToolTip4 = New ToolTip(components)
        ToolTip5 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.Menu
        txtName.Location = New Point(180, 59)
        txtName.Name = "txtName"
        txtName.Size = New Size(209, 27)
        txtName.TabIndex = 0
        ToolTip1.SetToolTip(txtName, "Enter the Name")
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.Menu
        txtGithubLink.Location = New Point(180, 175)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ScrollBars = ScrollBars.Vertical
        txtGithubLink.Size = New Size(209, 27)
        txtGithubLink.TabIndex = 1
        ToolTip4.SetToolTip(txtGithubLink, "Enter the GIthub Link")
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = SystemColors.Menu
        txtPhoneNumber.Location = New Point(180, 137)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(209, 27)
        txtPhoneNumber.TabIndex = 2
        ToolTip3.SetToolTip(txtPhoneNumber, "Enter Phone Number")
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.Menu
        txtEmail.Location = New Point(180, 99)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(209, 27)
        txtEmail.TabIndex = 4
        ToolTip2.SetToolTip(txtEmail, "Enter Email")
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnToggleStopwatch.Location = New Point(12, 232)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(235, 29)
        btnToggleStopwatch.TabIndex = 5
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        ToolTip5.SetToolTip(btnToggleStopwatch, "Start or Stop the Stopwatch")
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnSubmit.Location = New Point(90, 303)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(264, 43)
        btnSubmit.TabIndex = 8
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 9
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 10
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 20)
        Label4.TabIndex = 11
        Label4.Text = "Github link for task 2"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.BackColor = SystemColors.GradientActiveCaption
        lblStopwatchTime.Location = New Point(326, 236)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(63, 20)
        lblStopwatchTime.TabIndex = 12
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(41, 18)
        Label5.Name = "Label5"
        Label5.Size = New Size(384, 20)
        Label5.TabIndex = 13
        Label5.Text = "Bhaskar Das , Slidely task 2 - Create New Submissions"
        Label5.TextAlign = ContentAlignment.TopCenter
        ToolTip1.SetToolTip(Label5, "Enter Email")
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 379)
        Controls.Add(Label5)
        Controls.Add(lblStopwatchTime)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnSubmit)
        Controls.Add(Label1)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtGithubLink)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "Create New Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
End Class
