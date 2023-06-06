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
Partial Class ucrAxes
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdoSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.grpMajorBreaksDiscrete = New System.Windows.Forms.GroupBox()
        Me.ucrChkLabelsDiscrete = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabelsDiscrete = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksSeqDiscrete = New System.Windows.Forms.RadioButton()
        Me.rdoMajorBreaksCustomDiscrete = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksInStepsOfDiscrete = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksNoneDiscrete = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksToDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputMajorBreaksFromDiscrete = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksAutoDiscrete = New System.Windows.Forms.RadioButton()
        Me.lblMajorBreaksInStepsOfDiscrete = New System.Windows.Forms.Label()
        Me.lblMajorBreaksFromDiscrete = New System.Windows.Forms.Label()
        Me.lblMajorBreaksToDiscrete = New System.Windows.Forms.Label()
        Me.ucrPnlMajorBreaksDiscrete = New instat.UcrPanel()
        Me.ucrInputMajorBreaksCustomDiscrete = New instat.ucrInputTextBox()
        Me.grpMajorBreaks = New System.Windows.Forms.GroupBox()
        Me.ucrChkLabels = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabels = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.rdoMajorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMajorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.lblMajorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMajorBreaksFrom = New System.Windows.Forms.Label()
        Me.lblMajorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMajorBreaks = New instat.UcrPanel()
        Me.ucrInputMajorBreaksCustom = New instat.ucrInputTextBox()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.ucrInputRelaceMissingvalues = New instat.ucrInputTextBox()
        Me.ucrInputExpand = New instat.ucrInputTextBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkExpand = New instat.ucrCheck()
        Me.ucrChkPosition = New instat.ucrCheck()
        Me.ucrChkNaValue = New instat.ucrCheck()
        Me.ucrInputUpperLimit = New instat.ucrInputTextBox()
        Me.ucrInputLowerLimit = New instat.ucrInputTextBox()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.ucrInputTransformation = New instat.ucrInputComboBox()
        Me.ucrChkTransformation = New instat.ucrCheck()
        Me.grpScaleDiscrete = New System.Windows.Forms.GroupBox()
        Me.ucrInputNaValueDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputExpandDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputPositionDiscrete = New instat.ucrInputComboBox()
        Me.ucrChkExpandDiscrete = New instat.ucrCheck()
        Me.ucrChkPositionDiscrete = New instat.ucrCheck()
        Me.ucrChkNaValueDiscrete = New instat.ucrCheck()
        Me.ucrInputUpperLimitDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputLowerLimitDiscrete = New instat.ucrInputTextBox()
        Me.lblUpperLimitDiscrete = New System.Windows.Forms.Label()
        Me.lblLowerLimitDiscrete = New System.Windows.Forms.Label()
        Me.rdoCustomDiscrete = New System.Windows.Forms.RadioButton()
        Me.rdoAutoDiscrete = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScaleDiscrete = New instat.UcrPanel()
        Me.ucrInputDropUnusedLevels = New instat.ucrInputComboBox()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.grpScaleXDate = New System.Windows.Forms.GroupBox()
        Me.ucrInputComboDateLabel = New instat.ucrInputComboBox()
        Me.ucrChkDateLabels = New instat.ucrCheck()
        Me.ucrInputComboDateBreak = New instat.ucrInputComboBox()
        Me.lbXscaleDateLowerLimit = New System.Windows.Forms.Label()
        Me.lblXScalDateUpperLimit = New System.Windows.Forms.Label()
        Me.ucrNudDateBreak = New instat.ucrNud()
        Me.ucrDtpLowerLimit = New instat.ucrDateTimePicker()
        Me.ucrDtpUpperLimit = New instat.ucrDateTimePicker()
        Me.ucrChkLimits = New instat.ucrCheck()
        Me.ucrChkBreaks = New instat.ucrCheck()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.rdoMinorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.rdoMinorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMinorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksCustom = New instat.ucrInputTextBox()
        Me.lblMinorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMinorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMinorBreaks = New instat.UcrPanel()
        Me.grpMinorBreaks = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFrom = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.grpMinorBreaksDiscrete = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFromDiscrete = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksNoneDiscrete = New System.Windows.Forms.RadioButton()
        Me.rdoMinorBreaksAutoDiscrete = New System.Windows.Forms.RadioButton()
        Me.lblMinorBreaksInStepsOfDiscrete = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksSeqDiscrete = New System.Windows.Forms.RadioButton()
        Me.lblMinorBreaksToDiscrete = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksCustomDiscrete = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMinorBreaksDiscrete = New instat.UcrPanel()
        Me.ucrInputMinorBreaksFromDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksInStepsOfDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksToDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksCustomDiscrete = New instat.ucrInputTextBox()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpMajorBreaksDiscrete.SuspendLayout()
        Me.grpMajorBreaks.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.grpScaleDiscrete.SuspendLayout()
        Me.grpScaleXDate.SuspendLayout()
        Me.grpMinorBreaks.SuspendLayout()
        Me.grpMinorBreaksDiscrete.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.lblTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoSpecifyTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoNoTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(3, 1)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(301, 83)
        Me.grpAxisTitle.TabIndex = 0
        Me.grpAxisTitle.TabStop = False
        Me.grpAxisTitle.Text = "Axis Title"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(6, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Title:"
        '
        'rdoSpecifyTitle
        '
        Me.rdoSpecifyTitle.AutoSize = True
        Me.rdoSpecifyTitle.Location = New System.Drawing.Point(93, 21)
        Me.rdoSpecifyTitle.Name = "rdoSpecifyTitle"
        Me.rdoSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoSpecifyTitle.TabIndex = 3
        Me.rdoSpecifyTitle.TabStop = True
        Me.rdoSpecifyTitle.Text = "Specify Title"
        Me.rdoSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoNoTitle
        '
        Me.rdoNoTitle.AutoSize = True
        Me.rdoNoTitle.Location = New System.Drawing.Point(214, 21)
        Me.rdoNoTitle.Name = "rdoNoTitle"
        Me.rdoNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitle.TabIndex = 3
        Me.rdoNoTitle.TabStop = True
        Me.rdoNoTitle.Text = "No Title"
        Me.rdoNoTitle.UseVisualStyleBackColor = True
        '
        'rdoTitleAuto
        '
        Me.rdoTitleAuto.AutoSize = True
        Me.rdoTitleAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoTitleAuto.Name = "rdoTitleAuto"
        Me.rdoTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoTitleAuto.TabIndex = 2
        Me.rdoTitleAuto.TabStop = True
        Me.rdoTitleAuto.Text = "Auto"
        Me.rdoTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(62, 47)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputTitle.TabIndex = 1
        '
        'ucrPnlAxisTitle
        '
        Me.ucrPnlAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlAxisTitle.Location = New System.Drawing.Point(5, 18)
        Me.ucrPnlAxisTitle.Name = "ucrPnlAxisTitle"
        Me.ucrPnlAxisTitle.Size = New System.Drawing.Size(290, 23)
        Me.ucrPnlAxisTitle.TabIndex = 19
        '
        'grpMajorBreaksDiscrete
        '
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrChkLabelsDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksLabelsDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.rdoMajorBreaksSeqDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.rdoMajorBreaksCustomDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksInStepsOfDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.rdoMajorBreaksNoneDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksToDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksFromDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.rdoMajorBreaksAutoDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.lblMajorBreaksInStepsOfDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.lblMajorBreaksFromDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.lblMajorBreaksToDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrPnlMajorBreaksDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksCustomDiscrete)
        Me.grpMajorBreaksDiscrete.Location = New System.Drawing.Point(310, 34)
        Me.grpMajorBreaksDiscrete.Name = "grpMajorBreaksDiscrete"
        Me.grpMajorBreaksDiscrete.Size = New System.Drawing.Size(354, 162)
        Me.grpMajorBreaksDiscrete.TabIndex = 23
        Me.grpMajorBreaksDiscrete.TabStop = False
        Me.grpMajorBreaksDiscrete.Text = "Major Tick Marks"
        '
        'ucrChkLabelsDiscrete
        '
        Me.ucrChkLabelsDiscrete.AutoSize = True
        Me.ucrChkLabelsDiscrete.Checked = False
        Me.ucrChkLabelsDiscrete.Location = New System.Drawing.Point(5, 133)
        Me.ucrChkLabelsDiscrete.Name = "ucrChkLabelsDiscrete"
        Me.ucrChkLabelsDiscrete.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLabelsDiscrete.TabIndex = 22
        '
        'ucrInputMajorBreaksLabelsDiscrete
        '
        Me.ucrInputMajorBreaksLabelsDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabelsDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksLabelsDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksLabelsDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksLabelsDiscrete.Location = New System.Drawing.Point(98, 132)
        Me.ucrInputMajorBreaksLabelsDiscrete.Name = "ucrInputMajorBreaksLabelsDiscrete"
        Me.ucrInputMajorBreaksLabelsDiscrete.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputMajorBreaksLabelsDiscrete.TabIndex = 4
        '
        'rdoMajorBreaksSeqDiscrete
        '
        Me.rdoMajorBreaksSeqDiscrete.AutoSize = True
        Me.rdoMajorBreaksSeqDiscrete.Location = New System.Drawing.Point(98, 21)
        Me.rdoMajorBreaksSeqDiscrete.Name = "rdoMajorBreaksSeqDiscrete"
        Me.rdoMajorBreaksSeqDiscrete.Size = New System.Drawing.Size(74, 17)
        Me.rdoMajorBreaksSeqDiscrete.TabIndex = 21
        Me.rdoMajorBreaksSeqDiscrete.TabStop = True
        Me.rdoMajorBreaksSeqDiscrete.Text = "Sequence"
        Me.rdoMajorBreaksSeqDiscrete.UseVisualStyleBackColor = True
        '
        'rdoMajorBreaksCustomDiscrete
        '
        Me.rdoMajorBreaksCustomDiscrete.AutoSize = True
        Me.rdoMajorBreaksCustomDiscrete.Location = New System.Drawing.Point(179, 21)
        Me.rdoMajorBreaksCustomDiscrete.Name = "rdoMajorBreaksCustomDiscrete"
        Me.rdoMajorBreaksCustomDiscrete.Size = New System.Drawing.Size(60, 17)
        Me.rdoMajorBreaksCustomDiscrete.TabIndex = 20
        Me.rdoMajorBreaksCustomDiscrete.TabStop = True
        Me.rdoMajorBreaksCustomDiscrete.Text = "Custom"
        Me.rdoMajorBreaksCustomDiscrete.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksInStepsOfDiscrete
        '
        Me.ucrInputMajorBreaksInStepsOfDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksInStepsOfDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksInStepsOfDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksInStepsOfDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksInStepsOfDiscrete.Location = New System.Drawing.Point(114, 99)
        Me.ucrInputMajorBreaksInStepsOfDiscrete.Name = "ucrInputMajorBreaksInStepsOfDiscrete"
        Me.ucrInputMajorBreaksInStepsOfDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksInStepsOfDiscrete.TabIndex = 19
        '
        'rdoMajorBreaksNoneDiscrete
        '
        Me.rdoMajorBreaksNoneDiscrete.AutoSize = True
        Me.rdoMajorBreaksNoneDiscrete.Location = New System.Drawing.Point(278, 21)
        Me.rdoMajorBreaksNoneDiscrete.Name = "rdoMajorBreaksNoneDiscrete"
        Me.rdoMajorBreaksNoneDiscrete.Size = New System.Drawing.Size(56, 17)
        Me.rdoMajorBreaksNoneDiscrete.TabIndex = 3
        Me.rdoMajorBreaksNoneDiscrete.TabStop = True
        Me.rdoMajorBreaksNoneDiscrete.Text = "Aucun"
        Me.rdoMajorBreaksNoneDiscrete.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksToDiscrete
        '
        Me.ucrInputMajorBreaksToDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksToDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksToDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksToDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksToDiscrete.Location = New System.Drawing.Point(114, 72)
        Me.ucrInputMajorBreaksToDiscrete.Name = "ucrInputMajorBreaksToDiscrete"
        Me.ucrInputMajorBreaksToDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksToDiscrete.TabIndex = 19
        '
        'ucrInputMajorBreaksFromDiscrete
        '
        Me.ucrInputMajorBreaksFromDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksFromDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksFromDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksFromDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksFromDiscrete.Location = New System.Drawing.Point(114, 46)
        Me.ucrInputMajorBreaksFromDiscrete.Name = "ucrInputMajorBreaksFromDiscrete"
        Me.ucrInputMajorBreaksFromDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksFromDiscrete.TabIndex = 19
        '
        'rdoMajorBreaksAutoDiscrete
        '
        Me.rdoMajorBreaksAutoDiscrete.AutoSize = True
        Me.rdoMajorBreaksAutoDiscrete.Location = New System.Drawing.Point(6, 21)
        Me.rdoMajorBreaksAutoDiscrete.Name = "rdoMajorBreaksAutoDiscrete"
        Me.rdoMajorBreaksAutoDiscrete.Size = New System.Drawing.Size(47, 17)
        Me.rdoMajorBreaksAutoDiscrete.TabIndex = 2
        Me.rdoMajorBreaksAutoDiscrete.TabStop = True
        Me.rdoMajorBreaksAutoDiscrete.Text = "Auto"
        Me.rdoMajorBreaksAutoDiscrete.UseVisualStyleBackColor = True
        '
        'lblMajorBreaksInStepsOfDiscrete
        '
        Me.lblMajorBreaksInStepsOfDiscrete.AutoSize = True
        Me.lblMajorBreaksInStepsOfDiscrete.Location = New System.Drawing.Point(9, 103)
        Me.lblMajorBreaksInStepsOfDiscrete.Name = "lblMajorBreaksInStepsOfDiscrete"
        Me.lblMajorBreaksInStepsOfDiscrete.Size = New System.Drawing.Size(61, 13)
        Me.lblMajorBreaksInStepsOfDiscrete.TabIndex = 9
        Me.lblMajorBreaksInStepsOfDiscrete.Text = "In Steps of:"
        '
        'lblMajorBreaksFromDiscrete
        '
        Me.lblMajorBreaksFromDiscrete.AutoSize = True
        Me.lblMajorBreaksFromDiscrete.Location = New System.Drawing.Point(9, 50)
        Me.lblMajorBreaksFromDiscrete.Name = "lblMajorBreaksFromDiscrete"
        Me.lblMajorBreaksFromDiscrete.Size = New System.Drawing.Size(33, 13)
        Me.lblMajorBreaksFromDiscrete.TabIndex = 5
        Me.lblMajorBreaksFromDiscrete.Text = "From:"
        '
        'lblMajorBreaksToDiscrete
        '
        Me.lblMajorBreaksToDiscrete.AutoSize = True
        Me.lblMajorBreaksToDiscrete.Location = New System.Drawing.Point(9, 75)
        Me.lblMajorBreaksToDiscrete.Name = "lblMajorBreaksToDiscrete"
        Me.lblMajorBreaksToDiscrete.Size = New System.Drawing.Size(23, 13)
        Me.lblMajorBreaksToDiscrete.TabIndex = 6
        Me.lblMajorBreaksToDiscrete.Text = "To:"
        '
        'ucrPnlMajorBreaksDiscrete
        '
        Me.ucrPnlMajorBreaksDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMajorBreaksDiscrete.Location = New System.Drawing.Point(3, 19)
        Me.ucrPnlMajorBreaksDiscrete.Name = "ucrPnlMajorBreaksDiscrete"
        Me.ucrPnlMajorBreaksDiscrete.Size = New System.Drawing.Size(335, 23)
        Me.ucrPnlMajorBreaksDiscrete.TabIndex = 18
        '
        'ucrInputMajorBreaksCustomDiscrete
        '
        Me.ucrInputMajorBreaksCustomDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksCustomDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksCustomDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksCustomDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksCustomDiscrete.Location = New System.Drawing.Point(6, 46)
        Me.ucrInputMajorBreaksCustomDiscrete.Name = "ucrInputMajorBreaksCustomDiscrete"
        Me.ucrInputMajorBreaksCustomDiscrete.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMajorBreaksCustomDiscrete.TabIndex = 15
        '
        'grpMajorBreaks
        '
        Me.grpMajorBreaks.Controls.Add(Me.ucrChkLabels)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksLabels)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksSeq)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksCustom)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksNone)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksAuto)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrPnlMajorBreaks)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksCustom)
        Me.grpMajorBreaks.Location = New System.Drawing.Point(310, 35)
        Me.grpMajorBreaks.Name = "grpMajorBreaks"
        Me.grpMajorBreaks.Size = New System.Drawing.Size(354, 162)
        Me.grpMajorBreaks.TabIndex = 1
        Me.grpMajorBreaks.TabStop = False
        Me.grpMajorBreaks.Text = "Major Tick Marks"
        '
        'ucrChkLabels
        '
        Me.ucrChkLabels.AutoSize = True
        Me.ucrChkLabels.Checked = False
        Me.ucrChkLabels.Location = New System.Drawing.Point(5, 133)
        Me.ucrChkLabels.Name = "ucrChkLabels"
        Me.ucrChkLabels.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLabels.TabIndex = 22
        '
        'ucrInputMajorBreaksLabels
        '
        Me.ucrInputMajorBreaksLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabels.AutoSize = True
        Me.ucrInputMajorBreaksLabels.IsMultiline = False
        Me.ucrInputMajorBreaksLabels.IsReadOnly = False
        Me.ucrInputMajorBreaksLabels.Location = New System.Drawing.Point(98, 132)
        Me.ucrInputMajorBreaksLabels.Name = "ucrInputMajorBreaksLabels"
        Me.ucrInputMajorBreaksLabels.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputMajorBreaksLabels.TabIndex = 4
        '
        'rdoMajorBreaksSeq
        '
        Me.rdoMajorBreaksSeq.AutoSize = True
        Me.rdoMajorBreaksSeq.Location = New System.Drawing.Point(98, 21)
        Me.rdoMajorBreaksSeq.Name = "rdoMajorBreaksSeq"
        Me.rdoMajorBreaksSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdoMajorBreaksSeq.TabIndex = 21
        Me.rdoMajorBreaksSeq.TabStop = True
        Me.rdoMajorBreaksSeq.Text = "Sequence"
        Me.rdoMajorBreaksSeq.UseVisualStyleBackColor = True
        '
        'rdoMajorBreaksCustom
        '
        Me.rdoMajorBreaksCustom.AutoSize = True
        Me.rdoMajorBreaksCustom.Location = New System.Drawing.Point(179, 21)
        Me.rdoMajorBreaksCustom.Name = "rdoMajorBreaksCustom"
        Me.rdoMajorBreaksCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoMajorBreaksCustom.TabIndex = 20
        Me.rdoMajorBreaksCustom.TabStop = True
        Me.rdoMajorBreaksCustom.Text = "Custom"
        Me.rdoMajorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksInStepsOf
        '
        Me.ucrInputMajorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksInStepsOf.AutoSize = True
        Me.ucrInputMajorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMajorBreaksInStepsOf.IsReadOnly = False
        Me.ucrInputMajorBreaksInStepsOf.Location = New System.Drawing.Point(114, 99)
        Me.ucrInputMajorBreaksInStepsOf.Name = "ucrInputMajorBreaksInStepsOf"
        Me.ucrInputMajorBreaksInStepsOf.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksInStepsOf.TabIndex = 19
        '
        'rdoMajorBreaksNone
        '
        Me.rdoMajorBreaksNone.AutoSize = True
        Me.rdoMajorBreaksNone.Location = New System.Drawing.Point(278, 21)
        Me.rdoMajorBreaksNone.Name = "rdoMajorBreaksNone"
        Me.rdoMajorBreaksNone.Size = New System.Drawing.Size(56, 17)
        Me.rdoMajorBreaksNone.TabIndex = 3
        Me.rdoMajorBreaksNone.TabStop = True
        Me.rdoMajorBreaksNone.Text = "Aucun"
        Me.rdoMajorBreaksNone.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksTo
        '
        Me.ucrInputMajorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksTo.AutoSize = True
        Me.ucrInputMajorBreaksTo.IsMultiline = False
        Me.ucrInputMajorBreaksTo.IsReadOnly = False
        Me.ucrInputMajorBreaksTo.Location = New System.Drawing.Point(114, 72)
        Me.ucrInputMajorBreaksTo.Name = "ucrInputMajorBreaksTo"
        Me.ucrInputMajorBreaksTo.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksTo.TabIndex = 19
        '
        'ucrInputMajorBreaksFrom
        '
        Me.ucrInputMajorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksFrom.AutoSize = True
        Me.ucrInputMajorBreaksFrom.IsMultiline = False
        Me.ucrInputMajorBreaksFrom.IsReadOnly = False
        Me.ucrInputMajorBreaksFrom.Location = New System.Drawing.Point(114, 46)
        Me.ucrInputMajorBreaksFrom.Name = "ucrInputMajorBreaksFrom"
        Me.ucrInputMajorBreaksFrom.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksFrom.TabIndex = 19
        '
        'rdoMajorBreaksAuto
        '
        Me.rdoMajorBreaksAuto.AutoSize = True
        Me.rdoMajorBreaksAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoMajorBreaksAuto.Name = "rdoMajorBreaksAuto"
        Me.rdoMajorBreaksAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoMajorBreaksAuto.TabIndex = 2
        Me.rdoMajorBreaksAuto.TabStop = True
        Me.rdoMajorBreaksAuto.Text = "Auto"
        Me.rdoMajorBreaksAuto.UseVisualStyleBackColor = True
        '
        'lblMajorBreaksInStepsOf
        '
        Me.lblMajorBreaksInStepsOf.AutoSize = True
        Me.lblMajorBreaksInStepsOf.Location = New System.Drawing.Point(9, 103)
        Me.lblMajorBreaksInStepsOf.Name = "lblMajorBreaksInStepsOf"
        Me.lblMajorBreaksInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblMajorBreaksInStepsOf.TabIndex = 9
        Me.lblMajorBreaksInStepsOf.Text = "In Steps of:"
        '
        'lblMajorBreaksFrom
        '
        Me.lblMajorBreaksFrom.AutoSize = True
        Me.lblMajorBreaksFrom.Location = New System.Drawing.Point(9, 50)
        Me.lblMajorBreaksFrom.Name = "lblMajorBreaksFrom"
        Me.lblMajorBreaksFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblMajorBreaksFrom.TabIndex = 5
        Me.lblMajorBreaksFrom.Text = "From:"
        '
        'lblMajorBreaksTo
        '
        Me.lblMajorBreaksTo.AutoSize = True
        Me.lblMajorBreaksTo.Location = New System.Drawing.Point(9, 75)
        Me.lblMajorBreaksTo.Name = "lblMajorBreaksTo"
        Me.lblMajorBreaksTo.Size = New System.Drawing.Size(23, 13)
        Me.lblMajorBreaksTo.TabIndex = 6
        Me.lblMajorBreaksTo.Text = "To:"
        '
        'ucrPnlMajorBreaks
        '
        Me.ucrPnlMajorBreaks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMajorBreaks.Location = New System.Drawing.Point(3, 19)
        Me.ucrPnlMajorBreaks.Name = "ucrPnlMajorBreaks"
        Me.ucrPnlMajorBreaks.Size = New System.Drawing.Size(335, 23)
        Me.ucrPnlMajorBreaks.TabIndex = 18
        '
        'ucrInputMajorBreaksCustom
        '
        Me.ucrInputMajorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksCustom.AutoSize = True
        Me.ucrInputMajorBreaksCustom.IsMultiline = False
        Me.ucrInputMajorBreaksCustom.IsReadOnly = False
        Me.ucrInputMajorBreaksCustom.Location = New System.Drawing.Point(6, 46)
        Me.ucrInputMajorBreaksCustom.Name = "ucrInputMajorBreaksCustom"
        Me.ucrInputMajorBreaksCustom.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMajorBreaksCustom.TabIndex = 15
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.ucrInputRelaceMissingvalues)
        Me.grpScales.Controls.Add(Me.ucrInputExpand)
        Me.grpScales.Controls.Add(Me.ucrInputPosition)
        Me.grpScales.Controls.Add(Me.ucrChkExpand)
        Me.grpScales.Controls.Add(Me.ucrChkPosition)
        Me.grpScales.Controls.Add(Me.ucrChkNaValue)
        Me.grpScales.Controls.Add(Me.ucrInputUpperLimit)
        Me.grpScales.Controls.Add(Me.ucrInputLowerLimit)
        Me.grpScales.Controls.Add(Me.lblUpperLimit)
        Me.grpScales.Controls.Add(Me.lblLowerLimit)
        Me.grpScales.Controls.Add(Me.rdoScalesCustom)
        Me.grpScales.Controls.Add(Me.rdoScalesAuto)
        Me.grpScales.Controls.Add(Me.ucrPnlScales)
        Me.grpScales.Controls.Add(Me.ucrInputTransformation)
        Me.grpScales.Controls.Add(Me.ucrChkTransformation)
        Me.grpScales.Location = New System.Drawing.Point(3, 90)
        Me.grpScales.Name = "grpScales"
        Me.grpScales.Size = New System.Drawing.Size(274, 228)
        Me.grpScales.TabIndex = 2
        Me.grpScales.TabStop = False
        Me.grpScales.Text = "Scales"
        '
        'ucrInputRelaceMissingvalues
        '
        Me.ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = True
        Me.ucrInputRelaceMissingvalues.AutoSize = True
        Me.ucrInputRelaceMissingvalues.IsMultiline = False
        Me.ucrInputRelaceMissingvalues.IsReadOnly = False
        Me.ucrInputRelaceMissingvalues.Location = New System.Drawing.Point(191, 103)
        Me.ucrInputRelaceMissingvalues.Name = "ucrInputRelaceMissingvalues"
        Me.ucrInputRelaceMissingvalues.Size = New System.Drawing.Size(78, 22)
        Me.ucrInputRelaceMissingvalues.TabIndex = 27
        '
        'ucrInputExpand
        '
        Me.ucrInputExpand.AddQuotesIfUnrecognised = True
        Me.ucrInputExpand.AutoSize = True
        Me.ucrInputExpand.IsMultiline = False
        Me.ucrInputExpand.IsReadOnly = False
        Me.ucrInputExpand.Location = New System.Drawing.Point(191, 188)
        Me.ucrInputExpand.Name = "ucrInputExpand"
        Me.ucrInputExpand.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputExpand.TabIndex = 27
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(191, 131)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputPosition.TabIndex = 26
        '
        'ucrChkExpand
        '
        Me.ucrChkExpand.AutoSize = True
        Me.ucrChkExpand.Checked = False
        Me.ucrChkExpand.Location = New System.Drawing.Point(6, 188)
        Me.ucrChkExpand.Name = "ucrChkExpand"
        Me.ucrChkExpand.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkExpand.TabIndex = 23
        '
        'ucrChkPosition
        '
        Me.ucrChkPosition.AutoSize = True
        Me.ucrChkPosition.Checked = False
        Me.ucrChkPosition.Location = New System.Drawing.Point(6, 131)
        Me.ucrChkPosition.Name = "ucrChkPosition"
        Me.ucrChkPosition.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkPosition.TabIndex = 23
        '
        'ucrChkNaValue
        '
        Me.ucrChkNaValue.AutoSize = True
        Me.ucrChkNaValue.Checked = False
        Me.ucrChkNaValue.Location = New System.Drawing.Point(6, 103)
        Me.ucrChkNaValue.Name = "ucrChkNaValue"
        Me.ucrChkNaValue.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkNaValue.TabIndex = 23
        '
        'ucrInputUpperLimit
        '
        Me.ucrInputUpperLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperLimit.AutoSize = True
        Me.ucrInputUpperLimit.IsMultiline = False
        Me.ucrInputUpperLimit.IsReadOnly = False
        Me.ucrInputUpperLimit.Location = New System.Drawing.Point(90, 76)
        Me.ucrInputUpperLimit.Name = "ucrInputUpperLimit"
        Me.ucrInputUpperLimit.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputUpperLimit.TabIndex = 22
        '
        'ucrInputLowerLimit
        '
        Me.ucrInputLowerLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerLimit.AutoSize = True
        Me.ucrInputLowerLimit.IsMultiline = False
        Me.ucrInputLowerLimit.IsReadOnly = False
        Me.ucrInputLowerLimit.Location = New System.Drawing.Point(90, 46)
        Me.ucrInputLowerLimit.Name = "ucrInputLowerLimit"
        Me.ucrInputLowerLimit.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputLowerLimit.TabIndex = 22
        '
        'lblUpperLimit
        '
        Me.lblUpperLimit.AutoSize = True
        Me.lblUpperLimit.Location = New System.Drawing.Point(3, 75)
        Me.lblUpperLimit.Name = "lblUpperLimit"
        Me.lblUpperLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblUpperLimit.TabIndex = 5
        Me.lblUpperLimit.Text = "Upper Limit :"
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(3, 48)
        Me.lblLowerLimit.Name = "lblLowerLimit"
        Me.lblLowerLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblLowerLimit.TabIndex = 3
        Me.lblLowerLimit.Text = "Lower Limit :"
        '
        'rdoScalesCustom
        '
        Me.rdoScalesCustom.AutoSize = True
        Me.rdoScalesCustom.Location = New System.Drawing.Point(137, 20)
        Me.rdoScalesCustom.Name = "rdoScalesCustom"
        Me.rdoScalesCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoScalesCustom.TabIndex = 4
        Me.rdoScalesCustom.TabStop = True
        Me.rdoScalesCustom.Text = "Custom"
        Me.rdoScalesCustom.UseVisualStyleBackColor = True
        '
        'rdoScalesAuto
        '
        Me.rdoScalesAuto.AutoSize = True
        Me.rdoScalesAuto.Location = New System.Drawing.Point(9, 20)
        Me.rdoScalesAuto.Name = "rdoScalesAuto"
        Me.rdoScalesAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoScalesAuto.TabIndex = 3
        Me.rdoScalesAuto.TabStop = True
        Me.rdoScalesAuto.Text = "Auto"
        Me.rdoScalesAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlScales
        '
        Me.ucrPnlScales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlScales.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlScales.Name = "ucrPnlScales"
        Me.ucrPnlScales.Size = New System.Drawing.Size(233, 23)
        Me.ucrPnlScales.TabIndex = 20
        '
        'ucrInputTransformation
        '
        Me.ucrInputTransformation.AddQuotesIfUnrecognised = True
        Me.ucrInputTransformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTransformation.GetSetSelectedIndex = -1
        Me.ucrInputTransformation.IsReadOnly = False
        Me.ucrInputTransformation.Location = New System.Drawing.Point(191, 159)
        Me.ucrInputTransformation.Name = "ucrInputTransformation"
        Me.ucrInputTransformation.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputTransformation.TabIndex = 26
        '
        'ucrChkTransformation
        '
        Me.ucrChkTransformation.AutoSize = True
        Me.ucrChkTransformation.Checked = False
        Me.ucrChkTransformation.Location = New System.Drawing.Point(6, 159)
        Me.ucrChkTransformation.Name = "ucrChkTransformation"
        Me.ucrChkTransformation.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkTransformation.TabIndex = 23
        '
        'grpScaleDiscrete
        '
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputNaValueDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputExpandDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputPositionDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkExpandDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkPositionDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkNaValueDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputUpperLimitDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputLowerLimitDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.lblUpperLimitDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.lblLowerLimitDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.rdoCustomDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.rdoAutoDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrPnlScaleDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputDropUnusedLevels)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.grpScaleDiscrete.Location = New System.Drawing.Point(3, 90)
        Me.grpScaleDiscrete.Name = "grpScaleDiscrete"
        Me.grpScaleDiscrete.Size = New System.Drawing.Size(274, 228)
        Me.grpScaleDiscrete.TabIndex = 30
        Me.grpScaleDiscrete.TabStop = False
        Me.grpScaleDiscrete.Text = "Scales"
        '
        'ucrInputNaValueDiscrete
        '
        Me.ucrInputNaValueDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputNaValueDiscrete.AutoSize = True
        Me.ucrInputNaValueDiscrete.IsMultiline = False
        Me.ucrInputNaValueDiscrete.IsReadOnly = False
        Me.ucrInputNaValueDiscrete.Location = New System.Drawing.Point(191, 103)
        Me.ucrInputNaValueDiscrete.Name = "ucrInputNaValueDiscrete"
        Me.ucrInputNaValueDiscrete.Size = New System.Drawing.Size(78, 22)
        Me.ucrInputNaValueDiscrete.TabIndex = 27
        '
        'ucrInputExpandDiscrete
        '
        Me.ucrInputExpandDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputExpandDiscrete.AutoSize = True
        Me.ucrInputExpandDiscrete.IsMultiline = False
        Me.ucrInputExpandDiscrete.IsReadOnly = False
        Me.ucrInputExpandDiscrete.Location = New System.Drawing.Point(191, 188)
        Me.ucrInputExpandDiscrete.Name = "ucrInputExpandDiscrete"
        Me.ucrInputExpandDiscrete.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputExpandDiscrete.TabIndex = 27
        '
        'ucrInputPositionDiscrete
        '
        Me.ucrInputPositionDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputPositionDiscrete.IsReadOnly = False
        Me.ucrInputPositionDiscrete.Location = New System.Drawing.Point(191, 131)
        Me.ucrInputPositionDiscrete.Name = "ucrInputPositionDiscrete"
        Me.ucrInputPositionDiscrete.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputPositionDiscrete.TabIndex = 26
        '
        'ucrChkExpandDiscrete
        '
        Me.ucrChkExpandDiscrete.AutoSize = True
        Me.ucrChkExpandDiscrete.Checked = False
        Me.ucrChkExpandDiscrete.Location = New System.Drawing.Point(6, 188)
        Me.ucrChkExpandDiscrete.Name = "ucrChkExpandDiscrete"
        Me.ucrChkExpandDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkExpandDiscrete.TabIndex = 23
        '
        'ucrChkPositionDiscrete
        '
        Me.ucrChkPositionDiscrete.AutoSize = True
        Me.ucrChkPositionDiscrete.Checked = False
        Me.ucrChkPositionDiscrete.Location = New System.Drawing.Point(6, 131)
        Me.ucrChkPositionDiscrete.Name = "ucrChkPositionDiscrete"
        Me.ucrChkPositionDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkPositionDiscrete.TabIndex = 23
        '
        'ucrChkNaValueDiscrete
        '
        Me.ucrChkNaValueDiscrete.AutoSize = True
        Me.ucrChkNaValueDiscrete.Checked = False
        Me.ucrChkNaValueDiscrete.Location = New System.Drawing.Point(6, 103)
        Me.ucrChkNaValueDiscrete.Name = "ucrChkNaValueDiscrete"
        Me.ucrChkNaValueDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkNaValueDiscrete.TabIndex = 23
        '
        'ucrInputUpperLimitDiscrete
        '
        Me.ucrInputUpperLimitDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperLimitDiscrete.AutoSize = True
        Me.ucrInputUpperLimitDiscrete.IsMultiline = False
        Me.ucrInputUpperLimitDiscrete.IsReadOnly = False
        Me.ucrInputUpperLimitDiscrete.Location = New System.Drawing.Point(90, 76)
        Me.ucrInputUpperLimitDiscrete.Name = "ucrInputUpperLimitDiscrete"
        Me.ucrInputUpperLimitDiscrete.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputUpperLimitDiscrete.TabIndex = 22
        '
        'ucrInputLowerLimitDiscrete
        '
        Me.ucrInputLowerLimitDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerLimitDiscrete.AutoSize = True
        Me.ucrInputLowerLimitDiscrete.IsMultiline = False
        Me.ucrInputLowerLimitDiscrete.IsReadOnly = False
        Me.ucrInputLowerLimitDiscrete.Location = New System.Drawing.Point(90, 46)
        Me.ucrInputLowerLimitDiscrete.Name = "ucrInputLowerLimitDiscrete"
        Me.ucrInputLowerLimitDiscrete.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputLowerLimitDiscrete.TabIndex = 22
        '
        'lblUpperLimitDiscrete
        '
        Me.lblUpperLimitDiscrete.AutoSize = True
        Me.lblUpperLimitDiscrete.Location = New System.Drawing.Point(3, 75)
        Me.lblUpperLimitDiscrete.Name = "lblUpperLimitDiscrete"
        Me.lblUpperLimitDiscrete.Size = New System.Drawing.Size(66, 13)
        Me.lblUpperLimitDiscrete.TabIndex = 5
        Me.lblUpperLimitDiscrete.Text = "Upper Limit :"
        '
        'lblLowerLimitDiscrete
        '
        Me.lblLowerLimitDiscrete.AutoSize = True
        Me.lblLowerLimitDiscrete.Location = New System.Drawing.Point(3, 48)
        Me.lblLowerLimitDiscrete.Name = "lblLowerLimitDiscrete"
        Me.lblLowerLimitDiscrete.Size = New System.Drawing.Size(66, 13)
        Me.lblLowerLimitDiscrete.TabIndex = 3
        Me.lblLowerLimitDiscrete.Text = "Lower Limit :"
        '
        'rdoCustomDiscrete
        '
        Me.rdoCustomDiscrete.AutoSize = True
        Me.rdoCustomDiscrete.Location = New System.Drawing.Point(137, 20)
        Me.rdoCustomDiscrete.Name = "rdoCustomDiscrete"
        Me.rdoCustomDiscrete.Size = New System.Drawing.Size(60, 17)
        Me.rdoCustomDiscrete.TabIndex = 4
        Me.rdoCustomDiscrete.TabStop = True
        Me.rdoCustomDiscrete.Text = "Custom"
        Me.rdoCustomDiscrete.UseVisualStyleBackColor = True
        '
        'rdoAutoDiscrete
        '
        Me.rdoAutoDiscrete.AutoSize = True
        Me.rdoAutoDiscrete.Location = New System.Drawing.Point(9, 20)
        Me.rdoAutoDiscrete.Name = "rdoAutoDiscrete"
        Me.rdoAutoDiscrete.Size = New System.Drawing.Size(47, 17)
        Me.rdoAutoDiscrete.TabIndex = 3
        Me.rdoAutoDiscrete.TabStop = True
        Me.rdoAutoDiscrete.Text = "Auto"
        Me.rdoAutoDiscrete.UseVisualStyleBackColor = True
        '
        'ucrPnlScaleDiscrete
        '
        Me.ucrPnlScaleDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlScaleDiscrete.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlScaleDiscrete.Name = "ucrPnlScaleDiscrete"
        Me.ucrPnlScaleDiscrete.Size = New System.Drawing.Size(233, 23)
        Me.ucrPnlScaleDiscrete.TabIndex = 20
        '
        'ucrInputDropUnusedLevels
        '
        Me.ucrInputDropUnusedLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevels.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevels.IsReadOnly = False
        Me.ucrInputDropUnusedLevels.Location = New System.Drawing.Point(191, 159)
        Me.ucrInputDropUnusedLevels.Name = "ucrInputDropUnusedLevels"
        Me.ucrInputDropUnusedLevels.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputDropUnusedLevels.TabIndex = 29
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(6, 160)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 28
        '
        'grpScaleXDate
        '
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateLabel)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkDateLabels)
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.lbXscaleDateLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.lblXScalDateUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrNudDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkLimits)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkBreaks)
        Me.grpScaleXDate.Location = New System.Drawing.Point(3, 90)
        Me.grpScaleXDate.Name = "grpScaleXDate"
        Me.grpScaleXDate.Size = New System.Drawing.Size(301, 153)
        Me.grpScaleXDate.TabIndex = 34
        Me.grpScaleXDate.TabStop = False
        Me.grpScaleXDate.Text = "Date Scales"
        '
        'ucrInputComboDateLabel
        '
        Me.ucrInputComboDateLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboDateLabel.GetSetSelectedIndex = -1
        Me.ucrInputComboDateLabel.IsReadOnly = False
        Me.ucrInputComboDateLabel.Location = New System.Drawing.Point(95, 54)
        Me.ucrInputComboDateLabel.Name = "ucrInputComboDateLabel"
        Me.ucrInputComboDateLabel.Size = New System.Drawing.Size(135, 21)
        Me.ucrInputComboDateLabel.TabIndex = 9
        '
        'ucrChkDateLabels
        '
        Me.ucrChkDateLabels.AutoSize = True
        Me.ucrChkDateLabels.Checked = False
        Me.ucrChkDateLabels.Location = New System.Drawing.Point(14, 54)
        Me.ucrChkDateLabels.Name = "ucrChkDateLabels"
        Me.ucrChkDateLabels.Size = New System.Drawing.Size(92, 23)
        Me.ucrChkDateLabels.TabIndex = 8
        '
        'ucrInputComboDateBreak
        '
        Me.ucrInputComboDateBreak.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateBreak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboDateBreak.GetSetSelectedIndex = -1
        Me.ucrInputComboDateBreak.IsReadOnly = False
        Me.ucrInputComboDateBreak.Location = New System.Drawing.Point(145, 31)
        Me.ucrInputComboDateBreak.Name = "ucrInputComboDateBreak"
        Me.ucrInputComboDateBreak.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputComboDateBreak.TabIndex = 7
        '
        'lbXscaleDateLowerLimit
        '
        Me.lbXscaleDateLowerLimit.AutoSize = True
        Me.lbXscaleDateLowerLimit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbXscaleDateLowerLimit.Location = New System.Drawing.Point(10, 100)
        Me.lbXscaleDateLowerLimit.Name = "lbXscaleDateLowerLimit"
        Me.lbXscaleDateLowerLimit.Size = New System.Drawing.Size(60, 13)
        Me.lbXscaleDateLowerLimit.TabIndex = 6
        Me.lbXscaleDateLowerLimit.Text = "Lower Limit"
        '
        'lblXScalDateUpperLimit
        '
        Me.lblXScalDateUpperLimit.AutoSize = True
        Me.lblXScalDateUpperLimit.Location = New System.Drawing.Point(9, 123)
        Me.lblXScalDateUpperLimit.Name = "lblXScalDateUpperLimit"
        Me.lblXScalDateUpperLimit.Size = New System.Drawing.Size(60, 13)
        Me.lblXScalDateUpperLimit.TabIndex = 5
        Me.lblXScalDateUpperLimit.Text = "Upper Limit"
        '
        'ucrNudDateBreak
        '
        Me.ucrNudDateBreak.AutoSize = True
        Me.ucrNudDateBreak.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDateBreak.Location = New System.Drawing.Point(95, 31)
        Me.ucrNudDateBreak.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreak.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Name = "ucrNudDateBreak"
        Me.ucrNudDateBreak.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDateBreak.TabIndex = 4
        Me.ucrNudDateBreak.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrDtpLowerLimit
        '
        Me.ucrDtpLowerLimit.AutoSize = True
        Me.ucrDtpLowerLimit.DateValue = New Date(2021, 6, 19, 11, 15, 36, 159)
        Me.ucrDtpLowerLimit.Format = "dd MMM yyyy"
        Me.ucrDtpLowerLimit.Location = New System.Drawing.Point(95, 100)
        Me.ucrDtpLowerLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.Name = "ucrDtpLowerLimit"
        Me.ucrDtpLowerLimit.Size = New System.Drawing.Size(136, 20)
        Me.ucrDtpLowerLimit.TabIndex = 3
        '
        'ucrDtpUpperLimit
        '
        Me.ucrDtpUpperLimit.AutoSize = True
        Me.ucrDtpUpperLimit.DateValue = New Date(2021, 6, 19, 11, 15, 36, 170)
        Me.ucrDtpUpperLimit.Format = "dd MMM yyyy"
        Me.ucrDtpUpperLimit.Location = New System.Drawing.Point(95, 123)
        Me.ucrDtpUpperLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.Name = "ucrDtpUpperLimit"
        Me.ucrDtpUpperLimit.Size = New System.Drawing.Size(135, 20)
        Me.ucrDtpUpperLimit.TabIndex = 2
        '
        'ucrChkLimits
        '
        Me.ucrChkLimits.AutoSize = True
        Me.ucrChkLimits.Checked = False
        Me.ucrChkLimits.Location = New System.Drawing.Point(14, 77)
        Me.ucrChkLimits.Name = "ucrChkLimits"
        Me.ucrChkLimits.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkLimits.TabIndex = 1
        '
        'ucrChkBreaks
        '
        Me.ucrChkBreaks.AutoSize = True
        Me.ucrChkBreaks.Checked = False
        Me.ucrChkBreaks.Location = New System.Drawing.Point(14, 31)
        Me.ucrChkBreaks.Name = "ucrChkBreaks"
        Me.ucrChkBreaks.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBreaks.TabIndex = 0
        '
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAxisType.GetSetSelectedIndex = -1
        Me.ucrInputAxisType.IsReadOnly = False
        Me.ucrInputAxisType.Location = New System.Drawing.Point(527, 7)
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        Me.ucrInputAxisType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAxisType.TabIndex = 3
        '
        'rdoMinorBreaksSeq
        '
        Me.rdoMinorBreaksSeq.AutoSize = True
        Me.rdoMinorBreaksSeq.Location = New System.Drawing.Point(98, 20)
        Me.rdoMinorBreaksSeq.Name = "rdoMinorBreaksSeq"
        Me.rdoMinorBreaksSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdoMinorBreaksSeq.TabIndex = 32
        Me.rdoMinorBreaksSeq.TabStop = True
        Me.rdoMinorBreaksSeq.Text = "Sequence"
        Me.rdoMinorBreaksSeq.UseVisualStyleBackColor = True
        '
        'rdoMinorBreaksCustom
        '
        Me.rdoMinorBreaksCustom.AutoSize = True
        Me.rdoMinorBreaksCustom.Location = New System.Drawing.Point(179, 20)
        Me.rdoMinorBreaksCustom.Name = "rdoMinorBreaksCustom"
        Me.rdoMinorBreaksCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoMinorBreaksCustom.TabIndex = 31
        Me.rdoMinorBreaksCustom.TabStop = True
        Me.rdoMinorBreaksCustom.Text = "Custom"
        Me.rdoMinorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrInputMinorBreaksInStepsOf
        '
        Me.ucrInputMinorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksInStepsOf.AutoSize = True
        Me.ucrInputMinorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMinorBreaksInStepsOf.IsReadOnly = False
        Me.ucrInputMinorBreaksInStepsOf.Location = New System.Drawing.Point(126, 97)
        Me.ucrInputMinorBreaksInStepsOf.Name = "ucrInputMinorBreaksInStepsOf"
        Me.ucrInputMinorBreaksInStepsOf.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksInStepsOf.TabIndex = 28
        '
        'ucrInputMinorBreaksTo
        '
        Me.ucrInputMinorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksTo.AutoSize = True
        Me.ucrInputMinorBreaksTo.IsMultiline = False
        Me.ucrInputMinorBreaksTo.IsReadOnly = False
        Me.ucrInputMinorBreaksTo.Location = New System.Drawing.Point(126, 71)
        Me.ucrInputMinorBreaksTo.Name = "ucrInputMinorBreaksTo"
        Me.ucrInputMinorBreaksTo.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksTo.TabIndex = 29
        '
        'ucrInputMinorBreaksFrom
        '
        Me.ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksFrom.AutoSize = True
        Me.ucrInputMinorBreaksFrom.IsMultiline = False
        Me.ucrInputMinorBreaksFrom.IsReadOnly = False
        Me.ucrInputMinorBreaksFrom.Location = New System.Drawing.Point(125, 43)
        Me.ucrInputMinorBreaksFrom.Name = "ucrInputMinorBreaksFrom"
        Me.ucrInputMinorBreaksFrom.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksFrom.TabIndex = 30
        '
        'rdoMinorBreaksAuto
        '
        Me.rdoMinorBreaksAuto.AutoSize = True
        Me.rdoMinorBreaksAuto.Location = New System.Drawing.Point(6, 19)
        Me.rdoMinorBreaksAuto.Name = "rdoMinorBreaksAuto"
        Me.rdoMinorBreaksAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoMinorBreaksAuto.TabIndex = 22
        Me.rdoMinorBreaksAuto.TabStop = True
        Me.rdoMinorBreaksAuto.Text = "Auto"
        Me.rdoMinorBreaksAuto.UseVisualStyleBackColor = True
        '
        'ucrInputMinorBreaksCustom
        '
        Me.ucrInputMinorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksCustom.AutoSize = True
        Me.ucrInputMinorBreaksCustom.IsMultiline = False
        Me.ucrInputMinorBreaksCustom.IsReadOnly = False
        Me.ucrInputMinorBreaksCustom.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputMinorBreaksCustom.Name = "ucrInputMinorBreaksCustom"
        Me.ucrInputMinorBreaksCustom.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMinorBreaksCustom.TabIndex = 26
        '
        'lblMinorBreaksInStepsOf
        '
        Me.lblMinorBreaksInStepsOf.AutoSize = True
        Me.lblMinorBreaksInStepsOf.Location = New System.Drawing.Point(9, 101)
        Me.lblMinorBreaksInStepsOf.Name = "lblMinorBreaksInStepsOf"
        Me.lblMinorBreaksInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblMinorBreaksInStepsOf.TabIndex = 25
        Me.lblMinorBreaksInStepsOf.Text = "In Steps of:"
        '
        'lblMinorBreaksTo
        '
        Me.lblMinorBreaksTo.AutoSize = True
        Me.lblMinorBreaksTo.Location = New System.Drawing.Point(9, 75)
        Me.lblMinorBreaksTo.Name = "lblMinorBreaksTo"
        Me.lblMinorBreaksTo.Size = New System.Drawing.Size(23, 13)
        Me.lblMinorBreaksTo.TabIndex = 24
        Me.lblMinorBreaksTo.Text = "To:"
        '
        'ucrPnlMinorBreaks
        '
        Me.ucrPnlMinorBreaks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMinorBreaks.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlMinorBreaks.Name = "ucrPnlMinorBreaks"
        Me.ucrPnlMinorBreaks.Size = New System.Drawing.Size(332, 23)
        Me.ucrPnlMinorBreaks.TabIndex = 27
        '
        'grpMinorBreaks
        '
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksNone)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksAuto)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksSeq)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrPnlMinorBreaks)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksCustom)
        Me.grpMinorBreaks.Location = New System.Drawing.Point(310, 197)
        Me.grpMinorBreaks.Name = "grpMinorBreaks"
        Me.grpMinorBreaks.Size = New System.Drawing.Size(354, 121)
        Me.grpMinorBreaks.TabIndex = 33
        Me.grpMinorBreaks.TabStop = False
        Me.grpMinorBreaks.Text = "Minor Tick Marks"
        '
        'lblMinorBreaksFrom
        '
        Me.lblMinorBreaksFrom.AutoSize = True
        Me.lblMinorBreaksFrom.Location = New System.Drawing.Point(9, 48)
        Me.lblMinorBreaksFrom.Name = "lblMinorBreaksFrom"
        Me.lblMinorBreaksFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblMinorBreaksFrom.TabIndex = 34
        Me.lblMinorBreaksFrom.Text = "From:"
        '
        'rdoMinorBreaksNone
        '
        Me.rdoMinorBreaksNone.AutoSize = True
        Me.rdoMinorBreaksNone.Location = New System.Drawing.Point(278, 20)
        Me.rdoMinorBreaksNone.Name = "rdoMinorBreaksNone"
        Me.rdoMinorBreaksNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoMinorBreaksNone.TabIndex = 22
        Me.rdoMinorBreaksNone.TabStop = True
        Me.rdoMinorBreaksNone.Text = "None"
        Me.rdoMinorBreaksNone.UseVisualStyleBackColor = True
        '
        'grpMinorBreaksDiscrete
        '
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.lblMinorBreaksFromDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.rdoMinorBreaksNoneDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.rdoMinorBreaksAutoDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.lblMinorBreaksInStepsOfDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.rdoMinorBreaksSeqDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.lblMinorBreaksToDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.rdoMinorBreaksCustomDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.ucrPnlMinorBreaksDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.ucrInputMinorBreaksFromDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.ucrInputMinorBreaksInStepsOfDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.ucrInputMinorBreaksToDiscrete)
        Me.grpMinorBreaksDiscrete.Controls.Add(Me.ucrInputMinorBreaksCustomDiscrete)
        Me.grpMinorBreaksDiscrete.Location = New System.Drawing.Point(310, 197)
        Me.grpMinorBreaksDiscrete.Name = "grpMinorBreaksDiscrete"
        Me.grpMinorBreaksDiscrete.Size = New System.Drawing.Size(354, 121)
        Me.grpMinorBreaksDiscrete.TabIndex = 35
        Me.grpMinorBreaksDiscrete.TabStop = False
        Me.grpMinorBreaksDiscrete.Text = "Minor Tick Marks"
        '
        'lblMinorBreaksFromDiscrete
        '
        Me.lblMinorBreaksFromDiscrete.AutoSize = True
        Me.lblMinorBreaksFromDiscrete.Location = New System.Drawing.Point(9, 48)
        Me.lblMinorBreaksFromDiscrete.Name = "lblMinorBreaksFromDiscrete"
        Me.lblMinorBreaksFromDiscrete.Size = New System.Drawing.Size(33, 13)
        Me.lblMinorBreaksFromDiscrete.TabIndex = 34
        Me.lblMinorBreaksFromDiscrete.Text = "From:"
        '
        'rdoMinorBreaksNoneDiscrete
        '
        Me.rdoMinorBreaksNoneDiscrete.AutoSize = True
        Me.rdoMinorBreaksNoneDiscrete.Location = New System.Drawing.Point(278, 20)
        Me.rdoMinorBreaksNoneDiscrete.Name = "rdoMinorBreaksNoneDiscrete"
        Me.rdoMinorBreaksNoneDiscrete.Size = New System.Drawing.Size(51, 17)
        Me.rdoMinorBreaksNoneDiscrete.TabIndex = 22
        Me.rdoMinorBreaksNoneDiscrete.TabStop = True
        Me.rdoMinorBreaksNoneDiscrete.Text = "None"
        Me.rdoMinorBreaksNoneDiscrete.UseVisualStyleBackColor = True
        '
        'rdoMinorBreaksAutoDiscrete
        '
        Me.rdoMinorBreaksAutoDiscrete.AutoSize = True
        Me.rdoMinorBreaksAutoDiscrete.Location = New System.Drawing.Point(6, 19)
        Me.rdoMinorBreaksAutoDiscrete.Name = "rdoMinorBreaksAutoDiscrete"
        Me.rdoMinorBreaksAutoDiscrete.Size = New System.Drawing.Size(47, 17)
        Me.rdoMinorBreaksAutoDiscrete.TabIndex = 22
        Me.rdoMinorBreaksAutoDiscrete.TabStop = True
        Me.rdoMinorBreaksAutoDiscrete.Text = "Auto"
        Me.rdoMinorBreaksAutoDiscrete.UseVisualStyleBackColor = True
        '
        'lblMinorBreaksInStepsOfDiscrete
        '
        Me.lblMinorBreaksInStepsOfDiscrete.AutoSize = True
        Me.lblMinorBreaksInStepsOfDiscrete.Location = New System.Drawing.Point(9, 101)
        Me.lblMinorBreaksInStepsOfDiscrete.Name = "lblMinorBreaksInStepsOfDiscrete"
        Me.lblMinorBreaksInStepsOfDiscrete.Size = New System.Drawing.Size(61, 13)
        Me.lblMinorBreaksInStepsOfDiscrete.TabIndex = 25
        Me.lblMinorBreaksInStepsOfDiscrete.Text = "In Steps of:"
        '
        'rdoMinorBreaksSeqDiscrete
        '
        Me.rdoMinorBreaksSeqDiscrete.AutoSize = True
        Me.rdoMinorBreaksSeqDiscrete.Location = New System.Drawing.Point(98, 20)
        Me.rdoMinorBreaksSeqDiscrete.Name = "rdoMinorBreaksSeqDiscrete"
        Me.rdoMinorBreaksSeqDiscrete.Size = New System.Drawing.Size(74, 17)
        Me.rdoMinorBreaksSeqDiscrete.TabIndex = 32
        Me.rdoMinorBreaksSeqDiscrete.TabStop = True
        Me.rdoMinorBreaksSeqDiscrete.Text = "Sequence"
        Me.rdoMinorBreaksSeqDiscrete.UseVisualStyleBackColor = True
        '
        'lblMinorBreaksToDiscrete
        '
        Me.lblMinorBreaksToDiscrete.AutoSize = True
        Me.lblMinorBreaksToDiscrete.Location = New System.Drawing.Point(9, 75)
        Me.lblMinorBreaksToDiscrete.Name = "lblMinorBreaksToDiscrete"
        Me.lblMinorBreaksToDiscrete.Size = New System.Drawing.Size(23, 13)
        Me.lblMinorBreaksToDiscrete.TabIndex = 24
        Me.lblMinorBreaksToDiscrete.Text = "To:"
        '
        'rdoMinorBreaksCustomDiscrete
        '
        Me.rdoMinorBreaksCustomDiscrete.AutoSize = True
        Me.rdoMinorBreaksCustomDiscrete.Location = New System.Drawing.Point(179, 20)
        Me.rdoMinorBreaksCustomDiscrete.Name = "rdoMinorBreaksCustomDiscrete"
        Me.rdoMinorBreaksCustomDiscrete.Size = New System.Drawing.Size(60, 17)
        Me.rdoMinorBreaksCustomDiscrete.TabIndex = 31
        Me.rdoMinorBreaksCustomDiscrete.TabStop = True
        Me.rdoMinorBreaksCustomDiscrete.Text = "Custom"
        Me.rdoMinorBreaksCustomDiscrete.UseVisualStyleBackColor = True
        '
        'ucrPnlMinorBreaksDiscrete
        '
        Me.ucrPnlMinorBreaksDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMinorBreaksDiscrete.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlMinorBreaksDiscrete.Name = "ucrPnlMinorBreaksDiscrete"
        Me.ucrPnlMinorBreaksDiscrete.Size = New System.Drawing.Size(332, 23)
        Me.ucrPnlMinorBreaksDiscrete.TabIndex = 27
        '
        'ucrInputMinorBreaksFromDiscrete
        '
        Me.ucrInputMinorBreaksFromDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksFromDiscrete.AutoSize = True
        Me.ucrInputMinorBreaksFromDiscrete.IsMultiline = False
        Me.ucrInputMinorBreaksFromDiscrete.IsReadOnly = False
        Me.ucrInputMinorBreaksFromDiscrete.Location = New System.Drawing.Point(125, 43)
        Me.ucrInputMinorBreaksFromDiscrete.Name = "ucrInputMinorBreaksFromDiscrete"
        Me.ucrInputMinorBreaksFromDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksFromDiscrete.TabIndex = 30
        '
        'ucrInputMinorBreaksInStepsOfDiscrete
        '
        Me.ucrInputMinorBreaksInStepsOfDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksInStepsOfDiscrete.AutoSize = True
        Me.ucrInputMinorBreaksInStepsOfDiscrete.IsMultiline = False
        Me.ucrInputMinorBreaksInStepsOfDiscrete.IsReadOnly = False
        Me.ucrInputMinorBreaksInStepsOfDiscrete.Location = New System.Drawing.Point(126, 97)
        Me.ucrInputMinorBreaksInStepsOfDiscrete.Name = "ucrInputMinorBreaksInStepsOfDiscrete"
        Me.ucrInputMinorBreaksInStepsOfDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksInStepsOfDiscrete.TabIndex = 28
        '
        'ucrInputMinorBreaksToDiscrete
        '
        Me.ucrInputMinorBreaksToDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksToDiscrete.AutoSize = True
        Me.ucrInputMinorBreaksToDiscrete.IsMultiline = False
        Me.ucrInputMinorBreaksToDiscrete.IsReadOnly = False
        Me.ucrInputMinorBreaksToDiscrete.Location = New System.Drawing.Point(126, 71)
        Me.ucrInputMinorBreaksToDiscrete.Name = "ucrInputMinorBreaksToDiscrete"
        Me.ucrInputMinorBreaksToDiscrete.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksToDiscrete.TabIndex = 29
        '
        'ucrInputMinorBreaksCustomDiscrete
        '
        Me.ucrInputMinorBreaksCustomDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksCustomDiscrete.AutoSize = True
        Me.ucrInputMinorBreaksCustomDiscrete.IsMultiline = False
        Me.ucrInputMinorBreaksCustomDiscrete.IsReadOnly = False
        Me.ucrInputMinorBreaksCustomDiscrete.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputMinorBreaksCustomDiscrete.Name = "ucrInputMinorBreaksCustomDiscrete"
        Me.ucrInputMinorBreaksCustomDiscrete.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMinorBreaksCustomDiscrete.TabIndex = 26
        '
        'ucrAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.grpScaleDiscrete)
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpScaleXDate)
        Me.Controls.Add(Me.grpMinorBreaks)
        Me.Controls.Add(Me.ucrInputAxisType)
        Me.Controls.Add(Me.grpMajorBreaks)
        Me.Controls.Add(Me.grpMajorBreaksDiscrete)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Controls.Add(Me.grpMinorBreaksDiscrete)
        Me.Name = "ucrAxes"
        Me.Size = New System.Drawing.Size(667, 337)
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpMajorBreaksDiscrete.ResumeLayout(False)
        Me.grpMajorBreaksDiscrete.PerformLayout()
        Me.grpMajorBreaks.ResumeLayout(False)
        Me.grpMajorBreaks.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.grpScaleDiscrete.ResumeLayout(False)
        Me.grpScaleDiscrete.PerformLayout()
        Me.grpScaleXDate.ResumeLayout(False)
        Me.grpScaleXDate.PerformLayout()
        Me.grpMinorBreaks.ResumeLayout(False)
        Me.grpMinorBreaks.PerformLayout()
        Me.grpMinorBreaksDiscrete.ResumeLayout(False)
        Me.grpMinorBreaksDiscrete.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents grpMajorBreaks As GroupBox
    Friend WithEvents lblMajorBreaksFrom As Label
    Friend WithEvents rdoMajorBreaksNone As RadioButton
    Friend WithEvents rdoMajorBreaksAuto As RadioButton
    Friend WithEvents lblMajorBreaksTo As Label
    Friend WithEvents lblMajorBreaksInStepsOf As Label
    Friend WithEvents ucrInputMajorBreaksCustom As ucrInputTextBox

    Friend WithEvents grpScales As GroupBox
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoNoTitle As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents ucrPnlMajorBreaks As UcrPanel
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents ucrInputUpperLimit As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimit As ucrInputTextBox
    Friend WithEvents rdoSpecifyTitle As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrInputMajorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksSeq As RadioButton
    Friend WithEvents rdoMajorBreaksCustom As RadioButton
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents ucrInputMajorBreaksLabels As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksSeq As RadioButton
    Friend WithEvents rdoMinorBreaksCustom As RadioButton
    Friend WithEvents ucrInputMinorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksAuto As RadioButton
    Friend WithEvents ucrInputMinorBreaksCustom As ucrInputTextBox
    Friend WithEvents lblMinorBreaksInStepsOf As Label
    Friend WithEvents lblMinorBreaksTo As Label
    Friend WithEvents ucrPnlMinorBreaks As UcrPanel
    Friend WithEvents grpMinorBreaks As GroupBox
    Friend WithEvents lblMinorBreaksFrom As Label
    Friend WithEvents rdoMinorBreaksNone As RadioButton
    Friend WithEvents ucrChkLabels As ucrCheck
    Friend WithEvents ucrInputTransformation As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkNaValue As ucrCheck
    Friend WithEvents ucrInputExpand As ucrInputTextBox
    Friend WithEvents ucrInputRelaceMissingvalues As ucrInputTextBox
    Friend WithEvents ucrChkPosition As ucrCheck
    Friend WithEvents ucrChkExpand As ucrCheck
    Friend WithEvents ucrChkTransformation As ucrCheck
    Friend WithEvents grpScaleXDate As GroupBox
    Friend WithEvents ucrChkLimits As ucrCheck
    Friend WithEvents ucrChkBreaks As ucrCheck
    Friend WithEvents lbXscaleDateLowerLimit As Label
    Friend WithEvents lblXScalDateUpperLimit As Label
    Friend WithEvents ucrNudDateBreak As ucrNud
    Friend WithEvents ucrDtpLowerLimit As ucrDateTimePicker
    Friend WithEvents ucrDtpUpperLimit As ucrDateTimePicker
    Friend WithEvents ucrInputComboDateBreak As ucrInputComboBox
    Friend WithEvents ucrChkDateLabels As ucrCheck
    Friend WithEvents ucrInputComboDateLabel As ucrInputComboBox
    Friend WithEvents grpScaleDiscrete As GroupBox
    Friend WithEvents ucrInputNaValueDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputExpandDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputPositionDiscrete As ucrInputComboBox
    Friend WithEvents ucrChkExpandDiscrete As ucrCheck
    Friend WithEvents ucrChkPositionDiscrete As ucrCheck
    Friend WithEvents ucrChkNaValueDiscrete As ucrCheck
    Friend WithEvents ucrInputUpperLimitDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimitDiscrete As ucrInputTextBox
    Friend WithEvents lblUpperLimitDiscrete As Label
    Friend WithEvents lblLowerLimitDiscrete As Label
    Friend WithEvents rdoCustomDiscrete As RadioButton
    Friend WithEvents rdoAutoDiscrete As RadioButton
    Friend WithEvents ucrPnlScaleDiscrete As UcrPanel
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents ucrInputDropUnusedLevels As ucrInputComboBox
    Friend WithEvents grpMajorBreaksDiscrete As GroupBox
    Friend WithEvents ucrChkLabelsDiscrete As ucrCheck
    Friend WithEvents ucrInputMajorBreaksLabelsDiscrete As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksSeqDiscrete As RadioButton
    Friend WithEvents rdoMajorBreaksCustomDiscrete As RadioButton
    Friend WithEvents ucrInputMajorBreaksInStepsOfDiscrete As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksNoneDiscrete As RadioButton
    Friend WithEvents ucrInputMajorBreaksToDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksFromDiscrete As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksAutoDiscrete As RadioButton
    Friend WithEvents lblMajorBreaksInStepsOfDiscrete As Label
    Friend WithEvents lblMajorBreaksFromDiscrete As Label
    Friend WithEvents lblMajorBreaksToDiscrete As Label
    Friend WithEvents ucrPnlMajorBreaksDiscrete As UcrPanel
    Friend WithEvents ucrInputMajorBreaksCustomDiscrete As ucrInputTextBox
    Friend WithEvents grpMinorBreaksDiscrete As GroupBox
    Friend WithEvents lblMinorBreaksFromDiscrete As Label
    Friend WithEvents rdoMinorBreaksNoneDiscrete As RadioButton
    Friend WithEvents rdoMinorBreaksAutoDiscrete As RadioButton
    Friend WithEvents lblMinorBreaksInStepsOfDiscrete As Label
    Friend WithEvents rdoMinorBreaksSeqDiscrete As RadioButton
    Friend WithEvents lblMinorBreaksToDiscrete As Label
    Friend WithEvents rdoMinorBreaksCustomDiscrete As RadioButton
    Friend WithEvents ucrPnlMinorBreaksDiscrete As UcrPanel
    Friend WithEvents ucrInputMinorBreaksFromDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksInStepsOfDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksToDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksCustomDiscrete As ucrInputTextBox
End Class
