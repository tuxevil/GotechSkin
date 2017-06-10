Public Class ControlVentasEditar

    Dim lista1 As New List(Of Integer)
    Dim lista2 As New List(Of Integer)




    Sub Limpiar()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

        ComboBox2.SelectedItem = 0
        txtLicencia.Text = ""
        txtmac.Text = ""
        txtwindowsid.Text = ""
        txtServidorId.Text = ""
        Label8.Visible = False

    End Sub



    Sub llenaComboClientes()
        ComboBox1.Items.Clear()

        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Ventas_retorna_Clientes()
        Do While Rc.EOF = False
            ComboBox1.Items.Add(Rc.Fields.Item(0).Value & ". " & Rc.Fields.Item(1).Value)

            '            lista1.Add(Rc.Fields.Item(0).Value)
            Rc.MoveNext()
        Loop
    End Sub

    Sub llenaComboProductos()
        ComboBox2.Items.Clear()

        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Ventas_retorna_Productos(Buffer.clientesCodigo)
        Do While Rc.EOF = False
            ComboBox2.Items.Add(Rc.Fields.Item(0).Value & ". " & Rc.Fields.Item(1).Value)
            ' lista2.Add(Rc.Fields.Item(0).Value)
            Rc.MoveNext()
        Loop
    End Sub

    Sub llenaDatos()
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Ventas_Cliente_Producto(Buffer.clientesCodigo, Buffer.productosCodigo)
        Do While Rc.EOF = False
            Buffer.ventaCodigo = Rc.Fields.Item("ventas_codigo").Value
            txtLicencia.Text = Rc.Fields.Item("ventas_licencia").Value
            txtmac.Text = Rc.Fields.Item("ventas_mac").Value
            txtwindowsid.Text = Rc.Fields.Item("ventas_windowsid").Value
            txtServidorId.Text = Rc.Fields.Item("ventas_servidorid").Value
            dtPeriodo.Value = Rc.Fields.Item("ventas_periodo_validez").Value
            If dtPeriodo.Value < System.DateTime.Today Then
                Label8.Visible = True
            End If
            Rc.MoveNext()
        Loop
    End Sub


    Private Sub ControlVentasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ini()
    End Sub
    Sub ini()
        Limpiar()
        llenaComboClientes()
        deshabilitarControles()
        Label1.Enabled = True
        ComboBox1.Enabled = True
        Label8.Visible = False
    End Sub

    Sub deshabilitarControles()
        For i As Integer = 0 To Me.Controls.Count - 1
            Me.Controls(i).Enabled = False
        Next


    End Sub
    Sub habilitarControles()
        For i As Integer = 0 To Me.Controls.Count - 1
            Me.Controls(i).Enabled = True
        Next


    End Sub




    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

      
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ComboBox2_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedValueChanged

        Buffer.productosCodigo = ComboBox2.SelectedItem.ToString().Substring(0, ComboBox2.SelectedItem.ToString().IndexOf("."))
        ' lista2.Item(ComboBox2.SelectedIndex)
        Buffer.productosNombre = ComboBox2.SelectedItem
        llenaDatos()
        If Buffer.pVentasEditar = 1 Then
            habilitarControles()
        Else
            habilitarControles()
            Button1.Enabled = False
            Button2.Enabled = False
        End If



    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        Buffer.clientesCodigo = ComboBox1.SelectedItem.ToString().Substring(0, ComboBox1.SelectedItem.ToString().IndexOf("."))

        '  lista1.Item(ComboBox1.SelectedIndex)
        Buffer.clientesNombre = ComboBox1.SelectedItem
        llenaComboProductos()
        ComboBox2.Enabled = True
    End Sub

    Private Sub ComboBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged

    End Sub

    Private Sub ComboBox2_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.ValueMemberChanged
     
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        DatosGotech.OLEDB.ventas_eliminar(Buffer.ventaCodigo)
        Limpiar()
        llenaComboClientes()
        ini()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DatosGotech.OLEDB.ventas_actualizar(Buffer.ventaCodigo, Buffer.clientesCodigo, Buffer.productosCodigo, txtLicencia.Text, dtPeriodo.Value, txtmac.Text, txtwindowsid.Text, txtServidorId.Text)



    End Sub
End Class
