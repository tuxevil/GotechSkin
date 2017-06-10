<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUsuarios
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
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.fp1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New Glass.GlassButton
        Me.Busca2 = New Gotech.controlBuscaTipos
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.c6 = New System.Windows.Forms.CheckBox
        Me.c5 = New System.Windows.Forms.CheckBox
        Me.c7 = New System.Windows.Forms.CheckBox
        Me.c2 = New System.Windows.Forms.CheckBox
        Me.c1 = New System.Windows.Forms.CheckBox
        Me.c3 = New System.Windows.Forms.CheckBox
        Me.c4 = New System.Windows.Forms.CheckBox
        Me.Button2 = New Glass.GlassButton
        Me.Button1 = New Glass.GlassButton
        Me.Button3 = New Glass.GlassButton
        Me.Button4 = New Glass.GlassButton
        Me.txtBuffer = New System.Windows.Forms.TextBox
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de Usuario :"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(10, 71)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(380, 26)
        Me.txtnombre.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(493, 203)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 20)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Agregar Usuario"
        '
        'fp1
        '
        Me.fp1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fp1.AutoScroll = True
        Me.fp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fp1.Location = New System.Drawing.Point(6, 226)
        Me.fp1.Name = "fp1"
        Me.fp1.Size = New System.Drawing.Size(612, 229)
        Me.fp1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Código:"
        Me.Label6.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Busca2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.txtBuffer)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.fp1)
        Me.GroupBox1.Controls.Add(Me.lblcodigo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 461)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(449, 71)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Nuevo"
        '
        'Busca2
        '
        Me.Busca2.Location = New System.Drawing.Point(10, 97)
        Me.Busca2.Name = "Busca2"
        Me.Busca2.Size = New System.Drawing.Size(380, 155)
        Me.Busca2.TabIndex = 0
        Me.Busca2.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c6)
        Me.GroupBox2.Controls.Add(Me.c5)
        Me.GroupBox2.Controls.Add(Me.c7)
        Me.GroupBox2.Controls.Add(Me.c2)
        Me.GroupBox2.Controls.Add(Me.c1)
        Me.GroupBox2.Controls.Add(Me.c3)
        Me.GroupBox2.Controls.Add(Me.c4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 88)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permisos"
        '
        'c6
        '
        Me.c6.AutoSize = True
        Me.c6.Location = New System.Drawing.Point(248, 65)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(89, 17)
        Me.c6.TabIndex = 36
        Me.c6.Text = "Editar Ventas"
        Me.c6.UseVisualStyleBackColor = True
        '
        'c5
        '
        Me.c5.AutoSize = True
        Me.c5.Location = New System.Drawing.Point(248, 44)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(106, 17)
        Me.c5.TabIndex = 35
        Me.c5.Text = "Consultar Ventas"
        Me.c5.UseVisualStyleBackColor = True
        '
        'c7
        '
        Me.c7.AutoSize = True
        Me.c7.Location = New System.Drawing.Point(350, 23)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(67, 17)
        Me.c7.TabIndex = 34
        Me.c7.Text = "Usuarios"
        Me.c7.UseVisualStyleBackColor = True
        '
        'c2
        '
        Me.c2.AutoSize = True
        Me.c2.Location = New System.Drawing.Point(73, 23)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(89, 17)
        Me.c2.TabIndex = 33
        Me.c2.Text = "Seguimientos"
        Me.c2.UseVisualStyleBackColor = True
        '
        'c1
        '
        Me.c1.AutoSize = True
        Me.c1.Location = New System.Drawing.Point(13, 23)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(63, 17)
        Me.c1.TabIndex = 32
        Me.c1.Text = "Clientes"
        Me.c1.UseVisualStyleBackColor = True
        '
        'c3
        '
        Me.c3.AutoSize = True
        Me.c3.Location = New System.Drawing.Point(168, 23)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(74, 17)
        Me.c3.TabIndex = 31
        Me.c3.Text = "Productos"
        Me.c3.UseVisualStyleBackColor = True
        '
        'c4
        '
        Me.c4.AutoSize = True
        Me.c4.Location = New System.Drawing.Point(248, 23)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(100, 17)
        Me.c4.TabIndex = 30
        Me.c4.Text = "Realizar Ventas"
        Me.c4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(449, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Actualizar"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(449, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Guardar"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.GlowColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(449, 120)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Eliminar"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.GlowColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(396, 71)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 26)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "?"
        '
        'txtBuffer
        '
        Me.txtBuffer.Location = New System.Drawing.Point(543, 16)
        Me.txtBuffer.Name = "txtBuffer"
        Me.txtBuffer.Size = New System.Drawing.Size(59, 20)
        Me.txtBuffer.TabIndex = 18
        Me.txtBuffer.Visible = False
        '
        'lblcodigo
        '
        Me.lblcodigo.AutoSize = True
        Me.lblcodigo.Location = New System.Drawing.Point(88, 19)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(51, 13)
        Me.lblcodigo.TabIndex = 13
        Me.lblcodigo.Text = "<Nuevo>"
        Me.lblcodigo.Visible = False
        '
        'ControlUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlUsuarios"
        Me.Size = New System.Drawing.Size(642, 491)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents fp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuffer As System.Windows.Forms.TextBox
    Friend WithEvents Busca2 As Gotech.controlBuscaTipos
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Button4 As Glass.GlassButton
    Friend WithEvents Button2 As Glass.GlassButton
    Friend WithEvents Button1 As Glass.GlassButton
    Friend WithEvents Button3 As Glass.GlassButton
    Friend WithEvents c1 As System.Windows.Forms.CheckBox
    Friend WithEvents c3 As System.Windows.Forms.CheckBox
    Friend WithEvents c4 As System.Windows.Forms.CheckBox
    Friend WithEvents c7 As System.Windows.Forms.CheckBox
    Friend WithEvents c2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c5 As System.Windows.Forms.CheckBox
    Friend WithEvents c6 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As Glass.GlassButton

End Class
