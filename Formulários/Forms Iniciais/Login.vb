Public Class Login
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Cliente.Visible = True Then
            Cliente.Hide()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Hide()
        ElseIf Livro.Visible = True Then
            Livro.Hide()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Hide()
        ElseIf Operador.Visible = True Then
            Operador.Hide()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Hide()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Hide()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Hide()
        End If

        txtUsuario.Text = ""
        txtSenha.Text = ""
        txtUsuario.Focus()
    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyValue = Keys.Enter Then
            Dim Login As New Logar
            Login.EntrarComLogin()
        End If
    End Sub

    Private Sub btnEntrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim Login As New Logar
        If txtUsuario.Text = "" Or txtSenha.Text = "" Then
            LoginErrado.Show()
            Me.Hide()
        Else
            Me.Hide()
            Login.EntrarComLogin()
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        MessageBox.Show("Survivor Corp. está sendo finalizada...", "Survivor Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End
    End Sub
End Class
