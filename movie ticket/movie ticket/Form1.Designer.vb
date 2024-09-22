<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Logo = New Label()
        homeNav = New Label()
        aboutNav = New Label()
        showTimeNav = New Label()
        SplitContainer1 = New SplitContainer()
        LoginBtn = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        SplitContainer2 = New SplitContainer()
        MovieName = New Label()
        Label2 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Logo
        ' 
        Logo.AutoSize = True
        Logo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Logo.Location = New Point(33, 10)
        Logo.Name = "Logo"
        Logo.Size = New Size(123, 28)
        Logo.TabIndex = 0
        Logo.Text = "Movie Ticket"
        Logo.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' homeNav
        ' 
        homeNav.AutoSize = True
        homeNav.Location = New Point(38, 18)
        homeNav.Name = "homeNav"
        homeNav.Size = New Size(50, 20)
        homeNav.TabIndex = 1
        homeNav.Text = "Home"
        ' 
        ' aboutNav
        ' 
        aboutNav.AutoSize = True
        aboutNav.Location = New Point(121, 18)
        aboutNav.Name = "aboutNav"
        aboutNav.Size = New Size(50, 20)
        aboutNav.TabIndex = 2
        aboutNav.Text = "About"
        ' 
        ' showTimeNav
        ' 
        showTimeNav.AutoSize = True
        showTimeNav.Location = New Point(216, 18)
        showTimeNav.Name = "showTimeNav"
        showTimeNav.Size = New Size(82, 20)
        showTimeNav.TabIndex = 3
        showTimeNav.Text = "Show Time"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(-4, -1)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Logo)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(LoginBtn)
        SplitContainer1.Panel2.Controls.Add(homeNav)
        SplitContainer1.Panel2.Controls.Add(showTimeNav)
        SplitContainer1.Panel2.Controls.Add(aboutNav)
        SplitContainer1.Size = New Size(806, 58)
        SplitContainer1.SplitterDistance = 204
        SplitContainer1.TabIndex = 4
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = SystemColors.AppWorkspace
        LoginBtn.ForeColor = SystemColors.ControlText
        LoginBtn.Location = New Point(470, 13)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(94, 29)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login" & vbCrLf
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Controls.Add(SplitContainer2)
        FlowLayoutPanel1.Location = New Point(74, 322)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(608, 116)
        FlowLayoutPanel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 28)
        Label1.TabIndex = 0
        Label1.Text = "Now Showing"
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Location = New Point(3, 31)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(MovieName)
        SplitContainer2.Size = New Size(467, 53)
        SplitContainer2.SplitterDistance = 155
        SplitContainer2.TabIndex = 1
        ' 
        ' MovieName
        ' 
        MovieName.AutoSize = True
        MovieName.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MovieName.ForeColor = SystemColors.ButtonHighlight
        MovieName.Location = New Point(15, 14)
        MovieName.Name = "MovieName"
        MovieName.Size = New Size(97, 23)
        MovieName.TabIndex = 0
        MovieName.Text = "Infinity War"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(242, 353)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 60)
        Label2.TabIndex = 0
        Label2.Text = "The Avengers must stop Thanos, an intergalactic" & vbCrLf & " warlord, from getting his hands on all the" & vbCrLf & " infinity stones. " & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        BackgroundImage = My.Resources.Resources.wallpaper1
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(SplitContainer1)
        Cursor = Cursors.Hand
        Name = "Form1"
        Text = "Form1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Logo As Label
    Friend WithEvents homeNav As Label
    Friend WithEvents aboutNav As Label
    Friend WithEvents showTimeNav As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents LoginBtn As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents MovieName As Label
    Friend WithEvents Label2 As Label

End Class
