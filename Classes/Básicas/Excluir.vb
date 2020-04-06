Imports System.Data.SqlClient
Public Class Excluir
    ' ---------- SUB'S DO FORMULÁRIO PRINCIPAL ----------
    Public Sub ExcluirCliente()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_CLIENTE"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", Cliente.IDcmo.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Dados excluídos")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub ExcluirFornecedor()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_FORN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", Fornecedor.ID_Forn.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Dados excluídos")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
        view.CadViewForn()
    End Sub

    Public Sub ExcluirLivro()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_LIVRO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", Livro.ID_Livro.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Dados excluídos")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub ExcluirFuncionario()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_FUNC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", Funcionario.ID_Func.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Dados excluídos")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
        view.CadViewOp()
    End Sub
    
    Public Sub ExcluirOperador()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_LOGIN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", Operador.ID_OP.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Dados excluídos")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub ExcluirCarrinho_1()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_CARRINHO_1"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("ID", NotaFiscal.cbocarrinho.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub ExcluirCarrinho_1_Tudo()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "DELETE_CARRINHO_1_TUDO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub
End Class
