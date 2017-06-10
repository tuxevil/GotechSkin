Public Class ControlProductos

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            accionBusca(False)

        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub





    Sub llenaDatos()
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.productos_retorna_por_codigo(Buffer.productosCodigo)

        Do While Rc.EOF = False
            lblcodigo.Text = Rc.Fields.Item("productos_codigo").Value
            txtnombre.Text = Rc.Fields.Item("productos_nombre").Value
            txtPrecio.Text = Rc.Fields.Item("productos_precio").Value.ToString()
            txtDetalle.Text = Rc.Fields.Item("productos_detalle").Value
            
            Rc.MoveNext()
        Loop
    End Sub



    Sub llenaPanelContactos()
        fp1.Controls.Clear()

        ' Dim Rc As ADODB.Recordset = contactos_retornaCodigos(Buffer.clientesCodigo)
        ' Do While Rc.EOF = False
        'Dim cc As New Controlcontactos
        'cc.llenaCasillas(Rc.Fields.Item("contactos_codigo").Value)
        'fp1.Controls.Add(cc)

        ' Rc.MoveNext()
        ' Loop
    End Sub



    Sub limpiar()
        lblcodigo.Text = "<Nuevo>"
        txtnombre.Text = ""
        txtPrecio.Text = ""
        txtDetalle.Text = ""

    End Sub

    Private Sub ControlClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        ini()
        txtnombre.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim cc As New Controlcontactos
        cc.modoAgregar()
        fp1.Controls.Add(cc)
    End Sub

    Private Sub txtBuffer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuffer.TextChanged
        llenaDatos()
        '  llenaPanelContactos()
        habilitarControles()
        Button1.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub accionBusca(ByVal vacio As Boolean)
        If vacio Then
            busca2.llenaLista()
            busca2.Visible = True
            busca2.Focus()
            busca2.ListView1.Focus()

        Else
            If txtnombre.Text = "" Then
                busca2.llenaLista()
            Else
                busca2.llenaLista(txtnombre.Text)
            End If

            busca2.Visible = True
            busca2.Focus()
            busca2.ListView1.Focus()

        End If
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub ini()
        deshabilitarControles()
        Busca2.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        txtnombre.Enabled = True
    End Sub


    Sub deshabilitarControles()
        For i As Integer = 0 To Me.Controls("GroupBox1").Controls.Count - 1
            Me.Controls("GroupBox1").Controls(i).Enabled = False
        Next
        Busca2.Enabled = True

    End Sub
    Sub habilitarControles()
        For i As Integer = 0 To Me.Controls("GroupBox1").Controls.Count - 1
            Me.Controls("GroupBox1").Controls(i).Enabled = True
        Next
        Busca2.Enabled = True

    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        accionBusca(True)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        limpiar()
        deshabilitarControles()
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DatosGotech.OLEDB.productos_guardar(txtnombre.Text, Double.Parse(txtPrecio.Text), txtDetalle.Text)
        ini()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        DatosGotech.OLEDB.productos_actualizar(Buffer.productosCodigo, txtnombre.Text, Double.Parse(txtPrecio.Text), txtDetalle.Text)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        DatosGotech.OLEDB.productos_eliminar(Buffer.productosCodigo)
        limpiar()
        ini()
    End Sub
End Class
