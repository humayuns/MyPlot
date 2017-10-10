Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Invalidate()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint

        Dim p As New Plot

        p.Draw(Sub()
                   p.Y = Math.Sin(p.X * Math.PI / 180) * 100
               End Sub, -100, 100, e.Graphics)
    End Sub
End Class
