Public Class CurveExample

    Public Sub Draw(factor As Integer, g As Graphics)
        Dim p As New Plot

        p.Draw(Sub()
                   p.Y = Math.Sin(p.X * Math.PI / 180) * factor
               End Sub, -180, 180, g)
    End Sub
End Class
