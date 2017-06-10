Public Class ControlClientes

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            accionBusca(False)

        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub





    Sub llenaDatos()
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Retorna_clientes_por_codigo(Buffer.clientesCodigo)

        Do While Rc.EOF = False
            lblcodigo.Text = Rc.Fields.Item("clientes_codigo").Value
            txtnombre.Text = Rc.Fields.Item("clientes_nombre").Value
            txtactividad.Text = Rc.Fields.Item("clientes_actividad").Value
            txtdireccion.Text = Rc.Fields.Item("clientes_direccion").Value
            txttelefono.Text = Rc.Fields.Item("clientes_telefono").Value
            txtfax.Text = Rc.Fields.Item("clientes_fax").Value
            If Rc.Fields.Item("clientes_esmatriz").Value = "1" Then
                rmatriz.Checked = True
            Else
                rsucursal.Checked = True
            End If
            Rc.MoveNext()
        Loop
    End Sub



    Sub llenaPanelContactos()
        fp1.Controls.Clear()

        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.contactos_retornaCodigos(Buffer.clientesCodigo)
        Do While Rc.EOF = False
            Dim cc As New Controlcontactos
            cc.llenaCasillas(Rc.Fields.Item("contactos_codigo").Value)
            fp1.Controls.Add(cc)

            Rc.MoveNext()
        Loop
    End Sub



    Sub limpiar()
        lblcodigo.Text = "<Nuevo>"
        txtnombre.Text = ""
        txtactividad.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtfax.Text = ""

    End Sub

    Private Sub ControlClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ini()
       
    End Sub


    Sub ini()
        limpiar()
        deshabilitarControles()

        txtnombre.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        busca2.Enabled = True
        fp1.Enabled = False
        LinkLabel1.Enabled = False
        txtnombre.Focus()
    End Sub


    Sub deshabilitarControles()
        For i As Integer = 0 To Me.Controls("GroupBox1").Controls.Count - 1
            Me.Controls("GroupBox1").Controls(i).Enabled = False
        Next


    End Sub
    Sub habilitarControles()
        For i As Integer = 0 To Me.Controls("GroupBox1").Controls.Count - 1
            Me.Controls("GroupBox1").Controls(i).Enabled = True
        Next


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
        llenaPanelContactos()
        habilitarControles()
        Button1.Enabled = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub limpiar_fp()
        fp1.Controls.Clear()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


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

    Private Sub busca2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles busca2.Load

    End Sub


    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        accionBusca(True)
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        habilitarControles()
        Button4.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        LinkLabel1.Enabled = False

        limpiar()
        limpiar_fp()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim matrix = 0
        If rmatriz.Checked Then
            matrix = 1
        Else
            matrix = 0
        End If
        DatosGotech.OLEDB.clientes_guardar(txtnombre.Text, txtactividad.Text, txtdireccion.Text, txttelefono.Text, txtfax.Text, matrix, Buffer.usuarioCodigo)

        limpiar()
        limpiar_fp()
        ini()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim matrix = 0
        If rmatriz.Checked Then
            matrix = 1
        Else
            matrix = 0
        End If

        DatosGotech.OLEDB.clientes_actualizar(Buffer.clientesCodigo, txtnombre.Text, txtactividad.Text, txtdireccion.Text, txttelefono.Text, txtfax.Text, matrix)


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DatosGotech.OLEDB.clientes_eliminar(Buffer.clientesCodigo)
        limpiar()
        ini()
    End Sub
End Class
