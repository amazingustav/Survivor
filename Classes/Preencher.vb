Public Class Preencher
    ' ---------- SUB'S DO FORMULÁRIO PRINCIPAL ----------
    Public Sub DTGcliente()
        Cliente.IDcmo.Text = Cliente.dtgCliente.CurrentRow.Cells(0).Value.ToString()
        Cliente.txtIDcli.Text = Cliente.dtgCliente.CurrentRow.Cells(0).Value.ToString()
        Cliente.txtNomeCli.Text = Cliente.dtgCliente.CurrentRow.Cells(1).Value.ToString()

        If Cliente.dtgCliente.CurrentRow.Cells(2).Value.ToString() = "M" Then
            Cliente.rdbMascCli.Checked = True
            Cliente.rdbFemCli.Checked = False
        ElseIf Cliente.dtgCliente.CurrentRow.Cells(2).Value.ToString() = "F" Then
            Cliente.rdbFemCli.Checked = True
            Cliente.rdbMascCli.Checked = False
        End If

        Cliente.txtRGcli.Text = Cliente.dtgCliente.CurrentRow.Cells(3).Value.ToString()
        Cliente.mskCPFcli.Text = Cliente.dtgCliente.CurrentRow.Cells(4).Value.ToString()
        Cliente.txtEnderCli.Text = Cliente.dtgCliente.CurrentRow.Cells(5).Value.ToString()
        Cliente.txtCompleCli.Text = Cliente.dtgCliente.CurrentRow.Cells(6).Value.ToString()
        Cliente.txtBairroCli.Text = Cliente.dtgCliente.CurrentRow.Cells(7).Value.ToString()
        Cliente.txtCidadeCli.Text = Cliente.dtgCliente.CurrentRow.Cells(8).Value.ToString()
        Cliente.mskCEPcli.Text = Cliente.dtgCliente.CurrentRow.Cells(9).Value.ToString()
        Cliente.cboUFcli.Text = Cliente.dtgCliente.CurrentRow.Cells(10).Value.ToString()
        Cliente.mskTelCli.Text = Cliente.dtgCliente.CurrentRow.Cells(11).Value.ToString()
        Cliente.mskCelCli.Text = Cliente.dtgCliente.CurrentRow.Cells(12).Value.ToString()
        Cliente.txtEmailCli.Text = Cliente.dtgCliente.CurrentRow.Cells(13).Value.ToString()

        If Cliente.dtgCliente.CurrentRow.Cells(14).Value.ToString() = "Ativo" Then
            Cliente.rdbAtivo.Checked = True
            Cliente.rdbInativo.Checked = False

            Cliente.txtNomeCli.ForeColor = Color.Black
            Cliente.txtRGcli.ForeColor = Color.Black
            Cliente.mskCPFcli.ForeColor = Color.Black
            Cliente.txtEnderCli.ForeColor = Color.Black
            Cliente.txtCompleCli.ForeColor = Color.Black
            Cliente.txtBairroCli.ForeColor = Color.Black
            Cliente.txtCidadeCli.ForeColor = Color.Black
            Cliente.mskCEPcli.ForeColor = Color.Black
            Cliente.cboUFcli.ForeColor = Color.Black
            Cliente.mskTelCli.ForeColor = Color.Black
            Cliente.mskCelCli.ForeColor = Color.Black
            Cliente.txtEmailCli.ForeColor = Color.Black

        ElseIf Cliente.dtgCliente.CurrentRow.Cells(14).Value.ToString() = "Inativo" Then
            Cliente.rdbInativo.Checked = True
            Cliente.rdbAtivo.Checked = False

            Cliente.txtNomeCli.ForeColor = Color.DarkRed
            Cliente.txtRGcli.ForeColor = Color.DarkRed
            Cliente.mskCPFcli.ForeColor = Color.DarkRed
            Cliente.txtEnderCli.ForeColor = Color.DarkRed
            Cliente.txtCompleCli.ForeColor = Color.DarkRed
            Cliente.txtBairroCli.ForeColor = Color.DarkRed
            Cliente.txtCidadeCli.ForeColor = Color.DarkRed
            Cliente.mskCEPcli.ForeColor = Color.DarkRed
            Cliente.cboUFcli.ForeColor = Color.DarkRed
            Cliente.mskTelCli.ForeColor = Color.DarkRed
            Cliente.mskCelCli.ForeColor = Color.DarkRed
            Cliente.txtEmailCli.ForeColor = Color.DarkRed
        End If

        Cliente.btnAlterCli.Enabled = True
        Cliente.btnExcluiCli.Enabled = True
        Cliente.btnCadastraCli.Enabled = False
    End Sub

    Public Sub DTGnota()
        NotaFiscal.cboCodLivro.Text = NotaFiscal.dtgNota.CurrentRow.Cells(0).Value.ToString
        NotaFiscal.txtcodlivro.Text = NotaFiscal.dtgNota.CurrentRow.Cells(0).Value.ToString
        NotaFiscal.txtLivroNota.Text = NotaFiscal.dtgNota.CurrentRow.Cells(1).Value.ToString()
        NotaFiscal.txtValorUnit.Text = NotaFiscal.dtgNota.CurrentRow.Cells(10).Value.ToString

        If NotaFiscal.txtQtde.Text = "" Then
            NotaFiscal.txtValorItem.Text = NotaFiscal.dtgNota.CurrentRow.Cells(10).Value.ToString
        End If
    End Sub

    Public Sub DTGcarrinho()
        NotaFiscal.cbocarrinho.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(0).Value.ToString
        NotaFiscal.cboCodLivro.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(1).Value.ToString
        NotaFiscal.txtcodlivro.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(1).Value.ToString
        NotaFiscal.txtLivroNota.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(2).Value.ToString()
        NotaFiscal.txtValorUnit.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(3).Value.ToString
        NotaFiscal.txtQtde.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(4).Value.ToString
        NotaFiscal.txtValorItem.Text = NotaFiscal.dtgCarrinho.CurrentRow.Cells(5).Value.ToString
    End Sub

    Public Sub DTGforn()
        Fornecedor.ID_Forn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(0).Value.ToString()
        Fornecedor.txtIDforn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(0).Value.ToString()
        Fornecedor.txtNomeFant.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(1).Value.ToString()
        Fornecedor.txtNomeForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(2).Value.ToString()
        Fornecedor.mskCNPJ.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(3).Value.ToString()
        Fornecedor.txtEnderForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(4).Value.ToString()
        Fornecedor.txtBairroForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(5).Value.ToString()
        Fornecedor.txtCidadeForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(6).Value.ToString()
        Fornecedor.mskCEPforn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(7).Value.ToString()
        Fornecedor.cboUFforn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(8).Value.ToString()
        Fornecedor.mskTelForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(9).Value.ToString()
        Fornecedor.txtEmailForn.Text = Fornecedor.dtgFornecedor.CurrentRow.Cells(10).Value.ToString()

        Fornecedor.btnAlterForn.Enabled = True
        Fornecedor.btnExcluiForn.Enabled = True
        Fornecedor.btnCadastraForn.Enabled = False
    End Sub

    Public Sub DTGlivro()
        Livro.ID_Livro.Text = Livro.dtgLivro.CurrentRow.Cells(0).Value.ToString()
        Livro.txtIDLivro.Text = Livro.dtgLivro.CurrentRow.Cells(0).Value.ToString()
        Livro.txtTituloLivro.Text = Livro.dtgLivro.CurrentRow.Cells(1).Value.ToString()
        Livro.txtISBN.Text = Livro.dtgLivro.CurrentRow.Cells(2).Value.ToString()
        Livro.cboFornLivro.SelectedValue = Livro.dtgLivro.CurrentRow.Cells(3).Value
        Livro.txtAutorLivro.Text = Livro.dtgLivro.CurrentRow.Cells(5).Value.ToString()
        Livro.txtEditora.Text = Livro.dtgLivro.CurrentRow.Cells(6).Value.ToString()
        Livro.txtGenero.Text = Livro.dtgLivro.CurrentRow.Cells(7).Value.ToString()
        Livro.txtEdicao.Text = Livro.dtgLivro.CurrentRow.Cells(8).Value.ToString()
        Livro.txtQtde.Text = Livro.dtgLivro.CurrentRow.Cells(9).Value.ToString()
        Livro.mskPrecoLivro.Text = Livro.dtgLivro.CurrentRow.Cells(10).Value.ToString()
        Sinopse.txtSinopse.Text = Livro.dtgLivro.CurrentRow.Cells(11).Value.ToString()

        If Livro.dtgLivro.CurrentRow.Cells(11).Value.ToString() = Nothing Then
            Livro.pbxLivro.Image = Nothing
            Livro.pbxLivro.ImageLocation = Nothing
        End If
        ID_Forn = CInt(Livro.cboFornLivro.SelectedValue)
        nomearq = Livro.dtgLivro.CurrentRow.Cells(12).Value.ToString()
        Livro.pbxLivro.BackgroundImageLayout = ImageLayout.Stretch
        Livro.pbxLivro.SizeMode = PictureBoxSizeMode.StretchImage
        Try
            Livro.pbxLivro.Image = Nothing
            Livro.pbxLivro.Image = Image.FromFile(((nomearq)))
        Catch
        End Try

        Livro.btnAlterLivro.Enabled = True
        Livro.btnExcluiLivro.Enabled = True
        Livro.btnCadastraLivro.Enabled = False
    End Sub

    Public Sub DTGfunc()
        Funcionario.ID_Func.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(0).Value.ToString()
        Funcionario.txtIDfunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(0).Value.ToString()
        Funcionario.txtNomeFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(1).Value.ToString()

        If Funcionario.dtgFuncionario.CurrentRow.Cells(2).Value.ToString() = "M" Then
            Funcionario.rdbMascFunc.Checked = True
            Funcionario.rdbFemFunc.Checked = False
        ElseIf Funcionario.dtgFuncionario.CurrentRow.Cells(2).Value.ToString() = "F" Then
            Funcionario.rdbFemFunc.Checked = True
            Funcionario.rdbMascFunc.Checked = False
        End If

        Funcionario.txtRGFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(3).Value.ToString()
        Funcionario.mskCPFfunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(4).Value.ToString()
        Funcionario.txtEnderFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(5).Value.ToString()
        Funcionario.txtCompleFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(6).Value.ToString()
        Funcionario.txtBairroFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(7).Value.ToString()
        Funcionario.txtCidadeFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(8).Value.ToString()
        Funcionario.mskCEPfunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(9).Value.ToString()
        Funcionario.cboUFfunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(10).Value.ToString()
        Funcionario.mskTelFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(11).Value.ToString()
        Funcionario.mskCelFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(12).Value.ToString()
        Funcionario.txtEmailFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(13).Value.ToString()
        Funcionario.txtCargoFunc.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(14).Value.ToString()
        Funcionario.mskSalario.Text = Funcionario.dtgFuncionario.CurrentRow.Cells(15).Value.ToString()

        Funcionario.btnAlterFunc.Enabled = True
        Funcionario.btnExcluiFunc.Enabled = True
        Funcionario.btnCadastraFunc.Enabled = False
    End Sub

    Public Sub DTGoperador()
        Operador.ID_OP.Text = Operador.dtgOperador.CurrentRow.Cells(0).Value.ToString()
        Operador.txtNomeOp.Text = Operador.dtgOperador.CurrentRow.Cells(1).Value.ToString()
        Operador.txtSenhaOp.Text = Operador.dtgOperador.CurrentRow.Cells(2).Value.ToString()
        Operador.txtConfSenhaOp.Text = Operador.dtgOperador.CurrentRow.Cells(2).Value.ToString()
        Operador.cboNivelOp.Text = Operador.dtgOperador.CurrentRow.Cells(3).Value.ToString()
        Operador.cboFuncOp.Text = Operador.dtgOperador.CurrentRow.Cells(4).Value.ToString()

        Operador.btnAlterOp.Enabled = True
        Operador.btnExcluiOp.Enabled = True
        Operador.btnCadastraOp.Enabled = False

        Operador.lblStatusSenha.Visible = False
    End Sub
End Class
