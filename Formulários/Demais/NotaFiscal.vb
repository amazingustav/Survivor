Public Class NotaFiscal
    Private Sub btnAdicionarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarCompra.Click
        view.VisualizarNota()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If mskCPF.Text = "   ,   ,   -" Then
            MessageBox.Show("Campo CPF vazio! Caso o cliente não deseje que o CPF seja imprimido na nota, use 999,999,999-99", "Atenção ao CPF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbocarrinho.Text = "" Then
            MessageBox.Show("Você ainda não completou a sua venda!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            ID_Vend = CInt(cboFuncNota.SelectedValue)
            insert.CadastrarNotaADM()
            Pgto.Show()
        End If
        
        Crystal.Show()
    End Sub

    Private Sub NotaFiscal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        delete.ExcluirCarrinho_1_Tudo()
    End Sub

    Private Sub NotaFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        delete.ExcluirCarrinho_1_Tudo()

        formata.FormatNota()
        formata.FormatCarrinho()
        code.Cod_Nota()
        view.CadViewOp()
        txtcodlivro.Text = cboCodLivro.Text
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        Dim valor As Decimal

        valor = CDec(txtValorUnit.Text)
        If txtQtde.Text <> Nothing Then
            qtde = txtQtde.Text
        Else
            qtde = 1
        End If

        txtValorItem.Text = valor * qtde
        txtValorItem.Refresh()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mskDataEmissao.Text = FormatDateTime(Now, DateFormat.GeneralDate)
    End Sub

    Private Sub btnAdicionarCompra_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarCompra.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnAdicionarCompra_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarCompra.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim valor As Double
        
        If txtQtde.Text = "" Then
            MessageBox.Show("Digite a quantidade!", "Quantidade vazia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf txtQtde.Text > Me.dtgNota.CurrentRow.Cells(10).Value Then
            MessageBox.Show("Você digitou um valor maior do que a disponibilidade em nosso estoque! ", "Quantidade inválida!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            valor = CDbl(txtValorUnit.Text)

            txtValorItem.Text = valor * qtde

            insert.CadastrarCarrinho()
            insert.CadastrarCarrinho_1()
            alter.AlterarNota()
            view.ValTotal()
            lblValorTotal.Refresh()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Você deseja remover este item do carrinho?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            alter.AlterarNotaAdd()
            delete.ExcluirCarrinho_1()
            view.VisualizarCarrinho_1()
            view.ValTotal()
        End If
    End Sub

    Private Sub dtgCarrinho_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCarrinho.SelectionChanged
        data.DTGcarrinho()
    End Sub

    Private Sub dtgNota_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgNota.SelectionChanged
        data.DTGnota()
        lblValorTotal.Refresh()
    End Sub

    Private Sub txtPesquisaNota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaNota.TextChanged
        If cboPesquisaNota.Text = "ID" Then
            view.NotaID()
        ElseIf cboPesquisaNota.Text = "ISBN" Then
            view.NotaISBN()
        ElseIf cboPesquisaNota.Text = "Título" Then
            view.NotaTitulo()
        ElseIf txtPesquisaNota.Text = "" Then
            dtgNota.Visible.Equals(False)
        End If
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        NotaHelp.Show()
    End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class