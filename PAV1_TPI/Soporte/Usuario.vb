Public Class Usuario
    Public Shared nombre As String
    Public Shared apellido As String
    Public Shared username As String

    Public Shared Sub login(ByRef tabla As DataTable)
        nombre = tabla.Rows(0)("nombre")
        apellido = tabla.Rows(0)("apellido")
        username = tabla.Rows(0)("id_usuario")
    End Sub

    Public Shared Sub logout()
        nombre = ""
        apellido = ""
        username = ""
    End Sub
End Class
