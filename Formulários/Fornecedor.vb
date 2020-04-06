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
    End Sub

    Private Sub btnCadastraForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraForn.Click
        insert.CadastrarFornecedor()
        view.VisualizarForn()
    End Sub

    Private Sub btnAlterForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterForn.Click
        alter.AlterarFornecedor()
        view.VisualizarForn()
    End Sub

    Private Sub btnExcluiForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiForn.Click
        delete.ExcluirFornecedor()
        view.VisualizarForn()
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
End Class