' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgExtremesClimatic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblStations = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.grpMinMaxOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkLastDate = New instat.ucrCheck()
        Me.ucrChkNDates = New instat.ucrCheck()
        Me.ucrChkMissingValues = New instat.ucrCheck()
        Me.rdoMin = New System.Windows.Forms.RadioButton()
        Me.rdoMax = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMaxMin = New instat.UcrPanel()
        Me.ucrChkFirstDate = New instat.ucrCheck()
        Me.lblValues = New System.Windows.Forms.Label()
        Me.cmdDoyRange = New System.Windows.Forms.Button()
        Me.rdoMinMax = New System.Windows.Forms.RadioButton()
        Me.rdoPeaks = New System.Windows.Forms.RadioButton()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.lblNewDFName = New System.Windows.Forms.Label()
        Me.grpPeakOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputThresholdValue = New instat.ucrInputTextBox()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblThresholdColumns = New System.Windows.Forms.Label()
        Me.lblThresholds = New System.Windows.Forms.Label()
        Me.lblAlpha = New System.Windows.Forms.Label()
        Me.lblDistribution = New System.Windows.Forms.Label()
        Me.rdoMrlPlot = New System.Windows.Forms.RadioButton()
        Me.rdoThreshRangePlot = New System.Windows.Forms.RadioButton()
        Me.grpThresholdOptions = New System.Windows.Forms.GroupBox()
        Me.grpMrlOptions = New System.Windows.Forms.GroupBox()
        Me.ucrInputMin = New instat.ucrInputTextBox()
        Me.ucrChkRugPlot = New instat.ucrCheck()
        Me.ucrInputMax = New instat.ucrInputTextBox()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.rdoThreshold = New System.Windows.Forms.RadioButton()
        Me.ttpThreshold = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDeclusterColumns = New System.Windows.Forms.Label()
        Me.grpDeclusteringOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkRunLength = New instat.ucrCheck()
        Me.ucrChkPrintSummary = New instat.ucrCheck()
        Me.ucrChkDeclustering = New instat.ucrCheck()
        Me.ucrInputFilterPreview = New instat.ucrInputTextBox()
        Me.ucrInputSave = New instat.ucrInputTextBox()
        Me.ucrReceiverDOY = New instat.ucrReceiverSingle()
        Me.ucrReceiverYear = New instat.ucrReceiverSingle()
        Me.ucrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverStation = New instat.ucrReceiverSingle()
        Me.ucrReceiverElement = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlExtremesType = New instat.UcrPanel()
        Me.ucrChkDayRange = New instat.ucrCheck()
        Me.rdoStation = New System.Windows.Forms.RadioButton()
        Me.grpMinMaxOptions.SuspendLayout()
        Me.grpPeakOptions.SuspendLayout()
        Me.grpThresholdOptions.SuspendLayout()
        Me.grpMrlOptions.SuspendLayout()
        Me.grpPlots.SuspendLayout()
        Me.grpDeclusteringOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStations
        '
        Me.lblStations.AutoSize = True
        Me.lblStations.Location = New System.Drawing.Point(251, 62)
        Me.lblStations.Name = "lblStations"
        Me.lblStations.Size = New System.Drawing.Size(43, 13)
        Me.lblStations.TabIndex = 5
        Me.lblStations.Text = "Station:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(251, 104)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(251, 146)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 9
        Me.lblYear.Text = "Year:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(251, 189)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayOfYear.TabIndex = 11
        Me.lblDayOfYear.Text = "Day of Year:"
        '
        'grpMinMaxOptions
        '
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkLastDate)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkNDates)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkMissingValues)
        Me.grpMinMaxOptions.Controls.Add(Me.rdoMin)
        Me.grpMinMaxOptions.Controls.Add(Me.rdoMax)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrPnlMaxMin)
        Me.grpMinMaxOptions.Controls.Add(Me.ucrChkFirstDate)
        Me.grpMinMaxOptions.Location = New System.Drawing.Point(10, 228)
        Me.grpMinMaxOptions.Name = "grpMinMaxOptions"
        Me.grpMinMaxOptions.Size = New System.Drawing.Size(210, 173)
        Me.grpMinMaxOptions.TabIndex = 14
        Me.grpMinMaxOptions.TabStop = False
        Me.grpMinMaxOptions.Text = "Options"
        '
        'ucrChkLastDate
        '
        Me.ucrChkLastDate.AutoSize = True
        Me.ucrChkLastDate.Checked = False
        Me.ucrChkLastDate.Location = New System.Drawing.Point(9, 121)
        Me.ucrChkLastDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkLastDate.Name = "ucrChkLastDate"
        Me.ucrChkLastDate.Size = New System.Drawing.Size(195, 27)
        Me.ucrChkLastDate.TabIndex = 13
        '
        'ucrChkNDates
        '
        Me.ucrChkNDates.AutoSize = True
        Me.ucrChkNDates.Checked = False
        Me.ucrChkNDates.Location = New System.Drawing.Point(10, 97)
        Me.ucrChkNDates.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkNDates.Name = "ucrChkNDates"
        Me.ucrChkNDates.Size = New System.Drawing.Size(194, 34)
        Me.ucrChkNDates.TabIndex = 12
        '
        'ucrChkMissingValues
        '
        Me.ucrChkMissingValues.AutoSize = True
        Me.ucrChkMissingValues.Checked = False
        Me.ucrChkMissingValues.Location = New System.Drawing.Point(10, 147)
        Me.ucrChkMissingValues.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkMissingValues.Name = "ucrChkMissingValues"
        Me.ucrChkMissingValues.Size = New System.Drawing.Size(194, 27)
        Me.ucrChkMissingValues.TabIndex = 11
        '
        'rdoMin
        '
        Me.rdoMin.AutoSize = True
        Me.rdoMin.Location = New System.Drawing.Point(10, 24)
        Me.rdoMin.Name = "rdoMin"
        Me.rdoMin.Size = New System.Drawing.Size(101, 17)
        Me.rdoMin.TabIndex = 4
        Me.rdoMin.TabStop = True
        Me.rdoMin.Text = "Minimum Values"
        Me.rdoMin.UseVisualStyleBackColor = True
        '
        'rdoMax
        '
        Me.rdoMax.AutoSize = True
        Me.rdoMax.Location = New System.Drawing.Point(12, 48)
        Me.rdoMax.Name = "rdoMax"
        Me.rdoMax.Size = New System.Drawing.Size(104, 17)
        Me.rdoMax.TabIndex = 9
        Me.rdoMax.TabStop = True
        Me.rdoMax.Text = "Maximum Values"
        Me.rdoMax.UseVisualStyleBackColor = True
        '
        'ucrPnlMaxMin
        '
        Me.ucrPnlMaxMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMaxMin.Location = New System.Drawing.Point(6, 18)
        Me.ucrPnlMaxMin.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlMaxMin.Name = "ucrPnlMaxMin"
        Me.ucrPnlMaxMin.Size = New System.Drawing.Size(131, 49)
        Me.ucrPnlMaxMin.TabIndex = 7
        '
        'ucrChkFirstDate
        '
        Me.ucrChkFirstDate.AutoSize = True
        Me.ucrChkFirstDate.Checked = False
        Me.ucrChkFirstDate.Location = New System.Drawing.Point(10, 73)
        Me.ucrChkFirstDate.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkFirstDate.Name = "ucrChkFirstDate"
        Me.ucrChkFirstDate.Size = New System.Drawing.Size(194, 34)
        Me.ucrChkFirstDate.TabIndex = 0
        '
        'lblValues
        '
        Me.lblValues.AutoSize = True
        Me.lblValues.Location = New System.Drawing.Point(4, 22)
        Me.lblValues.Name = "lblValues"
        Me.lblValues.Size = New System.Drawing.Size(37, 13)
        Me.lblValues.TabIndex = 5
        Me.lblValues.Text = "Value:"
        '
        'cmdDoyRange
        '
        Me.cmdDoyRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoyRange.Location = New System.Drawing.Point(8, 438)
        Me.cmdDoyRange.Name = "cmdDoyRange"
        Me.cmdDoyRange.Size = New System.Drawing.Size(105, 26)
        Me.cmdDoyRange.TabIndex = 17
        Me.cmdDoyRange.Tag = ""
        Me.cmdDoyRange.Text = "Day Range"
        Me.cmdDoyRange.UseVisualStyleBackColor = True
        '
        'rdoMinMax
        '
        Me.rdoMinMax.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMinMax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatAppearance.BorderSize = 2
        Me.rdoMinMax.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMinMax.Location = New System.Drawing.Point(39, 6)
        Me.rdoMinMax.Name = "rdoMinMax"
        Me.rdoMinMax.Size = New System.Drawing.Size(88, 27)
        Me.rdoMinMax.TabIndex = 1
        Me.rdoMinMax.TabStop = True
        Me.rdoMinMax.Text = "Min/Max"
        Me.rdoMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMinMax.UseVisualStyleBackColor = True
        '
        'rdoPeaks
        '
        Me.rdoPeaks.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPeaks.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatAppearance.BorderSize = 2
        Me.rdoPeaks.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPeaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPeaks.Location = New System.Drawing.Point(210, 6)
        Me.rdoPeaks.Name = "rdoPeaks"
        Me.rdoPeaks.Size = New System.Drawing.Size(87, 27)
        Me.rdoPeaks.TabIndex = 3
        Me.rdoPeaks.TabStop = True
        Me.rdoPeaks.Text = "Peaks"
        Me.rdoPeaks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPeaks.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(251, 232)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 13
        Me.lblElement.Text = "Element:"
        '
        'lblNewColName
        '
        Me.lblNewColName.Location = New System.Drawing.Point(16, 470)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(180, 19)
        Me.lblNewColName.TabIndex = 20
        Me.lblNewColName.Text = "New Column Name:"
        '
        'lblNewDFName
        '
        Me.lblNewDFName.AutoSize = True
        Me.lblNewDFName.Location = New System.Drawing.Point(17, 471)
        Me.lblNewDFName.Name = "lblNewDFName"
        Me.lblNewDFName.Size = New System.Drawing.Size(121, 13)
        Me.lblNewDFName.TabIndex = 1
        Me.lblNewDFName.Text = "New Data Frame Name:"
        '
        'grpPeakOptions
        '
        Me.grpPeakOptions.Controls.Add(Me.ucrInputThresholdValue)
        Me.grpPeakOptions.Controls.Add(Me.lblValues)
        Me.grpPeakOptions.Location = New System.Drawing.Point(9, 229)
        Me.grpPeakOptions.Name = "grpPeakOptions"
        Me.grpPeakOptions.Size = New System.Drawing.Size(211, 46)
        Me.grpPeakOptions.TabIndex = 14
        Me.grpPeakOptions.TabStop = False
        Me.grpPeakOptions.Text = "Options"
        '
        'ucrInputThresholdValue
        '
        Me.ucrInputThresholdValue.AddQuotesIfUnrecognised = True
        Me.ucrInputThresholdValue.AutoSize = True
        Me.ucrInputThresholdValue.IsMultiline = False
        Me.ucrInputThresholdValue.IsReadOnly = False
        Me.ucrInputThresholdValue.Location = New System.Drawing.Point(113, 19)
        Me.ucrInputThresholdValue.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputThresholdValue.Name = "ucrInputThresholdValue"
        Me.ucrInputThresholdValue.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputThresholdValue.TabIndex = 0
        '
        'lblFill
        '
        Me.lblFill.AutoSize = True
        Me.lblFill.Location = New System.Drawing.Point(6, 66)
        Me.lblFill.Name = "lblFill"
        Me.lblFill.Size = New System.Drawing.Size(55, 13)
        Me.lblFill.TabIndex = 40
        Me.lblFill.Text = "Fill Colour:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(6, 43)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(63, 13)
        Me.lblColour.TabIndex = 39
        Me.lblColour.Text = "Line Colour:"
        '
        'lblMinimum
        '
        Me.lblMinimum.AutoSize = True
        Me.lblMinimum.Location = New System.Drawing.Point(6, 20)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(33, 13)
        Me.lblMinimum.TabIndex = 34
        Me.lblMinimum.Text = "From:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(126, 20)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 32
        Me.lblTo.Text = "To:"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.Location = New System.Drawing.Point(6, 113)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblColumns.TabIndex = 31
        Me.lblColumns.Text = "Column(s):"
        '
        'lblThresholdColumns
        '
        Me.lblThresholdColumns.AutoSize = True
        Me.lblThresholdColumns.Location = New System.Drawing.Point(6, 108)
        Me.lblThresholdColumns.Name = "lblThresholdColumns"
        Me.lblThresholdColumns.Size = New System.Drawing.Size(56, 13)
        Me.lblThresholdColumns.TabIndex = 33
        Me.lblThresholdColumns.Text = "Column(s):"
        '
        'lblThresholds
        '
        Me.lblThresholds.AutoSize = True
        Me.lblThresholds.Location = New System.Drawing.Point(6, 84)
        Me.lblThresholds.Name = "lblThresholds"
        Me.lblThresholds.Size = New System.Drawing.Size(114, 13)
        Me.lblThresholds.TabIndex = 37
        Me.lblThresholds.Text = "Number of Thresholds:"
        '
        'lblAlpha
        '
        Me.lblAlpha.AutoSize = True
        Me.lblAlpha.Location = New System.Drawing.Point(6, 57)
        Me.lblAlpha.Name = "lblAlpha"
        Me.lblAlpha.Size = New System.Drawing.Size(37, 13)
        Me.lblAlpha.TabIndex = 38
        Me.lblAlpha.Text = "Alpha:"
        '
        'lblDistribution
        '
        Me.lblDistribution.AutoSize = True
        Me.lblDistribution.Location = New System.Drawing.Point(6, 29)
        Me.lblDistribution.Name = "lblDistribution"
        Me.lblDistribution.Size = New System.Drawing.Size(62, 13)
        Me.lblDistribution.TabIndex = 40
        Me.lblDistribution.Text = "Distribution:"
        '
        'rdoMrlPlot
        '
        Me.rdoMrlPlot.AutoSize = True
        Me.rdoMrlPlot.Location = New System.Drawing.Point(14, 16)
        Me.rdoMrlPlot.Name = "rdoMrlPlot"
        Me.rdoMrlPlot.Size = New System.Drawing.Size(107, 17)
        Me.rdoMrlPlot.TabIndex = 42
        Me.rdoMrlPlot.TabStop = True
        Me.rdoMrlPlot.Text = "Mean residual life"
        Me.rdoMrlPlot.UseVisualStyleBackColor = True
        '
        'rdoThreshRangePlot
        '
        Me.rdoThreshRangePlot.AutoSize = True
        Me.rdoThreshRangePlot.Location = New System.Drawing.Point(14, 35)
        Me.rdoThreshRangePlot.Name = "rdoThreshRangePlot"
        Me.rdoThreshRangePlot.Size = New System.Drawing.Size(105, 17)
        Me.rdoThreshRangePlot.TabIndex = 43
        Me.rdoThreshRangePlot.TabStop = True
        Me.rdoThreshRangePlot.Text = "Threshold range "
        Me.rdoThreshRangePlot.UseVisualStyleBackColor = True
        '
        'grpThresholdOptions
        '
        Me.grpThresholdOptions.Controls.Add(Me.lblThresholds)
        Me.grpThresholdOptions.Controls.Add(Me.lblThresholdColumns)
        Me.grpThresholdOptions.Controls.Add(Me.lblAlpha)
        Me.grpThresholdOptions.Controls.Add(Me.lblDistribution)
        Me.grpThresholdOptions.Location = New System.Drawing.Point(10, 297)
        Me.grpThresholdOptions.Name = "grpThresholdOptions"
        Me.grpThresholdOptions.Size = New System.Drawing.Size(210, 141)
        Me.grpThresholdOptions.TabIndex = 44
        Me.grpThresholdOptions.TabStop = False
        Me.grpThresholdOptions.Text = "Options"
        '
        'grpMrlOptions
        '
        Me.grpMrlOptions.Controls.Add(Me.lblColour)
        Me.grpMrlOptions.Controls.Add(Me.lblFill)
        Me.grpMrlOptions.Controls.Add(Me.lblColumns)
        Me.grpMrlOptions.Controls.Add(Me.lblTo)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputMin)
        Me.grpMrlOptions.Controls.Add(Me.ucrChkRugPlot)
        Me.grpMrlOptions.Controls.Add(Me.lblMinimum)
        Me.grpMrlOptions.Controls.Add(Me.ucrInputMax)
        Me.grpMrlOptions.Location = New System.Drawing.Point(10, 300)
        Me.grpMrlOptions.Name = "grpMrlOptions"
        Me.grpMrlOptions.Size = New System.Drawing.Size(273, 139)
        Me.grpMrlOptions.TabIndex = 16
        Me.grpMrlOptions.TabStop = False
        Me.grpMrlOptions.Text = "Options"
        '
        'ucrInputMin
        '
        Me.ucrInputMin.AddQuotesIfUnrecognised = True
        Me.ucrInputMin.AutoSize = True
        Me.ucrInputMin.IsMultiline = False
        Me.ucrInputMin.IsReadOnly = False
        Me.ucrInputMin.Location = New System.Drawing.Point(75, 16)
        Me.ucrInputMin.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputMin.Name = "ucrInputMin"
        Me.ucrInputMin.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputMin.TabIndex = 33
        '
        'ucrChkRugPlot
        '
        Me.ucrChkRugPlot.AutoSize = True
        Me.ucrChkRugPlot.Checked = False
        Me.ucrChkRugPlot.Location = New System.Drawing.Point(9, 88)
        Me.ucrChkRugPlot.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkRugPlot.Name = "ucrChkRugPlot"
        Me.ucrChkRugPlot.Size = New System.Drawing.Size(144, 23)
        Me.ucrChkRugPlot.TabIndex = 38
        '
        'ucrInputMax
        '
        Me.ucrInputMax.AddQuotesIfUnrecognised = True
        Me.ucrInputMax.AutoSize = True
        Me.ucrInputMax.IsMultiline = False
        Me.ucrInputMax.IsReadOnly = False
        Me.ucrInputMax.Location = New System.Drawing.Point(152, 16)
        Me.ucrInputMax.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputMax.Name = "ucrInputMax"
        Me.ucrInputMax.Size = New System.Drawing.Size(43, 21)
        Me.ucrInputMax.TabIndex = 35
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoMrlPlot)
        Me.grpPlots.Controls.Add(Me.rdoThreshRangePlot)
        Me.grpPlots.Controls.Add(Me.ucrPnlPlots)
        Me.grpPlots.Location = New System.Drawing.Point(9, 218)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(211, 65)
        Me.grpPlots.TabIndex = 15
        Me.grpPlots.TabStop = False
        Me.grpPlots.Text = "Plots"
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(12, 13)
        Me.ucrPnlPlots.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(111, 44)
        Me.ucrPnlPlots.TabIndex = 41
        '
        'rdoThreshold
        '
        Me.rdoThreshold.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreshold.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatAppearance.BorderSize = 2
        Me.rdoThreshold.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreshold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreshold.Location = New System.Drawing.Point(125, 6)
        Me.rdoThreshold.Name = "rdoThreshold"
        Me.rdoThreshold.Size = New System.Drawing.Size(87, 27)
        Me.rdoThreshold.TabIndex = 2
        Me.rdoThreshold.TabStop = True
        Me.rdoThreshold.Text = "Threshold "
        Me.rdoThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreshold.UseVisualStyleBackColor = True
        '
        'lblDeclusterColumns
        '
        Me.lblDeclusterColumns.AutoSize = True
        Me.lblDeclusterColumns.Location = New System.Drawing.Point(7, 74)
        Me.lblDeclusterColumns.Name = "lblDeclusterColumns"
        Me.lblDeclusterColumns.Size = New System.Drawing.Size(82, 13)
        Me.lblDeclusterColumns.TabIndex = 51
        Me.lblDeclusterColumns.Text = "Graph Columns:"
        '
        'grpDeclusteringOptions
        '
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrChkRunLength)
        Me.grpDeclusteringOptions.Controls.Add(Me.ucrChkPrintSummary)
        Me.grpDeclusteringOptions.Controls.Add(Me.lblDeclusterColumns)
        Me.grpDeclusteringOptions.Location = New System.Drawing.Point(11, 282)
        Me.grpDeclusteringOptions.Name = "grpDeclusteringOptions"
        Me.grpDeclusteringOptions.Size = New System.Drawing.Size(209, 100)
        Me.grpDeclusteringOptions.TabIndex = 16
        Me.grpDeclusteringOptions.TabStop = False
        Me.grpDeclusteringOptions.Text = "Options"
        '
        'ucrChkRunLength
        '
        Me.ucrChkRunLength.AutoSize = True
        Me.ucrChkRunLength.Checked = False
        Me.ucrChkRunLength.Location = New System.Drawing.Point(7, 20)
        Me.ucrChkRunLength.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkRunLength.Name = "ucrChkRunLength"
        Me.ucrChkRunLength.Size = New System.Drawing.Size(117, 23)
        Me.ucrChkRunLength.TabIndex = 52
        '
        'ucrChkPrintSummary
        '
        Me.ucrChkPrintSummary.AutoSize = True
        Me.ucrChkPrintSummary.Checked = False
        Me.ucrChkPrintSummary.Location = New System.Drawing.Point(7, 47)
        Me.ucrChkPrintSummary.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkPrintSummary.Name = "ucrChkPrintSummary"
        Me.ucrChkPrintSummary.Size = New System.Drawing.Size(149, 27)
        Me.ucrChkPrintSummary.TabIndex = 45
        '
        'ucrChkDeclustering
        '
        Me.ucrChkDeclustering.AutoSize = True
        Me.ucrChkDeclustering.Checked = False
        Me.ucrChkDeclustering.Location = New System.Drawing.Point(251, 282)
        Me.ucrChkDeclustering.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDeclustering.Name = "ucrChkDeclustering"
        Me.ucrChkDeclustering.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkDeclustering.TabIndex = 53
        '
        'ucrInputFilterPreview
        '
        Me.ucrInputFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterPreview.AutoSize = True
        Me.ucrInputFilterPreview.IsMultiline = False
        Me.ucrInputFilterPreview.IsReadOnly = True
        Me.ucrInputFilterPreview.Location = New System.Drawing.Point(115, 442)
        Me.ucrInputFilterPreview.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputFilterPreview.Name = "ucrInputFilterPreview"
        Me.ucrInputFilterPreview.Size = New System.Drawing.Size(231, 22)
        Me.ucrInputFilterPreview.TabIndex = 18
        '
        'ucrInputSave
        '
        Me.ucrInputSave.AddQuotesIfUnrecognised = True
        Me.ucrInputSave.AutoSize = True
        Me.ucrInputSave.IsMultiline = False
        Me.ucrInputSave.IsReadOnly = False
        Me.ucrInputSave.Location = New System.Drawing.Point(203, 469)
        Me.ucrInputSave.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSave.Name = "ucrInputSave"
        Me.ucrInputSave.Size = New System.Drawing.Size(170, 21)
        Me.ucrInputSave.TabIndex = 20
        '
        'ucrReceiverDOY
        '
        Me.ucrReceiverDOY.AutoSize = True
        Me.ucrReceiverDOY.frmParent = Me
        Me.ucrReceiverDOY.Location = New System.Drawing.Point(251, 204)
        Me.ucrReceiverDOY.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDOY.Name = "ucrReceiverDOY"
        Me.ucrReceiverDOY.Selector = Nothing
        Me.ucrReceiverDOY.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDOY.strNcFilePath = ""
        Me.ucrReceiverDOY.TabIndex = 12
        Me.ucrReceiverDOY.ucrSelector = Nothing
        '
        'ucrReceiverYear
        '
        Me.ucrReceiverYear.AutoSize = True
        Me.ucrReceiverYear.frmParent = Me
        Me.ucrReceiverYear.Location = New System.Drawing.Point(251, 161)
        Me.ucrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYear.Name = "ucrReceiverYear"
        Me.ucrReceiverYear.Selector = Nothing
        Me.ucrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverYear.strNcFilePath = ""
        Me.ucrReceiverYear.TabIndex = 10
        Me.ucrReceiverYear.ucrSelector = Nothing
        '
        'ucrReceiverDate
        '
        Me.ucrReceiverDate.AutoSize = True
        Me.ucrReceiverDate.frmParent = Me
        Me.ucrReceiverDate.Location = New System.Drawing.Point(251, 119)
        Me.ucrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDate.Name = "ucrReceiverDate"
        Me.ucrReceiverDate.Selector = Nothing
        Me.ucrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDate.strNcFilePath = ""
        Me.ucrReceiverDate.TabIndex = 8
        Me.ucrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverStation
        '
        Me.ucrReceiverStation.AutoSize = True
        Me.ucrReceiverStation.frmParent = Me
        Me.ucrReceiverStation.Location = New System.Drawing.Point(251, 77)
        Me.ucrReceiverStation.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStation.Name = "ucrReceiverStation"
        Me.ucrReceiverStation.Selector = Nothing
        Me.ucrReceiverStation.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStation.strNcFilePath = ""
        Me.ucrReceiverStation.TabIndex = 6
        Me.ucrReceiverStation.ucrSelector = Nothing
        '
        'ucrReceiverElement
        '
        Me.ucrReceiverElement.AutoSize = True
        Me.ucrReceiverElement.frmParent = Me
        Me.ucrReceiverElement.Location = New System.Drawing.Point(251, 247)
        Me.ucrReceiverElement.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverElement.Name = "ucrReceiverElement"
        Me.ucrReceiverElement.Selector = Nothing
        Me.ucrReceiverElement.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverElement.strNcFilePath = ""
        Me.ucrReceiverElement.TabIndex = 14
        Me.ucrReceiverElement.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 494)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 21
        '
        'ucrPnlExtremesType
        '
        Me.ucrPnlExtremesType.AccessibleDescription = "                              "
        Me.ucrPnlExtremesType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlExtremesType.Location = New System.Drawing.Point(36, 2)
        Me.ucrPnlExtremesType.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlExtremesType.Name = "ucrPnlExtremesType"
        Me.ucrPnlExtremesType.Size = New System.Drawing.Size(359, 37)
        Me.ucrPnlExtremesType.TabIndex = 0
        '
        'ucrChkDayRange
        '
        Me.ucrChkDayRange.AutoSize = True
        Me.ucrChkDayRange.Checked = False
        Me.ucrChkDayRange.Location = New System.Drawing.Point(353, 444)
        Me.ucrChkDayRange.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkDayRange.Name = "ucrChkDayRange"
        Me.ucrChkDayRange.Size = New System.Drawing.Size(80, 23)
        Me.ucrChkDayRange.TabIndex = 54
        '
        'rdoStation
        '
        Me.rdoStation.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStation.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatAppearance.BorderSize = 2
        Me.rdoStation.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStation.Location = New System.Drawing.Point(295, 6)
        Me.rdoStation.Name = "rdoStation"
        Me.rdoStation.Size = New System.Drawing.Size(88, 27)
        Me.rdoStation.TabIndex = 55
        Me.rdoStation.TabStop = True
        Me.rdoStation.Text = "Station"
        Me.rdoStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStation.UseVisualStyleBackColor = True
        '
        'dlgExtremesClimatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(435, 467)
        Me.Controls.Add(Me.rdoStation)
        Me.Controls.Add(Me.ucrChkDayRange)
        Me.Controls.Add(Me.ucrChkDeclustering)
        Me.Controls.Add(Me.grpDeclusteringOptions)
        Me.Controls.Add(Me.grpMrlOptions)
        Me.Controls.Add(Me.grpThresholdOptions)
        Me.Controls.Add(Me.rdoThreshold)
        Me.Controls.Add(Me.grpPeakOptions)
        Me.Controls.Add(Me.cmdDoyRange)
        Me.Controls.Add(Me.ucrInputFilterPreview)
        Me.Controls.Add(Me.lblNewColName)
        Me.Controls.Add(Me.ucrInputSave)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.rdoPeaks)
        Me.Controls.Add(Me.rdoMinMax)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblStations)
        Me.Controls.Add(Me.ucrReceiverDOY)
        Me.Controls.Add(Me.ucrReceiverYear)
        Me.Controls.Add(Me.ucrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverStation)
        Me.Controls.Add(Me.ucrReceiverElement)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlExtremesType)
        Me.Controls.Add(Me.lblNewDFName)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.grpMinMaxOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgExtremesClimatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Extremes "
        Me.grpMinMaxOptions.ResumeLayout(False)
        Me.grpMinMaxOptions.PerformLayout()
        Me.grpPeakOptions.ResumeLayout(False)
        Me.grpPeakOptions.PerformLayout()
        Me.grpThresholdOptions.ResumeLayout(False)
        Me.grpThresholdOptions.PerformLayout()
        Me.grpMrlOptions.ResumeLayout(False)
        Me.grpMrlOptions.PerformLayout()
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.grpDeclusteringOptions.ResumeLayout(False)
        Me.grpDeclusteringOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverStation As ucrReceiverSingle
    Friend WithEvents grpMinMaxOptions As GroupBox
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblStations As Label
    Friend WithEvents ucrReceiverDOY As ucrReceiverSingle
    Friend WithEvents ucrReceiverYear As ucrReceiverSingle
    Friend WithEvents ucrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrPnlExtremesType As UcrPanel
    Friend WithEvents rdoPeaks As RadioButton
    Friend WithEvents rdoMinMax As RadioButton
    Friend WithEvents ucrChkFirstDate As ucrCheck
    Friend WithEvents lblElement As Label
    Friend WithEvents ucrReceiverElement As ucrReceiverSingle
    Friend WithEvents ucrInputSave As ucrInputTextBox
    Friend WithEvents ucrInputThresholdValue As ucrInputTextBox
    Friend WithEvents lblValues As Label
    Friend WithEvents rdoMin As RadioButton
    Friend WithEvents rdoMax As RadioButton
    Friend WithEvents ucrPnlMaxMin As UcrPanel
    Friend WithEvents lblNewColName As Label
    Friend WithEvents ucrChkMissingValues As ucrCheck
    Friend WithEvents lblNewDFName As Label
    Friend WithEvents cmdDoyRange As Button
    Friend WithEvents ucrInputFilterPreview As ucrInputTextBox
    Friend WithEvents ucrChkLastDate As ucrCheck
    Friend WithEvents ucrChkNDates As ucrCheck
    Friend WithEvents grpPeakOptions As GroupBox
    Friend WithEvents lblColumns As Label
    Friend WithEvents ucrInputMax As ucrInputTextBox
    Friend WithEvents lblMinimum As Label
    Friend WithEvents ucrInputMin As ucrInputTextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrChkRugPlot As ucrCheck
    Friend WithEvents lblFill As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblThresholdColumns As Label
    Friend WithEvents lblAlpha As Label
    Friend WithEvents lblThresholds As Label
    Friend WithEvents lblDistribution As Label
    Friend WithEvents rdoThreshRangePlot As RadioButton
    Friend WithEvents rdoMrlPlot As RadioButton
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents grpMrlOptions As GroupBox
    Friend WithEvents grpThresholdOptions As GroupBox
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoThreshold As RadioButton
    Friend WithEvents ttpThreshold As ToolTip
    Friend WithEvents ucrChkPrintSummary As ucrCheck
    Friend WithEvents lblDeclusterColumns As Label
    Friend WithEvents grpDeclusteringOptions As GroupBox
    Friend WithEvents ucrChkRunLength As ucrCheck
    Friend WithEvents ucrChkDeclustering As ucrCheck
    Friend WithEvents ucrChkDayRange As ucrCheck
    Friend WithEvents rdoStation As RadioButton
End Class
