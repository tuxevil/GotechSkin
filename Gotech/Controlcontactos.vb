Public Class Controlcontactos

    Dim codigoActual As Integer
    Dim magregar As Boolean = False
    Dim llamo_para_agregar As Boolean = False





    Private Sub Controlcontactos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub modoAgregar()
        magregar = True
        llamo_para_agregar = True
        GroupBox1.Text = "< Nuevo >"
        txtnombres.Visible = True
        txtCargo.Visible = True
        txtExtencion.Visible = True
        txtCelular.Visible = True
        txtEmail.Visible = True
    End Sub



    Sub llenaCasillas(ByVal codigo As Integer)

        Me.codigoActual = codigo
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.contacto_por_Codigo(codigo)
        Do While Rc.EOF = False
            GroupBox1.Text = "Código: " + codigo.ToString
            lblnombre.Text = Rc.Fields.Item("contactos_nombres").Value
            lblcargo.Text = Rc.Fields.Item("contactos_cargo").Value
            lblextencion.Text = Rc.Fields.Item("contactos_extencion").Value
            lblcelular.Text = Rc.Fields.Item("contactos_celular").Value
            lblEmail.Text = Rc.Fields.Item("contactos_email").Value
            Rc.MoveNext()
        Loop
    End Sub




    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        txtnombres.Text = lblnombre.Text

        txtCargo.Text = lblcargo.Text
        txtExtencion.Text = lblextencion.Text
        txtCelular.Text = lblcelular.Text
        txtEmail.Text = lblEmail.Text

        txtnombres.Visible = True
        txtCargo.Visible = True
        txtExtencion.Visible = True
        txtCelular.Visible = True
        txtEmail.Visible = True

    End Sub



    Public Function UltimoCodigo() As Integer

        Dim rr As Integer
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.contacto_Last_Codigo(Buffer.clientesCodigo)

        Do While Rc.EOF = False
            rr = Rc.Fields.Item("maximo").Value
            Rc.MoveNext()
        Loop

        Return CInt(rr)
    End Function

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If magregar Then
            DatosGotech.OLEDB.contactosGuardar(Buffer.clientesCodigo, txtnombres.Text, txtCargo.Text, txtExtencion.Text, txtCelular.Text, txtEmail.Text)

            GroupBox1.Text = "Código: "
            lblnombre.Text = txtnombres.Text
            lblcargo.Text = txtCargo.Text
            lblextencion.Text = txtExtencion.Text
            lblcelular.Text = txtCelular.Text
            lblEmail.Text = txtEmail.Text


            txtnombres.Visible = False
            txtCargo.Visible = False
            txtExtencion.Visible = False
            txtCelular.Visible = False
            txtEmail.Visible = False


        Else
            DatosGotech.OLEDB.contactosActualizar(codigoActual, txtnombres.Text, txtCargo.Text, txtExtencion.Text, txtCelular.Text, txtEmail.Text)
            llenaCasillas(Me.codigoActual)
            txtnombres.Visible = False
            txtCargo.Visible = False
            txtExtencion.Visible = False
            txtCelular.Visible = False
            txtEmail.Visible = False
        End If

      

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If llamo_para_agregar Then
            DatosGotech.OLEDB.contactos_eliminar(UltimoCodigo())
        Else
            DatosGotech.OLEDB.contactos_eliminar(Me.codigoActual)
        End If
        Me.Dispose()

    End Sub

   
End Class
