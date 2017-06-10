<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlProductos
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
        Me.txtDetalle = New System.Windows.Forms.TextBox
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.fp1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Busca2 = New Gotech.controlBuscaProducto
        Me.txtBuffer = New System.Windows.Forms.TextBox
        Me.Button4 = New Glass.GlassButton
        Me.Button3 = New Glass.GlassButton
        Me.Button2 = New Glass.GlassButton
        Me.Button1 = New Glass.GlassButton
        Me.Button5 = New Glass.GlassButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(71, 75)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(217, 20)
        Me.txtDetalle.TabIndex = 8
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(71, 102)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Detalle:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio:"
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
        Me.txtnombre.Size = New System.Drawing.Size(217, 20)
        Me.txtnombre.TabIndex = 0
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
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(457, 163)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 13)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "AgregarContacto"
        Me.LinkLabel1.Visible = False
        '
        'fp1
        '
        Me.fp1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fp1.AutoScroll = True
        Me.fp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fp1.Location = New System.Drawing.Point(6, 180)
        Me.fp1.Name = "fp1"
        Me.fp1.Size = New System.Drawing.Size(541, 238)
        Me.fp1.TabIndex = 5
        Me.fp1.Visible = False
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Busca2)
        Me.GroupBox1.Controls.Add(Me.txtBuffer)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.fp1)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDetalle)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 429)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'Busca2
        '
        Me.Busca2.Location = New System.Drawing.Point(71, 72)
        Me.Busca2.Name = "Busca2"
        Me.Busca2.Size = New System.Drawing.Size(295, 199)
        Me.Busca2.TabIndex = 19
        Me.Busca2.Visible = False
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(478, 19)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(59, 20)
        Me.txtBuffer.TabIndex = 18
        Me.txtBuffer.Visible = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.GlowColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(294, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "?"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.GlowColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(387, 134)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(387, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Actualizar"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(387, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Guardar"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(387, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 26
        Me.Button5.Text = "Nuevo"
        '
        'ControlProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlProductos"
        Me.Size = New System.Drawing.Size(571, 459)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents fp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Busca2 As Gotech.controlBuscaProducto
    Friend WithEvents Button4 As Glass.GlassButton
    Friend WithEvents Button3 As Glass.GlassButton
    Friend WithEvents Button2 As Glass.GlassButton
    Friend WithEvents Button1 As Glass.GlassButton
    Friend WithEvents Button5 As Glass.GlassButton

End Class
