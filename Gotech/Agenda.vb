Imports System.Runtime.InteropServices
Public Class Agenda
    Dim hoy As Boolean = True


    Private Sub Agenda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub Agenda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargaLista()
    End Sub


    Public Function retorna_codigo_por_nombres(ByVal nombres As String) As Integer
        Dim rr As Integer = 0
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open("Provider=SQLOLEDB;Data Source=SERVIDOR-DEV\SQLEXPRESS;Password=gotechdev;User ID=sa;Initial Catalog=Gotech")
        Rc.Open("select seguimientos.seguimientos_codigo  from seguimientos,contactos where seguimientos.contactos_codigo=contactos.contactos_codigo and contactos.contactos_nombres= '" & nombres & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Rc.EOF = False
            rr = Rc.Fields.Item(0).Value
            Rc.MoveNext()
        Loop
        Return rr
    End Function

    Sub cargaLista()
        Dim Rc As ADODB.Recordset
        If hoy Then
            If Buffer.pClientes = 1 And Buffer.pSeguimientos = 1 And Buffer.pProductos = 1 And Buffer.pVentasRealizar = 1 And Buffer.pVentasConsultar = 1 And Buffer.pVentasEditar = 1 And Buffer.pUsuarios = 1 Then
                Rc = DatosGotech.OLEDB.seguimientos_retornaTodo_Root_hoy()
            Else
                Rc = DatosGotech.OLEDB.seguimientos_retornaTodo_usuario_hoy(Buffer.usuarioCodigo)
            End If

        Else
            If Buffer.pClientes = 1 And Buffer.pSeguimientos = 1 And Buffer.pProductos = 1 And Buffer.pVentasRealizar = 1 And Buffer.pVentasConsultar = 1 And Buffer.pVentasEditar = 1 And Buffer.pUsuarios = 1 Then
                Rc = DatosGotech.OLEDB.seguimientos_retornaTodo_Root()
            Else
                Rc = DatosGotech.OLEDB.seguimientos_retornaTodo_usuario(Buffer.usuarioCodigo)
            End If
        End If



        ListView1.Items.Clear()
        Do While Rc.EOF = False
            Dim t As New ListViewItem
            t.SubItems.Clear()
            t.Text = Rc.Fields.Item(0).Value

            t.SubItems.Add(Rc.Fields.Item(1).Value)
            t.SubItems.Add(Rc.Fields.Item(2).Value)
            t.SubItems.Add(Rc.Fields.Item(3).Value)

            ListView1.Items.Add(t)
            Rc.MoveNext()
        Loop
        ListView1.Focus()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        ' MsgBox(ListView1.SelectedItems(0).SubItems(2).Text)
        reflejo.pressSEg1()
        reflejo.TabPage2.Show()

        'reflejo.ControlSeguimiento1.TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text
        reflejo.ControlSeguimiento1.carga_por_codigo(retorna_codigo_por_nombres(ListView1.SelectedItems(0).SubItems(2).Text))
        'reflejo.ControlSeguimiento1.accionBusca(False)

        ' My.Computer.Keyboard.SendKeys(ChrW(13))
        'reflejo.ControlSeguimiento1.busca1.ListView1.Items(0).Selected = True
        ' reflejo.ControlSeguimiento1.busca1.seleccionaContacto()
        Me.Close()
    End Sub
    Dim reflejo As Home

    Sub setReflejo(ByVal hh As Home)
        reflejo = hh
    End Sub

    Private Sub ListView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ListView1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        hoy = True
        cargaLista()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        hoy = False
        cargaLista()

    End Sub




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'INSTRUCCIONES PARA MOVER FORMULARIO
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImportAttribute("user32.dll")> Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Agenda_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
End Class