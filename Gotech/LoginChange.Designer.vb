<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginChange
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
        Me.t1 = New System.Windows.Forms.TextBox
        Me.t2 = New System.Windows.Forms.TextBox
        Me.GlassButton1 = New Glass.GlassButton
        Me.t3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(75, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contraseña Anterior:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(146, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nueva:"
        '
        't1
        '
        Me.t1.Location = New System.Drawing.Point(196, 34)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(99, 20)
        Me.t1.TabIndex = 3
        '
        't2
        '
        Me.t2.Location = New System.Drawing.Point(196, 61)
        Me.t2.Name = "t2"
        Me.t2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t2.Size = New System.Drawing.Size(99, 20)
        Me.t2.TabIndex = 4
        '
        'GlassButton1
        '
        Me.GlassButton1.Location = New System.Drawing.Point(115, 129)
        Me.GlassButton1.Name = "GlassButton1"
        Me.GlassButton1.OuterBorderColor = System.Drawing.Color.DimGray
        Me.GlassButton1.Size = New System.Drawing.Size(104, 31)
        Me.GlassButton1.TabIndex = 5
        Me.GlassButton1.Text = "Aceptar"
        '
        't3
        '
        Me.t3.Location = New System.Drawing.Point(195, 87)
        Me.t3.Name = "t3"
        Me.t3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t3.Size = New System.Drawing.Size(99, 20)
        Me.t3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(89, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Confirmar Nueva:"
        '
        'LoginChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.Gotech.My.Resources.Resources.login2
        Me.ClientSize = New System.Drawing.Size(306, 168)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.GlassButton1)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginChange"
        Me.Opacity = 0.9
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.Blue
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.TextBox
    Friend WithEvents t2 As System.Windows.Forms.TextBox
    Friend WithEvents GlassButton1 As Glass.GlassButton
    Friend WithEvents t3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
