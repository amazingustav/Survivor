Public Class Abertura
    Public Sub abrir()
        If c = 10 Then
            c = 0
            Login.Timer1.Start()
            Timer2.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub
    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        b += 1
        If b = 12 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Abertura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TransparencyKey = BackColor
        Me.ControlBox = False

        Dim opacidade As Integer
        
        For opacidade = 0 To 100 Step +5
            Me.Opacity = opacidade / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        c += 1
        abrir()
    End Sub
End Class