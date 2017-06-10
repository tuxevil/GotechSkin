<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlVentas
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
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServidorId = New System.Windows.Forms.TextBox
        Me.txtwindowsid = New System.Windows.Forms.TextBox
        Me.txtmac = New System.Windows.Forms.TextBox
        Me.dtPeriodo = New System.Windows.Forms.DateTimePicker
        Me.txtLicencia = New System.Windows.Forms.TextBox
        Me.txtBuffer = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.BuscaC = New Gotech.controlBuscaCliente
        Me.buscaP = New Gotech.controlBuscaProducto
        Me.Button4 = New Glass.GlassButton
        Me.Button3 = New Glass.GlassButton
        Me.Button1 = New Glass.GlassButton
        Me.Button2 = New Glass.GlassButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(31, 61)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(226, 20)
        Me.txtCliente.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(336, 61)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(206, 20)
        Me.txtProducto.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cliente :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Producto :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServidorId)
        Me.GroupBox1.Controls.Add(Me.txtwindowsid)
        Me.GroupBox1.Controls.Add(Me.txtmac)
        Me.GroupBox1.Controls.Add(Me.dtPeriodo)
        Me.GroupBox1.Controls.Add(Me.txtLicencia)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(544, 166)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(183, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ServidorID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "WindowsID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "MAC :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(302, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Período de Validez :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Licencia :"
        '
        'txtServidorId
        '
        Me.txtServidorId.Location = New System.Drawing.Point(264, 138)
        Me.txtServidorId.Name = "txtServidorId"
        Me.txtServidorId.Size = New System.Drawing.Size(100, 20)
        Me.txtServidorId.TabIndex = 9
        '
        'txtwindowsid
        '
        Me.txtwindowsid.Location = New System.Drawing.Point(264, 112)
        Me.txtwindowsid.Name = "txtwindowsid"
        Me.txtwindowsid.Size = New System.Drawing.Size(100, 20)
        Me.txtwindowsid.TabIndex = 8
        '
        'txtmac
        '
        Me.txtmac.Location = New System.Drawing.Point(264, 86)
        Me.txtmac.Name = "txtmac"
        Me.txtmac.Size = New System.Drawing.Size(100, 20)
        Me.txtmac.TabIndex = 7
        '
        'dtPeriodo
        '
        Me.dtPeriodo.Location = New System.Drawing.Point(305, 36)
        Me.dtPeriodo.Name = "dtPeriodo"
        Me.dtPeriodo.Size = New System.Drawing.Size(200, 20)
        Me.dtPeriodo.TabIndex = 6
        '
        'txtLicencia
        '
        Me.txtLicencia.Location = New System.Drawing.Point(24, 36)
        Me.txtLicencia.Name = "txtLicencia"
        Me.txtLicencia.Size = New System.Drawing.Size(226, 20)
        Me.txtLicencia.TabIndex = 5
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(43, 273)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(107, 20)
        Me.txtBuffer.TabIndex = 22
        Me.txtBuffer.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Código :"
        Me.Label8.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(80, 10)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(57, 13)
        Me.lblCodigo.TabIndex = 18
        Me.lblCodigo.Text = "< Nuevo >"
        Me.lblCodigo.Visible = False
        '
        'BuscaC
        '
        Me.BuscaC.Location = New System.Drawing.Point(31, 82)
        Me.BuscaC.Name = "BuscaC"
        Me.BuscaC.Size = New System.Drawing.Size(307, 169)
        Me.BuscaC.TabIndex = 15
        Me.BuscaC.Visible = False
        '
        'buscaP
        '
        Me.buscaP.Location = New System.Drawing.Point(341, 83)
        Me.buscaP.Name = "buscaP"
        Me.buscaP.Size = New System.Drawing.Size(239, 174)
        Me.buscaP.TabIndex = 14
        Me.buscaP.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.GlowColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(258, 59)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "?"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.GlowColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(543, 59)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(496, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(400, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Nuevo"
        '
        'controlVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtBuffer)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BuscaC)
        Me.Controls.Add(Me.buscaP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "controlVentas"
        Me.Size = New System.Drawing.Size(597, 323)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents buscaP As Gotech.controlBuscaProducto
    Friend WithEvents BuscaC As Gotech.controlBuscaCliente
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtServidorId As System.Windows.Forms.TextBox
    Friend WithEvents txtwindowsid As System.Windows.Forms.TextBox
    Friend WithEvents txtmac As System.Windows.Forms.TextBox
    Friend WithEvents dtPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLicencia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As Glass.GlassButton
    Friend WithEvents Button3 As Glass.GlassButton
    Friend WithEvents Button1 As Glass.GlassButton
    Friend WithEvents Button2 As Glass.GlassButton

End Class
