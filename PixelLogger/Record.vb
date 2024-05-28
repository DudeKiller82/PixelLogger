Public Class Record
    Public recordDate As DateTime
    Public statusName As String
    Public totalTime As TimeSpan
    Public color As Color

    Public Sub New(recordDate As DateTime, statusName As String, totalTime As TimeSpan, color As Color)
        Me.recordDate = recordDate
        Me.statusName = statusName
        Me.totalTime = totalTime
        Me.color = color
    End Sub

    Public Function getRecordDateString() As String
        getRecordDateString = recordDate.ToString("yyyy/MM/dd")
    End Function

    Public Function getRecordHourString() As String
        getRecordHourString = recordDate.ToString("HH:mm:ss")
    End Function

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
