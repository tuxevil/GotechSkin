Public Class controlVentas

    Dim flag1 As Boolean = False







    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub controlVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ini()
    End Sub

    Sub ini()
        deshabilitarControles()
        txtProducto.Enabled = False
        txtCliente.Enabled = False
        Button4.Enabled = False
        Button3.Enabled = False
        Label6.Enabled = False
        Label7.Enabled = False
        Button1.Enabled = False


    End Sub


    Private Sub txtCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCliente.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            
            buscaCliente(False)
        End If
    End Sub

    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged

    End Sub

    Sub buscaCliente(ByVal vacio As Boolean)
        If vacio Then


            BuscaC.llenaLista()


            BuscaC.Visible = True
            BuscaC.Focus()
            BuscaC.ListView1.Focus()
        Else
            If txtCliente.Text = "" Then
                BuscaC.llenaLista()
            Else
                BuscaC.llenaLista(txtCliente.Text)
            End If

            BuscaC.Visible = True
            BuscaC.Focus()
            BuscaC.ListView1.Focus()
        End If

    End Sub

    Private Sub txtProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            buscaProducto(False)
        End If
    End Sub

    Sub buscaProducto(ByVal vacio As Boolean)

        If vacio Then
            flag1 = True
            buscaP.llenaLista()

            buscaP.Visible = True
            buscaP.Focus()
            buscaP.ListView1.Focus()

        Else
            flag1 = True
            If txtProducto.Text = "" Then
                buscaP.llenaLista()
            Else
                buscaP.llenaLista(txtProducto.Text)
            End If

            buscaP.Visible = True
            buscaP.Focus()
            buscaP.ListView1.Focus()

        End If

    End Sub

    Private Sub txtProducto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProducto.TextChanged

    End Sub

    Private Sub txtBuffer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuffer.TextChanged
        txtCliente.Text = " " + Buffer.clientesCodigo.ToString() + ".- " + Buffer.clientesNombre
        If flag1 Then
            txtProducto.Text = " " + Buffer.productosCodigo.ToString() + ".- " + Buffer.productosNombre
        End If

          End Sub

    Sub Limpiar()

        txtLicencia.Text = ""
        txtmac.Text = ""
        txtwindowsid.Text = ""
        txtServidorId.Text = ""

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        buscaCliente(True)
    End Sub

  
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        buscaProducto(True)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Limpiar()
        habilitarControles()
        txtProducto.Enabled = True
        txtCliente.Enabled = True
        Button4.Enabled = True
        Button3.Enabled = True
        Label6.Enabled = True
        Label7.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DatosGotech.OLEDB.ventas_guardar(Buffer.clientesCodigo, Buffer.productosCodigo, txtLicencia.Text, dtPeriodo.Value, txtmac.Text, txtwindowsid.Text, txtServidorId.Text)
        ini()
    End Sub
End Class
