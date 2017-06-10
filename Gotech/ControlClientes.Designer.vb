<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlClientes
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New Glass.GlassButton
        Me.Button2 = New Glass.GlassButton
        Me.Button1 = New Glass.GlassButton
        Me.Button4 = New Glass.GlassButton
        Me.Button5 = New Glass.GlassButton
        Me.busca2 = New Gotech.controlBuscaCliente
        Me.txtBuffer = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.fp1 = New System.Windows.Forms.FlowLayoutPanel
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.rsucursal = New System.Windows.Forms.RadioButton
        Me.rmatriz = New System.Windows.Forms.RadioButton
        Me.txtfax = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.txttelefono = New System.Windows.Forms.TextBox
        Me.txtactividad = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.busca2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.txtBuffer)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.fp1)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rsucursal)
        Me.GroupBox1.Controls.Add(Me.rmatriz)
        Me.GroupBox1.Controls.Add(Me.txtfax)
        Me.GroupBox1.Controls.Add(Me.txtdireccion)
        Me.GroupBox1.Controls.Add(Me.txttelefono)
        Me.GroupBox1.Controls.Add(Me.txtactividad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 429)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.GlowColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(490, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.Button3, "Elimina el Registro Actual")
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(490, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Actualizar"
        Me.ToolTip1.SetToolTip(Me.Button2, "Actualiza los datos Editados")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(490, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.Button1, "Guarda el Nuevo Registro")
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(490, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Button4, "Crea un nuevo Registro ")
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.GlowColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(425, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button5, "Muestra todos los usuarios")
        '
        'busca2
        '
        Me.busca2.Location = New System.Drawing.Point(71, 72)
        Me.busca2.Name = "busca2"
        Me.busca2.Size = New System.Drawing.Size(377, 199)
        Me.busca2.TabIndex = 17
        Me.busca2.Visible = False
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(478, 19)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(59, 20)
        Me.txtBuffer.TabIndex = 18
        Me.txtBuffer.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(528, 199)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "AgregarContacto"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Agrega un nuevo Contacto")
        '
        'fp1
        '
        Me.fp1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fp1.AutoScroll = True
        Me.fp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fp1.Location = New System.Drawing.Point(6, 217)
        Me.fp1.Name = "fp1"
        Me.fp1.Size = New System.Drawing.Size(610, 201)
        Me.fp1.TabIndex = 11
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(68, 25)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(51, 13)
        Me.lblcodigo.TabIndex = 13
        Me.lblcodigo.Text = "<Nuevo>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Código:"
        '
        'rsucursal
        '
        Me.rsucursal.AutoSize = True
        Me.rsucursal.Location = New System.Drawing.Point(282, 155)
        Me.rsucursal.Name = "rsucursal"
        Me.rsucursal.Size = New System.Drawing.Size(66, 17)
        Me.rsucursal.TabIndex = 6
        Me.rsucursal.TabStop = True
        Me.rsucursal.Text = "Sucursal"
        Me.rsucursal.UseVisualStyleBackColor = True
        '
        'rmatriz
        '
        Me.rmatriz.AutoSize = True
        Me.rmatriz.Checked = True
        Me.rmatriz.Location = New System.Drawing.Point(282, 134)
        Me.rmatriz.Name = "rmatriz"
        Me.rmatriz.Size = New System.Drawing.Size(53, 17)
        Me.rmatriz.TabIndex = 6
        Me.rmatriz.TabStop = True
        Me.rmatriz.Text = "Matriz"
        Me.rmatriz.UseVisualStyleBackColor = True
        '
        'txtfax
        '
        Me.txtfax.Location = New System.Drawing.Point(287, 104)
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Size = New System.Drawing.Size(160, 20)
        Me.txtfax.TabIndex = 5
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(71, 75)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(376, 20)
        Me.txtdireccion.TabIndex = 2
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(71, 105)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(177, 20)
        Me.txttelefono.TabIndex = 3
        '
        'txtactividad
        '
        Me.txtactividad.Location = New System.Drawing.Point(71, 133)
        Me.txtactividad.Name = "txtactividad"
        Me.txtactividad.Size = New System.Drawing.Size(177, 20)
        Me.txtactividad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Actividad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(71, 50)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(348, 20)
        Me.txtnombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtnombre, "Busca los usuarios por nombre")
        '
        'ControlClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlClientes"
        Me.Size = New System.Drawing.Size(640, 459)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuffer As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents fp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents busca2 As Gotech.controlBuscaCliente
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rsucursal As System.Windows.Forms.RadioButton
    Friend WithEvents rmatriz As System.Windows.Forms.RadioButton
    Friend WithEvents txtfax As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtactividad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As Glass.GlassButton
    Friend WithEvents Button4 As Glass.GlassButton
    Friend WithEvents Button3 As Glass.GlassButton
    Friend WithEvents Button2 As Glass.GlassButton
    Friend WithEvents Button1 As Glass.GlassButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
