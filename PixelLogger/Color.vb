Public Class Color
    Private color As Integer

    Public Sub New()
        Me.color = -1
    End Sub
    Public Sub New(color As Integer)
        Me.color = color
    End Sub

    Public Function getInt() As Integer
        getInt = color
    End Function

    Public Function getHex() As String
        If (color = -1) Then
            Return ""
        End If
        Dim currentColorString As String = Strings.Right("000000" & Hex(color), 6)
        getHex = Mid(currentColorString, 5, 2) & Mid(currentColorString, 3, 2) & Mid(currentColorString, 1, 2)
    End Function
    Public Function getR() As String
        If (color = -1) Then
            Return ""
        End If
        Dim currentColorString As String = Strings.Right("000000" & Hex(color), 6)
        getR = Mid(currentColorString, 5, 2)
    End Function
    Public Function getG() As String
        If (color = -1) Then
            Return ""
        End If
        Dim currentColorString As String = Strings.Right("000000" & Hex(color), 6)
        getG = Mid(currentColorString, 3, 2)
    End Function
    Public Function getB() As String
        If (color = -1) Then
            Return ""
        End If
        Dim currentColorString As String = Strings.Right("000000" & Hex(color), 6)
        getB = Mid(currentColorString, 1, 2)
    End Function
End Class
