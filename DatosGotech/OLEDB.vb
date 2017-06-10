Public Class OLEDB

    Public Shared CadenaConexion As String = Global.DatosGotech.My.Settings.CadenaConexion

    Public Shared Function clientes_retornaTodo(ByVal codUsuario As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=" & codUsuario & " and clientes.usuarios_codigo=usuarios.usuarios_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function clientes_retornaTodo() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=usuarios.usuarios_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function clientes_retornaTodo_LIKE(ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=usuarios.usuarios_codigo and clientes_nombre like '%" & nombreLike & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function clientes_retornaTodo_LIKE(ByVal codUsuario As Integer, ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select clientes.clientes_codigo,clientes.clientes_nombre,usuarios.usuarios_username from clientes,usuarios where clientes.usuarios_codigo=" & codUsuario & " and clientes.usuarios_codigo=usuarios.usuarios_codigo and clientes_nombre like '%" & nombreLike & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contactos_retornaTodo(ByVal codUsuario As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos.contactos_codigo,contactos.contactos_nombres,clientes.clientes_nombre from contactos,clientes where contactos.clientes_codigo=clientes.clientes_codigo and clientes.usuarios_codigo=" & codUsuario & " ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contactos_retornaTodo() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos.contactos_codigo,contactos.contactos_nombres,clientes.clientes_nombre from contactos,clientes where contactos.clientes_codigo=clientes.clientes_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contactos_retornaTodo_LIKE(ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos.contactos_codigo,contactos.contactos_nombres,clientes.clientes_nombre from contactos,clientes where contactos_nombres like '%" & nombreLike & "%' and  contactos.clientes_codigo=clientes.clientes_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contactos_retornaTodo_LIKE(ByVal codUsuario As Integer, ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos.contactos_codigo,contactos.contactos_nombres,clientes.clientes_nombre from contactos,clientes where contactos_nombres like '%" & nombreLike & "%' and   contactos.clientes_codigo=clientes.clientes_codigo and clientes.usuarios_codigo=" & codUsuario & " ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function productos_retornaTodo() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select productos_codigo,productos_nombre from productos", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function productos_retornaTodo_LIKE(ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select productos_codigo,productos_nombre from productos where productos_nombre like '%" & nombreLike & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function tipos_retornaTodo() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select tipo_codigo,tipo_nombre from usuarios_tipo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        Return Rc
    End Function
    Public Shared Function tipos_retornaTodo_LIKE(ByVal nombreLike As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select tipo_codigo,tipo_nombre from usuarios_tipo where tipo_nombre like '%" & nombreLike & "%'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        Return Rc
    End Function
    Public Shared Function Retorna_clientes_por_codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select clientes_codigo,clientes_nombre,clientes_actividad,clientes_direccion,clientes_telefono,clientes_fax,clientes_esmatriz from clientes where clientes_codigo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub clientes_actualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal actividad As String, ByVal direccion As String, ByVal telefono As String, ByVal fax As String, ByVal esMatriz As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update clientes set clientes_nombre='" & nombre & "', clientes_actividad='" & actividad & "',clientes_direccion='" & direccion & "',clientes_telefono='" & telefono & "',clientes_fax='" & fax & "',clientes_esmatriz=" & esMatriz & " where clientes_codigo=" & codigo & " ")
            cn.Close()
            MsgBox("Los datos se Actualizaron !!")
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub clientes_guardar(ByVal nombre As String, ByVal actividad As String, ByVal direccion As String, ByVal telefono As String, ByVal fax As String, ByVal esMatriz As Integer, ByVal usuarioCodigo As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("insert into clientes(clientes_nombre,clientes_actividad,clientes_direccion,clientes_telefono,clientes_fax,clientes_esmatriz,usuarios_codigo) values('" & nombre & "','" & actividad & "','" & direccion & "','" & telefono & "','" & fax & "'," & esMatriz & ",'" & usuarioCodigo & "')")
            cn.Close()
            MsgBox("Datos guardados...")
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub clientes_eliminar(ByVal codigoCliente As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete clientes where clientes_codigo=" & codigoCliente & "")
            cn.Close()
            MsgBox("Registro Eliminado ...")
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Function contactos_retornaCodigos(ByVal cod As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos_codigo from contactos where clientes_codigo=" & cod & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contacto_por_Codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select contactos_nombres,contactos_cargo,contactos_extencion,contactos_celular,contactos_email from contactos where contactos_codigo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub contactosActualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal cargo As String, ByVal extencion As Integer, ByVal celular As String, ByVal email As String)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update contactos set contactos_nombres='" & nombre & "', contactos_cargo='" & cargo & "',contactos_extencion=" & extencion & ",contactos_celular='" & celular & "',contactos_email='" & email & "' where contactos_codigo=" & codigo & " ")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try

    End Sub
    Public Shared Sub contactosGuardar(ByVal clienteCodigo As Integer, ByVal nombre As String, ByVal cargo As String, ByVal extencion As Integer, ByVal celular As String, ByVal email As String)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("insert into contactos (clientes_codigo,contactos_nombres, contactos_cargo,contactos_extencion,contactos_celular,contactos_email) values(" & clienteCodigo & ",'" & nombre & "','" & cargo & "'," & extencion & ",'" & celular & "','" & email & "')")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try

    End Sub
    Public Shared Function contacto_Last_Codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select max(contactos_codigo) as maximo from contactos where clientes_codigo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc

    End Function
    Public Shared Sub contactos_eliminar(ByVal codigoContacto As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete contactos where contactos_codigo=" & codigoContacto & "")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Function productos_retorna_por_codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select productos_codigo,productos_nombre,productos_precio,productos_detalle from productos where productos_codigo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub productos_actualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal precio As Double, ByVal detalle As String)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update productos set productos_nombre='" & nombre & "', productos_precio=" & precio & ",productos_detalle='" & detalle & "' where productos_codigo=" & codigo & " ")
            cn.Close()
            MsgBox("Los datos se Actualizaron !!")
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub productos_guardar(ByVal nombre As String, ByVal precio As Double, ByVal detalle As String)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("insert into productos(productos_nombre,productos_precio,productos_detalle) values('" & nombre & "'," & precio & ",'" & detalle & "')")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub productos_eliminar(ByVal codigoCliente As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete productos where productos_codigo=" & codigoCliente & "")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Function productos_retornaCodigos() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select productos_codigo from productos ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function contacto_retorna_Codigo(ByVal codContacto As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos_fecha_agenda,seguimientos_detalle from seguimientos where contactos_codigo=" & codContacto & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    'Graba un nuevo Seguimiento
    Public Shared Sub grabaSeguimiento(ByVal contacto As Integer, ByVal fecha As System.DateTime, ByVal detalle As String, ByVal estado As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)

        Rc.Open("select * from seguimientos", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.AddNew()
        Rc.Fields.Item("contactos_codigo").Value = contacto
        Rc.Fields.Item("seguimientos_fecha_agenda").Value = fecha
        Rc.Fields.Item("seguimientos_detalle").Value = detalle
        Rc.Fields.Item("seguimientos_estado").Value = "A"

        Rc.Update()
        Rc.Close()
        Db.Close()

    End Sub
    Public Shared Sub ActualizaSeguimiento(ByVal codigo As Integer, ByVal contacto As Integer, ByVal fecha As System.DateTime, ByVal detalle As String, ByVal estado As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)

        Rc.Open("select * from seguimientos where seguimientos_codigo = " & codigo & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Rc.Fields.Item("contactos_codigo").Value = contacto
        Rc.Fields.Item("seguimientos_fecha_agenda").Value = fecha
        Rc.Fields.Item("seguimientos_detalle").Value = detalle
        Rc.Fields.Item("seguimientos_estado").Value = estado

        Rc.Update()
        Rc.Close()
        Db.Close()
        MsgBox("Datos actualizados Correctamente !!!")

    End Sub


    Public Shared Function usuarios_retornaCodigos(ByVal cod As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select usuarios_codigo from usuarios where usuarios_tipo=" & cod & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function Retorna_tipos_por_codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select tipo_codigo,tipo_nombre,pClientes, pSeguimientos, pProductos, pVentasRealizar, pVentasConsultar, pVentasEditar, pUsuarios from usuarios_tipo where tipo_codigo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub tipo_actualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal c1 As Integer, ByVal c2 As Integer, ByVal c3 As Integer, ByVal c4 As Integer, ByVal c5 As Integer, ByVal c6 As Integer, ByVal c7 As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update usuarios_tipo set tipo_nombre='" & nombre & "',pClientes=" & c1 & " , pSeguimientos=" & c2 & ", pProductos=" & c3 & ", pVentasRealizar=" & c4 & ", pVentasConsultar=" & c5 & ", pVentasEditar=" & c6 & ", pUsuarios=" & c7 & "  where tipo_codigo=" & codigo & " ")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub tipo_guardar(ByVal nombre As String, ByVal c1 As Integer, ByVal c2 As Integer, ByVal c3 As Integer, ByVal c4 As Integer, ByVal c5 As Integer, ByVal c6 As Integer, ByVal c7 As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("insert into usuarios_tipo(tipo_nombre,pClientes, pSeguimientos, pProductos, pVentasRealizar, pVentasConsultar, pVentasEditar, pUsuarios) values('" & nombre & "',c1,c2,c3,c4,c5,c6,c7)")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub tipo_eliminar(ByVal codigoCliente As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete usuarios_tipo where tipo_codigo=" & codigoCliente & "")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Function Usuario_por_Codigo(ByVal code As Integer, ByVal tipo As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select usuarios_nombre,usuarios_apellido,usuarios_username,usuarios_password,usuarios_celular,usuarios_email from usuarios where usuarios_codigo=" & code & " and usuarios_tipo=" & tipo & " ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub usuarios_eliminar(ByVal codigoContacto As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete usuarios where usuarios_codigo=" & codigoContacto & "")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub UsuariosActualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal apellido As String, ByVal username As String, ByVal password As String, ByVal celular As String, ByVal email As String, ByVal tipo As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update usuarios set usuarios_nombre='" & nombre & "',usuarios_apellido='" & apellido & "',usuarios_username='" & username & "',usuarios_password='" & password & "',usuarios_celular='" & celular & "',usuarios_email='" & email & "',usuarios_tipo=" & tipo & " where usuarios_codigo=" & codigo & " ")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try

    End Sub
    Public Shared Sub usuariosGuardar(ByVal nombre As String, ByVal apellido As String, ByVal username As String, ByVal password As String, ByVal celular As String, ByVal email As String, ByVal tipo As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("insert into usuarios (usuarios_nombre, usuarios_apellido,usuarios_username,usuarios_password,usuarios_celular,usuarios_email,usuarios_tipo) values('" & nombre & "','" & apellido & "','" & username & "','" & password & "','" & celular & "','" & email & "'," & tipo & ")")
            cn.Close()
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try

    End Sub
    Public Shared Function usuarios_Last_Codigo(ByVal code As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select max(usuarios_codigo) as maximo from usuarios where usuarios_tipo=" & code & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc

    End Function
    Public Shared Sub ventas_actualizar(ByVal codigo As Integer, ByVal nombre As String, ByVal actividad As String, ByVal direccion As String, ByVal telefono As String, ByVal fax As String, ByVal esMatriz As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("update clientes set clientes_nombre='" & nombre & "', clientes_actividad='" & actividad & "',clientes_direccion='" & direccion & "',clientes_telefono='" & telefono & "',clientes_fax='" & fax & "',clientes_esmatriz=" & esMatriz & " where clientes_codigo=" & codigo & " ")
            cn.Close()
            MsgBox("El registro se Actualizó !!!")
        Catch ex As Exception
            MsgBox("Los datos no se Actualizaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Sub ventas_guardar(ByVal codCliente As Integer, ByVal codProducto As Integer, ByVal licencia As String, ByVal validez As System.DateTime, ByVal mac As String, ByVal windowsid As String, ByVal servidorid As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select * from ventas", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        Rc.AddNew()
        Rc.Fields.Item("clientes_codigo").Value = codCliente
        Rc.Fields.Item("productos_codigo").Value = codProducto
        Rc.Fields.Item("ventas_licencia").Value = licencia
        Rc.Fields.Item("ventas_periodo_validez").Value = validez
        Rc.Fields.Item("ventas_mac").Value = mac
        Rc.Fields.Item("ventas_windowsid").Value = windowsid
        Rc.Fields.Item("ventas_servidorid").Value = servidorid
        Rc.Update()
        Rc.Close()
        Db.Close()
        MsgBox("Los datos se guardaron Correctamente !!!")
    End Sub
    Public Shared Function Ventas_retorna_Clientes() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select distinct ventas.clientes_codigo,clientes.clientes_nombre from ventas,clientes where ventas.clientes_codigo=clientes.clientes_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function Ventas_retorna_Productos() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select ventas.productos_codigo,productos.productos_nombre from ventas,productos where ventas.productos_codigo=productos.productos_codigo", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function Ventas_retorna_Productos(ByVal codCliente) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select ventas.productos_codigo,productos.productos_nombre from ventas,productos where ventas.productos_codigo=productos.productos_codigo and ventas.clientes_codigo=" & codCliente & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function Ventas_Cliente_Producto(ByVal codCliente As Integer, ByVal codProducto As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select ventas_codigo,ventas_licencia,ventas_periodo_validez,ventas_mac,ventas_windowsid,ventas_servidorid from ventas where clientes_codigo=" & codCliente & " and productos_codigo=" & codProducto & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Sub ventas_Actualizar(ByVal codVenta As Integer, ByVal codCliente As Integer, ByVal codProducto As Integer, ByVal licencia As String, ByVal validez As System.DateTime, ByVal mac As String, ByVal windowsid As String, ByVal servidorid As String)
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select * from ventas where ventas_codigo=" & codVenta & "", Db, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

        Rc.Fields.Item("clientes_codigo").Value = codCliente
        Rc.Fields.Item("productos_codigo").Value = codProducto
        Rc.Fields.Item("ventas_licencia").Value = licencia
        Rc.Fields.Item("ventas_periodo_validez").Value = validez
        Rc.Fields.Item("ventas_mac").Value = mac
        Rc.Fields.Item("ventas_windowsid").Value = windowsid
        Rc.Fields.Item("ventas_servidorid").Value = servidorid
        Rc.Update()
        Rc.Close()
        Db.Close()

    End Sub
    Public Shared Sub ventas_eliminar(ByVal codigoVenta As Integer)
        Dim cn As ADODB.Connection
        Try
            cn = New ADODB.Connection()
            cn.Open(CadenaConexion)
            cn.Execute("delete ventas where ventas_codigo=" & codigoVenta & "")
            cn.Close()
            MsgBox("El registro se Eliminó !!!")
        Catch ex As Exception
            MsgBox("Los datos no se guardaron ..." & ChrW(13) & "  - " & ex.Message)
        End Try
    End Sub
    Public Shared Function seguimientos_retornaTodo_usuario(ByVal usuario As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos.seguimientos_fecha_agenda as 'Fecha',clientes.clientes_nombre as 'Empresa',contactos.contactos_nombres as 'Contacto',seguimientos.seguimientos_detalle as 'Detalle' from seguimientos, contactos,clientes where seguimientos.contactos_codigo=contactos.contactos_codigo and contactos.clientes_codigo=clientes.clientes_codigo and seguimientos.seguimientos_estado='A'  and clientes.usuarios_codigo=" & usuario & " order by seguimientos.seguimientos_fecha_agenda asc", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function

    ''' <summary>
    ''' '''''''
    ''' </summary>
    ''' <param name="codigo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function seguimientos_retorna_codigo(ByVal codigo As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos.*,contactos.contactos_nombres from seguimientos,contactos where seguimientos_codigo=" & codigo & " and seguimientos.contactos_codigo=contactos.contactos_codigo ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function

    Public Shared Function seguimientos_retornaTodo_Root() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos.seguimientos_fecha_agenda as 'Fecha',clientes.clientes_nombre as 'Empresa',contactos.contactos_nombres as 'Contacto',seguimientos.seguimientos_detalle as 'Detalle' from seguimientos, contactos,clientes where seguimientos.contactos_codigo=contactos.contactos_codigo and contactos.clientes_codigo=clientes.clientes_codigo and seguimientos.seguimientos_estado='A'  order by seguimientos.seguimientos_fecha_agenda asc", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function seguimientos_retornaTodo_usuario_hoy(ByVal usuario As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos.seguimientos_fecha_agenda as 'Fecha',clientes.clientes_nombre as 'Empresa',contactos.contactos_nombres as 'Contacto',seguimientos.seguimientos_detalle as 'Detalle' from    seguimientos, contactos,clientes where  year(seguimientos.seguimientos_fecha_agenda)=year(getdate()) and month(seguimientos.seguimientos_fecha_agenda)=month(getdate()) and day(seguimientos.seguimientos_fecha_agenda)=day(getdate())   and  seguimientos.contactos_codigo=contactos.contactos_codigo and contactos.clientes_codigo=clientes.clientes_codigo and seguimientos.seguimientos_estado='A' and  clientes.usuarios_codigo=" & usuario & " order by seguimientos.seguimientos_fecha_agenda asc", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function seguimientos_retornaTodo_Root_hoy() As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select seguimientos.seguimientos_fecha_agenda as 'Fecha',clientes.clientes_nombre as 'Empresa',contactos.contactos_nombres as 'Contacto',seguimientos.seguimientos_detalle as 'Detalle' from    seguimientos, contactos,clientes where  year(seguimientos.seguimientos_fecha_agenda)=year(getdate()) and month(seguimientos.seguimientos_fecha_agenda)=month(getdate()) and day(seguimientos.seguimientos_fecha_agenda)=day(getdate())   and  seguimientos.contactos_codigo=contactos.contactos_codigo and contactos.clientes_codigo=clientes.clientes_codigo and seguimientos.seguimientos_estado='A' order by seguimientos.seguimientos_fecha_agenda asc", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function usuarios_password_por_username(ByVal username As String) As String
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select usuarios_password from usuarios where usuarios_username='" & username & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        Dim passwd As String = ""
        Do While Rc.EOF = False
            passwd = Rc.Fields.Item(0).Value.ToString()

            Rc.MoveNext()

        Loop

        Return passwd
    End Function
    Public Shared Function usuarios_cambia_password(ByVal username As String, ByVal passwordViejo As String, ByVal passwordNuevo As String) As Boolean
        Dim cambio As Boolean = False
       
        If usuarios_password_por_username(username) = passwordViejo Then

            'Cambia la contrasena con un update
            Dim Db As New ADODB.Connection
            Dim Rc As New ADODB.Recordset
            Try
                Db.Open(CadenaConexion)
                Rc.Open("update usuarios set usuarios_password='" & passwordNuevo & "' where usuarios_username='" & username & "' ", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                Rc.Close()
                Db.Close()
                
            Catch ex As Exception

            End Try
            cambio = True
            Return cambio
        ElseIf usuarios_password_por_username(username) <> passwordViejo Then
            cambio = False


        End If
        Return cambio
    End Function


    Public Shared Function Usuarios_Retorna_Valida(ByVal user As String, ByVal pass As String) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select usuarios_codigo,usuarios_username,usuarios_password,usuarios_tipo from usuarios where usuarios_username='" & user & "' and usuarios_password='" & pass & "'", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
    Public Shared Function Retorna_Permisos_por_Tipo(ByVal codigo As Integer) As ADODB.Recordset
        Dim Db As New ADODB.Connection
        Dim Rc As New ADODB.Recordset
        Db.Open(CadenaConexion)
        Rc.Open("select pClientes, pSeguimientos, pProductos, pVentasRealizar, pVentasConsultar, pVentasEditar, pUsuarios from usuarios_tipo where tipo_codigo=" & codigo & "", Db, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Return Rc
    End Function
End Class
