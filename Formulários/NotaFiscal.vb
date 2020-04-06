Public Class NotaFiscal
    Private Sub btnAdicionarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionarCompra.Click
        view.VisualizarNota()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        ID_Vend = CInt(cboFuncNota.SelectedValue)
        insert.CadastrarNotaADM()
    End Sub

    Private Sub NotaFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        TransparencyKey = BackColor
        Me.ControlBox = False

        formata.FormatNota()
        formata.FormatCarrinho()
        code.Cod_Nota()
        view.CadViewOp()
        txtcodlivro.Text = cboCodLivro.Text
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        Dim valor As Decimal

        valor = CDec(txtValorVenda.Text)
        If txtQtde.Text <> Nothing Then
            qtde = txtQtde.Text
        Else
            qtde = 1
        End If

        lblValorTotal.Text = valor * qtde

        lblValorTotal.Refresh()
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
        If txtQtde.Text = Nothing Then
            qtde = 1
        End If
        insert.CadastrarCarrinho()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        delete.ExcluirCarrinho()
    End Sub

    Private Sub dtgCarrinho_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgCarrinho.CellEnter
        ID_Carrinho = dtgCarrinho.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub dtgCarrinho_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCarrinho.SelectionChanged
        data.DTGcarrinho()
    End Sub

    Private Sub dtgNota_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgNota.SelectionChanged
        data.DTGnota()
        lblValorTotal.Refresh()
    End Sub
End Class