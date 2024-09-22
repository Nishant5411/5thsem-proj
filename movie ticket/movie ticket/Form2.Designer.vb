<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        userId = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        PasswordId = New Label()
        submitBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(68, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(94, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 41)
        Label2.TabIndex = 1
        Label2.Text = "Login"
        ' 
        ' userId
        ' 
        userId.AutoSize = True
        userId.Location = New Point(35, 165)
        userId.Name = "userId"
        userId.Size = New Size(78, 20)
        userId.TabIndex = 2
        userId.Text = "UserName"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(149, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(147, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(149, 219)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(147, 27)
        TextBox2.TabIndex = 5
        ' 
        ' PasswordId
        ' 
        PasswordId.AutoSize = True
        PasswordId.Location = New Point(35, 219)
        PasswordId.Name = "PasswordId"
        PasswordId.Size = New Size(70, 20)
        PasswordId.TabIndex = 4
        PasswordId.Text = "Password"
        ' 
        ' submitBtn
        ' 
        submitBtn.Location = New Point(94, 323)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(110, 34)
        submitBtn.TabIndex = 6
        submitBtn.Text = "Submit"
        submitBtn.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(320, 516)
        Controls.Add(submitBtn)
        Controls.Add(TextBox2)
        Controls.Add(PasswordId)
        Controls.Add(TextBox1)
        Controls.Add(userId)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents userId As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PasswordId As Label
    Friend WithEvents submitBtn As Button
End Class
