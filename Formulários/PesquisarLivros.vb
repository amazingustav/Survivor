Public Class PesquisarLivros

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        view.VisualizarLivroVend()
    End Sub

    Private Sub PesquisarLivros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatPesquisar()
    End Sub

    Private Sub btnPesquisar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.MouseLeave
        pbxPesquisar.Visible = False
    End Sub
End Class