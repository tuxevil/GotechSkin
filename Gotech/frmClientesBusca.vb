Public Class frmClientesBusca

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim t As New ListViewItem

        t.SubItems.Clear()
        t.Text = "001"

        t.SubItems.Add("juank")
        t.SubItems.Add("root")
        ListView1.Items.Add(t)

    End Sub

    Private Sub frmClientesBusca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llenaLista(TextBox1.Text)
        ListView1.Focus()
    End Sub

    Sub llenaLista(ByVal criterio As String)
        Dim Rc As ADODB.Recordset
        If criterio = "" Then
            Rc = clientes_retorna_todo("All")
        Else
            Rc = clientes_retorna_todo(criterio)
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
    End Sub


    Function clientes_retorna_todo(ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        '
        'Provider=SQLOLEDB;Data Source='servidor-dev\sqlexpress';Initial Catalog=Gotech;Persist Security Info=True;User ID=sa;Password=gotechdev
        Db.Open("Provider=SQLOLEDB;Data Source=servidor-dev\sqlexpress;Integrated Security=SSPI;Initial Catalog=Gotech")
        If nombreLike = "All" Then
            Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=usuarios.usuarios_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Else
            Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=usuarios.usuarios_codigo and clientes_nombre like '%" & nombreLike & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        End If
        Return Rc
    End Function

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            llenaLista(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
seleccionaCLiente()
    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        seleccionaCLiente()
    End Sub

    Sub seleccionaCLiente()
        If ListView1.SelectedItems.Count >= 1 Then
            Buffer.clientesCodigo = CInt(ListView1.SelectedItems(0).Text)
            Buffer.clientesNombre = ListView1.SelectedItems(0).SubItems(1).Text
            Me.Close()
        End If

    End Sub


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class