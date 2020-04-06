Imports System.Data.SqlClient
Public Class FundoForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Você deseja sair do sistema?", MsgBoxStyle.YesNo, "Atenção!")
        
        If response = MsgBoxResult.Yes Then
            MessageBox.Show("Survivor Corp. está sendo finalizada...", "Survivor Messages", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        If Cliente.Visible = True Then
            Me.TopMost = False
            Cliente.TopMost = False
        ElseIf Fornecedor.Visible = True Then
            Me.TopMost = False
            Fornecedor.TopMost = False
        ElseIf Livro.Visible = True Then
            Me.TopMost = False
            Livro.TopMost = False
        ElseIf Funcionario.Visible = True Then
            Me.TopMost = False
            Funcionario.TopMost = False
        ElseIf Operador.Visible = True Then
            Me.TopMost = False
            Operador.TopMost = False
        ElseIf NotaFiscal.Visible = True Then
            Me.TopMost = False
            NotaFiscal.TopMost = False
        ElseIf EstoqueHelp.Visible = True Then
            Me.TopMost = False
            EstoqueHelp.TopMost = False
        ElseIf PesquisarLivros.Visible = True Then
            Me.TopMost = False
            PesquisarLivros.TopMost = False
        End If
        
        Dim response As New MsgBoxResult
        response = MsgBox("Você deseja logar com outra conta ?", MsgBoxStyle.YesNo, "Atenção!")
        
        If response = MsgBoxResult.Yes Then
            Login.Show()
            Login.txtUsuario.Text = ""
            Login.txtSenha.Text = ""
            Login.txtUsuario.Focus()
            Me.Hide()
        End If
    End Sub

    Private Sub FundoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Dim opacidade As Integer
        
        For opacidade = 0 To 50 Step +5
            Me.Opacity = opacidade / 50
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = FormatDateTime(Now, DateFormat.LongTime)
        lblData.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        If Fornecedor.Visible = True Then
            Fornecedor.Close()
            Cliente.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            Cliente.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            Cliente.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            Cliente.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Cliente.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Cliente.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Cliente.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Cliente.Show()
        Else
            Cliente.Show()
        End If
    End Sub

    Private Sub btnForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForn.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            Fornecedor.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            Fornecedor.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            Fornecedor.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            Fornecedor.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Fornecedor.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Fornecedor.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Fornecedor.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Fornecedor.Show()
        Else
            Fornecedor.Show()
        End If
    End Sub

    Private Sub btnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            Livro.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            Livro.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            Livro.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            Livro.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Livro.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Livro.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Livro.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Livro.Show()
        Else
            Livro.Show()
        End If
    End Sub

    Private Sub btnFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFunc.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            Funcionario.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            Funcionario.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            Funcionario.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            Funcionario.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Funcionario.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Funcionario.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Funcionario.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Funcionario.Show()
        Else
            Funcionario.Show()
        End If
    End Sub

    Private Sub btnOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperador.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            Operador.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            Operador.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            Operador.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            Operador.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Operador.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Operador.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Operador.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Operador.Show()
        Else
            Operador.Show()
        End If
    End Sub

    Private Sub btnNotaFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaFiscal.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            NotaFiscal.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            NotaFiscal.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            NotaFiscal.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            NotaFiscal.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            NotaFiscal.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            NotaFiscal.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            NotaFiscal.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            NotaFiscal.Show()
        Else
            NotaFiscal.Show()
        End If
    End Sub

    Private Sub btnEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstoque.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            EstoqueHelp.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            EstoqueHelp.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            EstoqueHelp.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            EstoqueHelp.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            EstoqueHelp.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            EstoqueHelp.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            EstoqueHelp.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            EstoqueHelp.Show()
        Else
            EstoqueHelp.Show()
        End If
    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            PesquisarLivros.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            PesquisarLivros.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            PesquisarLivros.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            PesquisarLivros.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            PesquisarLivros.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            PesquisarLivros.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            PesquisarLivros.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            PesquisarLivros.Show()
        Else
            PesquisarLivros.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Cliente.Visible = True Then
            Cliente.Close()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
        ElseIf Livro.Visible = True Then
            Livro.Close()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
        ElseIf Operador.Visible = True Then
            Operador.Close()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
        ElseIf FundoHelp.Visible = True Then
            FundoHelp.Close()
        End If
    End Sub

    Private Sub btnLogOut_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.MouseHover
        pbxLogout.Visible = True
    End Sub

    Private Sub btnLogOut_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.MouseLeave
        pbxLogout.Visible = False
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        pbxFechar.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        pbxFechar.Visible = False
    End Sub

    Private Sub PictureBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseHover
        pbxHome.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        pbxHome.Visible = False
    End Sub

    Private Sub btnCliente_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.MouseHover
        pbxCliente.Visible = True
    End Sub

    Private Sub btnCliente_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.MouseLeave
        pbxCliente.Visible = False
    End Sub

    Private Sub btnForn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForn.MouseHover
        pbxForn.Visible = True
    End Sub

    Private Sub btnForn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForn.MouseLeave
        pbxForn.Visible = False
    End Sub

    Private Sub btnBook_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.MouseHover
        pbxLivro.Visible = True
    End Sub

    Private Sub btnBook_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBook.MouseLeave
        pbxLivro.Visible = False
    End Sub

    Private Sub btnFunc_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFunc.MouseHover
        pbxFunc.Visible = True
    End Sub

    Private Sub btnFunc_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFunc.MouseLeave
        pbxFunc.Visible = False
    End Sub

    Private Sub btnOperador_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperador.MouseHover
        pbxOp.Visible = True
    End Sub

    Private Sub btnOperador_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOperador.MouseLeave
        pbxOp.Visible = False
    End Sub

    Private Sub btnNotaFiscal_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaFiscal.MouseHover
        pbxNota.Visible = True
    End Sub

    Private Sub btnNotaFiscal_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotaFiscal.MouseLeave
        pbxNota.Visible = False
    End Sub

    Private Sub btnEstoque_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstoque.MouseHover
        pbxEstoque.Visible = True
    End Sub

    Private Sub btnEstoque_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstoque.MouseLeave
        pbxEstoque.Visible = False
    End Sub

    Private Sub btnSobre_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobre.MouseHover
        pbxSobre.Visible = True
    End Sub

    Private Sub btnSobre_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobre.MouseLeave
        pbxSobre.Visible = False
    End Sub

    Private Sub btnPesquisar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub pbxAjuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjuda.Click
        FundoHelp.Show()
    End Sub

    Private Sub btnSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSobre.Click
        If Cliente.Visible = True Then
            Cliente.Close()
            Sobre.Show()
        ElseIf Fornecedor.Visible = True Then
            Fornecedor.Close()
            Sobre.Show()
        ElseIf Livro.Visible = True Then
            Livro.Close()
            Sobre.Show()
        ElseIf Funcionario.Visible = True Then
            Funcionario.Close()
            Sobre.Show()
        ElseIf Operador.Visible = True Then
            Operador.Close()
            Sobre.Show()
        ElseIf NotaFiscal.Visible = True Then
            NotaFiscal.Close()
            Sobre.Show()
        ElseIf EstoqueHelp.Visible = True Then
            EstoqueHelp.Close()
            Sobre.Show()
        ElseIf Sobre.Visible = True Then
            Sobre.Close()
            Sobre.Show()
        ElseIf PesquisarLivros.Visible = True Then
            PesquisarLivros.Close()
            Sobre.Show()
        Else
            Sobre.Show()
        End If
    End Sub
End Class