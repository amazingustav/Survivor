Public Class Estoque

    Private Sub Estoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatEstoque()
    End Sub

    Private Sub btnPesquisaLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.Click
        view.LivroPorNome()
    End Sub

    Private Sub btnPesquisaLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseHover
        pbxPesquisar1.Visible = True
    End Sub

    Private Sub btnPesquisaLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseLeave
        pbxPesquisar1.Visible = False
    End Sub
End Class