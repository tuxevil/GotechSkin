Imports System.Runtime.InteropServices

Public Class Home

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'INSTRUCCIONES PARA MOVER FORMULARIO
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2
    <DllImportAttribute("user32.dll")> Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")> Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Home_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

    End Sub

    Sub logUser()
        presentaimagen()
        Dim x As New Login
        x.ShowDialog()
            'muestra agenda
        daPermisos()
        MuestraAgenda()

        Label3.Text = " Gotech  -  " + Buffer.usuarioNombre
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - Me.Size.Width / 2, My.Computer.Screen.WorkingArea.Height / 2 - Me.Size.Height / 2, Me.Size.Width, Me.Size.Height)

        TabPage7.Text = "Nueva Venta"
        TabPage8.Text = "Editar Venta"
        Timer1.Start()

    End Sub


    Sub daPermisos()


        If Buffer.pClientes = 1 Then
            pictureBox2.Enabled = True
        Else
            pictureBox2.Enabled = False
        End If

        If Buffer.pSeguimientos = 1 Then
            PictureBox3.Enabled = True
        Else
            PictureBox3.Enabled = False
        End If

        If Buffer.pProductos = 1 Then
            PictureBox4.Enabled = True
        Else
            PictureBox4.Enabled = False
        End If

        If Buffer.pVentasRealizar = 1 Then
            TabPage7.Enabled = True
        Else
            TabPage7.Enabled = False
        End If

        If Buffer.pVentasConsultar = 1 Or Buffer.pVentasEditar = 1 Then
            TabPage8.Enabled = True

        Else
            TabPage8.Enabled = False
        End If

        If Buffer.pUsuarios = 1 Then
            PictureBox6.Enabled = True
        Else
            PictureBox6.Enabled = False
        End If





    End Sub

    Sub DaPermisoVendedor()
        pictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = False
        PictureBox5.Enabled = True
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False

        'ControlVentas1.Enabled = True
        'ControlVentasEditar1.Enabled = False

    End Sub

    Sub DaPermisoRoot()
        pictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        'ControlVentas1.Enabled = True
        'ControlVentasEditar1.Enabled = True

    End Sub


    Sub deshabilitarControles(ByVal control As String)
        For i As Integer = 0 To Me.Controls(control).Controls.Count - 1
            Me.Controls(control).Controls(i).Enabled = False
        Next


    End Sub
    Sub habilitarControles(ByVal control As String)
        For i As Integer = 0 To Me.Controls(control).Controls.Count - 1
            Me.Controls(control).Controls(i).Enabled = True
        Next


    End Sub


    Public pressCli As Boolean = False
    Public pressSeg As Boolean = False
    Public pressProd As Boolean = False
    Public pressVentas As Boolean = False
    Public pressUsuarios As Boolean = False
    Public pressConfig As Boolean = False
    Sub presentaimagen()
        Me.PictureBox13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                   Or System.Windows.Forms.AnchorStyles.Left) _
                   Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ' Me.PictureBox13.Image = Global.Gotech.My.Resources.Resources.logoMAin
        Me.PictureBox13.Location = New System.Drawing.Point(1, 57)
        ' Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(796, 459)
        ' Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        ' Me.PictureBox13.TabIndex = 15
        ' Me.PictureBox13.TabStop = False
        PictureBox13.Visible = True
    End Sub


    Sub normalCli()
        pressCli = False
        If Not pressCli Then
            pictureBox2.Image = Global.Gotech.My.Resources.Resources.banner1
        End If
    End Sub
    Sub normalSeg()
        pressSeg = False
        If Not pressSeg Then
            PictureBox3.Image = Global.Gotech.My.Resources.Resources.banner1Segui
        End If
    End Sub
    Sub normalProd()
        pressProd = False
        If Not pressProd Then
            PictureBox4.Image = Global.Gotech.My.Resources.Resources.banner1Prod
        End If
    End Sub
    Sub normalVentas()
        pressVentas = False
        If Not pressVentas Then
            PictureBox5.Image = Global.Gotech.My.Resources.Resources.banner1Ventas
        End If
    End Sub
    Sub normalUsuarios()
        pressUsuarios = False
        If Not pressUsuarios Then
            PictureBox6.Image = Global.Gotech.My.Resources.Resources.banner1Usua
        End If
    End Sub
    Sub normalConfig()
        pressConfig = False
        If Not pressConfig Then
            PictureBox7.Image = Global.Gotech.My.Resources.Resources.banner1Conf
        End If
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox2.Click
        If PictureBox13.Visible = True Then
            PictureBox13.Visible = False
        End If

        pictureBox2.Image = Global.Gotech.My.Resources.Resources.TClientes
        pressCli = True
        normalSeg()
        normalProd()
        normalVentas()
        normalUsuarios()
        normalConfig()

        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        Me.TabControl1.SelectedTab = TabPage1
        TabPage1.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictureBox2.MouseEnter
        pictureBox2.Image = Global.Gotech.My.Resources.Resources.selClientes

    End Sub

    Private Sub pictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pictureBox2.MouseLeave
        If Not pressCli Then
            pictureBox2.Image = Global.Gotech.My.Resources.Resources.banner1

        End If

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        pressSEg1()
    End Sub

    Sub pressSEg1()
        If PictureBox13.Visible = True Then
            PictureBox13.Visible = False
        End If

        PictureBox3.Image = Global.Gotech.My.Resources.Resources.TSeguimientos
        pressSeg = True
        normalCli()
        normalProd()
        normalVentas()
        normalUsuarios()
        normalConfig()
        TabPage2.Show()
        Me.TabControl1.SelectedTab = TabPage2
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage1.Hide()
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = Global.Gotech.My.Resources.Resources.selSeguimientos

    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        If Not pressSeg Then
            PictureBox3.Image = Global.Gotech.My.Resources.Resources.banner1Segui

        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox13.Visible = True Then
            PictureBox13.Visible = False
        End If

        PictureBox4.Image = Global.Gotech.My.Resources.Resources.TProductos
        pressProd = True
        normalCli()
        normalSeg()
        normalVentas()
        normalUsuarios()
        normalConfig()
        TabPage2.Hide()
        ' TabPage3.Select()
        Me.TabControl1.SelectedTab = TabPage3
        TabPage3.Show()
        TabPage4.Hide()
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage1.Hide()

    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = Global.Gotech.My.Resources.Resources.selProductos

    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        If Not pressProd Then
            PictureBox4.Image = Global.Gotech.My.Resources.Resources.banner1Prod

        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox13.Visible = True Then
            PictureBox13.Visible = False
        End If

        PictureBox5.Image = Global.Gotech.My.Resources.Resources.TVentas
        pressVentas = True
        normalSeg()
        normalProd()
        normalCli()
        normalUsuarios()
        normalConfig()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Show()
        Me.TabControl1.SelectedTab = TabPage4
        TabPage5.Hide()
        TabPage6.Hide()
        TabPage1.Hide()
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = Global.Gotech.My.Resources.Resources.selVentas

    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        If Not pressVentas Then
            PictureBox5.Image = Global.Gotech.My.Resources.Resources.banner1Ventas

        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox13.Visible = True Then
            PictureBox13.Visible = False
        End If

        PictureBox6.Image = Global.Gotech.My.Resources.Resources.TUsuarios
        pressUsuarios = True
        normalSeg()
        normalProd()
        normalVentas()
        normalCli()
        normalConfig()
        TabPage2.Hide()
        TabPage3.Hide()
        TabPage4.Hide()
        TabPage5.Show()
        Me.TabControl1.SelectedTab = TabPage5
        TabPage6.Hide()
        TabPage1.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Image = Global.Gotech.My.Resources.Resources.selUsuarios

    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        If Not pressUsuarios Then
            PictureBox6.Image = Global.Gotech.My.Resources.Resources.banner1Usua

        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        'If PictureBox13.Visible = True Then
        'PictureBox13.Visible = False
        ' End If

        ' PictureBox7.Image = Global.Gotech.My.Resources.Resources.TConfiguracion
        ' pressConfig = True
        ' normalSeg()
        ' normalProd()
        ' normalVentas()
        ' normalUsuarios()
        ' normalCli()
        ' TabPage2.Hide()
        ' TabPage3.Hide()
        ' TabPage4.Hide()
        ' TabPage5.Hide()
        ' TabPage6.Show()
        ' Me.TabControl1.SelectedTab = TabPage6
        ' TabPage1.Hide()
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        'PictureBox7.Image = Global.Gotech.My.Resources.Resources.selConfiguracion

    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        ' If Not pressConfig Then
        'PictureBox7.Image = Global.Gotech.My.Resources.Resources.banner1Conf

        '  End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Me.Close()

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = 0
        Else
            ' Me.SetBounds(Me.Location.X, Me.Location.Y, Me.Size.Width, My.Computer.Screen.WorkingArea.Height)


            Me.WindowState = 2
        End If



    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.WindowState = 1

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Me.ControlClientes1.ini()
        Me.ControlProductos1.ini()
        Me.ControlVentas1.ini()
        Me.ControlVentasEditar1.ini()
        Me.ControlSeguimiento1.limpiar()
        Me.ControlUsuarios1.limpiar()

        logUser()

        Dim x As New Agenda
        x.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - x.Size.Width, My.Computer.Screen.WorkingArea.Height / 2 - x.Size.Height / 2, x.Size.Width, x.Size.Height)
        x.setReflejo(Me)
        x.ShowDialog()
        PictureBox13.Visible = False

    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Me.Close()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MuestraAgenda()
    End Sub

    Sub MuestraAgenda()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        logUser()

        Dim x As New Agenda
        x.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - x.Size.Width, My.Computer.Screen.WorkingArea.Height / 2 - x.Size.Height / 2, x.Size.Width, x.Size.Height)
        x.setReflejo(Me)
        x.ShowDialog()
        PictureBox13.Visible = False

    End Sub

    Private Sub Home_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click

    End Sub
    Dim pressed As Boolean = False


    Private Sub PictureBox14_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox14.MouseDown
        'Me.SetBounds(Me.Location.X, Me.Location.Y, Me.Size.Width + e.Location.X, Me.Size.Height)
        pressed = True
        'PictureBox14_MouseMove(sender, e)
        ' Label4.Text = e.Location.X.ToString
    End Sub

    Private Sub PictureBox14_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseHover


    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseLeave
        pressed = False
    End Sub

    Private Sub PictureBox14_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox14.MouseMove
        If pressed Then
            Me.SetBounds(Me.Location.X, Me.Location.Y, Me.Size.Width + e.Location.X, Me.Size.Height + e.Location.Y)


        End If
    End Sub

    Private Sub PictureBox14_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox14.MouseUp
        pressed = False
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        Dim x As New Agenda
        x.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - x.Size.Width, My.Computer.Screen.WorkingArea.Height / 2 - x.Size.Height / 2, x.Size.Width, x.Size.Height)
        x.setReflejo(Me)
        x.ShowDialog()
    End Sub
End Class