Public Class Form1
    ':::Creamos un objeto para establecer conexion con nuestra clase CRUD
    Dim Obj As New CRUD

    Private Sub BtnConexion_Click(sender As Object, e As EventArgs) Handles BtnConexion.Click
        ':::Mediante el objeto que creamos accedemos al procedimiento "conexion"
        Obj.conexion()
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Select * from Clientes"
        ':::Mediante el objeto que creamos globalmente y nombramos "Obj"
        ':::Accedemos a nuestro procedimiento "consulta" y le pasamos los
        ':::dos (2) parametros (DGTabla, Sql)
        Obj.consulta(DGTabla, Sql)
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Insert Into Clientes (Id, Nombres, Apellidos) Select " & TxtId.Text & ", '" & TxtNombres.Text & "', '" & TxtApellidos.Text & "'"
        ':::Cambiamos el nombre del procedimiento "operaciones"
        Obj.operaciones(DGTabla, Sql)
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Update Clientes Set Nombres='" & TxtNombres.Text & "', Apellidos='" & TxtApellidos.Text & "' where Id=" & TxtId.Text & ""
        Obj.operaciones(DGTabla, Sql)
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        ':::Creamos la variable Sql que guardar la instruccion de tipo SQL
        Dim Sql As String = "Delete * From Clientes Where Id=" & TxtId.Text & ""
        Obj.operaciones(DGTabla, Sql)
    End Sub
End Class
