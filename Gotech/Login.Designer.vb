<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.GlassButton1 = New Glass.GlassButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UserName :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(98, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(169, 55)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(99, 20)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(169, 81)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(99, 20)
        Me.txtPass.TabIndex = 4
        '
        'GlassButton1
        '
        Me.GlassButton1.Location = New System.Drawing.Point(121, 130)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.DimGray
        Me.GlassButton1.Size = New System.Drawing.Size(104, 31)
        Me.GlassButton1.TabIndex = 5
        Me.GlassButton1.Text = "Aceptar"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(130, 108)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Cambiar Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.Gotech.My.Resources.Resources.login1
        Me.ClientSize = New System.Drawing.Size(306, 168)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.9
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents GlassButton1 As Glass.GlassButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
