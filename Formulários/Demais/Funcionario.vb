Public Class Funcionario

    Private Sub btnNovoFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoFunc.Click
        Me.Refresh()
        txtNomeFunc.Clear()
        txtRGFunc.Clear()
        mskCPFfunc.Clear()
        txtEnderFunc.Clear()
        txtCompleFunc.Clear()
        txtCidadeFunc.Clear()
        txtBairroFunc.Clear()
        mskCEPfunc.Clear()
        mskTelFunc.Clear()
        mskCelFunc.Clear()
        txtEmailFunc.Clear()
        txtCargoFunc.Clear()
        mskSalario.Clear()

        code.Cod_Func()

        btnAlterFunc.Enabled = False
        btnExcluiFunc.Enabled = False
        btnCadastraFunc.Enabled = True
    End Sub

    Private Sub btnCadastraFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraFunc.Click
        If txtNomeFunc.Text = "" Or (rdbFemFunc.Checked = False And rdbMascFunc.Checked = False) Or txtRGFunc.Text = "" Or mskCPFfunc.Text = "" Or mskTelFunc.Text = "" Or txtEnderFunc.Text = "" Or txtCidadeFunc.Text = "" Or txtBairroFunc.Text = "" Or mskCEPfunc.Text = "" Or cboUFfunc.Text = "" Or txtCargoFunc.Text = "" Or mskSalario.Text = "" Then
            MessageBox.Show("Preencha todos os campos obrigatórios! (*)", "Atenção aos campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            insert.CadastrarFunc()
        End If
    End Sub

    Private Sub btnAlterFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterFunc.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem alterados." & Chr(13) & "Você deseja alterar estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            alter.AlterarFuncionario()
            view.VisualizarFunc()
        End If
    End Sub

    Private Sub btnExcluiFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiFunc.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem excluídos." & Chr(13) & "Você deseja excluir estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            delete.ExcluirFuncionario()
            view.VisualizarFunc()
        End If
    End Sub

    Private Sub btnPesquisaFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaFunc.Click
        view.VisualizarFunc()
    End Sub

    Private Sub Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatFunc()
        code.Cod_Func()

        btnAlterFunc.Enabled = False
        btnExcluiFunc.Enabled = False
    End Sub

    Private Sub dtgFuncionario_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgFuncionario.SelectionChanged
        data.DTGfunc()
    End Sub

    Private Sub btnNovoFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoFunc.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoFunc.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnCadastraFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraFunc.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastraFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraFunc.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnAlterFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterFunc.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterFunc.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiFunc.MouseHover
        pbxExclui.Visible = True
    End Sub

    Private Sub btnExcluiFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiFunc.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnPesquisaFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaFunc.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisaFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaFunc.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub txtPesquisaFunc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaFunc.TextChanged
        If cboPesquisaFunc.Text = "ID" Then
            view.FuncID()
        ElseIf cboPesquisaFunc.Text = "Nome" Then
            view.FuncNome()
        ElseIf cboPesquisaFunc.Text = "CPF" Then
            view.FuncCPF()
        ElseIf cboPesquisaFunc.Text = "CEP" Then
            view.FuncCEP()
        ElseIf cboPesquisaFunc.Text = "Telefone" Then
            view.FuncTelefone()
        ElseIf txtPesquisaFunc.Text = "" Then
            dtgFuncionario.Visible.Equals(False)
        End If
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        FuncHelp.Show()
    End Sub
End Class