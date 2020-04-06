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

    Private Sub txtPesquisar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisar.TextChanged
        If cboPesquisa.Text = "ID" Then
            view.PesquisarID()
        ElseIf cboPesquisa.Text = "Título" Then
            view.PesquisarTitulo()
        ElseIf cboPesquisa.Text = "ISBN" Then
            view.PesquisarISBN()
        ElseIf cboPesquisa.Text = "Autor" Then
            view.PesquisarAutor()
        ElseIf cboPesquisa.Text = "Editora" Then
            view.PesquisarEditora()
        ElseIf cboPesquisa.Text = "Gênero" Then
            view.PesquisarGenero()
        ElseIf cboPesquisa.Text = "" Then
            Me.dtgLivro.Visible.Equals(False)
        End If
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        BuscaRapidaHelp.Show()
    End Sub
End Class