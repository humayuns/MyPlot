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
            ' Not writing to debug at the moment.
            'Debug.WriteLine($"{X}, {Y}")
        Next

    End Sub

    Friend Sub DrawAsync(p As Action, v1 As Integer, v2 As Integer, graphics As Graphics)
        Throw New NotImplementedException()
    End Sub
End Class
