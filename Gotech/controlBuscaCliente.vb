Public Class controlBuscaCliente



    Private Sub controlBuscaContacto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 27 Then
            Me.Visible = False
        End If
    End Sub

    Private Sub controlBuscaContacto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Sub llenaLista()
        Dim Rc As ADODB.Recordset
        If Buffer.pClientes = 1 And Buffer.pSeguimientos = 1 And Buffer.pProductos = 1 And Buffer.pVentasRealizar = 1 And Buffer.pVentasConsultar = 1 And Buffer.pVentasEditar = 1 And Buffer.pUsuarios = 1 Then
            Rc = DatosGotech.OLEDB.clientes_retornaTodo()
        Else
            Rc = DatosGotech.OLEDB.clientes_retornaTodo(Buffer.usuarioCodigo)
        End If
        ListView1.Items.Clear()
        Do While Rc.EOF = False
            Dim t As New ListViewItem
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item(0).Value
            t.SubItems.Add(Rc.Fields.Item(1).Value)
            t.SubItems.Add(Rc.Fields.Item(2).Value)
            ListView1.Items.Add(t)
            Rc.MoveNext()
        Loop
        ListView1.Focus()
    End Sub

    Sub llenaLista(ByVal criterio As String)
        Dim Rc As ADODB.Recordset
        If Buffer.pClientes = 1 And Buffer.pSeguimientos = 1 And Buffer.pProductos = 1 And Buffer.pVentasRealizar = 1 And Buffer.pVentasConsultar = 1 And Buffer.pVentasEditar = 1 And Buffer.pUsuarios = 1 Then
            Rc = DatosGotech.OLEDB.clientes_retornaTodo_LIKE(criterio)
        Else
            Rc = DatosGotech.OLEDB.clientes_retornaTodo_LIKE(Buffer.usuarioCodigo, criterio)
        End If
        ListView1.Items.Clear()
        Do While Rc.EOF = False
            Dim t As New ListViewItem
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item(0).Value
            t.SubItems.Add(Rc.Fields.Item(1).Value)
            t.SubItems.Add(Rc.Fields.Item(2).Value)
            ListView1.Items.Add(t)
            Rc.MoveNext()
        Loop
        ListView1.Focus()
    End Sub



   

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub



    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        seleccionaContacto()
    End Sub

    Private Sub ListView1_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then

            seleccionaContacto()


        ElseIf keyascii = 27 Then
            Me.Visible = False
        End If
    End Sub
    Sub seleccionaContacto()
        If ListView1.SelectedItems.Count >= 1 Then
            Buffer.clientesCodigo = CInt(ListView1.SelectedItems(0).Text)
            Buffer.clientesNombre = ListView1.SelectedItems(0).SubItems(1).Text

            'reflejo = Me.Parent

            'reflejo.llenaDatos()
            'reflejo.llenaPanelContactos()
            Me.Parent.Controls("txtBuffer").Text = Me.Parent.Controls("txtBuffer").Text + "a"
            ' Me.Parent.Controls("textnombre").Text = "  " + Buffer.clientesCodigo.ToString() + " .- " + Buffer.clientesNombre

            Me.Visible = False
        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
