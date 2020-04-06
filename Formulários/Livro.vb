Public Class Livro

    Private Sub btnInserirImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirImg.Click
        picture.AbrirFoto()
    End Sub

    Private Sub btnNovoLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoLivro.Click
        Me.Refresh()
        txtISBN.Clear()
        txtTituloLivro.Clear()
        txtAutorLivro.Clear()
        mskPrecoLivro.Clear()
        txtEditora.Clear()
        txtGenero.Clear()
        cboFornLivro.Text = ""
        pbxLivro.Image = Nothing

        code.Cod_Livro()
    End Sub
    Private Sub btnCadastraLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraLivro.Click
        insert.CadastrarLivro()
        view.VisualizarLivro()
    End Sub

    Private Sub btnAlterLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterLivro.Click
        ID_Forn = NotaFiscal.cboCodLivro.SelectedValue
        alter.AlterarLivro()
        view.VisualizarLivro()
        Me.Refresh()
    End Sub

    Private Sub btnExcluiLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiLivro.Click
        delete.ExcluirLivro()
        view.VisualizarLivro()
    End Sub

    Private Sub btnSinopse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinopse.Click
        Sinopse.Show()

        If Sinopse.WindowState = FormWindowState.Minimized Then
            Sinopse.WindowState = FormWindowState.Normal
            Sinopse.Show()
        End If
    End Sub

    Private Sub btnPesquisaLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.Click
        view.VisualizarLivro()
    End Sub

    Private Sub Livro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TransparencyKey = BackColor
        'Me.ControlBox = False

        formata.FormatLivro()
        code.Cod_Livro()
        view.CadViewForn()
    End Sub

    Private Sub dtgLivro_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgLivro.SelectionChanged
        data.DTGlivro()
    End Sub

    Private Sub btnNovoLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoLivro.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoLivro.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnCadastraLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraLivro.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastraLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraLivro.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnAlterLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterLivro.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterLivro.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiLivro.MouseHover
        pbxExclui.Visible = True
    End Sub

    Private Sub btnExcluiLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiLivro.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnInserirImg_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirImg.MouseHover
        pbxEscolherfoto.Visible = True
    End Sub

    Private Sub btnInserirImg_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserirImg.MouseLeave
        pbxEscolherfoto.Visible = False

    End Sub
    Private Sub btnSinopse_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinopse.MouseLeave
        pbxSinopse.Visible = False
    End Sub

    Private Sub btnSinopse_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinopse.MouseHover
        pbxSinopse.Visible = True

    End Sub

    Private Sub btnPesquisaLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisaLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseLeave
        pbxPesquisar.Visible = False
    End Sub
End Class