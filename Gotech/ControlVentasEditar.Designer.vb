<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVentasEditar
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtServidorId = New System.Windows.Forms.TextBox
        Me.txtwindowsid = New System.Windows.Forms.TextBox
        Me.txtmac = New System.Windows.Forms.TextBox
        Me.dtPeriodo = New System.Windows.Forms.DateTimePicker
        Me.txtLicencia = New System.Windows.Forms.TextBox
        Me.Button1 = New Glass.GlassButton
        Me.Button2 = New Glass.GlassButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(44, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(226, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(291, 42)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(288, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "ServidorID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "WindowsID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "MAC :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Período de Validez :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Licencia :"
        '
        'txtServidorId
        '
        Me.txtServidorId.Location = New System.Drawing.Point(369, 147)
        Me.txtServidorId.Name = "txtServidorId"
        Me.txtServidorId.Size = New System.Drawing.Size(100, 20)
        Me.txtServidorId.TabIndex = 5
        '
        'txtwindowsid
        '
        Me.txtwindowsid.Location = New System.Drawing.Point(369, 121)
        Me.txtwindowsid.Name = "txtwindowsid"
        Me.txtwindowsid.Size = New System.Drawing.Size(100, 20)
        Me.txtwindowsid.TabIndex = 4
        '
        'txtmac
        '
        Me.txtmac.Location = New System.Drawing.Point(369, 95)
        Me.txtmac.Name = "txtmac"
        Me.txtmac.Size = New System.Drawing.Size(100, 20)
        Me.txtmac.TabIndex = 3
        '
        'dtPeriodo
        '
        Me.dtPeriodo.Location = New System.Drawing.Point(44, 141)
        Me.dtPeriodo.Name = "dtPeriodo"
        Me.dtPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.dtPeriodo.TabIndex = 6
        '
        'txtLicencia
        '
        Me.txtLicencia.Location = New System.Drawing.Point(44, 95)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(226, 20)
        Me.txtLicencia.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(388, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Actualizar"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(292, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Eliminar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(45, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 20)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Validez Expiró !!!"
        Me.Label8.Visible = False
        '
        'ControlVentasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtServidorId)
        Me.Controls.Add(Me.txtwindowsid)
        Me.Controls.Add(Me.txtmac)
        Me.Controls.Add(Me.dtPeriodo)
        Me.Controls.Add(Me.txtLicencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "ControlVentasEditar"
        Me.Size = New System.Drawing.Size(516, 250)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServidorId As System.Windows.Forms.TextBox
    Friend WithEvents txtwindowsid As System.Windows.Forms.TextBox
    Friend WithEvents txtmac As System.Windows.Forms.TextBox
    Friend WithEvents dtPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As Glass.GlassButton
    Friend WithEvents Button2 As Glass.GlassButton
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
