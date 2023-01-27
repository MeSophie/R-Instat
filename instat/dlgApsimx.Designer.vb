<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgApsimx
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
        Me.lblExampleList = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputComboList = New instat.ucrInputComboBox()
        Me.lblSaveData = New System.Windows.Forms.Label()
        Me.ucrInputSaveData = New instat.ucrInputTextBox()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.ucrChkInspectParameters = New instat.ucrCheck()
        Me.ucrChkEditParameters = New instat.ucrCheck()
        Me.ucrInputNode = New instat.ucrInputComboBox()
        Me.lblNodeList = New System.Windows.Forms.Label()
        Me.ucrInputSoilChildInspect = New instat.ucrInputComboBox()
        Me.lblSoilChildInspect = New System.Windows.Forms.Label()
        Me.ucrInputSoilChildEdit = New instat.ucrInputComboBox()
        Me.lbllblSoilChildInspect = New System.Windows.Forms.Label()
        Me.lblParm = New System.Windows.Forms.Label()
        Me.ucrInputParameter = New instat.ucrInputTextBox()
        Me.ucrNudParameterPosition = New instat.ucrNud()
        Me.ucrChkSilent = New instat.ucrCheck()
        Me.ucrChkPrintPath = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblExampleList
        '
        Me.lblExampleList.AutoSize = True
        Me.lblExampleList.Location = New System.Drawing.Point(4, 36)
        Me.lblExampleList.Name = "lblExampleList"
        Me.lblExampleList.Size = New System.Drawing.Size(74, 13)
        Me.lblExampleList.TabIndex = 0
        Me.lblExampleList.Text = "Examples List:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(7, 294)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrInputComboList
        '
        Me.ucrInputComboList.AddQuotesIfUnrecognised = True
        Me.ucrInputComboList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboList.GetSetSelectedIndex = -1
        Me.ucrInputComboList.IsReadOnly = False
        Me.ucrInputComboList.Location = New System.Drawing.Point(104, 36)
        Me.ucrInputComboList.Name = "ucrInputComboList"
        Me.ucrInputComboList.Size = New System.Drawing.Size(129, 28)
        Me.ucrInputComboList.TabIndex = 1
        '
        'lblSaveData
        '
        Me.lblSaveData.AutoSize = True
        Me.lblSaveData.Location = New System.Drawing.Point(7, 267)
        Me.lblSaveData.Name = "lblSaveData"
        Me.lblSaveData.Size = New System.Drawing.Size(61, 13)
        Me.lblSaveData.TabIndex = 3
        Me.lblSaveData.Text = "Save Data:"
        '
        'ucrInputSaveData
        '
        Me.ucrInputSaveData.AddQuotesIfUnrecognised = True
        Me.ucrInputSaveData.AutoSize = True
        Me.ucrInputSaveData.IsMultiline = False
        Me.ucrInputSaveData.IsReadOnly = False
        Me.ucrInputSaveData.Location = New System.Drawing.Point(135, 263)
        Me.ucrInputSaveData.Name = "ucrInputSaveData"
        Me.ucrInputSaveData.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSaveData.TabIndex = 4
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(60, 6)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ucrInputFilePath.Size = New System.Drawing.Size(336, 21)
        Me.ucrInputFilePath.TabIndex = 7
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(400, 5)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(66, 23)
        Me.cmdBrowse.TabIndex = 8
        Me.cmdBrowse.Tag = "browse"
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileOpenPath.Location = New System.Drawing.Point(4, 9)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(52, 13)
        Me.lblFileOpenPath.TabIndex = 6
        Me.lblFileOpenPath.Text = "File:"
        '
        'ucrChkInspectParameters
        '
        Me.ucrChkInspectParameters.AutoSize = True
        Me.ucrChkInspectParameters.Checked = False
        Me.ucrChkInspectParameters.Location = New System.Drawing.Point(7, 72)
        Me.ucrChkInspectParameters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkInspectParameters.Name = "ucrChkInspectParameters"
        Me.ucrChkInspectParameters.Size = New System.Drawing.Size(178, 23)
        Me.ucrChkInspectParameters.TabIndex = 37
        '
        'ucrChkEditParameters
        '
        Me.ucrChkEditParameters.AutoSize = True
        Me.ucrChkEditParameters.Checked = False
        Me.ucrChkEditParameters.Location = New System.Drawing.Point(260, 72)
        Me.ucrChkEditParameters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkEditParameters.Name = "ucrChkEditParameters"
        Me.ucrChkEditParameters.Size = New System.Drawing.Size(195, 23)
        Me.ucrChkEditParameters.TabIndex = 38
        '
        'ucrInputNode
        '
        Me.ucrInputNode.AddQuotesIfUnrecognised = True
        Me.ucrInputNode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNode.GetSetSelectedIndex = -1
        Me.ucrInputNode.IsReadOnly = False
        Me.ucrInputNode.Location = New System.Drawing.Point(104, 109)
        Me.ucrInputNode.Name = "ucrInputNode"
        Me.ucrInputNode.Size = New System.Drawing.Size(129, 35)
        Me.ucrInputNode.TabIndex = 40
        '
        'lblNodeList
        '
        Me.lblNodeList.AutoSize = True
        Me.lblNodeList.Location = New System.Drawing.Point(4, 109)
        Me.lblNodeList.Name = "lblNodeList"
        Me.lblNodeList.Size = New System.Drawing.Size(55, 13)
        Me.lblNodeList.TabIndex = 39
        Me.lblNodeList.Text = "Node List:"
        '
        'ucrInputSoilChildInspect
        '
        Me.ucrInputSoilChildInspect.AddQuotesIfUnrecognised = True
        Me.ucrInputSoilChildInspect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSoilChildInspect.GetSetSelectedIndex = -1
        Me.ucrInputSoilChildInspect.IsReadOnly = False
        Me.ucrInputSoilChildInspect.Location = New System.Drawing.Point(104, 143)
        Me.ucrInputSoilChildInspect.Name = "ucrInputSoilChildInspect"
        Me.ucrInputSoilChildInspect.Size = New System.Drawing.Size(129, 30)
        Me.ucrInputSoilChildInspect.TabIndex = 42
        '
        'lblSoilChildInspect
        '
        Me.lblSoilChildInspect.AutoSize = True
        Me.lblSoilChildInspect.Location = New System.Drawing.Point(7, 148)
        Me.lblSoilChildInspect.Name = "lblSoilChildInspect"
        Me.lblSoilChildInspect.Size = New System.Drawing.Size(91, 13)
        Me.lblSoilChildInspect.TabIndex = 41
        Me.lblSoilChildInspect.Text = "Soil Child Inspect:"
        '
        'ucrInputSoilChildEdit
        '
        Me.ucrInputSoilChildEdit.AddQuotesIfUnrecognised = True
        Me.ucrInputSoilChildEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSoilChildEdit.GetSetSelectedIndex = -1
        Me.ucrInputSoilChildEdit.IsReadOnly = False
        Me.ucrInputSoilChildEdit.Location = New System.Drawing.Point(330, 143)
        Me.ucrInputSoilChildEdit.Name = "ucrInputSoilChildEdit"
        Me.ucrInputSoilChildEdit.Size = New System.Drawing.Size(136, 30)
        Me.ucrInputSoilChildEdit.TabIndex = 44
        Me.ucrInputSoilChildEdit.Visible = False
        '
        'lbllblSoilChildInspect
        '
        Me.lbllblSoilChildInspect.AutoSize = True
        Me.lbllblSoilChildInspect.Location = New System.Drawing.Point(257, 148)
        Me.lbllblSoilChildInspect.Name = "lbllblSoilChildInspect"
        Me.lbllblSoilChildInspect.Size = New System.Drawing.Size(71, 13)
        Me.lbllblSoilChildInspect.TabIndex = 43
        Me.lbllblSoilChildInspect.Text = "Soil Child Edit"
        Me.lbllblSoilChildInspect.Visible = False
        '
        'lblParm
        '
        Me.lblParm.AutoSize = True
        Me.lblParm.Location = New System.Drawing.Point(4, 172)
        Me.lblParm.Name = "lblParm"
        Me.lblParm.Size = New System.Drawing.Size(58, 13)
        Me.lblParm.TabIndex = 45
        Me.lblParm.Text = "Parameter:"
        Me.lblParm.Visible = False
        '
        'ucrInputParameter
        '
        Me.ucrInputParameter.AddQuotesIfUnrecognised = True
        Me.ucrInputParameter.AutoSize = True
        Me.ucrInputParameter.IsMultiline = False
        Me.ucrInputParameter.IsReadOnly = False
        Me.ucrInputParameter.Location = New System.Drawing.Point(68, 172)
        Me.ucrInputParameter.Name = "ucrInputParameter"
        Me.ucrInputParameter.Size = New System.Drawing.Size(117, 29)
        Me.ucrInputParameter.TabIndex = 48
        Me.ucrInputParameter.Visible = False
        '
        'ucrNudParameterPosition
        '
        Me.ucrNudParameterPosition.AutoSize = True
        Me.ucrNudParameterPosition.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParameterPosition.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudParameterPosition.Location = New System.Drawing.Point(200, 172)
        Me.ucrNudParameterPosition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudParameterPosition.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudParameterPosition.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParameterPosition.Name = "ucrNudParameterPosition"
        Me.ucrNudParameterPosition.Size = New System.Drawing.Size(33, 20)
        Me.ucrNudParameterPosition.TabIndex = 49
        Me.ucrNudParameterPosition.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudParameterPosition.Visible = False
        '
        'ucrChkSilent
        '
        Me.ucrChkSilent.AutoSize = True
        Me.ucrChkSilent.Checked = False
        Me.ucrChkSilent.Location = New System.Drawing.Point(7, 234)
        Me.ucrChkSilent.Name = "ucrChkSilent"
        Me.ucrChkSilent.Size = New System.Drawing.Size(138, 23)
        Me.ucrChkSilent.TabIndex = 50
        '
        'ucrChkPrintPath
        '
        Me.ucrChkPrintPath.AutoSize = True
        Me.ucrChkPrintPath.Checked = False
        Me.ucrChkPrintPath.Location = New System.Drawing.Point(7, 205)
        Me.ucrChkPrintPath.Name = "ucrChkPrintPath"
        Me.ucrChkPrintPath.Size = New System.Drawing.Size(138, 23)
        Me.ucrChkPrintPath.TabIndex = 51
        '
        'dlgApsimx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 356)
        Me.Controls.Add(Me.ucrChkPrintPath)
        Me.Controls.Add(Me.ucrChkSilent)
        Me.Controls.Add(Me.ucrNudParameterPosition)
        Me.Controls.Add(Me.ucrInputParameter)
        Me.Controls.Add(Me.lblParm)
        Me.Controls.Add(Me.ucrInputSoilChildEdit)
        Me.Controls.Add(Me.lbllblSoilChildInspect)
        Me.Controls.Add(Me.ucrInputSoilChildInspect)
        Me.Controls.Add(Me.lblSoilChildInspect)
        Me.Controls.Add(Me.ucrInputNode)
        Me.Controls.Add(Me.lblNodeList)
        Me.Controls.Add(Me.ucrChkEditParameters)
        Me.Controls.Add(Me.ucrChkInspectParameters)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.ucrInputSaveData)
        Me.Controls.Add(Me.lblSaveData)
        Me.Controls.Add(Me.ucrInputComboList)
        Me.Controls.Add(Me.lblExampleList)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgApsimx"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Apsimx/Apsim Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExampleList As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrInputComboList As ucrInputComboBox
    Friend WithEvents lblSaveData As Label
    Friend WithEvents ucrInputSaveData As ucrInputTextBox
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents ucrChkInspectParameters As ucrCheck
    Friend WithEvents ucrChkEditParameters As ucrCheck
    Friend WithEvents ucrInputNode As ucrInputComboBox
    Friend WithEvents lblNodeList As Label
    Friend WithEvents ucrInputSoilChildInspect As ucrInputComboBox
    Friend WithEvents lblSoilChildInspect As Label
    Friend WithEvents ucrInputSoilChildEdit As ucrInputComboBox
    Friend WithEvents lbllblSoilChildInspect As Label
    Friend WithEvents lblParm As Label
    Friend WithEvents ucrInputParameter As ucrInputTextBox
    Friend WithEvents ucrNudParameterPosition As ucrNud
    Friend WithEvents ucrChkSilent As ucrCheck
    Friend WithEvents ucrChkPrintPath As ucrCheck
End Class
