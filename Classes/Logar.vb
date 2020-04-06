Imports System.Data.SqlClient
Public Class Logar
    Public Sub EntrarComLogin()
        Dim sql As String = ""
        sql = "SELECT * FROM LOGIN L inner join nivel N on L.id_nivel = N.id WHERE USUARIO = '" & CStr(Login.txtUsuario.Text) & "' AND SENHA = '" & CStr(Login.txtSenha.Text) & "'"

        Dim cx As New Conexao
        cx.Conectar()

        Dim cd As New SqlCommand
        cd.CommandText = sql
        cd.Connection = cx.cn

        Dim dr As SqlDataReader = cd.ExecuteReader

        If dr.Read Then
            Dim usuario As String = dr!usuario
            Dim senha As String = dr!senha
            Dim nivel As String = dr!id_nivel

            If Login.txtUsuario.Text = usuario And Login.txtSenha.Text = senha Then
                Hierarquia(nivel)
                Login.Hide()
            Else
                LoginErrado.Show()
                Login.Hide()
            End If
        Else
            LoginErrado.Show()
            Login.Hide()
        End If
        dr.Close()
        cx.Desconectar()
        Login.txtUsuario.Focus()
    End Sub

    Public Sub Hierarquia(ByVal nivel As String)
        Dim endereco As String = My.Computer.FileSystem.CurrentDirectory

        Dim sql As String = ""
        sql = "SELECT * FROM LOGIN L inner join nivel N on L.id_nivel = N.id inner join funcionario F on f.id = l.ID_FUNC WHERE USUARIO = '" & CStr(Login.txtUsuario.Text) & "' AND SENHA = '" & CStr(Login.txtSenha.Text) & "'"
        Dim cx As New Conexao
        cx.Conectar()
        Dim cd As New SqlCommand
        cd.CommandText = sql
        cd.Connection = cx.cn
        Dim dr As SqlDataReader = cd.ExecuteReader
        If dr.Read Then
            Dim usuario As String = dr!usuario
            Dim func As String = dr!nome
            FundoForm.lblnivel.Text = func
        End If

        If nivel = "1" Then
            FundoForm.btnCliente.Enabled = True
            FundoForm.btnForn.Enabled = True
            FundoForm.btnBook.Enabled = True
            FundoForm.btnFunc.Enabled = True
            FundoForm.btnOperador.Enabled = True
            FundoForm.btnSobre.Enabled = True
            FundoForm.btnEstoque.Enabled = True
            FundoForm.btnPesquisar.Enabled = True
            FundoForm.btnNotaFiscal.Enabled = True
            FundoForm.btnAjuda.Enabled = True
            FundoForm.BackgroundImage = Image.FromFile(endereco & "\BackGround\Fundo ADM.png")
            FundoForm.Size = FundoForm.BackgroundImage.Size
            FundoForm.BackgroundImageLayout = ImageLayout.Tile
            FundoForm.Show()
        ElseIf nivel = "2" Then
            FundoForm.btnCliente.Enabled = True
            FundoForm.btnForn.Enabled = False
            FundoForm.btnBook.Enabled = False
            FundoForm.btnFunc.Enabled = False
            FundoForm.btnOperador.Enabled = False
            FundoForm.btnNotaFiscal.Enabled = False
            FundoForm.btnEstoque.Enabled = False
            FundoForm.btnSobre.Enabled = True
            FundoForm.btnPesquisar.Enabled = True
            FundoForm.btnAjuda.Enabled = True
            FundoForm.BackgroundImage = Image.FromFile(endereco & "\BackGround\Fundo Vend..png")
            FundoForm.Size = FundoForm.BackgroundImage.Size
            FundoForm.BackgroundImageLayout = ImageLayout.Tile
            FundoForm.Show()
        ElseIf nivel = "3" Then
            FundoForm.btnCliente.Enabled = False
            FundoForm.btnForn.Enabled = False
            FundoForm.btnBook.Enabled = False
            FundoForm.btnFunc.Enabled = False
            FundoForm.btnOperador.Enabled = False
            FundoForm.btnSobre.Enabled = True
            FundoForm.btnEstoque.Enabled = False
            FundoForm.btnPesquisar.Enabled = False
            FundoForm.btnNotaFiscal.Enabled = True
            FundoForm.btnAjuda.Enabled = True
            FundoForm.BackgroundImage = Image.FromFile(endereco & "\BackGround\Fundo Caixa.png")
            FundoForm.Size = FundoForm.BackgroundImage.Size
            FundoForm.BackgroundImageLayout = ImageLayout.Tile
            FundoForm.Show()
        End If
    End Sub
End Class
