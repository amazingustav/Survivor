Public Class EstoqueHelp

    Private Sub Estoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatEstoque()
        ctrl.Quantidade()
        mskData.Text = ""
    End Sub

    Private Sub btnPesquisaLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.Click
        ctrl.VisualizarLivro()
    End Sub

    Private Sub btnPesquisaLivro_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseHover
        pbxPesquisar1.Visible = True
    End Sub

    Private Sub btnPesquisaLivro_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaLivro.MouseLeave
        pbxPesquisar1.Visible = False
    End Sub

    Private Sub btnPesquisaData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaData.Click
        If rdbDiario.Checked = True Then
            If mskData.Text = "  /  /" Then
                MessageBox.Show("Digite uma data!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ctrl.PesquisaDiario()
            End If
        End If


        If rdbMensal.Checked = True Then
            If cboMes.Text = "" Then
                MessageBox.Show("Escolha um mês!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ctrl.PesquisaMes()
            End If
        End If

        If rdbAnual.Checked = True Then
            If cboAno.Text = "" Then
                MessageBox.Show("Escolha um ano!", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ctrl.PesquisaAno()
            End If
        End If
    End Sub

    Private Sub txtNomeLivro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeLivro.TextChanged
        ctrl.LivroPorNome()
    End Sub

    Private Sub rdbDiario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDiario.CheckedChanged
        Me.mskData.Enabled = True
        Me.cboAno.Enabled = False
        Me.cboMes.Enabled = False
    End Sub

    Private Sub rdbMensal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbMensal.CheckedChanged
        Me.cboMes.Enabled = True
        Me.mskData.Enabled = False
        Me.cboAno.Enabled = False
    End Sub

    Private Sub rdbAnual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbAnual.CheckedChanged
        Me.cboAno.Enabled = True
        Me.cboMes.Enabled = False
        Me.mskData.Enabled = False
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnPesquisaData_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaData.MouseHover
        pbxpesquisar2.Visible = True
    End Sub

    Private Sub btnPesquisaData_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisaData.MouseLeave
        pbxpesquisar2.Visible = False
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        HelpEsto.Show()
    End Sub
End Class