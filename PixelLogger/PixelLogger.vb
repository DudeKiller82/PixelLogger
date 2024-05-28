Option Strict Off
Option Explicit On
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.DataVisualization.Charting
Imports Microsoft.Office.Interop

Public Class PixelLogger
    Inherits System.Windows.Forms.Form

    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As POINTAPI) As Integer
    Private Declare Function GetDC Lib "user32" Alias "GetDC" (ByVal hwnd As Integer) As Integer
    Private Declare Function GetPixel Lib "gdi32" (ByVal hdc As Integer, ByVal x As Integer, ByVal y As Integer) As Integer
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileInt Lib "kernel32" Alias "GetPrivateProfileIntA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileSection Lib "kernel32" Alias "GetPrivateProfileSectionA" (ByVal lpAppName As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function WritePrivateProfileString Lib "kernel32.dll" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long

    <StructLayout(LayoutKind.Sequential)> Private Structure POINTAPI
        Dim x As Integer
        Dim y As Integer
    End Structure

    Dim configurationFileName As String

    Dim storingPixel As Boolean
    Dim recordingPixelEvent As Boolean
    Dim catchingPixel As Boolean
    Dim triggered As Boolean

    Dim displayContext As Integer
    Dim cursorPosition As POINTAPI

    Dim currentColor As Color
    Dim currentStatusName As String
    Dim currentDate As Date

    Dim recordingBeginingDate As Date

    Dim recordList As List(Of Record)
    Dim statusDictionary As IDictionary(Of String, Status)
    Dim statusColorDictionary As IDictionary(Of String, String)

    Private Sub PixelLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        configurationFileName = "..\PixelLogger.ini"
        storingPixel = False
        recordingPixelEvent = False
        triggered = False
        catchingPixel = False
        displayContext = GetDC(0)
        cursorPosition = New POINTAPI
        currentColor = New Color
        currentStatusName = ""
        currentDate = New Date
        recordingBeginingDate = New Date
        recordList = New List(Of Record)
        statusDictionary = New Dictionary(Of String, Status)
        statusColorDictionary = New Dictionary(Of String, String)
        RecordPeriodNumericUpDown.Value = readKeyInt("Settings", "recordPeriod", 1)
        collectTimer.Interval = RecordPeriodNumericUpDown.Value
        collectTimer.Enabled = True
        actionLabel.Text = "Action: Stopped"
        cursorPosition.x = readKeyInt("Settings", "cursorPositionX", 0)
        cursorPosition.y = readKeyInt("Settings", "cursorPositionY", 0)
        recordUnknownStatus.CheckState = readKeyInt("Settings", "recordUnknownStatus", 0)
        StatusTriggerCheckBox.CheckState = readKeyInt("Settings", "useStatusTrigger", 0)
        TriggerStatusTextBox.Text = readKey("Settings", "triggerStatus", "")
        baseNameTextBox.Text = readKey("Settings", "baseExportFileName", "")
        recordChartTypeComboBox.Text = readKey("Settings", "recordChartType", "Pie")
        statusChartTypeComboBox.Text = readKey("Settings", "statusChartType", "Pie")
        xTextBox.Text = cursorPosition.x
        YTextBox.Text = cursorPosition.y
        readAllStatusColor()
    End Sub

    Private Sub collectTimer_Tick(sender As Object, e As EventArgs) Handles collectTimer.Tick
        collectPixelData()
        If storingPixel Then
            catchPixelPosition()
            If catchingPixel Then
                'looking for click down
                If GetKeyPress(1) <> 0 Then
                    catchingPixel = False
                    storingPixel = False
                    collectTimer.Interval = RecordPeriodNumericUpDown.Value
                    xTextBox.Text = cursorPosition.x
                    YTextBox.Text = cursorPosition.y
                End If
            Else
                'looking for click up
                If GetKeyPress(1) = 0 Then
                    catchingPixel = True
                End If
            End If
        ElseIf recordingPixelEvent Then
            If Not triggered And ((currentStatusName = TriggerStatusTextBox.Text) Or Not StatusTriggerCheckBox.Checked) Then
                triggered = True
            End If
            If triggered Then
                recordPixelEvent()
                updateDisplays()
            End If
        End If
    End Sub

    Private Sub selectPixelButton_Click(sender As Object, e As EventArgs) Handles selectPixelButton.Click
        storingPixel = True
        collectTimer.Interval = 1
    End Sub

    Private Sub assignStatusToColorButton_Click(sender As Object, e As EventArgs) Handles assignStatusToColorButton.Click
        assignStatusToColor()
    End Sub

    Private Sub startRecordingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startRecordingButton.Click
        actionLabel.Text = "Action: Waiting for trigger"
        recordingPixelEvent = True
    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopRecordingButton.Click
        actionLabel.Text = "Action: Stopped"
        recordingPixelEvent = False
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        currentColor = New Color
        currentStatusName = ""
        currentDate = New Date
        recordingBeginingDate = New Date
        recordList = New List(Of Record)
        statusDictionary = New Dictionary(Of String, Status)
        updateAllDisplays()
    End Sub

    Private Sub ResetTriggerButton_Click(sender As Object, e As EventArgs) Handles ResetTriggerButton.Click
        actionLabel.Text = "Action: Waiting for trigger"
        triggered = False
    End Sub

    Private Sub exportExcelFileButton_Click(sender As Object, e As EventArgs) Handles exportExcelFileButton.Click
        collectTimer.Enabled = False
        exportXLSXFile()
        collectTimer.Enabled = True
    End Sub

    Private Sub xTextBox_TextChanged(sender As Object, e As EventArgs) Handles xTextBox.TextChanged
        cursorPosition.x = xTextBox.Text
        writeKey("Settings", "cursorPositionX", cursorPosition.x)
    End Sub

    Private Sub YTextBox_TextChanged(sender As Object, e As EventArgs) Handles YTextBox.TextChanged
        cursorPosition.y = YTextBox.Text
        writeKey("Settings", "cursorPositionY", cursorPosition.y)
    End Sub

    Private Sub recordUnknownStatus_CheckedChanged(sender As Object, e As EventArgs) Handles recordUnknownStatus.CheckedChanged
        writeKey("Settings", "recordUnknownStatus", recordUnknownStatus.CheckState)
    End Sub

    Private Sub StatusTriggerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles StatusTriggerCheckBox.CheckedChanged
        If (StatusTriggerCheckBox.Checked) Then
            triggered = False
        Else
            triggered = True
        End If
        writeKey("Settings", "useStatusTrigger", StatusTriggerCheckBox.CheckState)
    End Sub

    Private Sub TriggerStatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles TriggerStatusTextBox.TextChanged
        writeKey("Settings", "triggerStatus", TriggerStatusTextBox.Text)
    End Sub

    Private Sub RecordPeriodNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles RecordPeriodNumericUpDown.ValueChanged
        writeKey("Settings", "recordPeriod", RecordPeriodNumericUpDown.Value)
        collectTimer.Interval = RecordPeriodNumericUpDown.Value
    End Sub

    Private Sub baseNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles baseNameTextBox.TextChanged
        writeKey("Settings", "baseExportFileName", baseNameTextBox.Text)
    End Sub

    Private Sub DisplayTab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayTab.SelectedIndexChanged
        updateDisplays()
    End Sub

    Private Sub recordChartTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles recordChartTypeComboBox.SelectedIndexChanged
        writeKey("Settings", "recordChartType", recordChartTypeComboBox.Text)
        drawRecordsChart()
    End Sub

    Private Sub statusChartTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusChartTypeComboBox.SelectedIndexChanged
        writeKey("Settings", "statusChartType", statusChartTypeComboBox.Text)
        drawStatusChart()
    End Sub

    Sub readAllStatusColor()
        Dim keyBuffer As String = Space(255)
        Dim copyBuffer As New StringBuilder
        Dim nullCount As Integer = 0
        Dim charsCopied As Integer = GetPrivateProfileSection("statusColor", keyBuffer, keyBuffer.Length, configurationFileName)
        statusColorDictionary = New Dictionary(Of String, String)
        For i As Integer = 0 To charsCopied
            If keyBuffer(i) <> vbNullChar Then
                nullCount = 0
                copyBuffer.Append(keyBuffer(i))
            Else
                Dim keyVal As String = copyBuffer.ToString()
                If keyVal <> "" Then
                    statusColorDictionary.Add(keyVal.Substring(0, 6), keyVal.Substring(7))
                End If
                copyBuffer.Length = 0
                nullCount += 1
                If nullCount > 1 Then
                    Exit For
                End If
            End If
        Next
    End Sub

    Function readKey(ByVal cat As String, ByVal key As String, ByVal def As String) As String
        Dim length As Integer = 255
        Dim value As String = New String(" "c, length)
        readKey = def
        Dim red As Integer = GetPrivateProfileString(cat, key, def, value, length, configurationFileName)
        readKey = Strings.Left(value, red)
    End Function

    Function readKeyInt(ByVal cat As String, ByVal key As String, ByVal def As Integer) As Integer
        Dim value As Integer
        value = GetPrivateProfileInt(cat, key, def, configurationFileName)
        readKeyInt = value
    End Function

    Sub writeKey(ByVal cat As String, ByVal key As String, ByVal val As String)
        WritePrivateProfileString(cat, key, val, configurationFileName)
    End Sub

    Private Sub collectPixelData()
        'Get date and time
        currentDate = DateTime.Now
        dateLabel.Text = "Date: " & currentDate.ToString("yyyy-MM-dd")
        timeLabel.Text = "Time: " & currentDate.ToString("HH:mm:ss")
        'Get cursor position
        If storingPixel Then
            Call GetCursorPos(cursorPosition)
        End If
        cursorPositionLabel.Text = "Pixel x: " & cursorPosition.x & " y: " & cursorPosition.y
        'Get pixel color
        currentColor = New Color(GetPixel(displayContext, cursorPosition.x, cursorPosition.y))
        ColorPanel.BackColor = System.Drawing.ColorTranslator.FromOle(currentColor.getInt)
        ColorLabel.Text = "Color: " & currentColor.getHex & " r: " & currentColor.getR & " g: " & currentColor.getG & " b: " & currentColor.getB
        If statusColorDictionary.Keys.Contains(currentColor.getHex) Then
            currentStatusName = statusColorDictionary(currentColor.getHex)
        Else
            If recordUnknownStatus.Checked Then
                currentStatusName = currentColor.getHex
            Else
                currentStatusName = ""
            End If
        End If
        StatusLabel.Text = "Status: " & currentStatusName
    End Sub


    Private Sub selectPixel()
        xTextBox.Text = cursorPosition.x
        YTextBox.Text = cursorPosition.y
    End Sub

    Private Sub assignStatusToColor()
        collectTimer.Enabled = False
        actionLabel.Text = "Action: Assigning Status to Color"
        currentStatusName = InputBox("Status for color " & currentColor.getHex, "Store Color Status", currentStatusName)
        If currentStatusName <> "" Then
            writeKey("statusColor", currentColor.getHex, currentStatusName)
            readAllStatusColor()
        End If
        collectTimer.Enabled = True
    End Sub

    Private Sub recordPixelEvent()
        actionLabel.Text = "Action: Recording pixel event"
        If recordUnknownStatus.Checked Or statusColorDictionary.Keys.Contains(currentColor.getHex) Then
            If recordingBeginingDate.Ticks = 0 Then
                recordingBeginingDate = currentDate
            End If
            addOrUpdateRecord()
        End If
    End Sub

    Private Sub catchPixelPosition()
        actionLabel.Text = "Action: Catching Pixel Position"
    End Sub

    Private Sub addOrUpdateRecord()
        If recordList.Count > 0 Then
            recordList.Last.totalTime = (currentDate - recordList.Last.recordDate)
            If recordList.Last.statusName <> currentStatusName Then
                Dim record As Record = New Record(currentDate, currentStatusName, New TimeSpan, currentColor)
                recordList.Add(record)
            End If
        Else
            Dim record As Record = New Record(currentDate, currentStatusName, New TimeSpan, currentColor)
            recordList.Add(record)
        End If
    End Sub

    Private Sub addOrUpdateStatus()
        statusDictionary = New Dictionary(Of String, Status)
        For Each record As Record In recordList
            If Not statusDictionary.Keys.Contains(record.statusName) Then
                Dim status As Status = New Status(record.statusName, 1, record.totalTime, 0.0, record.color)
                statusDictionary.Add(record.statusName, status)
            Else
                statusDictionary.Item(record.statusName).statusOccurences = statusDictionary.Item(record.statusName).statusOccurences + 1
                statusDictionary.Item(record.statusName).totalTime = statusDictionary.Item(record.statusName).totalTime + record.totalTime
            End If

        Next
        For Each status As Status In statusDictionary.Values
            If (currentDate - recordingBeginingDate).Ticks <> 0 Then
                status.statusPercent = 100.0 * status.totalTime.Ticks / (currentDate - recordingBeginingDate).Ticks
            Else
                status.statusPercent = 0.0
            End If
        Next
    End Sub

    Private Sub updateDisplays()
        Select Case DisplayTab.SelectedIndex
            Case 0
                drawRecordsDataGrids()
            Case 1
                addOrUpdateStatus()
                drawStatusDataGrids()
            Case 2
                drawRecordsChart()
            Case 3
                addOrUpdateStatus()
                drawStatusChart()
            Case Else
        End Select
    End Sub

    Private Sub updateAllDisplays()
        addOrUpdateStatus()
        drawRecordsDataGrids()
        drawStatusDataGrids()
        drawRecordsChart()
        drawStatusChart()
    End Sub

    Private Sub drawRecordsDataGrids()
        recordsDataGridView.Rows.Clear()
        For Each record As Record In recordList
            recordsDataGridView.Rows.Add(New String() {record.getRecordDateString, record.getRecordHourString, record.statusName, record.getTotalTimeString, record.getColorHex})
            recordsDataGridView.Rows.Item(recordsDataGridView.Rows.Count - 1).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromOle(record.getColorInt)
        Next
        If recordsDataGridView.RowCount > 1 Then
            recordsDataGridView.FirstDisplayedScrollingRowIndex = recordsDataGridView.RowCount - 1
        End If
        recordsDataGridView.ClearSelection()
    End Sub
    Private Sub drawStatusDataGrids()
        statusDataGridView.Rows.Clear()
        For Each status As Status In statusDictionary.Values
            statusDataGridView.Rows.Add(New String() {status.name, status.statusOccurences, status.getTotalTimeString, status.statusPercent.ToString("00.00"), status.getColorHex})
            statusDataGridView.Rows.Item(statusDataGridView.Rows.Count - 1).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromOle(status.getColorInt)
        Next
        If statusDataGridView.RowCount > 1 Then
            statusDataGridView.FirstDisplayedScrollingRowIndex = statusDataGridView.RowCount - 1
        End If
        statusDataGridView.ClearSelection()
    End Sub

    Sub drawRecordsChart()
        If recordList.Count = 0 Then
            Exit Sub
        End If
        recordsChart.Series.Clear()
        recordsChart.Titles.Clear()
        Dim xValues(recordList.Count - 1) As String
        Dim yValues(recordList.Count - 1) As Integer
        Dim i As Integer

        For Each record As Record In recordList
            xValues(i) = i
            yValues(i) = record.totalTime.TotalMilliseconds
            i = i + 1
        Next

        Dim seriesName As String = Nothing
        recordsChart.Series.Clear()
        recordsChart.Titles.Clear()

        ' Give unique Series Name
        seriesName = "ColorRecords"
        recordsChart.Series.Add(seriesName)

        ' Bind X and Y values
        recordsChart.Series(seriesName).Points.DataBindXY(xValues, yValues)

        ' Define Custom Chart Colors
        i = 0
        For Each dataPoint As DataPoint In recordsChart.Series(seriesName).Points
            dataPoint.Color = System.Drawing.ColorTranslator.FromOle(recordList(i).getColorInt)
            i = i + 1
        Next

        'Hide chart legend
        recordsChart.Series(seriesName).IsVisibleInLegend = False

        ' Define Chart Type
        Dim seriesChartType As Integer
        Select Case recordChartTypeComboBox.Text
            Case "Area"
                seriesChartType = 13
            Case "Bar"
                seriesChartType = 7
            Case "BoxPlot"
                seriesChartType = 28
            Case "Bubble"
                seriesChartType = 2
            Case "Candlestick"
                seriesChartType = 20
            Case "Column"
                seriesChartType = 10
            Case "Doughnut"
                seriesChartType = 18
                ' If you don't want to show data values and headings as label inside each Pie in chart
                recordsChart.Series(seriesName)("PieLabelStyle") = "Disabled"
                recordsChart.Series(seriesName).IsValueShownAsLabel = False
            Case "ErrorBar"
                seriesChartType = 27
            Case "FastLine"
                seriesChartType = 6
            Case "FastPoint"
                seriesChartType = 1
            Case "Funnel"
                seriesChartType = 33
            Case "Kagi"
                seriesChartType = 31
            Case "Line"
                seriesChartType = 3
            Case "Pie"
                seriesChartType = 17
                ' If you don't want to show data values and headings as label inside each Pie in chart
                recordsChart.Series(seriesName)("PieLabelStyle") = "Disabled"
                recordsChart.Series(seriesName).IsValueShownAsLabel = False
            Case "Point"
                seriesChartType = 0
            Case "PointAndFigure"
                seriesChartType = 3
            Case "Polar"
                seriesChartType = 26
            Case "Pyramid"
                seriesChartType = 34
            Case "Radar"
                seriesChartType = 25
            Case "Range"
                seriesChartType = 21
            Case "RangeBar"
                seriesChartType = 23
            Case "RangeColumn"
                seriesChartType = 24
            Case "Renko"
                seriesChartType = 29
            Case "Spline"
                seriesChartType = 4
            Case "SplineArea"
                seriesChartType = 14
            Case "SplineRange"
                seriesChartType = 22
            Case "StackedArea"
                seriesChartType = 15
            Case "StackedArea100"
                seriesChartType = 16
            Case "StackedBar"
                seriesChartType = 8
            Case "StackedBar100"
                seriesChartType = 9
            Case "StackedColumn"
                seriesChartType = 11
            Case "StackedColumn100"
                seriesChartType = 12
            Case "StepLine"
                seriesChartType = 5
            Case "Stock"
                seriesChartType = 19
            Case "ThreeLineBreak"
                seriesChartType = 30
            Case Else
        End Select
        recordsChart.Series(seriesName).ChartType = seriesChartType
    End Sub

    Sub drawStatusChart()
        If statusDictionary.Keys.Count = 0 Then
            Exit Sub
        End If
        statusChart.Series.Clear()
        statusChart.Titles.Clear()
        Dim xValues(statusDictionary.Keys.Count - 1) As String
        Dim yValues(statusDictionary.Keys.Count - 1) As Integer
        Dim i As Integer

        For Each statusRecordKey As String In statusDictionary.Keys
            Dim statusRecord As Status = statusDictionary(statusRecordKey)
            xValues(i) = statusRecordKey
            yValues(i) = statusRecord.statusPercent
            i = i + 1
        Next

        Dim seriesName As String = Nothing
        statusChart.Series.Clear()
        statusChart.Titles.Clear()

        ' Give unique Series Name
        seriesName = "ColorRecords"
        statusChart.Series.Add(seriesName)

        ' Bind X and Y values
        statusChart.Series(seriesName).Points.DataBindXY(xValues, yValues)

        ' Define Custom Chart Colors
        For Each dataPoint As DataPoint In statusChart.Series(seriesName).Points
            dataPoint.Color = System.Drawing.ColorTranslator.FromOle(statusDictionary(dataPoint.AxisLabel).getColorInt)
        Next

        'Hide chart legend
        statusChart.Series(seriesName).IsVisibleInLegend = False

        ' Define Chart Type
        Dim seriesChartType As Integer
        Select Case statusChartTypeComboBox.Text
            Case "Area"
                seriesChartType = 13
            Case "Bar"
                seriesChartType = 7
            Case "BoxPlot"
                seriesChartType = 28
            Case "Bubble"
                seriesChartType = 2
            Case "Candlestick"
                seriesChartType = 20
            Case "Column"
                seriesChartType = 10
            Case "Doughnut"
                seriesChartType = 18
                statusChart.Series(seriesName).IsVisibleInLegend = True
                ' If you don't want to show data values and headings as label inside each Pie in chart
                statusChart.Series(seriesName)("PieLabelStyle") = "Disabled"
                statusChart.Series(seriesName).IsValueShownAsLabel = False
            Case "ErrorBar"
                seriesChartType = 27
            Case "FastLine"
                seriesChartType = 6
            Case "FastPoint"
                seriesChartType = 1
            Case "Funnel"
                seriesChartType = 33
                statusChart.Series(seriesName).IsVisibleInLegend = True
            Case "Kagi"
                seriesChartType = 31
            Case "Line"
                seriesChartType = 3
            Case "Pie"
                seriesChartType = 17
                statusChart.Series(seriesName).IsVisibleInLegend = True
                ' If you don't want to show data values and headings as label inside each Pie in chart
                statusChart.Series(seriesName)("PieLabelStyle") = "Disabled"
                statusChart.Series(seriesName).IsValueShownAsLabel = False
            Case "Point"
                seriesChartType = 0
            Case "PointAndFigure"
                seriesChartType = 3
            Case "Polar"
                seriesChartType = 26
            Case "Pyramid"
                seriesChartType = 34
                statusChart.Series(seriesName).IsVisibleInLegend = True
            Case "Radar"
                seriesChartType = 25
            Case "Range"
                seriesChartType = 21
            Case "RangeBar"
                seriesChartType = 23
            Case "RangeColumn"
                seriesChartType = 24
            Case "Renko"
                seriesChartType = 29
            Case "Spline"
                seriesChartType = 4
            Case "SplineArea"
                seriesChartType = 14
            Case "SplineRange"
                seriesChartType = 22
            Case "StackedArea"
                seriesChartType = 15
            Case "StackedArea100"
                seriesChartType = 16
            Case "StackedBar"
                seriesChartType = 8
            Case "StackedBar100"
                seriesChartType = 9
            Case "StackedColumn"
                seriesChartType = 11
            Case "StackedColumn100"
                seriesChartType = 12
            Case "StepLine"
                seriesChartType = 5
            Case "Stock"
                seriesChartType = 19
            Case "ThreeLineBreak"
                seriesChartType = 30
            Case Else
        End Select
        statusChart.Series(seriesName).ChartType = seriesChartType
    End Sub

    Sub exportCSVFile()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("..\" & baseNameTextBox.Text & "-" & currentDate.ToString("yyyy-MM-dd HH-mm-ss") & ".csv", True)
        file.WriteLine("Date,Hour,Status,Time,Color")
        Dim sb As New Text.StringBuilder()
        For Each row As DataGridViewRow In recordsDataGridView.Rows
            sb.AppendLine(String.Join(",", (From i As DataGridViewCell In row.Cells Select i.Value.ToString().Replace("""", """""").Replace(",", "\,").Replace(Environment.NewLine, "\" & Environment.NewLine).Replace("\", "\\")).ToArray()))
        Next
        file.WriteLine(sb.ToString())

        addOrUpdateStatus()
        drawStatusDataGrids()
        file.WriteLine("Status,Occurence,Since,%,Color")
        sb.Clear()
        For Each row As DataGridViewRow In statusDataGridView.Rows
            sb.AppendLine(String.Join(",", (From i As DataGridViewCell In row.Cells Select i.Value.ToString().Replace("""", """""").Replace(",", "\,").Replace(Environment.NewLine, "\" & Environment.NewLine).Replace("\", "\\")).ToArray()))
        Next row
        file.WriteLine(sb.ToString())
        file.Close()
    End Sub

    Sub exportXLSXFile()
        exportCSVFile()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For j = 0 To recordsDataGridView.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = recordsDataGridView.Columns(j).HeaderText
        Next
        For i = 0 To recordsDataGridView.RowCount - 1
            For j = 0 To recordsDataGridView.ColumnCount - 1
                Dim cell As DataGridViewCell
                cell = recordsDataGridView(j, i)
                xlWorkSheet.Cells(i + 2, j + 1) = cell.Value
            Next
        Next
        'xlWorkSheet.SaveAs("..\" & baseNameTextBox.Text & "-" & currentDate.ToString("yyyy-MM-dd HH-mm-ss") & ".xlsx")
        xlWorkSheet.SaveAs("C:\Users\p14\Desktop\PixelLogger\PixelLogger\bin\" & baseNameTextBox.Text & "-" & currentDate.ToString("yyyy-MM-dd HH-mm-ss") & ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
