Public Class controlSeguimiento

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            accionBusca(False)

        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub


    Sub limpiar()

        TextBox1.Text = ""
        TextBox2.Text = ""
        ListView1.Items.Clear()


    End Sub

    Private Sub controlSeguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0

        TextBox2.Focus()
    End Sub


    ''-------------------------------------------------


    Sub carga_por_codigo(ByVal codigo As Integer)
        codigoTemp = codigo
        Dim Rc As ADODB.Recordset

        Rc = DatosGotech.OLEDB.seguimientos_retorna_codigo(codigo)

        'ListView1.Items.Clear()
        Do While Rc.EOF = False

            TextBox2.Text = Rc.Fields.Item(5).Value
            TextBox1.Text = Rc.Fields.Item(3).Value
            If Rc.Fields.Item(4).Value.ToString() = "A" Then
                ComboBox1.SelectedIndex = 0
            Else
                ComboBox1.SelectedIndex = 1
            End If
            Buffer.contactosCodigo = Rc.Fields.Item(1).Value
            DateTimePicker1.Value = Rc.Fields.Item(2).Value
            'Datetimepicker1.Value=

            '   Dim t As New ListViewItem
            '  t.SubItems.Clear()
            ' t.Text = Rc.Fields.Item(0).Value
            't.SubItems.Add(Rc.Fields.Item(1).Value)
            'ListView1.Items.Add(t)
            Rc.MoveNext()
        Loop
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub llenaLista()
        Dim Rc As ADODB.Recordset

        Rc = DatosGotech.OLEDB.contacto_retorna_Codigo(Buffer.contactosCodigo)

        ListView1.Items.Clear()
        Do While Rc.EOF = False
            Dim t As New ListViewItem
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item(0).Value
            t.SubItems.Add(Rc.Fields.Item(1).Value)
            ListView1.Items.Add(t)
            Rc.MoveNext()
        Loop
    End Sub



    Private Sub busca1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles busca1.KeyPress

    End Sub

    Private Sub busca1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles busca1.Load

    End Sub

    Private Sub busca1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles busca1.VisibleChanged
        llenaLista()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub accionBusca(ByVal vacio As Boolean)
        If vacio Then

            busca1.llenaLista()


            busca1.Visible = True
            busca1.Focus()
            busca1.ListView1.Focus()

        Else
            If TextBox2.Text = "" Then
                busca1.llenaLista()
            Else
                busca1.llenaLista(TextBox2.Text)
            End If

            busca1.Visible = True
            busca1.Focus()
            busca1.ListView1.Focus()

        End If


    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        accionBusca(True)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            DatosGotech.OLEDB.grabaSeguimiento(Buffer.contactosCodigo, DateTimePicker1.Value, TextBox1.Text, "A")

        Else
            DatosGotech.OLEDB.grabaSeguimiento(Buffer.contactosCodigo, DateTimePicker1.Value, TextBox1.Text, "E")

        End If

        llenaLista()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Dim codigoTemp As Integer

    Private Sub act_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles act.Click
        If ComboBox1.SelectedIndex = 0 Then
            DatosGotech.OLEDB.ActualizaSeguimiento(codigoTemp, Buffer.contactosCodigo, DateTimePicker1.Value, TextBox1.Text, "A")

        Else
            DatosGotech.OLEDB.ActualizaSeguimiento(codigoTemp, Buffer.contactosCodigo, DateTimePicker1.Value, TextBox1.Text, "E")

        End If


          End Sub
End Class
