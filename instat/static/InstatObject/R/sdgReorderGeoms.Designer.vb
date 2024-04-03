<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgReorderGeoms
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReorderColumns = New instat.ucrReorder()
        Me.ucrAdditionalLayers = New instat.ucrAdditionalLayers()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(40, 208)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 5
        '
        'ucrReorderColumns
        '
        Me.ucrReorderColumns.Location = New System.Drawing.Point(273, 28)
        Me.ucrReorderColumns.Name = "ucrReorderColumns"
        Me.ucrReorderColumns.Size = New System.Drawing.Size(211, 174)
        Me.ucrReorderColumns.TabIndex = 4
        Me.ucrReorderColumns.ucrDataFrameList = Nothing
        Me.ucrReorderColumns.ucrReceiver = Nothing
        '
        'ucrAdditionalLayers
        '
        Me.ucrAdditionalLayers.AutoSize = True
        Me.ucrAdditionalLayers.Location = New System.Drawing.Point(12, 21)
        Me.ucrAdditionalLayers.Name = "ucrAdditionalLayers"
        Me.ucrAdditionalLayers.Size = New System.Drawing.Size(247, 181)
        Me.ucrAdditionalLayers.TabIndex = 9
        '
        'sdgReorderGeoms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 269)
        Me.Controls.Add(Me.ucrAdditionalLayers)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReorderColumns)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgReorderGeoms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reorder Geoms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReorderColumns As ucrReorder
    Friend WithEvents ucrAdditionalLayers As ucrAdditionalLayers
End Class
