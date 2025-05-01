<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPLModelOptions
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
        Me.grpPriors = New System.Windows.Forms.GroupBox()
        Me.lblShape = New System.Windows.Forms.Label()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.ucrChkGamma = New System.Windows.Forms.CheckBox()
        Me.ucrChkMultivariateNormal = New System.Windows.Forms.CheckBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblSigma = New System.Windows.Forms.Label()
        Me.ucrChkTreatsNAs = New System.Windows.Forms.CheckBox()
        Me.ucrChkWeights = New System.Windows.Forms.CheckBox()
        Me.lblOuterIterations = New System.Windows.Forms.Label()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblMaximumIterations = New System.Windows.Forms.Label()
        Me.lblSteffenson = New System.Windows.Forms.Label()
        Me.lblEpsilon = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrNudMaxIterations = New instat.ucrNud()
        Me.ucrInputNA = New instat.ucrInputTextBox()
        Me.UcrInputWeight = New instat.ucrInputTextBox()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrNudSteffenson = New instat.ucrNud()
        Me.ucrNudOuterIterations = New instat.ucrNud()
        Me.ucrNudRate = New instat.ucrNud()
        Me.ucrNudShape = New instat.ucrNud()
        Me.ucrNudSigma = New instat.ucrNud()
        Me.ucrNudMean = New instat.ucrNud()
        Me.ucrInputEpsilon = New instat.ucrInputTextBox()
        Me.grpPriors.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPriors
        '
        Me.grpPriors.Controls.Add(Me.lblShape)
        Me.grpPriors.Controls.Add(Me.lblMean)
        Me.grpPriors.Controls.Add(Me.ucrChkGamma)
        Me.grpPriors.Controls.Add(Me.ucrChkMultivariateNormal)
        Me.grpPriors.Controls.Add(Me.ucrNudRate)
        Me.grpPriors.Controls.Add(Me.ucrNudShape)
        Me.grpPriors.Controls.Add(Me.ucrNudSigma)
        Me.grpPriors.Controls.Add(Me.lblRate)
        Me.grpPriors.Controls.Add(Me.ucrNudMean)
        Me.grpPriors.Controls.Add(Me.lblSigma)
        Me.grpPriors.Location = New System.Drawing.Point(12, 12)
        Me.grpPriors.Name = "grpPriors"
        Me.grpPriors.Size = New System.Drawing.Size(252, 145)
        Me.grpPriors.TabIndex = 0
        Me.grpPriors.TabStop = False
        Me.grpPriors.Text = "Priors"
        '
        'lblShape
        '
        Me.lblShape.AutoSize = True
        Me.lblShape.Location = New System.Drawing.Point(123, 86)
        Me.lblShape.Name = "lblShape"
        Me.lblShape.Size = New System.Drawing.Size(41, 13)
        Me.lblShape.TabIndex = 5
        Me.lblShape.Text = "Shape:"
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Location = New System.Drawing.Point(123, 25)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(43, 13)
        Me.lblMean.TabIndex = 4
        Me.lblMean.Text = "Meaan:"
        '
        'ucrChkGamma
        '
        Me.ucrChkGamma.AutoSize = True
        Me.ucrChkGamma.Location = New System.Drawing.Point(6, 85)
        Me.ucrChkGamma.Name = "ucrChkGamma"
        Me.ucrChkGamma.Size = New System.Drawing.Size(81, 17)
        Me.ucrChkGamma.TabIndex = 4
        Me.ucrChkGamma.Text = "CheckBox4"
        Me.ucrChkGamma.UseVisualStyleBackColor = True
        '
        'ucrChkMultivariateNormal
        '
        Me.ucrChkMultivariateNormal.AutoSize = True
        Me.ucrChkMultivariateNormal.Location = New System.Drawing.Point(6, 24)
        Me.ucrChkMultivariateNormal.Name = "ucrChkMultivariateNormal"
        Me.ucrChkMultivariateNormal.Size = New System.Drawing.Size(81, 17)
        Me.ucrChkMultivariateNormal.TabIndex = 1
        Me.ucrChkMultivariateNormal.Text = "CheckBox1"
        Me.ucrChkMultivariateNormal.UseVisualStyleBackColor = True
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(123, 113)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 11
        Me.lblRate.Text = "Rate:"
        '
        'lblSigma
        '
        Me.lblSigma.AutoSize = True
        Me.lblSigma.Location = New System.Drawing.Point(123, 54)
        Me.lblSigma.Name = "lblSigma"
        Me.lblSigma.Size = New System.Drawing.Size(39, 13)
        Me.lblSigma.TabIndex = 8
        Me.lblSigma.Text = "Sigma:"
        '
        'ucrChkTreatsNAs
        '
        Me.ucrChkTreatsNAs.AutoSize = True
        Me.ucrChkTreatsNAs.Location = New System.Drawing.Point(18, 221)
        Me.ucrChkTreatsNAs.Name = "ucrChkTreatsNAs"
        Me.ucrChkTreatsNAs.Size = New System.Drawing.Size(81, 17)
        Me.ucrChkTreatsNAs.TabIndex = 2
        Me.ucrChkTreatsNAs.Text = "CheckBox2"
        Me.ucrChkTreatsNAs.UseVisualStyleBackColor = True
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.AutoSize = True
        Me.ucrChkWeights.Location = New System.Drawing.Point(18, 194)
        Me.ucrChkWeights.Name = "ucrChkWeights"
        Me.ucrChkWeights.Size = New System.Drawing.Size(81, 17)
        Me.ucrChkWeights.TabIndex = 3
        Me.ucrChkWeights.Text = "CheckBox3"
        Me.ucrChkWeights.UseVisualStyleBackColor = True
        '
        'lblOuterIterations
        '
        Me.lblOuterIterations.AutoSize = True
        Me.lblOuterIterations.Location = New System.Drawing.Point(15, 290)
        Me.lblOuterIterations.Name = "lblOuterIterations"
        Me.lblOuterIterations.Size = New System.Drawing.Size(85, 13)
        Me.lblOuterIterations.TabIndex = 6
        Me.lblOuterIterations.Text = " Outer Iterations:"
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(15, 170)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 9
        Me.lblMethod.Text = "Method:"
        '
        'lblMaximumIterations
        '
        Me.lblMaximumIterations.AutoSize = True
        Me.lblMaximumIterations.Location = New System.Drawing.Point(15, 254)
        Me.lblMaximumIterations.Name = "lblMaximumIterations"
        Me.lblMaximumIterations.Size = New System.Drawing.Size(100, 13)
        Me.lblMaximumIterations.TabIndex = 10
        Me.lblMaximumIterations.Text = "Maximum Iterations:"
        '
        'lblSteffenson
        '
        Me.lblSteffenson.AutoSize = True
        Me.lblSteffenson.Location = New System.Drawing.Point(15, 352)
        Me.lblSteffenson.Name = "lblSteffenson"
        Me.lblSteffenson.Size = New System.Drawing.Size(61, 13)
        Me.lblSteffenson.TabIndex = 12
        Me.lblSteffenson.Text = "Steffenson:"
        '
        'lblEpsilon
        '
        Me.lblEpsilon.AutoSize = True
        Me.lblEpsilon.Location = New System.Drawing.Point(15, 320)
        Me.lblEpsilon.Name = "lblEpsilon"
        Me.lblEpsilon.Size = New System.Drawing.Size(44, 13)
        Me.lblEpsilon.TabIndex = 324
        Me.lblEpsilon.Text = "Epsilon:"
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.Location = New System.Drawing.Point(24, 380)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(224, 30)
        Me.ucrBase.TabIndex = 326
        '
        'ucrNudMaxIterations
        '
        Me.ucrNudMaxIterations.AutoSize = True
        Me.ucrNudMaxIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxIterations.Location = New System.Drawing.Point(138, 252)
        Me.ucrNudMaxIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMaxIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxIterations.Name = "ucrNudMaxIterations"
        Me.ucrNudMaxIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaxIterations.TabIndex = 325
        Me.ucrNudMaxIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputNA
        '
        Me.ucrInputNA.AddQuotesIfUnrecognised = True
        Me.ucrInputNA.AutoSize = True
        Me.ucrInputNA.IsMultiline = False
        Me.ucrInputNA.IsReadOnly = False
        Me.ucrInputNA.Location = New System.Drawing.Point(138, 219)
        Me.ucrInputNA.Name = "ucrInputNA"
        Me.ucrInputNA.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputNA.TabIndex = 323
        '
        'UcrInputWeight
        '
        Me.UcrInputWeight.AddQuotesIfUnrecognised = True
        Me.UcrInputWeight.AutoSize = True
        Me.UcrInputWeight.IsMultiline = False
        Me.UcrInputWeight.IsReadOnly = False
        Me.UcrInputWeight.Location = New System.Drawing.Point(138, 190)
        Me.UcrInputWeight.Name = "UcrInputWeight"
        Me.UcrInputWeight.Size = New System.Drawing.Size(105, 21)
        Me.UcrInputWeight.TabIndex = 322
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(138, 162)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(105, 26)
        Me.ucrInputMethod.TabIndex = 321
        '
        'ucrNudSteffenson
        '
        Me.ucrNudSteffenson.AutoSize = True
        Me.ucrNudSteffenson.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSteffenson.Location = New System.Drawing.Point(138, 350)
        Me.ucrNudSteffenson.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSteffenson.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSteffenson.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSteffenson.Name = "ucrNudSteffenson"
        Me.ucrNudSteffenson.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSteffenson.TabIndex = 26
        Me.ucrNudSteffenson.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudOuterIterations
        '
        Me.ucrNudOuterIterations.AutoSize = True
        Me.ucrNudOuterIterations.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOuterIterations.Location = New System.Drawing.Point(138, 287)
        Me.ucrNudOuterIterations.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudOuterIterations.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOuterIterations.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOuterIterations.Name = "ucrNudOuterIterations"
        Me.ucrNudOuterIterations.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudOuterIterations.TabIndex = 25
        Me.ucrNudOuterIterations.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRate
        '
        Me.ucrNudRate.AutoSize = True
        Me.ucrNudRate.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRate.Location = New System.Drawing.Point(181, 107)
        Me.ucrNudRate.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudRate.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRate.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRate.Name = "ucrNudRate"
        Me.ucrNudRate.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRate.TabIndex = 22
        Me.ucrNudRate.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudShape
        '
        Me.ucrNudShape.AutoSize = True
        Me.ucrNudShape.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShape.Location = New System.Drawing.Point(181, 79)
        Me.ucrNudShape.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudShape.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShape.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShape.Name = "ucrNudShape"
        Me.ucrNudShape.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShape.TabIndex = 23
        Me.ucrNudShape.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSigma
        '
        Me.ucrNudSigma.AutoSize = True
        Me.ucrNudSigma.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigma.Location = New System.Drawing.Point(181, 51)
        Me.ucrNudSigma.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSigma.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigma.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigma.Name = "ucrNudSigma"
        Me.ucrNudSigma.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigma.TabIndex = 24
        Me.ucrNudSigma.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMean
        '
        Me.ucrNudMean.AutoSize = True
        Me.ucrNudMean.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMean.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMean.Location = New System.Drawing.Point(181, 21)
        Me.ucrNudMean.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMean.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMean.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMean.Name = "ucrNudMean"
        Me.ucrNudMean.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMean.TabIndex = 21
        Me.ucrNudMean.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputEpsilon
        '
        Me.ucrInputEpsilon.AddQuotesIfUnrecognised = True
        Me.ucrInputEpsilon.AutoSize = True
        Me.ucrInputEpsilon.IsMultiline = False
        Me.ucrInputEpsilon.IsReadOnly = False
        Me.ucrInputEpsilon.Location = New System.Drawing.Point(138, 314)
        Me.ucrInputEpsilon.Name = "ucrInputEpsilon"
        Me.ucrInputEpsilon.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputEpsilon.TabIndex = 327
        '
        'sdgPLModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 422)
        Me.Controls.Add(Me.ucrInputEpsilon)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrNudMaxIterations)
        Me.Controls.Add(Me.lblEpsilon)
        Me.Controls.Add(Me.ucrInputNA)
        Me.Controls.Add(Me.UcrInputWeight)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.ucrNudSteffenson)
        Me.Controls.Add(Me.ucrNudOuterIterations)
        Me.Controls.Add(Me.lblSteffenson)
        Me.Controls.Add(Me.lblOuterIterations)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.lblMaximumIterations)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkTreatsNAs)
        Me.Controls.Add(Me.grpPriors)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPLModelOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plackett-Luce Model Options"
        Me.grpPriors.ResumeLayout(False)
        Me.grpPriors.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPriors As GroupBox
    Friend WithEvents lblShape As Label
    Friend WithEvents lblMean As Label
    Friend WithEvents ucrChkGamma As CheckBox
    Friend WithEvents ucrChkMultivariateNormal As CheckBox
    Friend WithEvents ucrChkTreatsNAs As CheckBox
    Friend WithEvents ucrChkWeights As CheckBox
    Friend WithEvents lblOuterIterations As Label
    Friend WithEvents lblSigma As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents lblMaximumIterations As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblSteffenson As Label
    Friend WithEvents ucrNudRate As ucrNud
    Friend WithEvents ucrNudShape As ucrNud
    Friend WithEvents ucrNudSigma As ucrNud
    Friend WithEvents ucrNudMean As ucrNud
    Friend WithEvents ucrNudOuterIterations As ucrNud
    Friend WithEvents ucrNudSteffenson As ucrNud
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents UcrInputWeight As ucrInputTextBox
    Friend WithEvents ucrInputNA As ucrInputTextBox
    Friend WithEvents lblEpsilon As Label
    Friend WithEvents ucrNudMaxIterations As ucrNud
    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrInputEpsilon As ucrInputTextBox
End Class
