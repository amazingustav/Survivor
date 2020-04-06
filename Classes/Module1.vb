Imports System.Data.SqlClient

Module Module1
    Public cn As New SqlConnection
    Public cx As New Conexao
    Public cmd As New SqlCommand

    'Public rpt As New CrystalReport1
    Public sql As String = ""
    Public da As New SqlDataAdapter(Sql, cn)
    Public ds As New DataSet

    Public alter As New Alterar
    Public insert As New Cadastrar
    Public delete As New Excluir
    Public view As New Visualizar
    Public data As New Preencher
    Public picture As New Foto
    Public formata As New FormataGrid
    Public code As New AutoCode
    Public ctrl As New ControleEstoque

    Public a As Integer = 0
    Public b As Integer = 0
    Public c As Integer = 0

    Public nomearq As String
    Public ID_Forn As Integer
    Public ID_Func As Integer
    Public qtde As Integer
    Public ID_Vend As Integer
    Public ID_Autor As Integer
    Public ID_Editora As Integer
    Public ID_Genero As Integer

    'Public CPF_cli As Integer
    Public idAutor, IdEditora, Idgenero As Integer

    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If

        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If

        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
End Module
