Public Class LoginChange


    Dim cerroVentana As Boolean = True


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Sub login()
        Dim Rc As ADODB.Recordset

        Try
     
            If Rc.EOF Then
                'accion para expulsar usuario
                validar(False, 0, "", "", 0)
            End If
            Do While Rc.EOF = False
                'accion para si validar usuario
                validar(True, Rc.Fields.Item(0).Value, Rc.Fields.Item(1).Value, Rc.Fields.Item(2).Value, Rc.Fields.Item(3).Value)

                Rc.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Hubo un error de Conexión con la base de datos...")
        End Try
    End Sub


    Sub validar(ByVal si As Boolean, ByVal codigo As Integer, ByVal user As String, ByVal password As String, ByVal tipo As Integer)

        If si Then
            Buffer.usuarioCodigo = codigo
            Buffer.usuarioNombre = user
            Dim Rc As ADODB.Recordset
            Try
                Rc = Retorna_Permisos_por_Tipo(tipo)
                Do While Rc.EOF = False

                    If Rc.Fields.Item(0).Value Then
                        Buffer.pClientes = 1
                    Else
                        Buffer.pClientes = 0
                    End If

                    If Rc.Fields.Item(1).Value Then
                        Buffer.pSeguimientos = 1
                    Else
                        Buffer.pSeguimientos = 0
                    End If

                    If Rc.Fields.Item(2).Value Then
                        Buffer.pProductos = 1
                    Else
                        Buffer.pProductos = 0
                    End If

                    If Rc.Fields.Item(3).Value Then
                        Buffer.pVentasRealizar = 1
                    Else
                        Buffer.pVentasRealizar = 0
                    End If

                    If Rc.Fields.Item(4).Value Then
                        Buffer.pVentasConsultar = 1
                    Else
                        Buffer.pVentasConsultar = 0
                    End If

                    If Rc.Fields.Item(5).Value Then
                        Buffer.pVentasEditar = 1
                    Else
                        Buffer.pVentasEditar = 0
                    End If

                    If Rc.Fields.Item(6).Value Then
                        Buffer.pUsuarios = 1
                    Else
                        Buffer.pUsuarios = 0
                    End If
                    Rc.MoveNext()
                Loop
            Catch ex As Exception
                MsgBox("Hubo un error de Conexión con la base de datos...")
            End Try
            cerroVentana = False
            Me.Close()

        Else
            
            MsgBox("user no valido")
        End If
    End Sub

    Public Function Retorna_Permisos_por_Tipo(ByVal codigo As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open("Provider=SQLOLEDB;Data Source=SERVIDOR-DEV\SQLEXPRESS;Password=gotechdev;User ID=sa;Initial Catalog=Gotech")
        Rc.Open("select pClientes, pSeguimientos, pProductos, pVentasRealizar, pVentasConsultar, pVentasEditar, pUsuarios from usuarios_tipo where tipo_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function


    Private Sub Login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      

    End Sub

    Private Sub LoginChange_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            GlassButton1.Focus()
        ElseIf keyascii = 27 Then
            Me.Close()
        End If
    End Sub


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetBounds(My.Computer.Screen.WorkingArea.Width / 2 - Me.Size.Width / 2, My.Computer.Screen.WorkingArea.Height / 2 - Me.Size.Height / 2, Me.Size.Width, Me.Size.Height)
    End Sub

    Sub setPosicion(ByVal x As Integer, ByVal y As Integer)
        Me.SetBounds(x, y, Me.Size.Width, Me.Size.Height)

    End Sub




 


  


    Private Sub GlassButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GlassButton1.Click
        If t2.Text = t3.Text Then

            If DatosGotech.OLEDB.usuarios_cambia_password(Buffer.tempUsername, t1.Text, t2.Text) = True Then
                MsgBox("Tu contraseña se cambio Exitosamente !!!")
                Me.Close()
            Else
                MsgBox("Tu contraseña anterior no coincide con la del usuario !!!")
            End If
        Else
            MsgBox("Deben coincidir las contrasenas...")
        End If
        
    End Sub

    Private Sub t1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t1.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            GlassButton1.Focus()
        ElseIf keyascii = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged

    End Sub

    Private Sub t2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t2.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            GlassButton1.Focus()
        ElseIf keyascii = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub t2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t2.TextChanged

    End Sub

    Private Sub t3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles t3.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If keyascii = 13 Then
            GlassButton1.Focus()
        ElseIf keyascii = 27 Then
            Me.Close()
        End If
    End Sub

    Private Sub t3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t3.TextChanged

    End Sub
End Class