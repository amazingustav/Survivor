Imports System.Data.SqlClient

Public Class Alterar

    Public Sub AlterarLogin()
        view.Mostrar_IDFunc()
        
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        
        cmd.CommandText = "ALTER_LOGIN"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
        
        Try
            cx.Conectar()
            cmd.Parameters.AddWithValue("@ID", Trim(Operador.ID_OP.Text))
            cmd.Parameters.AddWithValue("@USUARIO", Operador.txtNomeOp.Text)
            cmd.Parameters.AddWithValue("@SENHA", Operador.txtSenhaOp.Text)
            cmd.Parameters.AddWithValue("@ID_FUNC", ID_Func)
        
            If Operador.cboNivelOp.Text = "Administrador" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 1)
            ElseIf Operador.cboNivelOp.Text = "Vendedor" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 2)
            ElseIf Operador.cboNivelOp.Text = "Caixa" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 3)
            End If
            
            cmd.ExecuteNonQuery()
            
            Operador.cboFuncOp.Refresh()
            MessageBox.Show("Login atualizado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
        
        cx.Desconectar()
    End Sub

    Public Sub AlterarCliente()
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        
        cmd.CommandText = "ALTER_CLIENTE"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
        
        Try
            cx.Conectar()
            
            cmd.Parameters.AddWithValue("@ID", Cliente.IDcmo.Text)
            cmd.Parameters.AddWithValue("@NOME", Trim(Cliente.txtNomeCli.Text))
            cmd.Parameters.AddWithValue("@RG", Cliente.txtRGcli.Text)
            cmd.Parameters.AddWithValue("@ENDERECO", Cliente.txtEnderCli.Text)
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Cliente.txtCompleCli.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Cliente.txtCidadeCli.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Cliente.txtBairroCli.Text)
            cmd.Parameters.AddWithValue("@EMAIL", Cliente.txtEmailCli.Text)
            cmd.Parameters.AddWithValue("@CPF", Cliente.mskCPFcli.Text)
            cmd.Parameters.AddWithValue("@CEP", Cliente.mskCEPcli.Text)
            cmd.Parameters.AddWithValue("@UF", Cliente.cboUFcli.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", Cliente.mskTelCli.Text)
            cmd.Parameters.AddWithValue("@CELULAR", Cliente.mskCelCli.Text)
        
            If Cliente.rdbFemCli.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Cliente.rdbFemCli.Text)
            ElseIf Cliente.rdbMascCli.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Cliente.rdbMascCli.Text)
            End If
        
            If Cliente.rdbAtivo.Checked = True Then
                cmd.Parameters.AddWithValue("@STATUS", Cliente.rdbAtivo.Text)
            ElseIf Cliente.rdbInativo.Checked = True Then
                cmd.Parameters.AddWithValue("@STATUS", Cliente.rdbInativo.Text)
            End If
            
            cmd.ExecuteNonQuery()

            MessageBox.Show("Dados atualizados!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
        
        cx.Desconectar()
    End Sub
    
    Public Sub AlterarFornecedor()
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        
        cmd.CommandText = "ALTER_FORN"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
        
        Try
            cx.Conectar()

            cmd.Parameters.AddWithValue("@ID", Fornecedor.ID_Forn.Text)
            cmd.Parameters.AddWithValue("@FANTASIA", Trim(Fornecedor.txtNomeFant.Text))
            cmd.Parameters.AddWithValue("@FORNECEDOR", Fornecedor.txtNomeForn.Text)
            cmd.Parameters.AddWithValue("@CNPJ", Fornecedor.mskCNPJ.Text)
            cmd.Parameters.AddWithValue("@ENDERECO", Fornecedor.txtEnderForn.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Fornecedor.txtBairroForn.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Fornecedor.txtCidadeForn.Text)
            cmd.Parameters.AddWithValue("@CEP", Fornecedor.mskCEPforn.Text)
            cmd.Parameters.AddWithValue("@UF", Fornecedor.cboUFforn.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", Fornecedor.mskTelForn.Text)
            cmd.Parameters.AddWithValue("@EMAIL", Fornecedor.txtEmailForn.Text)
        
            cmd.ExecuteNonQuery()

            Livro.cboFornLivro.Refresh()
            MessageBox.Show("Dados atualizados!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try

        cx.Desconectar()
    End Sub
    
    Public Sub AlterarLivro()
        view.Mostrar_IDForn()
        insert.Pegar_Autor()
        insert.Pegar_editora()
        insert.Pegar_genero()
    
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        cmd.CommandText = "ALTER_LIVRO"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
    
        Try
            cx.Conectar()

            cmd.Parameters.AddWithValue("@ID", CInt(Livro.ID_Livro.Text))
            cmd.Parameters.AddWithValue("@LIVRO", Livro.txtTituloLivro.Text)
            cmd.Parameters.AddWithValue("@ISBN", Livro.txtISBN.Text)
            cmd.Parameters.AddWithValue("@ID_FORN", ID_Forn)
            cmd.Parameters.AddWithValue("@PRECO", CDec(Livro.mskPrecoLivro.Text))
            cmd.Parameters.AddWithValue("@SINOPSE", Sinopse.txtSinopse.Text)
            cmd.Parameters.AddWithValue("@QTDE", Livro.txtQtde.Text)
            cmd.Parameters.AddWithValue("@IMAGEM", nomearq)
            cmd.Parameters.AddWithValue("@ID_AUTOR", idAutor)
            cmd.Parameters.AddWithValue("@ID_EDITORA", IdEditora)
            cmd.Parameters.AddWithValue("@ID_GENERO", Idgenero)
            cmd.Parameters.AddWithValue("@EDICAO", Livro.txtEdicao.Text)
    
            cmd.ExecuteNonQuery()

            Livro.cboFornLivro.Refresh()
            MessageBox.Show("Dados atualizados!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
    
        cx.Desconectar()
    End Sub
    
    Public Sub AlterarNota()
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
    
        cmd.CommandText = "ALTER_NOTA"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
    
        Try
            cx.Conectar()
            
            cmd.Parameters.AddWithValue("@ID", CInt(NotaFiscal.cboCodLivro.Text))
            cmd.Parameters.AddWithValue("@QTDE", CInt(NotaFiscal.txtQtde.Text))
    
            cmd.ExecuteNonQuery()  
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try

        cx.Desconectar()
    End Sub

    Public Sub AlterarNotaAdd()
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        cmd.CommandText = "ALTER_NOTA_ADD"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
        
        Try
            cx.Conectar()

            cmd.Parameters.AddWithValue("@ID", CInt(NotaFiscal.cboCodLivro.Text))
            cmd.Parameters.AddWithValue("@QTDE", CInt(NotaFiscal.txtQtde.Text))
            
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
        
        cx.Desconectar()
    End Sub

    Public Sub AlterarFuncionario()
        Dim cx As New Conexao
        Dim cmd As New SqlCommand
        cmd.CommandText = "ALTER_FUNC"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cx.cn
        
        Try
            cx.Conectar()

            cmd.Parameters.AddWithValue("@ID", Funcionario.ID_Func.Text)
            cmd.Parameters.AddWithValue("@NOME", Trim(Funcionario.txtNomeFunc.Text))
            cmd.Parameters.AddWithValue("@RG", Funcionario.txtRGFunc.Text)
            cmd.Parameters.AddWithValue("@ENDERECO", Funcionario.txtEnderFunc.Text)
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Funcionario.txtCompleFunc.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Funcionario.txtCidadeFunc.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Funcionario.txtBairroFunc.Text)
            cmd.Parameters.AddWithValue("@EMAIL", Funcionario.txtEmailFunc.Text)
            cmd.Parameters.AddWithValue("@CPF", Funcionario.mskCPFfunc.Text)
            cmd.Parameters.AddWithValue("@CEP", Funcionario.mskCEPfunc.Text)
            cmd.Parameters.AddWithValue("@UF", Funcionario.cboUFfunc.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", Funcionario.mskTelFunc.Text)
            cmd.Parameters.AddWithValue("@CELULAR", Funcionario.mskCelFunc.Text)
            cmd.Parameters.AddWithValue("@CARGO", Funcionario.txtCargoFunc.Text)
            cmd.Parameters.AddWithValue("@SALARIO", Funcionario.mskSalario.Text)
        
            If Funcionario.rdbFemFunc.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Funcionario.rdbFemFunc.Text)
            ElseIf Funcionario.rdbMascFunc.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Funcionario.rdbMascFunc.Text)
            End If
        
            cmd.ExecuteNonQuery()

            Operador.cboFuncOp.Refresh()
            MessageBox.Show("Dados atualizados!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro!")
        End Try
        
        cx.Desconectar()
        view.CadViewOp()
    End Sub
End Class
