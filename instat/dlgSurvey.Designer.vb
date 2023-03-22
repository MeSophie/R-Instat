<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSurvey
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rdoClustered = New System.Windows.Forms.RadioButton()
        Me.rdoStratified = New System.Windows.Forms.RadioButton()
        Me.rdoSRS = New System.Windows.Forms.RadioButton()
        Me.lblFPC = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblStrata = New System.Windows.Forms.Label()
        Me.lblSummaryStatistics = New System.Windows.Forms.Label()
        Me.lblPlotType = New System.Windows.Forms.Label()
        Me.lblModelType = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblVar1 = New System.Windows.Forms.Label()
        Me.ucrReceiverVar1 = New instat.ucrReceiverSingle()
        Me.ucrVariablesAsFactorforVar = New instat.ucrVariablesAsFactor()
        Me.ucrInputId = New instat.ucrInputTextBox()
        Me.ucrSelectorSurvey = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverStrata = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkModelPlot = New instat.ucrCheck()
        Me.ucrChkModel = New instat.ucrCheck()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.ucrChkContingencyTables = New instat.ucrCheck()
        Me.ucrChkRatios = New instat.ucrCheck()
        Me.ucrChkTests = New instat.ucrCheck()
        Me.ucrChkModelSummary = New instat.ucrCheck()
        Me.ucrInputPlotType = New instat.ucrInputComboBox()
        Me.ucrInputModelType = New instat.ucrInputComboBox()
        Me.ucrInputSummaryStat = New instat.ucrInputComboBox()
        Me.ucrReceiverFPC = New instat.ucrReceiverSingle()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoClustered
        '
        Me.rdoClustered.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoClustered.BackColor = System.Drawing.SystemColors.Control
        Me.rdoClustered.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatAppearance.BorderSize = 2
        Me.rdoClustered.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoClustered.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoClustered.Location = New System.Drawing.Point(257, 13)
        Me.rdoClustered.Name = "rdoClustered"
        Me.rdoClustered.Size = New System.Drawing.Size(84, 28)
        Me.rdoClustered.TabIndex = 7
        Me.rdoClustered.TabStop = True
        Me.rdoClustered.Tag = "linepathstep"
        Me.rdoClustered.Text = "CLUSTERED"
        Me.rdoClustered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoClustered.UseVisualStyleBackColor = False
        '
        'rdoStratified
        '
        Me.rdoStratified.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStratified.BackColor = System.Drawing.SystemColors.Control
        Me.rdoStratified.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatAppearance.BorderSize = 2
        Me.rdoStratified.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStratified.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStratified.Location = New System.Drawing.Point(175, 13)
        Me.rdoStratified.Name = "rdoStratified"
        Me.rdoStratified.Size = New System.Drawing.Size(84, 28)
        Me.rdoStratified.TabIndex = 6
        Me.rdoStratified.TabStop = True
        Me.rdoStratified.Tag = "Smooth"
        Me.rdoStratified.Text = "STRATIFIED"
        Me.rdoStratified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStratified.UseVisualStyleBackColor = False
        '
        'rdoSRS
        '
        Me.rdoSRS.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSRS.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSRS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.FlatAppearance.BorderSize = 2
        Me.rdoSRS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSRS.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSRS.Location = New System.Drawing.Point(93, 13)
        Me.rdoSRS.Name = "rdoSRS"
        Me.rdoSRS.Size = New System.Drawing.Size(84, 28)
        Me.rdoSRS.TabIndex = 5
        Me.rdoSRS.TabStop = True
        Me.rdoSRS.Tag = "linepathstep"
        Me.rdoSRS.Text = "SRS"
        Me.rdoSRS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSRS.UseVisualStyleBackColor = False
        '
        'lblFPC
        '
        Me.lblFPC.AutoSize = True
        Me.lblFPC.Location = New System.Drawing.Point(275, 60)
        Me.lblFPC.Name = "lblFPC"
        Me.lblFPC.Size = New System.Drawing.Size(112, 13)
        Me.lblFPC.TabIndex = 23
        Me.lblFPC.Text = "FPC (Population Zise):"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(275, 99)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(74, 13)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "Id (Cluster Ids)"
        '
        'lblStrata
        '
        Me.lblStrata.AutoSize = True
        Me.lblStrata.Location = New System.Drawing.Point(275, 176)
        Me.lblStrata.Name = "lblStrata"
        Me.lblStrata.Size = New System.Drawing.Size(38, 13)
        Me.lblStrata.TabIndex = 25
        Me.lblStrata.Text = "Strata:"
        '
        'lblSummaryStatistics
        '
        Me.lblSummaryStatistics.AutoSize = True
        Me.lblSummaryStatistics.Location = New System.Drawing.Point(12, 410)
        Me.lblSummaryStatistics.Name = "lblSummaryStatistics"
        Me.lblSummaryStatistics.Size = New System.Drawing.Size(95, 13)
        Me.lblSummaryStatistics.TabIndex = 26
        Me.lblSummaryStatistics.Text = "Summary Statistics"
        '
        'lblPlotType
        '
        Me.lblPlotType.AutoSize = True
        Me.lblPlotType.Location = New System.Drawing.Point(12, 448)
        Me.lblPlotType.Name = "lblPlotType"
        Me.lblPlotType.Size = New System.Drawing.Size(52, 13)
        Me.lblPlotType.TabIndex = 27
        Me.lblPlotType.Text = "Plot Type"
        '
        'lblModelType
        '
        Me.lblModelType.AutoSize = True
        Me.lblModelType.Location = New System.Drawing.Point(275, 410)
        Me.lblModelType.Name = "lblModelType"
        Me.lblModelType.Size = New System.Drawing.Size(63, 13)
        Me.lblModelType.TabIndex = 28
        Me.lblModelType.Text = "Model Type"
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.Location = New System.Drawing.Point(275, 138)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(49, 13)
        Me.lblWeights.TabIndex = 31
        Me.lblWeights.Text = "Weights:"
        '
        'lblVar1
        '
        Me.lblVar1.AutoSize = True
        Me.lblVar1.Location = New System.Drawing.Point(272, 213)
        Me.lblVar1.Name = "lblVar1"
        Me.lblVar1.Size = New System.Drawing.Size(32, 13)
        Me.lblVar1.TabIndex = 36
        Me.lblVar1.Text = "Var1:"
        '
        'ucrReceiverVar1
        '
        Me.ucrReceiverVar1.AutoSize = True
        Me.ucrReceiverVar1.frmParent = Me
        Me.ucrReceiverVar1.Location = New System.Drawing.Point(272, 228)
        Me.ucrReceiverVar1.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverVar1.Name = "ucrReceiverVar1"
        Me.ucrReceiverVar1.Selector = Nothing
        Me.ucrReceiverVar1.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverVar1.strNcFilePath = ""
        Me.ucrReceiverVar1.TabIndex = 37
        Me.ucrReceiverVar1.ucrSelector = Nothing
        '
        'ucrVariablesAsFactorforVar
        '
        Me.ucrVariablesAsFactorforVar.AutoSize = True
        Me.ucrVariablesAsFactorforVar.frmParent = Me
        Me.ucrVariablesAsFactorforVar.Location = New System.Drawing.Point(275, 261)
        Me.ucrVariablesAsFactorforVar.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrVariablesAsFactorforVar.Name = "ucrVariablesAsFactorforVar"
        Me.ucrVariablesAsFactorforVar.Selector = Nothing
        Me.ucrVariablesAsFactorforVar.Size = New System.Drawing.Size(137, 108)
        Me.ucrVariablesAsFactorforVar.strNcFilePath = ""
        Me.ucrVariablesAsFactorforVar.TabIndex = 35
        Me.ucrVariablesAsFactorforVar.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforVar.ucrVariableSelector = Nothing
        '
        'ucrInputId
        '
        Me.ucrInputId.AddQuotesIfUnrecognised = True
        Me.ucrInputId.AutoSize = True
        Me.ucrInputId.IsMultiline = False
        Me.ucrInputId.IsReadOnly = False
        Me.ucrInputId.Location = New System.Drawing.Point(278, 116)
        Me.ucrInputId.Name = "ucrInputId"
        Me.ucrInputId.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputId.TabIndex = 34
        '
        'ucrSelectorSurvey
        '
        Me.ucrSelectorSurvey.AutoSize = True
        Me.ucrSelectorSurvey.bDropUnusedFilterLevels = False
        Me.ucrSelectorSurvey.bShowHiddenColumns = False
        Me.ucrSelectorSurvey.bUseCurrentFilter = True
        Me.ucrSelectorSurvey.Location = New System.Drawing.Point(25, 60)
        Me.ucrSelectorSurvey.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSurvey.Name = "ucrSelectorSurvey"
        Me.ucrSelectorSurvey.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSurvey.TabIndex = 33
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(275, 153)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 32
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverStrata
        '
        Me.ucrReceiverStrata.AutoSize = True
        Me.ucrReceiverStrata.frmParent = Me
        Me.ucrReceiverStrata.Location = New System.Drawing.Point(275, 191)
        Me.ucrReceiverStrata.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStrata.Name = "ucrReceiverStrata"
        Me.ucrReceiverStrata.Selector = Nothing
        Me.ucrReceiverStrata.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverStrata.strNcFilePath = ""
        Me.ucrReceiverStrata.TabIndex = 30
        Me.ucrReceiverStrata.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 563)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 22
        '
        'ucrChkModelPlot
        '
        Me.ucrChkModelPlot.AutoSize = True
        Me.ucrChkModelPlot.Checked = False
        Me.ucrChkModelPlot.Location = New System.Drawing.Point(275, 491)
        Me.ucrChkModelPlot.Name = "ucrChkModelPlot"
        Me.ucrChkModelPlot.Size = New System.Drawing.Size(137, 23)
        Me.ucrChkModelPlot.TabIndex = 21
        '
        'ucrChkModel
        '
        Me.ucrChkModel.AutoSize = True
        Me.ucrChkModel.Checked = False
        Me.ucrChkModel.Location = New System.Drawing.Point(275, 384)
        Me.ucrChkModel.Name = "ucrChkModel"
        Me.ucrChkModel.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkModel.TabIndex = 20
        '
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(12, 384)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSummary.TabIndex = 19
        '
        'ucrChkContingencyTables
        '
        Me.ucrChkContingencyTables.AutoSize = True
        Me.ucrChkContingencyTables.Checked = False
        Me.ucrChkContingencyTables.Location = New System.Drawing.Point(275, 522)
        Me.ucrChkContingencyTables.Name = "ucrChkContingencyTables"
        Me.ucrChkContingencyTables.Size = New System.Drawing.Size(137, 23)
        Me.ucrChkContingencyTables.TabIndex = 18
        '
        'ucrChkRatios
        '
        Me.ucrChkRatios.AutoSize = True
        Me.ucrChkRatios.Checked = False
        Me.ucrChkRatios.Location = New System.Drawing.Point(12, 522)
        Me.ucrChkRatios.Name = "ucrChkRatios"
        Me.ucrChkRatios.Size = New System.Drawing.Size(137, 23)
        Me.ucrChkRatios.TabIndex = 17
        '
        'ucrChkTests
        '
        Me.ucrChkTests.AutoSize = True
        Me.ucrChkTests.Checked = False
        Me.ucrChkTests.Location = New System.Drawing.Point(12, 491)
        Me.ucrChkTests.Name = "ucrChkTests"
        Me.ucrChkTests.Size = New System.Drawing.Size(137, 23)
        Me.ucrChkTests.TabIndex = 16
        '
        'ucrChkModelSummary
        '
        Me.ucrChkModelSummary.AutoSize = True
        Me.ucrChkModelSummary.Checked = False
        Me.ucrChkModelSummary.Location = New System.Drawing.Point(275, 464)
        Me.ucrChkModelSummary.Name = "ucrChkModelSummary"
        Me.ucrChkModelSummary.Size = New System.Drawing.Size(137, 23)
        Me.ucrChkModelSummary.TabIndex = 15
        '
        'ucrInputPlotType
        '
        Me.ucrInputPlotType.AddQuotesIfUnrecognised = True
        Me.ucrInputPlotType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPlotType.GetSetSelectedIndex = -1
        Me.ucrInputPlotType.IsReadOnly = False
        Me.ucrInputPlotType.Location = New System.Drawing.Point(12, 464)
        Me.ucrInputPlotType.Name = "ucrInputPlotType"
        Me.ucrInputPlotType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPlotType.TabIndex = 14
        '
        'ucrInputModelType
        '
        Me.ucrInputModelType.AddQuotesIfUnrecognised = True
        Me.ucrInputModelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputModelType.GetSetSelectedIndex = -1
        Me.ucrInputModelType.IsReadOnly = False
        Me.ucrInputModelType.Location = New System.Drawing.Point(275, 426)
        Me.ucrInputModelType.Name = "ucrInputModelType"
        Me.ucrInputModelType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputModelType.TabIndex = 13
        '
        'ucrInputSummaryStat
        '
        Me.ucrInputSummaryStat.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaryStat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummaryStat.GetSetSelectedIndex = -1
        Me.ucrInputSummaryStat.IsReadOnly = False
        Me.ucrInputSummaryStat.Location = New System.Drawing.Point(12, 426)
        Me.ucrInputSummaryStat.Name = "ucrInputSummaryStat"
        Me.ucrInputSummaryStat.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSummaryStat.TabIndex = 12
        '
        'ucrReceiverFPC
        '
        Me.ucrReceiverFPC.AutoSize = True
        Me.ucrReceiverFPC.frmParent = Me
        Me.ucrReceiverFPC.Location = New System.Drawing.Point(275, 76)
        Me.ucrReceiverFPC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFPC.Name = "ucrReceiverFPC"
        Me.ucrReceiverFPC.Selector = Nothing
        Me.ucrReceiverFPC.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverFPC.strNcFilePath = ""
        Me.ucrReceiverFPC.TabIndex = 9
        Me.ucrReceiverFPC.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        Me.ucrPnlMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMethod.Location = New System.Drawing.Point(12, 12)
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        Me.ucrPnlMethod.Size = New System.Drawing.Size(375, 29)
        Me.ucrPnlMethod.TabIndex = 0
        '
        'dlgSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 625)
        Me.Controls.Add(Me.ucrReceiverVar1)
        Me.Controls.Add(Me.lblVar1)
        Me.Controls.Add(Me.ucrVariablesAsFactorforVar)
        Me.Controls.Add(Me.ucrInputId)
        Me.Controls.Add(Me.ucrSelectorSurvey)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.ucrReceiverStrata)
        Me.Controls.Add(Me.lblModelType)
        Me.Controls.Add(Me.lblPlotType)
        Me.Controls.Add(Me.lblSummaryStatistics)
        Me.Controls.Add(Me.lblStrata)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblFPC)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkModelPlot)
        Me.Controls.Add(Me.ucrChkModel)
        Me.Controls.Add(Me.ucrChkSummary)
        Me.Controls.Add(Me.ucrChkContingencyTables)
        Me.Controls.Add(Me.ucrChkRatios)
        Me.Controls.Add(Me.ucrChkTests)
        Me.Controls.Add(Me.ucrChkModelSummary)
        Me.Controls.Add(Me.ucrInputPlotType)
        Me.Controls.Add(Me.ucrInputModelType)
        Me.Controls.Add(Me.ucrInputSummaryStat)
        Me.Controls.Add(Me.ucrReceiverFPC)
        Me.Controls.Add(Me.rdoClustered)
        Me.Controls.Add(Me.rdoStratified)
        Me.Controls.Add(Me.rdoSRS)
        Me.Controls.Add(Me.ucrPnlMethod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSurvey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Survey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrPnlMethod As UcrPanel
    Friend WithEvents rdoClustered As RadioButton
    Friend WithEvents rdoStratified As RadioButton
    Friend WithEvents rdoSRS As RadioButton
    Friend WithEvents ucrReceiverFPC As ucrReceiverSingle
    Friend WithEvents ucrChkModelPlot As ucrCheck
    Friend WithEvents ucrChkModel As ucrCheck
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents ucrChkContingencyTables As ucrCheck
    Friend WithEvents ucrChkRatios As ucrCheck
    Friend WithEvents ucrChkTests As ucrCheck
    Friend WithEvents ucrChkModelSummary As ucrCheck
    Friend WithEvents ucrInputPlotType As ucrInputComboBox
    Friend WithEvents ucrInputModelType As ucrInputComboBox
    Friend WithEvents ucrInputSummaryStat As ucrInputComboBox
    Friend WithEvents ucrReceiverStrata As ucrReceiverSingle
    Friend WithEvents lblModelType As Label
    Friend WithEvents lblPlotType As Label
    Friend WithEvents lblSummaryStatistics As Label
    Friend WithEvents lblStrata As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblFPC As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrSelectorSurvey As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputId As ucrInputTextBox
    Friend WithEvents ucrVariablesAsFactorforVar As ucrVariablesAsFactor
    Friend WithEvents ucrReceiverVar1 As ucrReceiverSingle
    Friend WithEvents lblVar1 As Label
End Class
