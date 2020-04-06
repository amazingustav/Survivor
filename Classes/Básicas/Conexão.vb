Imports System.Data.SqlClient
Public Class Conexao
    Public cn As New SqlConnection
    Public status As String = ""
    
    Public Sub Conectar()
        Dim StringConexao As String = "server=MARK-42;database=LIVRARIA_TCC;uid=sa;pwd=123456"
        
        cn.ConnectionString = StringConexao
        cn.Open()
        
        status = "Conexão aberta"
    End Sub
    
    Public Sub Desconectar()
        cn.Close()
        status = "Conexão Fechada"
    End Sub
End Class