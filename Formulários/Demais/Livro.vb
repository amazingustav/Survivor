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

        btnAlterLivro.Enabled = False
        btnExcluiLivro.Enabled = False
        btnCadastraLivro.Enabled = True
    End Sub
    Private Sub btnCadastraLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraLivro.Click
        If txtISBN.Text = "" Or txtTituloLivro.Text = "" Or txtGenero.Text = "" Or txtAutorLivro.Text = "" Or txtEdicao.Text = "" Or txtEditora.Text = "" Or cboFornLivro.Text = "" Or txtQtde.Text = "" Or mskPrecoLivro.Text = "" Then
            MessageBox.Show("Preencha todos os campos obrigatórios! (*)", "Atenção aos campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            insert.CadastrarLivro()
        End If
    End Sub

    Private Sub btnAlterLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterLivro.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem alterados." & Chr(13) & "Você deseja alterar estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            ID_Forn = NotaFiscal.cboCodLivro.SelectedValue
            alter.AlterarLivro()
            view.VisualizarLivro()
            Me.Refresh()
        End If
    End Sub

    Private Sub btnExcluiLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiLivro.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem excluídos." & Chr(13) & "Você deseja excluir estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            delete.ExcluirLivro()
            view.VisualizarLivro()
        End If
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
        formata.FormatLivro()
        code.Cod_Livro()
        view.CadViewForn()

        btnAlterLivro.Enabled = False
        btnExcluiLivro.Enabled = False
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

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        LivroHelp.Show()
    End Sub

    Private Sub btnAddAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAutor.Click
        AddAutor.Show()
    End Sub

    Private Sub btnAddAutor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAutor.MouseHover
        pbxAutor.Visible = True
    End Sub

    Private Sub btnAddAutor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAutor.MouseLeave
        pbxAutor.Visible = False
    End Sub

    Private Sub txtPesquisaLivro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaLivro.TextChanged
        If cboPesquisaLivro.Text = "ID" Then
            view.LivroID()
        ElseIf cboPesquisaLivro.Text = "Título" Then
            view.LivroTitulo()
        ElseIf cboPesquisaLivro.Text = "ISBN" Then
            view.LivroISBN()
        ElseIf cboPesquisaLivro.Text = "Autor" Then
            view.LivroAutor()
        ElseIf cboPesquisaLivro.Text = "Editora" Then
            view.LivroEditora()
        ElseIf cboPesquisaLivro.Text = "Gênero" Then
            view.LivroGenero()
        ElseIf cboPesquisaLivro.Text = "" Then
            dtgLivro.Visible.Equals(False)
        End If
    End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtISBN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtISBN.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class