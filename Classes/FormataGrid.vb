Public Class FormataGrid
    Public Sub FormatCliente()
        Try
            With Cliente.dtgCliente
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatForn()
        Try
            With Fornecedor.dtgFornecedor
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatFunc()
        Try
            With Funcionario.dtgFuncionario
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatOperador()
        Try
            With Operador.dtgOperador
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatNota()
        Try
            With NotaFiscal.dtgNota
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatLivro()
        Try
            With Livro.dtgLivro
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatPesquisar()
        Try
            With PesquisarLivros.dtgLivro
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatEstoque()
        Try
            With EstoqueHelp.dtgEstoque
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub

    Public Sub FormatCarrinho()
        Try
            With NotaFiscal.dtgCarrinho
                .ColumnHeadersDefaultCellStyle.Font = New Font("Maiandra GD", 11, FontStyle.Regular)
                .RowsDefaultCellStyle.SelectionBackColor = Color.LightGray
                .RowsDefaultCellStyle.ForeColor = Color.Black
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersVisible = False
            End With
        Catch ex As ArgumentException
        End Try
    End Sub
End Class
