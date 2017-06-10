Public Class ControlUsuarios

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            accionBusca(False)

        End If
    End Sub

    Sub accionBusca(ByVal vacio As Boolean)
        If vacio Then
            Busca2.llenaLista()
        Else
            If txtnombre.Text = "" Then
                Busca2.llenaLista()
            Else
                Busca2.llenaLista(txtnombre.Text)
            End If
        End If
        

        Busca2.Visible = True
        Busca2.Focus()
        Busca2.ListView1.Focus()


        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = False
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub





    Sub llenaDatos()
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.Retorna_tipos_por_codigo(Buffer.tipoCodigo)

        Do While Rc.EOF = False
            lblcodigo.Text = Rc.Fields.Item("tipo_codigo").Value
            txtnombre.Text = Rc.Fields.Item("tipo_nombre").Value
            If Rc.Fields.Item("pClientes").Value Then
                c1.Checked = True
                Buffer.fc1 = 1
            Else
                c1.Checked = False
                Buffer.fc1 = 0
            End If

            If Rc.Fields.Item("pSeguimientos").Value Then
                c2.Checked = True
                Buffer.fc2 = 1
            Else
                c2.Checked = False
                Buffer.fc2 = 0
            End If

            If Rc.Fields.Item("pProductos").Value Then
                c3.Checked = True
                Buffer.fc3 = 1
            Else
                c3.Checked = False
                Buffer.fc3 = 0
            End If

            If Rc.Fields.Item("pVentasRealizar").Value Then
                c4.Checked = True
                Buffer.fc4 = 1
            Else
                c4.Checked = False
                Buffer.fc4 = 0
            End If

            If Rc.Fields.Item("pVentasConsultar").Value Then
                c5.Checked = True
                Buffer.fc5 = 1
            Else
                c5.Checked = False
                Buffer.fc5 = 0
            End If

            If Rc.Fields.Item("pVentasEditar").Value Then
                c6.Checked = True
                Buffer.fc6 = 1
            Else
                c6.Checked = False
                Buffer.fc6 = 0
            End If

            If Rc.Fields.Item("pUsuarios").Value Then
                c7.Checked = True
                Buffer.fc7 = 1
            Else
                c7.Checked = False
                Buffer.fc7 = 0
            End If


            Rc.MoveNext()
        Loop
    End Sub



    Sub llenaPanelUsuarios()

        fp1.Controls.Clear()
        Dim Rc As ADODB.Recordset = DatosGotech.OLEDB.usuarios_retornaCodigos(Buffer.tipoCodigo)
        Do While Rc.EOF = False
            Dim cc As New ControlUsuariosDetalle
            cc.llenaCasillas(Rc.Fields.Item("usuarios_codigo").Value)
            fp1.Controls.Add(cc)

            Rc.MoveNext()
        Loop
    End Sub



    Sub limpiar()
        lblcodigo.Text = "<Nuevo>"


    End Sub

    Private Sub ControlClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpiar()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True


        txtnombre.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim cc As New ControlUsuariosDetalle
        cc.modoAgregar()
        fp1.Controls.Add(cc)
    End Sub

    Private Sub txtBuffer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuffer.TextChanged
        llenaDatos()
        llenaPanelUsuarios()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        accionBusca(True)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim matrix = 0

        DatosGotech.OLEDB.tipo_guardar(txtnombre.Text, Buffer.fc1, Buffer.fc2, Buffer.fc3, Buffer.fc4, Buffer.fc5, Buffer.fc6, Buffer.fc7)
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DatosGotech.OLEDB.tipo_eliminar(Buffer.tipoCodigo)
        limpiar()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DatosGotech.OLEDB.tipo_actualizar(Buffer.tipoCodigo, txtnombre.Text, Buffer.fc1, Buffer.fc2, Buffer.fc3, Buffer.fc4, Buffer.fc5, Buffer.fc6, Buffer.fc7)
        limpiar()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
    End Sub

    Private Sub c1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.CheckedChanged
        If c1.Checked = True Then
            Buffer.fc1 = 1
        Else
            Buffer.fc1 = 0
        End If
    End Sub

    Private Sub c2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.CheckedChanged
        If c2.Checked = True Then
            Buffer.fc2 = 1
        Else
            Buffer.fc2 = 0
        End If
    End Sub

    Private Sub c3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.CheckedChanged
        If c3.Checked = True Then
            Buffer.fc3 = 1
        Else
            Buffer.fc3 = 0
        End If
    End Sub

    Private Sub c4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4.CheckedChanged
        If c4.Checked = True Then
            Buffer.fc4 = 1
        Else
            Buffer.fc4 = 0
        End If
    End Sub

    Private Sub c5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c5.CheckedChanged
        If c5.Checked = True Then
            Buffer.fc5 = 1
        Else
            Buffer.fc5 = 0
        End If
    End Sub

    Private Sub c6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c6.CheckedChanged
        If c6.Checked = True Then
            Buffer.fc6 = 1
        Else
            Buffer.fc6 = 0
        End If
    End Sub

    Private Sub c7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c7.CheckedChanged
        If c7.Checked = True Then
            Buffer.fc7 = 1
        Else
            Buffer.fc7 = 0
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
    End Sub
End Class
