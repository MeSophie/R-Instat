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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgSurvey))
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
        Me.lblInputID = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'rdoClustered
        '
        resources.ApplyResources(Me.rdoClustered, "rdoClustered")
        Me.rdoClustered.BackColor = System.Drawing.SystemColors.Control
        Me.rdoClustered.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.FlatAppearance.BorderSize = 2
        Me.rdoClustered.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoClustered.Name = "rdoClustered"
        Me.rdoClustered.TabStop = True
        Me.rdoClustered.Tag = "linepathstep"
        Me.rdoClustered.UseVisualStyleBackColor = False
        '
        'rdoStratified
        '
        resources.ApplyResources(Me.rdoStratified, "rdoStratified")
        Me.rdoStratified.BackColor = System.Drawing.SystemColors.Control
        Me.rdoStratified.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.FlatAppearance.BorderSize = 2
        Me.rdoStratified.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStratified.Name = "rdoStratified"
        Me.rdoStratified.TabStop = True
        Me.rdoStratified.Tag = "Smooth"
        Me.rdoStratified.UseVisualStyleBackColor = False
        '
        'rdoSRS
        '
        resources.ApplyResources(Me.rdoSRS, "rdoSRS")
        Me.rdoSRS.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSRS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.FlatAppearance.BorderSize = 2
        Me.rdoSRS.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSRS.Name = "rdoSRS"
        Me.rdoSRS.TabStop = True
        Me.rdoSRS.Tag = "linepathstep"
        Me.rdoSRS.UseVisualStyleBackColor = False
        '
        'lblFPC
        '
        resources.ApplyResources(Me.lblFPC, "lblFPC")
        Me.lblFPC.Name = "lblFPC"
        '
        'lblId
        '
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.Name = "lblId"
        '
        'lblStrata
        '
        resources.ApplyResources(Me.lblStrata, "lblStrata")
        Me.lblStrata.Name = "lblStrata"
        '
        'lblSummaryStatistics
        '
        resources.ApplyResources(Me.lblSummaryStatistics, "lblSummaryStatistics")
        Me.lblSummaryStatistics.Name = "lblSummaryStatistics"
        '
        'lblWeights
        '
        resources.ApplyResources(Me.lblWeights, "lblWeights")
        Me.lblWeights.Name = "lblWeights"
        '
        'lblXFormular
        '
        resources.ApplyResources(Me.lblXFormular, "lblXFormular")
        Me.lblXFormular.Name = "lblXFormular"
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'lblMultipleId
        '
        resources.ApplyResources(Me.lblMultipleId, "lblMultipleId")
        Me.lblMultipleId.Name = "lblMultipleId"
        '
        'lblMultipleFPC
        '
        resources.ApplyResources(Me.lblMultipleFPC, "lblMultipleFPC")
        Me.lblMultipleFPC.Name = "lblMultipleFPC"
        '
        'lblInputID
        '
        resources.ApplyResources(Me.lblInputID, "lblInputID")
        Me.lblInputID.Name = "lblInputID"
        '
        'ucrChkMultistageSampling
        '
        resources.ApplyResources(Me.ucrChkMultistageSampling, "ucrChkMultistageSampling")
        Me.ucrChkMultistageSampling.Checked = False
        Me.ucrChkMultistageSampling.Name = "ucrChkMultistageSampling"
        '
        'ucrSelectorSurvey
        '
        resources.ApplyResources(Me.ucrSelectorSurvey, "ucrSelectorSurvey")
        Me.ucrSelectorSurvey.bDropUnusedFilterLevels = False
        Me.ucrSelectorSurvey.bShowHiddenColumns = False
        Me.ucrSelectorSurvey.bUseCurrentFilter = True
        Me.ucrSelectorSurvey.Name = "ucrSelectorSurvey"
        '
        'ucrReceiverWeights
        '
        resources.ApplyResources(Me.ucrReceiverWeights, "ucrReceiverWeights")
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverStrata
        '
        resources.ApplyResources(Me.ucrReceiverStrata, "ucrReceiverStrata")
        Me.ucrReceiverStrata.frmParent = Me
        Me.ucrReceiverStrata.Name = "ucrReceiverStrata"
        Me.ucrReceiverStrata.Selector = Nothing
        Me.ucrReceiverStrata.strNcFilePath = ""
        Me.ucrReceiverStrata.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrChkSummary
        '
        resources.ApplyResources(Me.ucrChkSummary, "ucrChkSummary")
        Me.ucrChkSummary.Checked = False
        Me.ucrChkSummary.Name = "ucrChkSummary"
        '
        'ucrInputSummaryStat
        '
        Me.ucrInputSummaryStat.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputSummaryStat, "ucrInputSummaryStat")
        Me.ucrInputSummaryStat.GetSetSelectedIndex = -1
        Me.ucrInputSummaryStat.IsReadOnly = False
        Me.ucrInputSummaryStat.Name = "ucrInputSummaryStat"
        '
        'ucrReceiverFPC
        '
        resources.ApplyResources(Me.ucrReceiverFPC, "ucrReceiverFPC")
        Me.ucrReceiverFPC.frmParent = Me
        Me.ucrReceiverFPC.Name = "ucrReceiverFPC"
        Me.ucrReceiverFPC.Selector = Nothing
        Me.ucrReceiverFPC.strNcFilePath = ""
        Me.ucrReceiverFPC.ucrSelector = Nothing
        '
        'ucrPnlMethod
        '
        resources.ApplyResources(Me.ucrPnlMethod, "ucrPnlMethod")
        Me.ucrPnlMethod.Name = "ucrPnlMethod"
        '
        'ucrReceiverMultipleVar2
        '
        resources.ApplyResources(Me.ucrReceiverMultipleVar2, "ucrReceiverMultipleVar2")
        Me.ucrReceiverMultipleVar2.frmParent = Me
        Me.ucrReceiverMultipleVar2.Name = "ucrReceiverMultipleVar2"
        Me.ucrReceiverMultipleVar2.Selector = Nothing
        Me.ucrReceiverMultipleVar2.strNcFilePath = ""
        Me.ucrReceiverMultipleVar2.ucrSelector = Nothing
        '
        'ucrReceiverMultipleId
        '
        resources.ApplyResources(Me.ucrReceiverMultipleId, "ucrReceiverMultipleId")
        Me.ucrReceiverMultipleId.frmParent = Me
        Me.ucrReceiverMultipleId.Name = "ucrReceiverMultipleId"
        Me.ucrReceiverMultipleId.Selector = Nothing
        Me.ucrReceiverMultipleId.strNcFilePath = ""
        Me.ucrReceiverMultipleId.ucrSelector = Nothing
        '
        'ucrInputId
        '
        Me.ucrInputId.AddQuotesIfUnrecognised = True
        resources.ApplyResources(Me.ucrInputId, "ucrInputId")
        Me.ucrInputId.IsMultiline = False
        Me.ucrInputId.IsReadOnly = False
        Me.ucrInputId.Name = "ucrInputId"
        '
        'ucrReceiverSingleID
        '
        resources.ApplyResources(Me.ucrReceiverSingleID, "ucrReceiverSingleID")
        Me.ucrReceiverSingleID.frmParent = Me
        Me.ucrReceiverSingleID.Name = "ucrReceiverSingleID"
        Me.ucrReceiverSingleID.Selector = Nothing
        Me.ucrReceiverSingleID.strNcFilePath = ""
        Me.ucrReceiverSingleID.ucrSelector = Nothing
        '
        'ucrReceiverMultipleFPC
        '
        resources.ApplyResources(Me.ucrReceiverMultipleFPC, "ucrReceiverMultipleFPC")
        Me.ucrReceiverMultipleFPC.frmParent = Me
        Me.ucrReceiverMultipleFPC.Name = "ucrReceiverMultipleFPC"
        Me.ucrReceiverMultipleFPC.Selector = Nothing
        Me.ucrReceiverMultipleFPC.strNcFilePath = ""
        Me.ucrReceiverMultipleFPC.ucrSelector = Nothing
        '
        'dlgSurvey
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.ucrInputId)
        Me.Controls.Add(Me.ucrReceiverSingleID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblMultipleFPC)
        Me.Controls.Add(Me.lblInputID)
        Me.Controls.Add(Me.ucrReceiverMultipleFPC)
        Me.Controls.Add(Me.ucrReceiverMultipleId)
        Me.Controls.Add(Me.lblMultipleId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSurvey"
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
