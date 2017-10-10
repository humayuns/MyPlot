Public Class Plot
    Public Property X As Integer
    Public Property Y As Integer

    Public Sub Draw(action As Action, a As Integer, b As Integer, g As Graphics)

        For i As Integer = a To b
            X = i


            action()
            X = X + 245
            Y = Y + 160

            g.DrawRectangle(Pens.Black, X, Y, 1, 1)
            Debug.WriteLine($"{X}, {Y}")
        Next

    End Sub
End Class
