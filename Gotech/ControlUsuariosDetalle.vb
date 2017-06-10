Public Class ControlUsuariosDetalle

    Dim codigoActual As Integer
    Dim magregar As Boolean = False
    Dim llamo_para_agregar As Boolean = False





    Private Sub Controlcontactos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub modoAgregar()
        magregar = True
        llamo_para_agregar = True
        GroupBox1.Text = "< Nuevo >"
        txtnombre.Visible = True
        txtapellido.Visible = True
        txtUsername.Visible = True
        txtPassword.Visible = True
        txtCelular.Visible = True
        txtEmail.Visible = True
    End Sub



    Sub llenaCasillas(ByVal codigo As Integer)

        Me.codigoActual = codigo
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Usuario_por_Codigo(codigo, Buffer.tipoCodigo)
        Do While Rc.EOF = False
            GroupBox1.Text = "Código: " + codigo.ToString
            lblnombre.Text = Rc.Fields.Item("usuarios_nombre").Value
            lblapellido.Text = Rc.Fields.Item("usuarios_apellido").Value
            lblUserName.Text = Rc.Fields.Item("usuarios_username").Value
            For i As Integer = 0 To Rc.Fields.Item("usuarios_password").Value.ToString.Length - 1
                lblPassword.Text = lblPassword.Text + "*"
            Next
             lblEmail.Text = Rc.Fields.Item("usuarios_email").Value
            lblcelular.Text = Rc.Fields.Item("usuarios_celular").Value
            Rc.MoveNext()
        Loop
    End Sub

   


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        txtnombre.Text = lblnombre.Text
        txtapellido.Text = lblapellido.Text
        txtUsername.Text = lblUserName.Text
        txtPassword.Text = lblPassword.Text
        txtCelular.Text = lblcelular.Text
        txtEmail.Text = lblEmail.Text

        txtnombre.Visible = True
        txtapellido.Visible = True
        txtUsername.Visible = True
        txtPassword.Visible = True
        txtCelular.Visible = True
        txtEmail.Visible = True

    End Sub



    Public Function UltimoCodigo() As Integer

        Dim rr As Integer
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.usuarios_Last_Codigo(Buffer.tipoCodigo)

        Do While Rc.EOF = False
            rr = Rc.Fields.Item("maximo").Value
            Rc.MoveNext()
        Loop

        Return CInt(rr)
    End Function

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If magregar Then
            DatosGotech.OLEDB.usuariosGuardar(txtnombre.Text, txtapellido.Text, txtUsername.Text, txtPassword.Text, txtCelular.Text, txtEmail.Text, Buffer.tipoCodigo)

            GroupBox1.Text = "Código: "
            lblnombre.Text = txtnombre.Text
            lblapellido.Text = txtapellido.Text
            lblUserName.Text = txtUsername.Text
            For i As Integer = 0 To txtPassword.Text.Length - 1
                lblPassword.Text = lblPassword.Text + "*"
            Next
            Dim pass2 As String

            lblcelular.Text = txtCelular.Text
            lblEmail.Text = txtEmail.Text


            txtnombre.Visible = False
            txtapellido.Visible = False
            txtUsername.Visible = False
            txtPassword.Visible = False
            txtCelular.Visible = False
            txtEmail.Visible = False


        Else
            DatosGotech.OLEDB.UsuariosActualizar(codigoActual, txtnombre.Text, txtapellido.Text, txtUsername.Text, txtPassword.Text, txtCelular.Text, txtEmail.Text, Buffer.tipoCodigo)
            llenaCasillas(Me.codigoActual)
            txtnombre.Visible = False
            txtapellido.Visible = False
            txtUsername.Visible = False
            txtPassword.Visible = False
            txtCelular.Visible = False
            txtEmail.Visible = False
        End If



    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If llamo_para_agregar Then
            DatosGotech.OLEDB.usuarios_eliminar(UltimoCodigo())
        Else
            DatosGotech.OLEDB.usuarios_eliminar(Me.codigoActual)
        End If
        Me.Dispose()

    End Sub



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
