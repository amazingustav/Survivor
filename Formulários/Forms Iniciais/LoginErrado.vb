Public Class LoginErrado
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Login.Show()
        Login.txtUsuario.Clear()
        Login.txtSenha.Clear()
        Me.Hide()
    End Sub
End Class