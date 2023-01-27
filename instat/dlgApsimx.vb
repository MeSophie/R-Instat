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

Imports instat.Translations
Imports System.IO

Public Class dlgApsimx
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsApsimxExampleFunction As New RFunction
    Private clsInspectApsimxFunction As New RFunction
    'Private clsEditApsimxFunction As New RFunction
    Private clsBaseFunction, clsDataListFunction, clsNodeListFunction, clsSoilChildInspectListFunction, clsSoilChildEditListFunction As New RFunction
    Private clsReportOperator As New ROperator
    Private Sub dlgApsimx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 479

        ucrInputComboList.IsReadOnly = True
        ucrInputNode.IsReadOnly = True
        ucrInputSoilChildInspect.IsReadOnly = True
        ucrInputSoilChildEdit.IsReadOnly = True
        ucrInputSoilChildEdit.IsReadOnly = True

        ucrInputFilePath.SetParameter(New RParameter("src.dir", 1))

        ucrInputParameter.SetParameter(New RParameter("parm", 4))
        ucrInputParameter.AddQuotesIfUnrecognised = False


        ucrChkSilent.SetText("Silent")
        ucrChkSilent.SetParameter(New RParameter("silent", 1))
        ucrChkSilent.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSilent.SetRDefault("FALSE")

        Dim dctExamplesModels As New Dictionary(Of String, String) From {
           {"Barley", Chr(34) & "Barley" & Chr(34)},
           {"Controlled Environment", Chr(34) & "ControlledEnvironment" & Chr(34)},
           {"Eucalyptus", Chr(34) & "Eucalyptus" & Chr(34)},
           {"Eucalyptus Rotation", Chr(34) & "EucalyptusRotation" & Chr(34)},
           {"Maize", Chr(34) & "Maize" & Chr(34)},
           {"Oats", Chr(34) & "Oats" & Chr(34)},
           {"Rotation", Chr(34) & "Rotation" & Chr(34)},
           {"Soybean", Chr(34) & "Soybean" & Chr(34)},
           {"Sugarcane", Chr(34) & "Sugarcane" & Chr(34)},
           {"Wheat", Chr(34) & "Wheat" & Chr(34)}}

        Dim dctNodeElements As New Dictionary(Of String, String) From {
           {"Clock", Chr(34) & "Clock" & Chr(34)},
           {"Weather", Chr(34) & "Weather" & Chr(34)},
           {"Soil", Chr(34) & "Soil" & Chr(34)},
           {"Surface Organic Matter", Chr(34) & "SurfaceOrganicMatter" & Chr(34)},
           {"Micro Climate", Chr(34) & "MicroClimate" & Chr(34)},
           {"Crop", Chr(34) & "Crop" & Chr(34)},
           {"Manager", Chr(34) & "Manager" & Chr(34)},
           {"Report", Chr(34) & "Report" & Chr(34)},
           {"Other", Chr(34) & "Other" & Chr(34)}}

        Dim dctSoilChildInspectElements As New Dictionary(Of String, String) From {
           {"Meta data", Chr(34) & "Metadata" & Chr(34)},
           {"Water", Chr(34) & "Water" & Chr(34)},
           {"Initia lWater", Chr(34) & "InitialWater" & Chr(34)},
           {"Chemical", Chr(34) & "Chemical" & Chr(34)},
           {"Physical", Chr(34) & "Physical" & Chr(34)},
           {"Analysis", Chr(34) & "Analysis" & Chr(34)},
           {"Soil Water", Chr(34) & "SoilWater" & Chr(34)},
           {"Initial N", Chr(34) & "InitialN" & Chr(34)},
           {"Sample", Chr(34) & "Sample" & Chr(34)},
           {"Nutrient", Chr(34) & "Nutrient" & Chr(34)},
           {"Organic", Chr(34) & "Organic" & Chr(34)}}

        ucrInputComboList.SetParameter(New RParameter("example", 0))
        ucrInputComboList.SetItems(dctExamplesModels)
        ucrInputComboList.SetDropDownStyleAsNonEditable()

        ucrInputNode.SetParameter(New RParameter("node", 2))
        ucrInputNode.SetItems(dctNodeElements)
        ucrInputComboList.SetDropDownStyleAsNonEditable()

        ucrInputSoilChildInspect.SetParameter(New RParameter("soil.child", 3))
        ucrInputSoilChildInspect.SetItems(dctSoilChildInspectElements)
        ucrInputSoilChildInspect.SetDropDownStyleAsNonEditable()

        'ucrNudParameterPosition.SetParameter(New RParameter("p", 2))
        'ucrNudParameterPosition.SetLinkedDisplayControl(lbldigits)
        'ucrNudParameterPosition.SetMinMax(1, 10)
        'ucrNudParameterPosition.Increment = 1
        'ucrNudParameterPosition.SetRDefault(3)

    End Sub

    Private Sub SetDefaults()
        clsApsimxExampleFunction = New RFunction
        clsBaseFunction = New RFunction
        clsDataListFunction = New RFunction
        clsReportOperator = New ROperator
        clsNodeListFunction = New RFunction
        clsInspectApsimxFunction = New RFunction
        clsSoilChildEditListFunction = New RFunction

        clsReportOperator.SetOperation("$")
        clsReportOperator.AddParameter("left", "Rotation", iPosition:=0)
        clsReportOperator.AddParameter("right", "Report", iPosition:=1)
        clsReportOperator.bSpaceAroundOperation = False
        clsReportOperator.SetAssignTo("Rotation")

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsDataListFunction, iPosition:=0)
        clsDataListFunction.SetRCommand("list")
        clsApsimxExampleFunction.SetPackageName("apsimx")
        clsApsimxExampleFunction.SetRCommand("apsimx_example")
        clsApsimxExampleFunction.AddParameter("example", Chr(34) & "Barley" & Chr(34), iPosition:=0)

        clsNodeListFunction.SetRCommand("list")
        clsInspectApsimxFunction.SetPackageName("apsimx")
        clsInspectApsimxFunction.SetRCommand("inspect_apsimx")
        clsInspectApsimxFunction.AddParameter("node", Chr(34) & "Clock" & Chr(34), iPosition:=2)

        clsSoilChildInspectListFunction.SetRCommand("list")
        clsInspectApsimxFunction.SetPackageName("apsimx")
        clsInspectApsimxFunction.SetRCommand("inspect_apsimx")
        clsInspectApsimxFunction.AddParameter("soil.child", Chr(34) & "Physical" & Chr(34), iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)



    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkSilent.SetRCode(clsApsimxExampleFunction, bReset)
        ucrInputComboList.SetRCode(clsApsimxExampleFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(ucrInputSaveData.GetText <> "")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputPath_ControlContentsChanged(ucrChangedControl As ucrCore)
        TestOKEnabled()
    End Sub

    Private Sub lblExampleList_Click(sender As Object, e As EventArgs) Handles lblExampleList.Click

    End Sub

    Private Sub ucrInputComboList_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboList.ControlValueChanged
        Dim strDataName As String = frmMain.clsRLink.MakeValidText(ucrInputComboList.GetText)
        ucrInputSaveData.SetText(strDataName)
        clsApsimxExampleFunction.SetAssignTo(strDataName)
        clsDataListFunction.ClearParameters()
        ucrBase.clsRsyntax.ClearCodes()
        If ucrInputComboList.GetText = "Rotation" Then
            clsDataListFunction.AddParameter(strDataName, clsRFunctionParameter:=clsApsimxExampleFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsApsimxExampleFunction, 0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsReportOperator, 1)
        Else
            clsDataListFunction.AddParameter(ucrInputSaveData.GetText, clsRFunctionParameter:=clsApsimxExampleFunction, iPosition:=0)
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)
    End Sub
End Class