Public Class fundo




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.Show()
        Form1.Visible = True
        Me.Location = Form1.Location

        If p1.Left + p1.Width > 0 And p2.Left > p1.Left Then
            p1.Left -= 1
            p2.Left = p1.Left + p1.Width
        ElseIf p2.Left + p2.Width > 0 And p1.Left > p2.Left Then
            p2.Left -= 1
            p1.Left = p2.Left + p2.Width
        Else
            If p1.Left < p2.Left Then
                p1.Left = p2.Left + p2.Width
            Else
                p2.Left = p1.Left + p1.Width
            End If
        End If
    End Sub
End Class