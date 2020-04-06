Public Class Fornecedor

    Private Sub btnNovoForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoForn.Click
        Me.Refresh()
        txtNomeFant.Clear()
        txtNomeForn.Clear()
        mskCNPJ.Clear()
        txtEnderForn.Clear()
        txtCidadeForn.Clear()
        txtBairroForn.Clear()
        mskCEPforn.Clear()
        mskTelForn.Clear()
        txtEmailForn.Clear()
        cboUFforn.Text = ""

        code.Cod_Forn()

        btnAlterForn.Enabled = False
        btnExcluiForn.Enabled = False
        btnCadastraForn.Enabled = True
    End Sub

    Private Sub btnCadastraForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraForn.Click
        If txtNomeForn.Text = "" Or txtNomeFant.Text = "" Or mskCNPJ.Text = "" Or mskTelForn.Text = "" Or txtEnderForn.Text = "" Or txtBairroForn.Text = "" Or txtCidadeForn.Text = "" Or cboUFforn.Text = "" Then
            MessageBox.Show("Preencha todos os campos obrigatórios! (*)", "Atenção aos campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            insert.CadastrarFornecedor()
        End If
    End Sub

    Private Sub btnAlterForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterForn.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem alterados." & Chr(13) & "Você deseja alterar estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            alter.AlterarFornecedor()
            view.VisualizarForn()
        End If
    End Sub

    Private Sub btnExcluiForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiForn.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem excluídos." & Chr(13) & "Você deseja excluir estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            delete.ExcluirFornecedor()
            view.VisualizarForn()
        End If
    End Sub

    Private Sub btnPesquisaForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaForn.Click
        view.VisualizarForn()
    End Sub

    Private Sub dtgFornecedor_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFornecedor.SelectionChanged
        data.DTGforn()
    End Sub

    Private Sub Fornecedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatForn()
        code.Cod_Forn()

        btnAlterForn.Enabled = False
        btnExcluiForn.Enabled = False
    End Sub

    Private Sub btnNovoForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoForn.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoForn.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnCadastraForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraForn.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastraForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraForn.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnAlterForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterForn.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterForn.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiForn.MouseHover
        pbxExclui.Visible = True
    End Sub

    Private Sub btnExcluiForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiForn.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnPesquisaForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaForn.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisaForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaForn.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub txtPesquisaForn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaForn.TextChanged
        If cboPesquisaForn.Text = "ID" Then
            view.FornID()
        ElseIf cboPesquisaForn.Text = "Nome" Then
            view.FornNome()
        ElseIf cboPesquisaForn.Text = "CNPJ" Then
            view.FornCNPJ()
        ElseIf cboPesquisaForn.Text = "CEP" Then
            view.FornCEP()
        ElseIf cboPesquisaForn.Text = "Telefone" Then
            view.FornTelefone()
        ElseIf txtPesquisaForn.Text = "" Then
            dtgFornecedor.Rows.Clear()
        End If
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        FornHelp.Show()
    End Sub
End Class