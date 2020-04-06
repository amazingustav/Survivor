Imports System.Data.SqlClient
Public Class AutoCode
    ' ---------- SUB'S DO FORMULÁRIO PRINCIPAL ----------
    Public Sub Cod_Cliente()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_CLI", cx.cn)
            da.Fill(ds, "CLIENTE")
            Cliente.IDcmo.DataSource = ds.Tables("CLIENTE")
            Cliente.IDcmo.DisplayMember = "ID"
            Cliente.txtIDcli.Text = Cliente.IDcmo.Text


            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Cod_Forn()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_FORN", cx.cn)
            da.Fill(ds, "FORNECEDOR")
            Fornecedor.ID_Forn.DataSource = ds.Tables("FORNECEDOR")
            Fornecedor.ID_Forn.DisplayMember = "ID_F"
            Fornecedor.txtIDforn.Text = Fornecedor.ID_Forn.Text

            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Cod_Livro()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_LIVRO", cx.cn)
            da.Fill(ds, "LIVRO")
            Livro.ID_Livro.DataSource = ds.Tables("LIVRO")
            Livro.ID_Livro.DisplayMember = "ID_L"
            Livro.txtIDLivro.Text = Livro.ID_Livro.Text

            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Cod_Func()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_FUNC", cx.cn)
            da.Fill(ds, "FUNCIONARIO")
            Funcionario.ID_Func.DataSource = ds.Tables("FUNCIONARIO")
            Funcionario.ID_Func.DisplayMember = "ID_Fu"
            Funcionario.txtIDfunc.Text = Funcionario.ID_Func.Text

            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Cod_Nota()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_NOTA", cx.cn)
            da.Fill(ds, "NOTA")
            NotaFiscal.ID_Nota.DataSource = ds.Tables("NOTA")
            NotaFiscal.ID_Nota.DisplayMember = "ID_N"
            NotaFiscal.txtid_nota.Text = NotaFiscal.ID_Nota.Text

            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Cod_Op()
        Try
            cx.Conectar()
            da = New SqlDataAdapter("CODE_OP", cx.cn)
            da.Fill(ds, "LOGIN")
            Operador.ID_OP.DataSource = ds.Tables("LOGIN")
            Operador.ID_OP.DisplayMember = "ID_O"

            cx.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
