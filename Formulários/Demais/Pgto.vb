Public Class Pgto

   
    Private Sub rdbCartao_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCartao.Click
        rdbVisa.Visible = True
        rdbMastercard.Visible = True
        rdbDinheiro.Checked = False
        rdbDriversClub.Visible = True
        rdbCartao.Checked = True
        txtParcelas.Enabled = True
    End Sub

    Private Sub rdbDinheiro_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDinheiro.Click
        rdbMastercard.Visible = False
        rdbVisa.Visible = False
        rdbCartao.Checked = False
        rdbDriversClub.Visible = False
        txtParcelas.Enabled = False
        rdbDinheiro.Checked = True
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        PagtoHelp.Show()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        MessageBox.Show("Obrigado por utilizar nossos produtos. Volte sempre!", "Parabens!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        NotaFiscal.Close()
    End Sub

    Private Sub btnOK_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.MouseHover
        pbxFinalizar.Visible = True
    End Sub

    Private Sub btnOK_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.MouseLeave
        pbxFinalizar.Visible = False
    End Sub

    Private Sub txtParcelas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtParcelas.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class