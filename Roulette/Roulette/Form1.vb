Public Class Form1
    Dim i As Integer = 1
    Private Sub imgRoulette_Click(sender As Object, e As EventArgs) Handles imgRoulette.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        imgRoulette.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        imgRoulette.Refresh()
    End Sub
End Class
