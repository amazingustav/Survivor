Imports System.Data.SqlClient
Public Class ControleEstoque

    Public Sub LivroPorNome()
        Dim sql As String = ""
        sql = "SELECT L.ID,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,AUTOR.AUTOR,EDITORA.EDITORA,GENERO.GENERO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA ON L.ID_EDITORA = EDITORA.ID INNER JOIN GENERO ON L.ID_GENERO = GENERO.ID INNER JOIN AUTOR ON L.ID_AUTOR = AUTOR.ID WHERE LIVRO LIKE'" & EstoqueHelp.txtNomeLivro.Text & "%' ORDER BY LIVRO"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        EstoqueHelp.dtgEstoque.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarLivro()
        Try
            Dim da As New SqlDataAdapter("VIEW_LIVRO", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_LIVRO")
            EstoqueHelp.dtgEstoque.DataSource = ds.Tables("VIEW_LIVRO")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Quantidade()
        Dim sql As String = ""
        sql = "SELECT SUM(QTDE) AS QUANT FROM LIVRO"

        Dim cx As New Conexao
        cx.Conectar()

        Dim cd As New SqlCommand
        cd.CommandText = sql
        cd.Connection = cx.cn

        Dim dr As SqlDataReader = cd.ExecuteReader

        If dr.Read() Then
            Dim qtde As String = dr("QUANT")
            EstoqueHelp.lblStatus.Text = qtde
        End If
        dr.Close()
        cx.Desconectar()
    End Sub

    Public Sub PesquisaDiario()
        Dim sql As String = ""

        Dim dia As DateTime
        dia = CDate(EstoqueHelp.mskData.Text)

        sql = "SELECT NOTA.ID AS CODIGO, ID_CARRINHO AS COD_CARRINHO, CLIENTE.NOME AS CLIENTE, CONVERT(VARCHAR, DATA_EMISSAO, 103) AS DATA, VLOR_TOT AS VALOR_TOTAL, FUNCIONARIO.NOME AS FUNCIONARIO FROM NOTA INNER JOIN CLIENTE ON NOTA.ID_CLI = CLIENTE.ID INNER JOIN FUNCIONARIO ON NOTA.ID_FUNC = FUNCIONARIO.ID WHERE DAY(DATA_EMISSAO) = DAY('" & dia & "')"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "NOTA")
        EstoqueHelp.dtgEstoque.DataSource = ds.Tables("NOTA")
        cx.Desconectar()
    End Sub

    Public Sub PesquisaMes()
        Dim sql As String = ""

        Dim mes As Integer
        Select Case EstoqueHelp.cboMes.Text
            Case "Janeiro"
                mes = 1
            Case "Fevereiro"
                mes = 2
            Case "Março"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Maio"
                mes = 5
            Case "Junho"
                mes = 6
            Case "Julho"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Setembro"
                mes = 9
            Case "Outubro"
                mes = 10
            Case "Novembro"
                mes = 11
            Case "Dezembro"
                mes = 12
        End Select

        sql = "SELECT NOTA.ID AS CODIGO, ID_CARRINHO AS COD_CARRINHO, CLIENTE.NOME AS CLIENTE, CONVERT(VARCHAR, DATA_EMISSAO, 103) AS DATA, VLOR_TOT AS VALOR_TOTAL, FUNCIONARIO.NOME AS FUNCIONARIO FROM NOTA INNER JOIN CLIENTE ON NOTA.ID_CLI = CLIENTE.ID INNER JOIN FUNCIONARIO ON NOTA.ID_FUNC = FUNCIONARIO.ID WHERE MONTH(DATA_EMISSAO) = " & mes
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "NOTA")
        EstoqueHelp.dtgEstoque.DataSource = ds.Tables("NOTA")
        cx.Desconectar()
    End Sub

    Public Sub PesquisaAno()
        Dim sql As String = ""

        sql = "SELECT NOTA.ID AS CODIGO, ID_CARRINHO AS COD_CARRINHO, CLIENTE.NOME AS CLIENTE, CONVERT(VARCHAR, DATA_EMISSAO, 103) AS DATA, VLOR_TOT AS VALOR_TOTAL, FUNCIONARIO.NOME AS FUNCIONARIO FROM NOTA INNER JOIN CLIENTE ON NOTA.ID_CLI = CLIENTE.ID INNER JOIN FUNCIONARIO ON NOTA.ID_FUNC = FUNCIONARIO.ID WHERE YEAR(DATA_EMISSAO) = " & CInt(EstoqueHelp.cboAno.Text)
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "NOTA")
        EstoqueHelp.dtgEstoque.DataSource = ds.Tables("NOTA")
        cx.Desconectar()
    End Sub

    Public Sub SomaNota()
        Dim sql As String = ""
        sql = "SELECT SUM(VLOR_ITEM) AS VALOR_TOTAL FROM CARRINHO"

        Dim cx As New Conexao
        cx.Conectar()

        Dim cd As New SqlCommand
        cd.CommandText = sql
        cd.Connection = cx.cn

        Dim dr As SqlDataReader = cd.ExecuteReader

        If dr.Read() Then
            Dim qtde As String = dr("VALOR_TOTAL")
            NotaFiscal.lblValorTotal.Text = qtde
        End If
        dr.Close()
        cx.Desconectar()
    End Sub
End Class
