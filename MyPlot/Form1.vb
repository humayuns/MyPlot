Public Class Form1

    Private factor As Integer = 100
    Dim curveExample As CurveExample
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Draw()

    End Sub

    Private Async Function Draw() As Task
        For i As Integer = 1 To 100
            factor = i
            Await Task.Delay(20)
            PictureBox1.Invalidate()
        Next
    End Function

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint


        curveExample.Draw(factor, e.Graphics)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveExample = New CurveExample
    End Sub
End Class
