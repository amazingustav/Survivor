Public Class Cliente
    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formata.FormatCliente()
        code.Cod_Cliente()

        btnAlterCli.Enabled = False
        btnExcluiCli.Enabled = False
    End Sub

    Private Sub dtgCliente_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgCliente.SelectionChanged
        data.DTGcliente()
    End Sub

    Private Sub btnNovoCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.Click
        Me.Refresh()

        rdbFemCli.Checked = False
        rdbMascCli.Checked = False
        rdbAtivo.Checked = False
        rdbInativo.Checked = False
        txtNomeCli.Clear()
        txtRGcli.Clear()
        mskCPFcli.Clear()
        txtEnderCli.Clear()
        txtCompleCli.Clear()
        txtCidadeCli.Clear()
        txtBairroCli.Clear()
        mskCEPcli.Clear()
        mskTelCli.Clear()
        mskCelCli.Clear()
        txtEmailCli.Clear()
        cboUFcli.Text = ""

        code.Cod_Cliente()

        btnAlterCli.Enabled = False
        btnExcluiCli.Enabled = False
        btnCadastraCli.Enabled = True
    End Sub

    Private Sub btnCadastraCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.Click
        If txtNomeCli.Text = "" Or (rdbMascCli.Checked = False And rdbFemCli.Checked = False) Or txtRGcli.Text = "" Or mskCPFcli.Text = "" Or mskTelCli.Text = "" Or txtEnderCli.Text = "" Or txtCidadeCli.Text = "" Or txtBairroCli.Text = "" Or mskCEPcli.Text = "" Or cboUFcli.Text = "" Or (rdbAtivo.Checked = False And rdbInativo.Checked = False) Then
            MessageBox.Show("Preencha todos os campos obrigatórios! (*)", "Atenção aos campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            insert.CadastrarCliente()
        End If
    End Sub

    Private Sub btnAlterCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem alterados." & Chr(13) & "Você deseja alterar estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            alter.AlterarCliente()
            view.VisualizarCliente()
        End If
    End Sub

    Private Sub btnExcluiCli_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Estes dados estão prestes a serem excluídos." & Chr(13) & "Você deseja excluir estes dados?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            delete.ExcluirCliente()
            view.VisualizarCliente()
        End If
    End Sub

    Private Sub btnPesquisarCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.Click
        view.VisualizarCliente()
    End Sub

    Private Sub btnCadastraCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastraCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastraCli.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnNovoCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.MouseHover
        pbxNovo.Visible = True
    End Sub

    Private Sub btnNovoCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovoCli.MouseLeave
        pbxNovo.Visible = False
    End Sub

    Private Sub btnAlterCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.MouseHover
        pbxAlter.Visible = True
    End Sub

    Private Sub btnAlterCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterCli.MouseLeave
        pbxAlter.Visible = False
    End Sub

    Private Sub btnExcluiCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.MouseHover
        pbxExclui.Visible = True
    End Sub

    Private Sub btnExcluiCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluiCli.MouseLeave
        pbxExclui.Visible = False
    End Sub

    Private Sub btnPesquisarCli_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.MouseHover
        pbxPesquisar.Visible = True
    End Sub

    Private Sub btnPesquisarCli_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisarCli.MouseLeave
        pbxPesquisar.Visible = False
    End Sub

    Private Sub txtPesquisaCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisaCli.TextChanged
        If cboPesquisaCli.Text = "ID" Then
            view.ClienteID()
        ElseIf cboPesquisaCli.Text = "Nome" Then
            view.ClienteNome()
        ElseIf cboPesquisaCli.Text = "RG" Then
            view.ClienteRG()
        ElseIf cboPesquisaCli.Text = "CPF" Then
            view.ClienteCPF()
        ElseIf cboPesquisaCli.Text = "CEP" Then
            view.ClienteCEP()
        ElseIf cboPesquisaCli.Text = "Telefone" Then
            view.ClienteTelefone()
        ElseIf txtPesquisaCli.Text = "" Then
            dtgCliente.Rows.Clear()
        End If
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ClienteHelp.Show()
    End Sub
End Class