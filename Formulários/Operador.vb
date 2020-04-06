Public Class Operador

    Private Sub btnNovoOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoOp.Click
        Me.Refresh()
        cboFuncOp.Text = ""
        cboNivelOp.Text = ""
        txtNomeOp.Clear()
        txtSenhaOp.Clear()
        txtConfSenhaOp.Clear()

        code.Cod_Op()
    End Sub

    Private Sub btnCadastraOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraOp.Click
        If txtSenhaOp.Text = txtConfSenhaOp.Text Then
            lblStatusSenha.Text = "Senhas confirmadas!"
            lblStatusSenha.ForeColor = Color.ForestGreen
            lblStatusSenha.Visible = True

            insert.CadastrarLogin()
            view.VisualizarOp()
        Else
            lblStatusSenha.Text = "X Senhas não compatíveis!"
            lblStatusSenha.ForeColor = Color.Tomato
            lblStatusSenha.Visible = True
            txtSenhaOp.Clear()
            txtConfSenhaOp.Clear()
            txtSenhaOp.Focus()
        End If
    End Sub

    Private Sub btnAlterOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterOp.Click
        alter.AlterarLogin()
        view.VisualizarOp()
    End Sub

    Private Sub btnExcluiOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiOp.Click
        delete.ExcluirOperador()
        view.VisualizarOp()
    End Sub

    Private Sub btnPesquisaOp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaOp.Click
        view.VisualizarOp()
    End Sub

    Private Sub Operador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TransparencyKey = BackColor
        'Me.ControlBox = False

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
End Class