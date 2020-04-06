Public Class Sinopse

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnCadastrarSinopse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSinopse.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Sinopse_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        Dim response As New MsgBoxResult
        response = MsgBox("Você deseja apagar o texto digitado?", MsgBoxStyle.YesNo, "Atenção!")
        If response = MsgBoxResult.Yes Then
            txtSinopse.Clear()
        End If
    End Sub

    Private Sub btnCadastrarSinopse_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSinopse.MouseHover
        pbxCadastrar.Visible = True
    End Sub

    Private Sub btnCadastrarSinopse_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrarSinopse.MouseLeave
        pbxCadastrar.Visible = False
    End Sub

    Private Sub btnLimpar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.MouseHover
        pbxLimpar.Visible = True
    End Sub

    Private Sub btnLimpar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.MouseLeave
        pbxLimpar.Visible = False
    End Sub

    Private Sub btnEND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEND.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        SinopseHelp.Show()
    End Sub

    Private Sub btnCancelar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseHover
        pbxFechar.Visible = True
    End Sub

    Private Sub btnCancelar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.MouseLeave
        pbxFechar.Visible = False
    End Sub
End Class