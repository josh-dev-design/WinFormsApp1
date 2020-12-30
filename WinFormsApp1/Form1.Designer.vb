<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TXTBusername = New System.Windows.Forms.TextBox()
        Me.TXTBpassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(122, 230)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(94, 29)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TXTBusername
        '
        Me.TXTBusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTBusername.Location = New System.Drawing.Point(111, 110)
        Me.TXTBusername.Name = "TXTBusername"
        Me.TXTBusername.PlaceholderText = "Username"
        Me.TXTBusername.Size = New System.Drawing.Size(214, 27)
        Me.TXTBusername.TabIndex = 1
        '
        'TXTBpassword
        '
        Me.TXTBpassword.Location = New System.Drawing.Point(111, 165)
        Me.TXTBpassword.Name = "TXTBpassword"
        Me.TXTBpassword.PlaceholderText = "Password"
        Me.TXTBpassword.Size = New System.Drawing.Size(214, 27)
        Me.TXTBpassword.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(21, 113)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(21, 168)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(70, 20)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Oswald", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(111, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 79)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(360, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.TXTBpassword)
        Me.Controls.Add(Me.TXTBusername)
        Me.Controls.Add(Me.BtnLogin)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TXTBusername As TextBox
    Friend WithEvents TXTBpassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents Label1 As Label
End Class
