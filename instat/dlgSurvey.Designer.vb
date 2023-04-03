<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgSurvey
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoClustered = New System.Windows.Forms.RadioButton()
        Me.rdoStratified = New System.Windows.Forms.RadioButton()
        Me.rdoSRS = New System.Windows.Forms.RadioButton()
        Me.lblFPC = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblStrata = New System.Windows.Forms.Label()
        Me.lblSummaryStatistics = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblXFormular = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblMultipleId = New System.Windows.Forms.Label()
        Me.lblMultipleFPC = New System.Windows.Forms.Label()
        Me.ucrChkMultistageSampling = New instat.ucrCheck()
        Me.ucrSelectorSurvey = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverStrata = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSummary = New instat.ucrCheck()
        Me.ucrInputSummaryStat = New instat.ucrInputComboBox()
        Me.ucrReceiverFPC = New instat.ucrReceiverSingle()
        Me.ucrPnlMethod = New instat.UcrPanel()
        Me.ucrReceiverMultipleVar2 = New instat.ucrReceiverMultiple()
        Me.ucrReceiverMultipleId = New instat.ucrReceiverMultiple()
        Me.ucrInputId = New instat.ucrInputTextBox()
        Me.ucrReceiverSingleID = New instat.ucrReceiverSingle()
        Me.ucrReceiverMultipleFPC = New instat.ucrReceiverMultiple()
        Me.lblInputID = New System.Windows.Forms.Label()
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
        Me.lblId.Size = New System.Drawing.Size(69, 13)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "Ids(Numeric):"
        '
        'lblStrata
        '
        Me.lblStrata.AutoSize = True
        Me.lblStrata.Location = New System.Drawing.Point(275, 176)
        Me.lblStrata.Name = "lblStrata"
        Me.lblStrata.Size = New System.Drawing.Size(74, 13)
        Me.lblStrata.TabIndex = 25
        Me.lblStrata.Text = "Strata(Factor):"
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
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.Location = New System.Drawing.Point(275, 138)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(49, 13)
        Me.lblWeights.TabIndex = 31
        Me.lblWeights.Text = "Weights:"
        '
        'lblXFormular
        '
        Me.lblXFormular.AutoSize = True
        Me.lblXFormular.Location = New System.Drawing.Point(272, 298)
        Me.lblXFormular.Name = "lblXFormular"
        Me.lblXFormular.Size = New System.Drawing.Size(59, 13)
        Me.lblXFormular.TabIndex = 39
        Me.lblXFormular.Text = "X/Formula:"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(275, 298)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 41
        Me.lblFactor.Text = "Factor:"
        '
        'lblMultipleId
        '
        Me.lblMultipleId.AutoSize = True
        Me.lblMultipleId.Location = New System.Drawing.Point(275, 155)
        Me.lblMultipleId.Name = "lblMultipleId"
        Me.lblMultipleId.Size = New System.Drawing.Size(69, 13)
        Me.lblMultipleId.TabIndex = 50
        Me.lblMultipleId.Text = "Ids(Numeric):"
        '
        'lblMultipleFPC
        '
        Me.lblMultipleFPC.AutoSize = True
        Me.lblMultipleFPC.Location = New System.Drawing.Point(275, 60)
        Me.lblMultipleFPC.Name = "lblMultipleFPC"
        Me.lblMultipleFPC.Size = New System.Drawing.Size(112, 13)
        Me.lblMultipleFPC.TabIndex = 51
        Me.lblMultipleFPC.Text = "FPC (Population Zise):"
        '
        'ucrChkMultistageSampling
        '
        Me.ucrChkMultistageSampling.AutoSize = True
        Me.ucrChkMultistageSampling.Checked = False
        Me.ucrChkMultistageSampling.Location = New System.Drawing.Point(25, 267)
        Me.ucrChkMultistageSampling.Name = "ucrChkMultistageSampling"
        Me.ucrChkMultistageSampling.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkMultistageSampling.TabIndex = 46
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
        'ucrChkSummary
        '
        Me.ucrChkSummary.AutoSize = True
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Location = New System.Drawing.Point(12, 384)
        Me.ucrChkSummary.Name = "ucrChkSummary"
        Me.ucrChkSummary.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSummary.TabIndex = 19
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
        'ucrReceiverMultipleVar2
        '
        Me.ucrReceiverMultipleVar2.AutoSize = True
        Me.ucrReceiverMultipleVar2.frmParent = Me
        Me.ucrReceiverMultipleVar2.Location = New System.Drawing.Point(272, 311)
        Me.ucrReceiverMultipleVar2.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleVar2.Name = "ucrReceiverMultipleVar2"
        Me.ucrReceiverMultipleVar2.Selector = Nothing
        Me.ucrReceiverMultipleVar2.Size = New System.Drawing.Size(137, 100)
        Me.ucrReceiverMultipleVar2.strNcFilePath = ""
        Me.ucrReceiverMultipleVar2.TabIndex = 43
        Me.ucrReceiverMultipleVar2.ucrSelector = Nothing
        '
        'ucrReceiverMultipleId
        '
        Me.ucrReceiverMultipleId.AutoSize = True
        Me.ucrReceiverMultipleId.frmParent = Me
        Me.ucrReceiverMultipleId.Location = New System.Drawing.Point(275, 171)
        Me.ucrReceiverMultipleId.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleId.Name = "ucrReceiverMultipleId"
        Me.ucrReceiverMultipleId.Selector = Nothing
        Me.ucrReceiverMultipleId.Size = New System.Drawing.Size(137, 60)
        Me.ucrReceiverMultipleId.strNcFilePath = ""
        Me.ucrReceiverMultipleId.TabIndex = 48
        Me.ucrReceiverMultipleId.ucrSelector = Nothing
        '
        'ucrInputId
        '
        Me.ucrInputId.AddQuotesIfUnrecognised = True
        Me.ucrInputId.AutoSize = True
        Me.ucrInputId.IsMultiline = False
        Me.ucrInputId.IsReadOnly = False
        Me.ucrInputId.Location = New System.Drawing.Point(275, 115)
        Me.ucrInputId.Name = "ucrInputId"
        Me.ucrInputId.Size = New System.Drawing.Size(137, 20)
        Me.ucrInputId.TabIndex = 34
        '
        'ucrReceiverSingleID
        '
        Me.ucrReceiverSingleID.AutoSize = True
        Me.ucrReceiverSingleID.frmParent = Me
        Me.ucrReceiverSingleID.Location = New System.Drawing.Point(275, 115)
        Me.ucrReceiverSingleID.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSingleID.Name = "ucrReceiverSingleID"
        Me.ucrReceiverSingleID.Selector = Nothing
        Me.ucrReceiverSingleID.Size = New System.Drawing.Size(137, 20)
        Me.ucrReceiverSingleID.strNcFilePath = ""
        Me.ucrReceiverSingleID.TabIndex = 49
        Me.ucrReceiverSingleID.ucrSelector = Nothing
        '
        'ucrReceiverMultipleFPC
        '
        Me.ucrReceiverMultipleFPC.AutoSize = True
        Me.ucrReceiverMultipleFPC.frmParent = Me
        Me.ucrReceiverMultipleFPC.Location = New System.Drawing.Point(275, 76)
        Me.ucrReceiverMultipleFPC.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleFPC.Name = "ucrReceiverMultipleFPC"
        Me.ucrReceiverMultipleFPC.Selector = Nothing
        Me.ucrReceiverMultipleFPC.Size = New System.Drawing.Size(137, 75)
        Me.ucrReceiverMultipleFPC.strNcFilePath = ""
        Me.ucrReceiverMultipleFPC.TabIndex = 47
        Me.ucrReceiverMultipleFPC.ucrSelector = Nothing
        '
        'lblInputID
        '
        Me.lblInputID.AutoSize = True
        Me.lblInputID.Location = New System.Drawing.Point(275, 99)
        Me.lblInputID.Name = "lblInputID"
        Me.lblInputID.Size = New System.Drawing.Size(69, 13)
        Me.lblInputID.TabIndex = 52
        Me.lblInputID.Text = "Ids(Numeric):"
        '
        'dlgSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 625)
        Me.Controls.Add(Me.lblMultipleId)
        Me.Controls.Add(Me.ucrChkMultistageSampling)
        Me.Controls.Add(Me.lblXFormular)
        Me.Controls.Add(Me.ucrSelectorSurvey)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.ucrReceiverStrata)
        Me.Controls.Add(Me.lblSummaryStatistics)
        Me.Controls.Add(Me.lblStrata)
        Me.Controls.Add(Me.lblFPC)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrChkSummary)
        Me.Controls.Add(Me.ucrInputSummaryStat)
        Me.Controls.Add(Me.ucrReceiverFPC)
        Me.Controls.Add(Me.rdoClustered)
        Me.Controls.Add(Me.rdoStratified)
        Me.Controls.Add(Me.rdoSRS)
        Me.Controls.Add(Me.ucrPnlMethod)
        Me.Controls.Add(Me.ucrReceiverMultipleVar2)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrReceiverMultipleId)
        Me.Controls.Add(Me.ucrInputId)
        Me.Controls.Add(Me.ucrReceiverSingleID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.ucrReceiverMultipleFPC)
        Me.Controls.Add(Me.lblMultipleFPC)
        Me.Controls.Add(Me.lblInputID)
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
    Friend WithEvents ucrChkSummary As ucrCheck
    Friend WithEvents ucrInputSummaryStat As ucrInputComboBox
    Friend WithEvents ucrReceiverStrata As ucrReceiverSingle
    Friend WithEvents lblSummaryStatistics As Label
    Friend WithEvents lblStrata As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblFPC As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrSelectorSurvey As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputId As ucrInputTextBox
    Friend WithEvents lblXFormular As Label
    Friend WithEvents ucrReceiverMultipleVar2 As ucrReceiverMultiple
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrChkMultistageSampling As ucrCheck
    Friend WithEvents ucrReceiverMultipleId As ucrReceiverMultiple
    Friend WithEvents ucrReceiverMultipleFPC As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSingleID As ucrReceiverSingle
    Friend WithEvents lblMultipleId As Label
    Friend WithEvents lblMultipleFPC As Label
    Friend WithEvents lblInputID As Label
End Class
