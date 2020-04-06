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
    End Sub

    Private Sub btnCadastraFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraFunc.Click
        insert.CadastrarFunc()
        view.VisualizarFunc()
    End Sub

    Private Sub btnAlterFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterFunc.Click
        alter.AlterarFuncionario()
        view.VisualizarFunc()
    End Sub

    Private Sub btnExcluiFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiFunc.Click
        delete.ExcluirFuncionario()
        view.VisualizarFunc()
    End Sub

    Private Sub btnPesquisaFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaFunc.Click
        view.VisualizarFunc()
    End Sub

    Private Sub Funcionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TransparencyKey = BackColor
        'Me.ControlBox = False

        formata.FormatFunc()
        code.Cod_Func()
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
End Class