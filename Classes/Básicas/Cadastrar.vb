Imports System.Data.SqlClient

Public Class Cadastrar
    
    Public Sub CadastrarLogin()
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_LOGIN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cx.Conectar()

            cmd.Parameters.AddWithValue("@USUARIO", Operador.txtNomeOp.Text)
            cmd.Parameters.AddWithValue("@SENHA", Operador.txtSenhaOp.Text)
            If Operador.cboNivelOp.Text = "Administrador" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 1)
            ElseIf Operador.cboNivelOp.Text = "Vendedor" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 2)
            ElseIf Operador.cboNivelOp.Text = "Caixa" Then
                cmd.Parameters.AddWithValue("@ID_NIVEL", 3)
            End If
            cmd.Parameters.AddWithValue("@ID_FUNC", Operador.cboFuncOp.SelectedValue)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Login Cadastrado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadastrarCliente()
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_CLIENTE"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cx.Conectar()

            cmd.Parameters.AddWithValue("@NOME", Cliente.txtNomeCli.Text)
            If Cliente.rdbFemCli.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Cliente.rdbFemCli.Text)
            ElseIf Cliente.rdbMascCli.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Cliente.rdbMascCli.Text)
            End If
            cmd.Parameters.AddWithValue("@RG", Cliente.txtRGcli.Text)
            cmd.Parameters.AddWithValue("@CPF", CStr(Cliente.mskCPFcli.Text))
            cmd.Parameters.AddWithValue("@ENDERECO", Cliente.txtEnderCli.Text)
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Cliente.txtCompleCli.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Cliente.txtBairroCli.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Cliente.txtCidadeCli.Text)
            cmd.Parameters.AddWithValue("@CEP", CStr(Cliente.mskCEPcli.Text))
            cmd.Parameters.AddWithValue("@UF", Cliente.cboUFcli.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", CStr(Cliente.mskTelCli.Text))
            cmd.Parameters.AddWithValue("@CELULAR", CStr(Cliente.mskCelCli.Text))
            cmd.Parameters.AddWithValue("@EMAIL", Cliente.txtEmailCli.Text)

            If Cliente.rdbAtivo.Checked = True Then
                cmd.Parameters.AddWithValue("@STATUS", Cliente.rdbAtivo.Text)
            ElseIf Cliente.rdbInativo.Checked = True Then
                cmd.Parameters.AddWithValue("@STATUS", Cliente.rdbInativo.Text)
            End If

            cmd.ExecuteNonQuery()
            MessageBox.Show("Cliente cadastrado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadastrarFornecedor()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_FORN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@FANTASIA", Fornecedor.txtNomeFant.Text)
            cmd.Parameters.AddWithValue("@FORNECEDOR", Fornecedor.txtNomeForn.Text)
            cmd.Parameters.AddWithValue("@CNPJ", CStr(Fornecedor.mskCNPJ.Text))
            cmd.Parameters.AddWithValue("@ENDERECO", Fornecedor.txtEnderForn.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Fornecedor.txtBairroForn.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Fornecedor.txtCidadeForn.Text)
            cmd.Parameters.AddWithValue("@CEP", CStr(Fornecedor.mskCEPforn.Text))
            cmd.Parameters.AddWithValue("@UF", Fornecedor.cboUFforn.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", CStr(Fornecedor.mskTelForn.Text))
            cmd.Parameters.AddWithValue("@EMAIL", Fornecedor.txtEmailForn.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Fornecedor Cadastrado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try

        cx.Desconectar()
        view.CadViewForn()
    End Sub

    Public Sub CadastrarLivro()
        view.Mostrar_IDForn()
        Pegar_Autor()
        Pegar_editora()
        Pegar_genero()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_LIVRO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
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

            Sinopse.Close()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Livro Cadastrado!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Pegar_Autor()
        Try
            Dim sql As String = "select * from Autor where Autor='" & Trim(Livro.txtAutorLivro.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                idAutor = dr("Id")
                If idAutor = Nothing Then
                    dr.Close()
                    cx.Desconectar()
                    CadAutor()
                End If
            Else
                dr.Close()
                cx.Desconectar()
                CadAutor()
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadAutor()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_AUTOR"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@AUTOR", Livro.txtAutorLivro.Text)
            cmd.ExecuteNonQuery()
        Catch
        End Try
        cx.Desconectar()
        Pegar_Autor()
    End Sub
    
    Public Sub CadGen()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_GEN"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@GENERO", Livro.txtGenero.Text)
            cmd.ExecuteNonQuery()
        Catch
        End Try
        cx.Desconectar()
        Pegar_genero()
    End Sub

    Public Sub CadEditora()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_EDITORA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@EDITORA", Livro.txtEditora.Text)
            cmd.ExecuteNonQuery()
        Catch
        End Try
        cx.Desconectar()
        Pegar_editora()
    End Sub

    Public Sub Pegar_editora()
        Try
            Dim sql As String = "select * from editora where editora='" & Trim(Livro.txtEditora.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                IdEditora = dr("Id")
            Else
                dr.Close()
                cx.Desconectar()
                CadEditora()
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub
    
    Public Sub Pegar_genero()
        Try
            Dim sql As String = "select * from genero where genero='" & Trim(Livro.txtGenero.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Idgenero = dr("Id")
            Else
                dr.Close()
                cx.Desconectar()
                CadGen()
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public cpf_local
    
    Public Sub CadastrarNotaADM()
        view.CPF_CLI()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_NOTA"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@ID_CARRINHO", CInt(NotaFiscal.cbocarrinho.Text))
            cmd.Parameters.AddWithValue("@ID_CLI", cpf_local)
            cmd.Parameters.AddWithValue("@DATA_EMISSAO", CDate(NotaFiscal.mskDataEmissao.Text))
            cmd.Parameters.AddWithValue("@VLOR_TOT", CDec(NotaFiscal.lblValorTotal.Text))
            cmd.Parameters.AddWithValue("@ID_FUNC", ID_Vend)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub qtde_carrinho()
        Dim sql As String = ""
        sql = "SELECT SUM(VLOR_ITEM) AS VALOR_TOTAL FROM CARRINHO"

        Dim cx As New Conexao
        cx.Conectar()

        Dim cd As New SqlCommand
        cd.CommandText = sql
        cd.Connection = cx.cn

        Dim dr As SqlDataReader = cd.ExecuteReader

        If dr.Read() Then
            Dim qtde As String = dr("VALOR_TOTAL")
            NotaFiscal.lblValorTotal.Text = qtde
        End If
        dr.Close()
        cx.Desconectar()
    End Sub

    Public Sub CadastrarCarrinho()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_CARRINHO"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@ID_LIVRO", CInt(NotaFiscal.txtcodlivro.Text))
            cmd.Parameters.AddWithValue("@QTD_LIVRO", qtde)
            cmd.Parameters.AddWithValue("@VLOR_UNIT", CDec(NotaFiscal.txtValorUnit.Text))
            cmd.Parameters.AddWithValue("@VLOR_ITEM", CDec(NotaFiscal.txtValorItem.Text))

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadastrarCarrinho_1()
        Try
            cx.Conectar()
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_CARRINHO_1"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cmd.Parameters.AddWithValue("@ID_LIVRO", CInt(NotaFiscal.txtcodlivro.Text))
            cmd.Parameters.AddWithValue("@QTD_LIVRO", qtde)
            cmd.Parameters.AddWithValue("@VLOR_UNIT", CDec(NotaFiscal.txtValorUnit.Text))
            cmd.Parameters.AddWithValue("@VLOR_ITEM", CDec(NotaFiscal.txtValorItem.Text))
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
        view.VisualizarCarrinho_1()
    End Sub

    Public Sub CadastrarFunc()
        Try
            Dim cmd As New SqlCommand
            cmd.CommandText = "CADASTRA_FUNC"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cx.cn
            cx.Conectar()

            cmd.Parameters.AddWithValue("@NOME", Funcionario.txtNomeFunc.Text)
            If Funcionario.rdbFemFunc.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Funcionario.rdbFemFunc.Text)
            ElseIf Funcionario.rdbMascFunc.Checked = True Then
                cmd.Parameters.AddWithValue("@SEXO", Funcionario.rdbMascFunc.Text)
            End If
            cmd.Parameters.AddWithValue("@RG", Funcionario.txtRGFunc.Text)
            cmd.Parameters.AddWithValue("@CPF", CStr(Funcionario.mskCPFfunc.Text))
            cmd.Parameters.AddWithValue("@ENDERECO", Funcionario.txtEnderFunc.Text)
            cmd.Parameters.AddWithValue("@COMPLEMENTO", Funcionario.txtCompleFunc.Text)
            cmd.Parameters.AddWithValue("@BAIRRO", Funcionario.txtBairroFunc.Text)
            cmd.Parameters.AddWithValue("@CIDADE", Funcionario.txtCidadeFunc.Text)
            cmd.Parameters.AddWithValue("@CEP", CStr(Funcionario.mskCEPfunc.Text))
            cmd.Parameters.AddWithValue("@UF", Funcionario.cboUFfunc.Text)
            cmd.Parameters.AddWithValue("@TELEFONE", CStr(Funcionario.mskTelFunc.Text))
            cmd.Parameters.AddWithValue("@CELULAR", CStr(Funcionario.mskCelFunc.Text))
            cmd.Parameters.AddWithValue("@EMAIL", Funcionario.txtEmailFunc.Text)
            cmd.Parameters.AddWithValue("@CARGO", Funcionario.txtCargoFunc.Text)
            cmd.Parameters.AddWithValue("@SALARIO", CDec(Funcionario.mskSalario.Text))

            cmd.ExecuteNonQuery()
            MessageBox.Show("Funcionário cadastrado")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cx.Desconectar()
        view.CadViewOp()
    End Sub
End Class