Public Class Cliente
    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatCliente()
        code.Cod_Cliente()
    End Sub

    Private Sub dtgCliente_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCliente.SelectionChanged
        data.DTGcliente()
    End Sub

    Private Sub btnNovoCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.Click
        Me.Refresh()

        txtNomeCli.Clear()
        txtRGcli.Clear()
        mskCPFcli.Clear()
        txtEnderCli.Clear()
        txtCompleCli.Clear()
        txtCidadeCli.Clear()
        txtBairroCli.Clear()
        mskCEPcli.Clear()
        mskTelCli.Clear()
        mskCelCli.Clear()
        txtEmailCli.Clear()
        cboUFcli.Text = ""

        code.Cod_Cliente()
    End Sub

    Private Sub btnCadastraCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.Click
        insert.CadastrarCliente()
        view.VisualizarCliente()
    End Sub

    Private Sub btnAlterCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.Click
        alter.AlterarCliente()
        view.VisualizarCliente()
    End Sub

    Private Sub btnExcluiCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.Click
        delete.ExcluirCliente()
        view.VisualizarCliente()
    End Sub

    Private Sub btnPesquisarCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.Click
        view.VisualizarCliente()
    End Sub

    Private Sub btnCadastraCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastraCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnNovoCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnAlterCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.MouseHover
        pbxExclui.Visible = True
    End Sub

    Private Sub btnExcluiCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnPesquisarCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisarCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.MouseLeave
        pbxPesquisar.Visible = False
    End Sub
End Class