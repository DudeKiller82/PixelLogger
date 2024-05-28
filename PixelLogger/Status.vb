Public Class Status
    Public name As String
    Public statusOccurences As Integer
    Public totalTime As TimeSpan
    Public statusPercent As Double
    Public color As Color

    Public Sub New(name As String, statusOccurences As Integer, totalTime As TimeSpan, statusPercent As Double, color As Color)
        Me.name = name
        Me.statusOccurences = statusOccurences
        Me.totalTime = totalTime
        Me.statusPercent = statusPercent
        Me.color = color
    End Sub

    Public Function getTotalTimeString() As String
        getTotalTimeString = (New DateTime(totalTime.Ticks)).ToString("HH:mm:ss")
    End Function

    Public Function getColorInt() As Integer
        getColorInt = color.getInt
    End Function

    Public Function getColorHex() As String
        getColorHex = color.getHex
    End Function
End Class
