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

    Private Sub Sinopse_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TransparencyKey = BackColor
        Me.ControlBox = False
    End Sub

    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
        txtSinopse.Clear()
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

    Private Sub btnLimpar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pbxLimpar.Visible = False

    End Sub
End Class