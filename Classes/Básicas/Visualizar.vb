Imports System.Data.SqlClient
Public Class Visualizar

    '------------------------ CLIENTE ------------------------

    Public Sub ClienteID()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE ID LIKE'" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub ClienteNome()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE NOME LIKE'" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub ClienteRG()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE RG LIKE'" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub ClienteCPF()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE CPF LIKE'" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub ClienteCEP()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE CEP LIKE'" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub ClienteTelefone()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO, BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, STATUS FROM CLIENTE WHERE TELEFONE LIKE'%" & Cliente.txtPesquisaCli.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "CLIENTE")
        Cliente.dtgCliente.DataSource = ds.Tables("CLIENTE")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarCliente()
        Try
            Dim da As New SqlDataAdapter("VIEW_CLIENTE", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_CLIENTE")
            Cliente.dtgCliente.DataSource = ds.Tables("VIEW_CLIENTE")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    '-------------------- FORNECEDOR ------------------------

    Public Sub FornID()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, FANTASIA AS NOME_FANTASIA, FORNECEDOR AS NOME_FORNECEDOR, CNPJ, ENDERECO,BAIRRO, CIDADE, CEP, UF, TELEFONE, EMAIL FROM FORNECEDOR WHERE ID LIKE'" & Fornecedor.txtPesquisaForn.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FORNECEDOR")
        Fornecedor.dtgFornecedor.DataSource = ds.Tables("FORNECEDOR")
        cx.Desconectar()
    End Sub

    Public Sub FornNome()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, FANTASIA AS NOME_FANTASIA, FORNECEDOR AS NOME_FORNECEDOR, CNPJ, ENDERECO,BAIRRO, CIDADE, CEP, UF, TELEFONE, EMAIL FROM FORNECEDOR WHERE FORNECEDOR LIKE'" & Fornecedor.txtPesquisaForn.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FORNECEDOR")
        Fornecedor.dtgFornecedor.DataSource = ds.Tables("FORNECEDOR")
        cx.Desconectar()
    End Sub

    Public Sub FornCNPJ()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, FANTASIA AS NOME_FANTASIA, FORNECEDOR AS NOME_FORNECEDOR, CNPJ, ENDERECO,BAIRRO, CIDADE, CEP, UF, TELEFONE, EMAIL FROM FORNECEDOR WHERE CNPJ LIKE'" & Fornecedor.txtPesquisaForn.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FORNECEDOR")
        Fornecedor.dtgFornecedor.DataSource = ds.Tables("FORNECEDOR")
        cx.Desconectar()
    End Sub

    Public Sub FornCEP()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, FANTASIA AS NOME_FANTASIA, FORNECEDOR AS NOME_FORNECEDOR, CNPJ, ENDERECO,BAIRRO, CIDADE, CEP, UF, TELEFONE, EMAIL FROM FORNECEDOR WHERE CEP LIKE'" & Fornecedor.txtPesquisaForn.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FORNECEDOR")
        Fornecedor.dtgFornecedor.DataSource = ds.Tables("FORNECEDOR")
        cx.Desconectar()
    End Sub

    Public Sub FornTelefone()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, FANTASIA AS NOME_FANTASIA, FORNECEDOR AS NOME_FORNECEDOR, CNPJ, ENDERECO,BAIRRO, CIDADE, CEP, UF, TELEFONE, EMAIL FROM FORNECEDOR WHERE TELEFONE LIKE'%" & Fornecedor.txtPesquisaForn.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FORNECEDOR")
        Fornecedor.dtgFornecedor.DataSource = ds.Tables("FORNECEDOR")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarForn()
        Try
            Dim da As New SqlDataAdapter("VIEW_FORN", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_FORN")
            Fornecedor.dtgFornecedor.DataSource = ds.Tables("VIEW_FORN")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    ' --------------------------- LIVRO ----------------------------

    Public Sub LivroID()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE L.ID LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub LivroTitulo()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE LIVRO LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub LivroISBN()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE ISBN LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub LivroAutor()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE A.AUTOR LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub LivroEditora()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE E.EDITORA LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub LivroGenero()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE G.GENERO LIKE'" & Livro.txtPesquisaLivro.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        Livro.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarLivro()
        Try
            Dim da As New SqlDataAdapter("VIEW_LIVRO", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_LIVRO")
            Livro.dtgLivro.DataSource = ds.Tables("VIEW_LIVRO")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    '------------------------- FUNCIONARIO -------------------------

    Public Sub FuncID()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO,BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, CARGO, SALARIO FROM FUNCIONARIO WHERE ID LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FUNCIONARIO")
        Funcionario.dtgFuncionario.DataSource = ds.Tables("FUNCIONARIO")
        cx.Desconectar()
    End Sub

    Public Sub FuncNome()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO,BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, CARGO, SALARIO FROM FUNCIONARIO WHERE NOME LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FUNCIONARIO")
        Funcionario.dtgFuncionario.DataSource = ds.Tables("FUNCIONARIO")
        cx.Desconectar()
    End Sub

    Public Sub FuncCPF()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO,BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, CARGO, SALARIO FROM FUNCIONARIO WHERE CPF LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FUNCIONARIO")
        Funcionario.dtgFuncionario.DataSource = ds.Tables("FUNCIONARIO")
        cx.Desconectar()
    End Sub

    Public Sub FuncCEP()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO,BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, CARGO, SALARIO FROM FUNCIONARIO WHERE CEP LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FUNCIONARIO")
        Funcionario.dtgFuncionario.DataSource = ds.Tables("FUNCIONARIO")
        cx.Desconectar()
    End Sub

    Public Sub FuncTelefone()
        Dim sql As String = ""
        sql = "SELECT ID AS CODIGO, NOME, SEXO, RG, CPF, ENDERECO, COMPLEMENTO,BAIRRO,CIDADE, CEP, UF, TELEFONE, CELULAR, EMAIL, CARGO, SALARIO FROM FUNCIONARIO WHERE TELEFONE LIKE'%" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "FUNCIONARIO")
        Funcionario.dtgFuncionario.DataSource = ds.Tables("FUNCIONARIO")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarFunc()
        Try
            Dim da As New SqlDataAdapter("VIEW_FUNC", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_FUNC")
            Funcionario.dtgFuncionario.DataSource = ds.Tables("VIEW_FUNC")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    '----------------------------- OPERADOR --------------------------

    Public Sub OpID()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,USUARIO,SENHA,DESC_NIVEL AS NÍVEL, NOME AS FUNCIONARIO FROM LOGIN L INNER JOIN NIVEL N ON L.ID_NIVEL = N.ID INNER JOIN FUNCIONARIO F ON L.ID_FUNC = F.ID WHERE L.ID LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LOGIN")
        Operador.dtgOperador.DataSource = ds.Tables("LOGIN")
        cx.Desconectar()
    End Sub

    Public Sub OpNome()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,USUARIO,SENHA,DESC_NIVEL AS NÍVEL, NOME AS FUNCIONARIO FROM LOGIN L INNER JOIN NIVEL N ON L.ID_NIVEL = N.ID INNER JOIN FUNCIONARIO F ON L.ID_FUNC = F.ID WHERE L.NOME LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LOGIN")
        Operador.dtgOperador.DataSource = ds.Tables("LOGIN")
        cx.Desconectar()
    End Sub

    Public Sub OpNivel()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,USUARIO,SENHA,DESC_NIVEL AS NÍVEL, NOME AS FUNCIONARIO FROM LOGIN L INNER JOIN NIVEL N ON L.ID_NIVEL = N.ID INNER JOIN FUNCIONARIO F ON L.ID_FUNC = F.ID WHERE DESC_NIVEL LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LOGIN")
        Operador.dtgOperador.DataSource = ds.Tables("LOGIN")
        cx.Desconectar()
    End Sub

    Public Sub OpUsuario()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,USUARIO,SENHA,DESC_NIVEL AS NÍVEL, NOME AS FUNCIONARIO FROM LOGIN L INNER JOIN NIVEL N ON L.ID_NIVEL = N.ID INNER JOIN FUNCIONARIO F ON L.ID_FUNC = F.ID WHERE USUARIO LIKE'" & Funcionario.txtPesquisaFunc.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LOGIN")
        Operador.dtgOperador.DataSource = ds.Tables("LOGIN")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarOp()
        Try
            Dim da As New SqlDataAdapter("VIEW_LOGIN", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_LOGIN")
            Operador.dtgOperador.DataSource = ds.Tables("VIEW_LOGIN")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    '----------------------------- NOTA FISCAL ------------------------------

    Public Sub NotaID()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE L.ID LIKE'" & NotaFiscal.txtPesquisaNota.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        NotaFiscal.dtgNota.DataSource = ds.Tables("LIVRO")
        NotaFiscal.txtQtde.Enabled = True
        cx.Desconectar()
    End Sub

    Public Sub NotaISBN()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE ISBN LIKE'" & NotaFiscal.txtPesquisaNota.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        NotaFiscal.dtgNota.DataSource = ds.Tables("LIVRO")
        NotaFiscal.txtQtde.Enabled = True
        cx.Desconectar()
    End Sub

    Public Sub NotaTitulo()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE LIVRO LIKE'" & NotaFiscal.txtPesquisaNota.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        NotaFiscal.dtgNota.DataSource = ds.Tables("LIVRO")
        NotaFiscal.txtQtde.Enabled = True
        cx.Desconectar()
    End Sub

    Public Sub VisualizarNota()
        Try
            Dim da As New SqlDataAdapter("VIEW_LIVRO", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_LIVRO")
            NotaFiscal.dtgNota.DataSource = ds.Tables("VIEW_LIVRO")
            NotaFiscal.txtQtde.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub VisualizarCarrinho_1()
        Try
            Dim da As New SqlDataAdapter("VIEW_CARRINHO_1", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_CARRINHO_1")
            NotaFiscal.dtgCarrinho.DataSource = ds.Tables("VIEW_CARRINHO_1")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadViewForn()
        Try
            Dim da As New SqlDataAdapter("select * from Fornecedor", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "FORNECEDOR")
            With Livro.cboFornLivro
                .DataSource = ds.Tables("FORNECEDOR")
                .DisplayMember = "FANTASIA"
                .ValueMember = "ID"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    Public Sub CadViewOp()
        Try
            Dim da As New SqlDataAdapter("select * from funcionario", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "FUNCIONARIO")
            With Operador.cboFuncOp
                .DataSource = ds.Tables("FUNCIONARIO")
                .DisplayMember = "NOME"
                .ValueMember = "ID"
            End With
            With NotaFiscal.cboFuncNota
                .DataSource = ds.Tables("FUNCIONARIO")
                .DisplayMember = "NOME"
                .ValueMember = "ID"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    ' ---------- SUB'S DO FORMULÁRIO VENDEDOR ----------

    Public Sub PesquisarID()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE L.ID LIKE'" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub PesquisarTitulo()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE LIVRO LIKE'" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub PesquisarISBN()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE ISBN LIKE'" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub PesquisarAutor()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE A.AUTOR LIKE'%" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub PesquisarEditora()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE E.EDITORA LIKE'" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub PesquisarGenero()
        Dim sql As String = ""
        sql = "SELECT L.ID AS CODIGO,LIVRO,ISBN,F.ID AS ID_FORN, FORNECEDOR,A.AUTOR,E.EDITORA,G.GENERO,EDICAO AS EDIÇÃO,QTDE,PRECO,SINOPSE,IMAGEM FROM LIVRO L INNER JOIN FORNECEDOR F ON L.ID_FORN = F.ID INNER JOIN EDITORA E ON L.ID_EDITORA = E.ID INNER JOIN GENERO G ON L.ID_GENERO = G.ID INNER JOIN AUTOR A ON L.ID_AUTOR = A.ID WHERE G.GENERO LIKE'" & PesquisarLivros.txtPesquisar.Text & "%'"
        Dim cx As New Conexao

        cx.Conectar()
        Dim da As New SqlDataAdapter(sql, cx.cn)
        Dim ds As New DataSet
        da.Fill(ds, "LIVRO")
        PesquisarLivros.dtgLivro.DataSource = ds.Tables("LIVRO")
        cx.Desconectar()
    End Sub

    Public Sub VisualizarLivroVend()
        Try
            Dim da As New SqlDataAdapter("VIEW_LIVRO", cx.cn)
            Dim ds As New DataSet
            cx.Conectar()
            da.Fill(ds, "VIEW_LIVRO")
            PesquisarLivros.dtgLivro.DataSource = ds.Tables("VIEW_LIVRO")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK)
        End Try
        cx.Desconectar()
    End Sub

    ' ---------- SUB'S DIVERSAS ----------
    Public Sub Mostrar_IDFunc()
        Dim cx As New Conexao
        Try
            Dim sql As String = "select * from funcionario where nome='" & Trim(Operador.cboFuncOp.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = dr("ID")
                ID_Func = id
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Mostrar_IDForn()
        Dim cx As New Conexao
        Try
            Dim sql As String = "select * from fornecedor where FORNECEDOR='" & Trim(Livro.cboFornLivro.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = dr("ID")
                ID_Forn = id
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Cad_idAutor()
        Dim cx As New Conexao
        Try
            Dim sql As String = "select * from autor where autor='" & Trim(Livro.txtAutorLivro.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = dr("ID")
                ID_Autor = id
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Cad_idEditora()
        Dim cx As New Conexao
        Try
            Dim sql As String = "select * from editora where editora='" & Trim(Livro.txtEditora.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = dr("ID")
                ID_Editora = id
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub Cad_idGenero()
        Dim cx As New Conexao
        Try
            Dim sql As String = "select * from genero where genero='" & Trim(Livro.txtGenero.Text) & "'"
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            cx.Conectar()
            cmd.CommandText = sql
            cmd.Connection = cx.cn
            dr = cmd.ExecuteReader
            If dr.Read Then
                Dim id As Integer = dr("ID")
                ID_Genero = id
            End If
            dr.Close()
        Catch ex As Exception
        End Try
        cx.Desconectar()
    End Sub

    Public Sub ValTotal()
        Try
            Dim sql As String = ""
            sql = "SELECT Sum(Vlor_item)As Q FROM carrinho_1"
            Dim cx As New Conexao
            cx.Conectar()

            Dim cd As New SqlCommand
            cd.CommandText = sql
            cd.Connection = cx.cn
            Dim dr As SqlDataReader = cd.ExecuteReader

            If dr.Read() Then
                Dim qtde As String = dr("Q")
                NotaFiscal.lblValorTotal.Text = qtde
            End If

            dr.Close()
            cx.Desconectar()
        Catch
        End Try
    End Sub

    Public Sub CPF_CLI()
        Try
            Dim sql As String = ""
            sql = "select id from cliente where cpf ='" & NotaFiscal.mskCPF.Text & "'"
            Dim cx As New Conexao
            cx.Conectar()

            Dim cd As New SqlCommand
            cd.CommandText = sql
            cd.Connection = cx.cn
            Dim dr As SqlDataReader = cd.ExecuteReader

            If dr.Read() Then
                Dim cpf As Integer = dr("id")
                'MsgBox(cpf)
                insert.cpf_local = cpf
                'NotaFiscal.mskCPF.Text = cpf
            End If

            dr.Close()
            cx.Desconectar()
        Catch
        End Try
    End Sub
End Class
