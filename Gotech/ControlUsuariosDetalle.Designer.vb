<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUsuariosDetalle
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtCelular = New System.Windows.Forms.TextBox
        Me.txtapellido = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblcelular = New System.Windows.Forms.Label
        Me.lblapellido = New System.Windows.Forms.Label
        Me.lblnombre = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cargo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "celular:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-mail:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblcelular)
        Me.GroupBox1.Controls.Add(Me.lblapellido)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 102)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(266, 42)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(101, 20)
        Me.txtPassword.TabIndex = 22
        Me.txtPassword.Visible = False
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(75, 41)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(101, 20)
        Me.txtUsername.TabIndex = 21
        Me.txtUsername.Visible = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(76, 44)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 20
        Me.lblUserName.Text = "Extencion :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(263, 44)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblPassword.TabIndex = 19
        Me.lblPassword.Text = "Password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "UserName :"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(529, 15)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(53, 13)
        Me.LinkLabel3.TabIndex = 17
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Actualizar"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(266, 71)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(140, 20)
        Me.txtEmail.TabIndex = 16
        Me.txtEmail.Visible = False
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(75, 71)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(96, 20)
        Me.txtCelular.TabIndex = 15
        Me.txtCelular.Visible = False
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(266, 16)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(140, 20)
        Me.txtapellido.TabIndex = 13
        Me.txtapellido.Visible = False
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(75, 15)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(134, 20)
        Me.txtnombre.TabIndex = 12
        Me.txtnombre.Visible = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(588, 15)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(43, 13)
        Me.LinkLabel2.TabIndex = 11
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Eliminar"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(489, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(34, 13)
        Me.LinkLabel1.TabIndex = 10
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Editar"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(263, 74)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Label6"
        '
        'lblcelular
        '
        Me.lblcelular.AutoSize = True
        Me.lblcelular.Location = New System.Drawing.Point(76, 74)
        Me.lblcelular.Name = "lblcelular"
        Me.lblcelular.Size = New System.Drawing.Size(39, 13)
        Me.lblcelular.TabIndex = 8
        Me.lblcelular.Text = "Label6"
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.Location = New System.Drawing.Point(263, 16)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(39, 13)
        Me.lblapellido.TabIndex = 6
        Me.lblapellido.Text = "Label6"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(76, 16)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(39, 13)
        Me.lblnombre.TabIndex = 5
        Me.lblnombre.Text = "Label6"
        '
        'ControlUsuariosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlUsuariosDetalle"
        Me.Size = New System.Drawing.Size(645, 115)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcelular As System.Windows.Forms.Label
    Friend WithEvents lblapellido As System.Windows.Forms.Label
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
