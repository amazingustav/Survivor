Public Class Operador

    Private Sub btnNovoOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoOp.Click
        Me.Refresh()
        cboFuncOp.Text = ""
        cboNivelOp.Text = ""
        txtNomeOp.Clear()
        txtSenhaOp.Clear()
        txtConfSenhaOp.Clear()

        code.Cod_Op()

        lblStatusSenha.Visible = False

        btnAlterOp.Enabled = False
        btnExcluiOp.Enabled = False
        btnCadastraOp.Enabled = True
    End Sub

    Private Sub btnCadastraOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraOp.Click
        If txtSenhaOp.Text = txtConfSenhaOp.Text & txtNomeOp.Text <> "" & txtSenhaOp.Text <> "" Then
            lblStatusSenha.Text = "Senhas confirmadas!"
            lblStatusSenha.ForeColor = Color.ForestGreen
            lblStatusSenha.Visible = True

            insert.CadastrarLogin()
            view.VisualizarOp()
        Else
            lblStatusSenha.Text = "Senhas não compatíveis!"
            lblStatusSenha.ForeColor = Color.Tomato
            lblStatusSenha.Visible = True
            txtSenhaOp.Clear()
            txtConfSenhaOp.Clear()
            txtSenhaOp.Focus()
        End If
    End Sub

    Private Sub btnAlterOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterOp.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem alterados." & Chr(13) & "Você deseja alterar estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            alter.AlterarLogin()
            view.VisualizarOp()
        End If
    End Sub

    Private Sub btnExcluiOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiOp.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem excluidos." & Chr(13) & "Você deseja excluir estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            delete.ExcluirOperador()
            view.VisualizarOp()
        End If
    End Sub

    Private Sub btnPesquisaOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaOp.Click
        view.VisualizarOp()
    End Sub

    Private Sub Operador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatOperador()
        code.Cod_Op()
        view.CadViewOp()
    End Sub

    Private Sub dtgOperador_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgOperador.SelectionChanged
        data.DTGoperador()
    End Sub

    Private Sub btnNovoOp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoOp.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoOp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoOp.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnCadastraOp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraOp.MouseHover
        pbxCadastrar.Visible = True

    End Sub

    Private Sub btnCadastraOp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraOp.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnAlterOp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterOp.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterOp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterOp.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiOp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiOp.MouseHover
        pbxExclui.Visible = True

    End Sub

    Private Sub btnExcluiOp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiOp.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnPesquisaOp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaOp.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisaOp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaOp.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub txtPesquisaOp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaOp.TextChanged
        If cboPesquisaOp.Text = "ID" Then
            view.OpID()
        ElseIf cboPesquisaOp.Text = "Nome" Then
            view.OpNome()
        ElseIf cboPesquisaOp.Text = "Nível" Then
            view.OpNivel()
        ElseIf cboPesquisaOp.Text = "Usuário" Then
            view.OpUsuario()
        ElseIf txtPesquisaOp.Text = "" Then
            dtgOperador.Visible.Equals(False)
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        OperadorHelp.Show()
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub
End Class