Imports System.Data.SqlClient
Public Class Foto
    Public Sub AbrirFoto()
        Try
            FundoForm.OpenFileDialog1.ShowDialog()
            If FundoForm.OpenFileDialog1.FileName <> Nothing Then
                nomearq = FundoForm.OpenFileDialog1.FileName
                Livro.pbxLivro.Image = Image.FromFile(nomearq)
            Else
                MessageBox.Show("Escolha uma Imagem")
            End If
            Livro.pbxLivro.SizeMode = PictureBoxSizeMode.StretchImage
        Catch
        End Try
    End Sub
End Class
