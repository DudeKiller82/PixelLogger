<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PixelLogger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PixelLogger))
        Me.collectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.startRecordingButton = New System.Windows.Forms.Button()
        Me.assignStatusToColorButton = New System.Windows.Forms.Button()
        Me.recordsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.timeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stopRecordingButton = New System.Windows.Forms.Button()
        Me.exportExcelFileButton = New System.Windows.Forms.Button()
        Me.ColorPanel = New System.Windows.Forms.Panel()
        Me.recordUnknownStatus = New System.Windows.Forms.CheckBox()
        Me.pixelEventsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResetTriggerButton = New System.Windows.Forms.Button()
        Me.TriggerStatusTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTriggerCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RecordPeriodNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.ExportGroupBox = New System.Windows.Forms.GroupBox()
        Me.fileNameLabel = New System.Windows.Forms.Label()
        Me.baseNameTextBox = New System.Windows.Forms.TextBox()
        Me.statusGroupBox = New System.Windows.Forms.GroupBox()
        Me.actionLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.cursorPositionLabel = New System.Windows.Forms.Label()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.statusChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pixelGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YTextBox = New System.Windows.Forms.TextBox()
        Me.selectPixelButton = New System.Windows.Forms.Button()
        Me.xTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayTab = New System.Windows.Forms.TabControl()
        Me.recordsTabPage = New System.Windows.Forms.TabPage()
        Me.statusTabPage = New System.Windows.Forms.TabPage()
        Me.statusDataGridView = New System.Windows.Forms.DataGridView()
        Me.statusColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.occurencesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusTimeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percentColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorColums = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recordChartTabPage = New System.Windows.Forms.TabPage()
        Me.recordChartTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.recordsChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.statusChartTabPage = New System.Windows.Forms.TabPage()
        Me.statusChartTypeComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.recordsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pixelEventsGroupBox.SuspendLayout()
        CType(Me.RecordPeriodNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExportGroupBox.SuspendLayout()
        Me.statusGroupBox.SuspendLayout()
        CType(Me.statusChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pixelGroupBox.SuspendLayout()
        Me.DisplayTab.SuspendLayout()
        Me.recordsTabPage.SuspendLayout()
        Me.statusTabPage.SuspendLayout()
        CType(Me.statusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recordChartTabPage.SuspendLayout()
        CType(Me.recordsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusChartTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'collectTimer
        '
        '
        'startRecordingButton
        '
        Me.startRecordingButton.Location = New System.Drawing.Point(6, 19)
        Me.startRecordingButton.Name = "startRecordingButton"
        Me.startRecordingButton.Size = New System.Drawing.Size(177, 23)
        Me.startRecordingButton.TabIndex = 0
        Me.startRecordingButton.Text = "Start Recording"
        Me.startRecordingButton.UseVisualStyleBackColor = True
        '
        'assignStatusToColorButton
        '
        Me.assignStatusToColorButton.Location = New System.Drawing.Point(6, 49)
        Me.assignStatusToColorButton.Name = "assignStatusToColorButton"
        Me.assignStatusToColorButton.Size = New System.Drawing.Size(177, 23)
        Me.assignStatusToColorButton.TabIndex = 2
        Me.assignStatusToColorButton.Text = "Assign Status to Color"
        Me.assignStatusToColorButton.UseVisualStyleBackColor = True
        '
        'recordsDataGridView
        '
        Me.recordsDataGridView.AllowUserToAddRows = False
        Me.recordsDataGridView.AllowUserToOrderColumns = True
        Me.recordsDataGridView.AllowUserToResizeRows = False
        Me.recordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recordsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateColumn, Me.HourColumn, Me.statusNameColumn, Me.timeColumn, Me.colorColumn})
        Me.recordsDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.recordsDataGridView.MultiSelect = False
        Me.recordsDataGridView.Name = "recordsDataGridView"
        Me.recordsDataGridView.Size = New System.Drawing.Size(372, 353)
        Me.recordsDataGridView.TabIndex = 4
        '
        'DateColumn
        '
        Me.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateColumn.HeaderText = "Date"
        Me.DateColumn.Name = "DateColumn"
        Me.DateColumn.ReadOnly = True
        Me.DateColumn.Width = 55
        '
        'HourColumn
        '
        Me.HourColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HourColumn.HeaderText = "Hour"
        Me.HourColumn.Name = "HourColumn"
        Me.HourColumn.ReadOnly = True
        Me.HourColumn.Width = 55
        '
        'statusNameColumn
        '
        Me.statusNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.statusNameColumn.HeaderText = "Status"
        Me.statusNameColumn.Name = "statusNameColumn"
        Me.statusNameColumn.ReadOnly = True
        Me.statusNameColumn.Width = 62
        '
        'timeColumn
        '
        Me.timeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.timeColumn.HeaderText = "Time"
        Me.timeColumn.Name = "timeColumn"
        Me.timeColumn.Width = 55
        '
        'colorColumn
        '
        Me.colorColumn.HeaderText = "Color"
        Me.colorColumn.Name = "colorColumn"
        Me.colorColumn.ReadOnly = True
        Me.colorColumn.Width = 10000
        '
        'stopRecordingButton
        '
        Me.stopRecordingButton.Location = New System.Drawing.Point(6, 46)
        Me.stopRecordingButton.Name = "stopRecordingButton"
        Me.stopRecordingButton.Size = New System.Drawing.Size(177, 23)
        Me.stopRecordingButton.TabIndex = 5
        Me.stopRecordingButton.Text = "Stop Recording"
        Me.stopRecordingButton.UseVisualStyleBackColor = True
        '
        'exportExcelFileButton
        '
        Me.exportExcelFileButton.Location = New System.Drawing.Point(6, 45)
        Me.exportExcelFileButton.Name = "exportExcelFileButton"
        Me.exportExcelFileButton.Size = New System.Drawing.Size(360, 23)
        Me.exportExcelFileButton.TabIndex = 7
        Me.exportExcelFileButton.Text = "Export Excel File"
        Me.exportExcelFileButton.UseVisualStyleBackColor = True
        '
        'ColorPanel
        '
        Me.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ColorPanel.Location = New System.Drawing.Point(289, 16)
        Me.ColorPanel.Name = "ColorPanel"
        Me.ColorPanel.Size = New System.Drawing.Size(77, 78)
        Me.ColorPanel.TabIndex = 8
        '
        'recordUnknownStatus
        '
        Me.recordUnknownStatus.AutoSize = True
        Me.recordUnknownStatus.Location = New System.Drawing.Point(192, 52)
        Me.recordUnknownStatus.Name = "recordUnknownStatus"
        Me.recordUnknownStatus.Size = New System.Drawing.Size(139, 17)
        Me.recordUnknownStatus.TabIndex = 9
        Me.recordUnknownStatus.Text = "Record unknown status"
        Me.recordUnknownStatus.UseVisualStyleBackColor = True
        '
        'pixelEventsGroupBox
        '
        Me.pixelEventsGroupBox.Controls.Add(Me.ResetTriggerButton)
        Me.pixelEventsGroupBox.Controls.Add(Me.TriggerStatusTextBox)
        Me.pixelEventsGroupBox.Controls.Add(Me.StatusTriggerCheckBox)
        Me.pixelEventsGroupBox.Controls.Add(Me.Label3)
        Me.pixelEventsGroupBox.Controls.Add(Me.RecordPeriodNumericUpDown)
        Me.pixelEventsGroupBox.Controls.Add(Me.clearButton)
        Me.pixelEventsGroupBox.Controls.Add(Me.startRecordingButton)
        Me.pixelEventsGroupBox.Controls.Add(Me.recordUnknownStatus)
        Me.pixelEventsGroupBox.Controls.Add(Me.stopRecordingButton)
        Me.pixelEventsGroupBox.Location = New System.Drawing.Point(12, 209)
        Me.pixelEventsGroupBox.Name = "pixelEventsGroupBox"
        Me.pixelEventsGroupBox.Size = New System.Drawing.Size(372, 110)
        Me.pixelEventsGroupBox.TabIndex = 10
        Me.pixelEventsGroupBox.TabStop = False
        Me.pixelEventsGroupBox.Text = "Pixel Events"
        '
        'ResetTriggerButton
        '
        Me.ResetTriggerButton.Location = New System.Drawing.Point(100, 77)
        Me.ResetTriggerButton.Name = "ResetTriggerButton"
        Me.ResetTriggerButton.Size = New System.Drawing.Size(83, 23)
        Me.ResetTriggerButton.TabIndex = 15
        Me.ResetTriggerButton.Text = "Reset Trigger"
        Me.ResetTriggerButton.UseVisualStyleBackColor = True
        '
        'TriggerStatusTextBox
        '
        Me.TriggerStatusTextBox.Location = New System.Drawing.Point(254, 79)
        Me.TriggerStatusTextBox.Name = "TriggerStatusTextBox"
        Me.TriggerStatusTextBox.Size = New System.Drawing.Size(112, 20)
        Me.TriggerStatusTextBox.TabIndex = 14
        '
        'StatusTriggerCheckBox
        '
        Me.StatusTriggerCheckBox.AutoSize = True
        Me.StatusTriggerCheckBox.Location = New System.Drawing.Point(192, 81)
        Me.StatusTriggerCheckBox.Name = "StatusTriggerCheckBox"
        Me.StatusTriggerCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.StatusTriggerCheckBox.TabIndex = 13
        Me.StatusTriggerCheckBox.Text = "Trigger:"
        Me.StatusTriggerCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(189, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Period (ms):"
        '
        'RecordPeriodNumericUpDown
        '
        Me.RecordPeriodNumericUpDown.Location = New System.Drawing.Point(254, 22)
        Me.RecordPeriodNumericUpDown.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.RecordPeriodNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RecordPeriodNumericUpDown.Name = "RecordPeriodNumericUpDown"
        Me.RecordPeriodNumericUpDown.Size = New System.Drawing.Size(112, 20)
        Me.RecordPeriodNumericUpDown.TabIndex = 11
        Me.RecordPeriodNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(6, 77)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(88, 23)
        Me.clearButton.TabIndex = 10
        Me.clearButton.Text = "Clear Records"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'ExportGroupBox
        '
        Me.ExportGroupBox.Controls.Add(Me.fileNameLabel)
        Me.ExportGroupBox.Controls.Add(Me.baseNameTextBox)
        Me.ExportGroupBox.Controls.Add(Me.exportExcelFileButton)
        Me.ExportGroupBox.Location = New System.Drawing.Point(12, 325)
        Me.ExportGroupBox.Name = "ExportGroupBox"
        Me.ExportGroupBox.Size = New System.Drawing.Size(372, 79)
        Me.ExportGroupBox.TabIndex = 11
        Me.ExportGroupBox.TabStop = False
        Me.ExportGroupBox.Text = "Export"
        '
        'fileNameLabel
        '
        Me.fileNameLabel.AutoSize = True
        Me.fileNameLabel.Location = New System.Drawing.Point(6, 22)
        Me.fileNameLabel.Name = "fileNameLabel"
        Me.fileNameLabel.Size = New System.Drawing.Size(54, 13)
        Me.fileNameLabel.TabIndex = 9
        Me.fileNameLabel.Text = "File Name"
        '
        'baseNameTextBox
        '
        Me.baseNameTextBox.Location = New System.Drawing.Point(66, 19)
        Me.baseNameTextBox.Name = "baseNameTextBox"
        Me.baseNameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.baseNameTextBox.TabIndex = 8
        '
        'statusGroupBox
        '
        Me.statusGroupBox.Controls.Add(Me.actionLabel)
        Me.statusGroupBox.Controls.Add(Me.StatusLabel)
        Me.statusGroupBox.Controls.Add(Me.ColorLabel)
        Me.statusGroupBox.Controls.Add(Me.cursorPositionLabel)
        Me.statusGroupBox.Controls.Add(Me.ColorPanel)
        Me.statusGroupBox.Controls.Add(Me.timeLabel)
        Me.statusGroupBox.Controls.Add(Me.dateLabel)
        Me.statusGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.statusGroupBox.Name = "statusGroupBox"
        Me.statusGroupBox.Size = New System.Drawing.Size(372, 102)
        Me.statusGroupBox.TabIndex = 12
        Me.statusGroupBox.TabStop = False
        Me.statusGroupBox.Text = "Status"
        '
        'actionLabel
        '
        Me.actionLabel.AutoSize = True
        Me.actionLabel.Location = New System.Drawing.Point(6, 81)
        Me.actionLabel.Name = "actionLabel"
        Me.actionLabel.Size = New System.Drawing.Size(40, 13)
        Me.actionLabel.TabIndex = 9
        Me.actionLabel.Text = "Action:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(6, 68)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(40, 13)
        Me.StatusLabel.TabIndex = 4
        Me.StatusLabel.Text = "Status:"
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(6, 55)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(34, 13)
        Me.ColorLabel.TabIndex = 3
        Me.ColorLabel.Text = "Color:"
        '
        'cursorPositionLabel
        '
        Me.cursorPositionLabel.AutoSize = True
        Me.cursorPositionLabel.Location = New System.Drawing.Point(6, 42)
        Me.cursorPositionLabel.Name = "cursorPositionLabel"
        Me.cursorPositionLabel.Size = New System.Drawing.Size(79, 13)
        Me.cursorPositionLabel.TabIndex = 2
        Me.cursorPositionLabel.Text = "Cursor position:"
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Location = New System.Drawing.Point(6, 29)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(33, 13)
        Me.timeLabel.TabIndex = 1
        Me.timeLabel.Text = "Time:"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(6, 16)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(33, 13)
        Me.dateLabel.TabIndex = 0
        Me.dateLabel.Text = "Date:"
        '
        'statusChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.statusChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.statusChart.Legends.Add(Legend1)
        Me.statusChart.Location = New System.Drawing.Point(6, 33)
        Me.statusChart.Name = "statusChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.statusChart.Series.Add(Series1)
        Me.statusChart.Size = New System.Drawing.Size(372, 326)
        Me.statusChart.TabIndex = 13
        '
        'pixelGroupBox
        '
        Me.pixelGroupBox.Controls.Add(Me.Label2)
        Me.pixelGroupBox.Controls.Add(Me.assignStatusToColorButton)
        Me.pixelGroupBox.Controls.Add(Me.Label1)
        Me.pixelGroupBox.Controls.Add(Me.YTextBox)
        Me.pixelGroupBox.Controls.Add(Me.selectPixelButton)
        Me.pixelGroupBox.Controls.Add(Me.xTextBox)
        Me.pixelGroupBox.Location = New System.Drawing.Point(12, 120)
        Me.pixelGroupBox.Name = "pixelGroupBox"
        Me.pixelGroupBox.Size = New System.Drawing.Size(372, 83)
        Me.pixelGroupBox.TabIndex = 14
        Me.pixelGroupBox.TabStop = False
        Me.pixelGroupBox.Text = "Pixel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Y:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X:"
        '
        'YTextBox
        '
        Me.YTextBox.Location = New System.Drawing.Point(209, 51)
        Me.YTextBox.Name = "YTextBox"
        Me.YTextBox.Size = New System.Drawing.Size(157, 20)
        Me.YTextBox.TabIndex = 2
        Me.YTextBox.Text = "0"
        '
        'selectPixelButton
        '
        Me.selectPixelButton.Location = New System.Drawing.Point(6, 19)
        Me.selectPixelButton.Name = "selectPixelButton"
        Me.selectPixelButton.Size = New System.Drawing.Size(177, 23)
        Me.selectPixelButton.TabIndex = 1
        Me.selectPixelButton.Text = "Select Pixel"
        Me.selectPixelButton.UseVisualStyleBackColor = True
        '
        'xTextBox
        '
        Me.xTextBox.Location = New System.Drawing.Point(209, 21)
        Me.xTextBox.Name = "xTextBox"
        Me.xTextBox.Size = New System.Drawing.Size(157, 20)
        Me.xTextBox.TabIndex = 3
        Me.xTextBox.Text = "0"
        '
        'DisplayTab
        '
        Me.DisplayTab.Controls.Add(Me.recordsTabPage)
        Me.DisplayTab.Controls.Add(Me.statusTabPage)
        Me.DisplayTab.Controls.Add(Me.recordChartTabPage)
        Me.DisplayTab.Controls.Add(Me.statusChartTabPage)
        Me.DisplayTab.Location = New System.Drawing.Point(390, 12)
        Me.DisplayTab.Name = "DisplayTab"
        Me.DisplayTab.SelectedIndex = 0
        Me.DisplayTab.Size = New System.Drawing.Size(392, 392)
        Me.DisplayTab.TabIndex = 15
        '
        'recordsTabPage
        '
        Me.recordsTabPage.Controls.Add(Me.recordsDataGridView)
        Me.recordsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.recordsTabPage.Name = "recordsTabPage"
        Me.recordsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.recordsTabPage.Size = New System.Drawing.Size(384, 366)
        Me.recordsTabPage.TabIndex = 0
        Me.recordsTabPage.Text = "Records"
        Me.recordsTabPage.UseVisualStyleBackColor = True
        '
        'statusTabPage
        '
        Me.statusTabPage.Controls.Add(Me.statusDataGridView)
        Me.statusTabPage.Location = New System.Drawing.Point(4, 22)
        Me.statusTabPage.Name = "statusTabPage"
        Me.statusTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.statusTabPage.Size = New System.Drawing.Size(384, 366)
        Me.statusTabPage.TabIndex = 2
        Me.statusTabPage.Text = "Status"
        Me.statusTabPage.UseVisualStyleBackColor = True
        '
        'statusDataGridView
        '
        Me.statusDataGridView.AllowUserToAddRows = False
        Me.statusDataGridView.AllowUserToOrderColumns = True
        Me.statusDataGridView.AllowUserToResizeRows = False
        Me.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.statusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.statusColumn, Me.occurencesColumn, Me.statusTimeColumn, Me.percentColumn, Me.colorColums})
        Me.statusDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.statusDataGridView.MultiSelect = False
        Me.statusDataGridView.Name = "statusDataGridView"
        Me.statusDataGridView.Size = New System.Drawing.Size(372, 353)
        Me.statusDataGridView.TabIndex = 5
        '
        'statusColumn
        '
        Me.statusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.statusColumn.HeaderText = "Status"
        Me.statusColumn.Name = "statusColumn"
        Me.statusColumn.ReadOnly = True
        Me.statusColumn.Width = 62
        '
        'occurencesColumn
        '
        Me.occurencesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.occurencesColumn.HeaderText = "Occurences"
        Me.occurencesColumn.Name = "occurencesColumn"
        Me.occurencesColumn.ReadOnly = True
        Me.occurencesColumn.Width = 90
        '
        'statusTimeColumn
        '
        Me.statusTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.statusTimeColumn.HeaderText = "Since"
        Me.statusTimeColumn.Name = "statusTimeColumn"
        Me.statusTimeColumn.Width = 59
        '
        'percentColumn
        '
        Me.percentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.percentColumn.HeaderText = "%"
        Me.percentColumn.Name = "percentColumn"
        Me.percentColumn.ReadOnly = True
        Me.percentColumn.Width = 40
        '
        'colorColums
        '
        Me.colorColums.HeaderText = "Color"
        Me.colorColums.Name = "colorColums"
        Me.colorColums.ReadOnly = True
        Me.colorColums.Width = 10000
        '
        'recordChartTabPage
        '
        Me.recordChartTabPage.Controls.Add(Me.recordChartTypeComboBox)
        Me.recordChartTabPage.Controls.Add(Me.recordsChart)
        Me.recordChartTabPage.Location = New System.Drawing.Point(4, 22)
        Me.recordChartTabPage.Name = "recordChartTabPage"
        Me.recordChartTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.recordChartTabPage.Size = New System.Drawing.Size(384, 366)
        Me.recordChartTabPage.TabIndex = 3
        Me.recordChartTabPage.Text = "Record Chart"
        Me.recordChartTabPage.UseVisualStyleBackColor = True
        '
        'recordChartTypeComboBox
        '
        Me.recordChartTypeComboBox.FormattingEnabled = True
        Me.recordChartTypeComboBox.Items.AddRange(New Object() {"Area", "Bar", "BoxPlot", "Bubble", "Candlestick", "Column", "Doughnut", "ErrorBar", "FastLine", "FastPoint", "Funnel", "Kagi", "Line", "Pie", "Point", "PointAndFigure", "Polar", "Pyramid", "Radar", "Range", "RangeBar", "RangeColumn", "Renko", "Spline", "SplineArea", "SplineRange", "StackedArea", "StackedArea100", "StackedBar", "StackedBar100", "StackedColumn", "StackedColumn100", "StepLine", "Stock"})
        Me.recordChartTypeComboBox.Location = New System.Drawing.Point(6, 6)
        Me.recordChartTypeComboBox.Name = "recordChartTypeComboBox"
        Me.recordChartTypeComboBox.Size = New System.Drawing.Size(372, 21)
        Me.recordChartTypeComboBox.TabIndex = 15
        '
        'recordsChart
        '
        ChartArea2.Name = "ChartArea1"
        Me.recordsChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.recordsChart.Legends.Add(Legend2)
        Me.recordsChart.Location = New System.Drawing.Point(6, 33)
        Me.recordsChart.Name = "recordsChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.recordsChart.Series.Add(Series2)
        Me.recordsChart.Size = New System.Drawing.Size(372, 326)
        Me.recordsChart.TabIndex = 14
        '
        'statusChartTabPage
        '
        Me.statusChartTabPage.Controls.Add(Me.statusChartTypeComboBox)
        Me.statusChartTabPage.Controls.Add(Me.statusChart)
        Me.statusChartTabPage.Location = New System.Drawing.Point(4, 22)
        Me.statusChartTabPage.Name = "statusChartTabPage"
        Me.statusChartTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.statusChartTabPage.Size = New System.Drawing.Size(384, 366)
        Me.statusChartTabPage.TabIndex = 1
        Me.statusChartTabPage.Text = "Status Chart"
        Me.statusChartTabPage.UseVisualStyleBackColor = True
        '
        'statusChartTypeComboBox
        '
        Me.statusChartTypeComboBox.FormattingEnabled = True
        Me.statusChartTypeComboBox.Items.AddRange(New Object() {"Area", "Bar", "BoxPlot", "Bubble", "Candlestick", "Column", "Doughnut", "ErrorBar", "FastLine", "FastPoint", "Funnel", "Kagi", "Line", "Pie", "Point", "PointAndFigure", "Polar", "Pyramid", "Radar", "Range", "RangeBar", "RangeColumn", "Renko", "Spline", "SplineArea", "SplineRange", "StackedArea", "StackedArea100", "StackedBar", "StackedBar100", "StackedColumn", "StackedColumn100", "StepLine", "Stock"})
        Me.statusChartTypeComboBox.Location = New System.Drawing.Point(6, 6)
        Me.statusChartTypeComboBox.Name = "statusChartTypeComboBox"
        Me.statusChartTypeComboBox.Size = New System.Drawing.Size(372, 21)
        Me.statusChartTypeComboBox.TabIndex = 14
        '
        'PixelLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 408)
        Me.Controls.Add(Me.DisplayTab)
        Me.Controls.Add(Me.pixelGroupBox)
        Me.Controls.Add(Me.statusGroupBox)
        Me.Controls.Add(Me.ExportGroupBox)
        Me.Controls.Add(Me.pixelEventsGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PixelLogger"
        Me.Text = "Pixel Logger"
        CType(Me.recordsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pixelEventsGroupBox.ResumeLayout(False)
        Me.pixelEventsGroupBox.PerformLayout()
        CType(Me.RecordPeriodNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExportGroupBox.ResumeLayout(False)
        Me.ExportGroupBox.PerformLayout()
        Me.statusGroupBox.ResumeLayout(False)
        Me.statusGroupBox.PerformLayout()
        CType(Me.statusChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pixelGroupBox.ResumeLayout(False)
        Me.pixelGroupBox.PerformLayout()
        Me.DisplayTab.ResumeLayout(False)
        Me.recordsTabPage.ResumeLayout(False)
        Me.statusTabPage.ResumeLayout(False)
        CType(Me.statusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recordChartTabPage.ResumeLayout(False)
        CType(Me.recordsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusChartTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents collectTimer As System.Windows.Forms.Timer
    Friend WithEvents startRecordingButton As System.Windows.Forms.Button
    Friend WithEvents assignStatusToColorButton As System.Windows.Forms.Button
    Friend WithEvents recordsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents stopRecordingButton As System.Windows.Forms.Button
    Friend WithEvents exportExcelFileButton As System.Windows.Forms.Button
    Friend WithEvents ColorPanel As System.Windows.Forms.Panel
    Friend WithEvents recordDateCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recordHourCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recordStatusCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recordSinceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recordColorCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents recordUnknownStatus As System.Windows.Forms.CheckBox
    Friend WithEvents pixelEventsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ExportGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents fileNameLabel As System.Windows.Forms.Label
    Friend WithEvents baseNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents statusGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cursorPositionLabel As System.Windows.Forms.Label
    Friend WithEvents timeLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ColorLabel As System.Windows.Forms.Label
    Friend WithEvents actionLabel As System.Windows.Forms.Label
    Friend WithEvents statusChart As DataVisualization.Charting.Chart
    Friend WithEvents pixelGroupBox As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents YTextBox As TextBox
    Friend WithEvents selectPixelButton As Button
    Friend WithEvents xTextBox As TextBox
    Friend WithEvents DisplayTab As TabControl
    Friend WithEvents recordsTabPage As TabPage
    Friend WithEvents statusChartTabPage As TabPage
    Friend WithEvents clearButton As Button
    Friend WithEvents statusTabPage As TabPage
    Friend WithEvents recordChartTabPage As TabPage
    Friend WithEvents recordsChart As DataVisualization.Charting.Chart
    Friend WithEvents statusDataGridView As DataGridView
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourColumn As DataGridViewTextBoxColumn
    Friend WithEvents statusNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents timeColumn As DataGridViewTextBoxColumn
    Friend WithEvents colorColumn As DataGridViewTextBoxColumn
    Friend WithEvents statusColumn As DataGridViewTextBoxColumn
    Friend WithEvents occurencesColumn As DataGridViewTextBoxColumn
    Friend WithEvents statusTimeColumn As DataGridViewTextBoxColumn
    Friend WithEvents percentColumn As DataGridViewTextBoxColumn
    Friend WithEvents colorColums As DataGridViewTextBoxColumn
    Friend WithEvents statusChartTypeComboBox As ComboBox
    Friend WithEvents recordChartTypeComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RecordPeriodNumericUpDown As NumericUpDown
    Friend WithEvents StatusTriggerCheckBox As CheckBox
    Friend WithEvents TriggerStatusTextBox As TextBox
    Friend WithEvents ResetTriggerButton As Button
End Class
