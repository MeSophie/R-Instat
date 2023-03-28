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

Public Class dlgSurvey
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = True
    Private clsSvydesignFunction As New RFunction
    Private clsSvrepDesignFunction, clsSvyTotalFunction, clsSvymeanFunction, clsVarFunction, clsSvyContrastFunction, clsSvyQuantileFunction, clsSvySDFunction As New RFunction
    Private clsSummaryFunction, clsDummyFunction, clsRatioFunction, clsSvychisqFunction As New RFunction
    Private clsDCastLeftContextFormula, clsWeightsOperator, clsIdOperator, clsFpcOperator, clsStrataOperator, clsXOperator, clsVar1operator As New ROperator


    Private Sub dlgSurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputSummaryStat As New Dictionary(Of String, String)
        'Dim dctInputModelType As New Dictionary(Of String, String)
        'Dim dtcInputPlotType As New Dictionary(Of String, String)

        ucrSelectorSurvey.SetParameter(New RParameter("data", 0))
        ucrSelectorSurvey.SetParameterIsrfunction()

        ucrReceiverFPC.SetParameter(New RParameter("fpc", 1))
        ucrReceiverFPC.Selector = ucrSelectorSurvey
        ucrReceiverFPC.bWithQuotes = False
        ucrReceiverFPC.SetParameterIsString()
        ucrReceiverFPC.SetMeAsReceiver()

        ucrInputId.SetParameter(New RParameter("ids", 2))
        ucrInputId.AddQuotesIfUnrecognised = False
        ucrInputId.SetLinkedDisplayControl(lblId)

        ucrReceiverVar1.SetParameter(New RParameter("denominator", 6))
        ucrReceiverVar1.Selector = ucrSelectorSurvey
        ucrReceiverVar1.bWithQuotes = False
        ucrReceiverVar1.SetParameterIsString()
        ucrReceiverVar1.SetMeAsReceiver()
        ucrReceiverVar1.SetLinkedDisplayControl(lblVar1)

        ucrReceiverStrata.SetParameter(New RParameter("strata", 4))
        ucrReceiverStrata.Selector = ucrSelectorSurvey
        ucrReceiverStrata.bWithQuotes = False
        ucrReceiverStrata.SetParameterIsString()
        ucrReceiverStrata.SetMeAsReceiver()

        ucrReceiverWeights.SetParameter(New RParameter("weights", 3))
        ucrReceiverWeights.Selector = ucrSelectorSurvey
        ucrReceiverWeights.bWithQuotes = False
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.SetMeAsReceiver()

        ucrReceiverMultipleVar2.SetParameter(New RParameter("x", 5))
        'ucrReceiverMultipleVar2.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverMultipleVar2.SetParameterIsString()
        ucrReceiverMultipleVar2.bWithQuotes = False
        ucrReceiverMultipleVar2.Selector = ucrSelectorSurvey
        'ucrReceiverMultipleVar2.SetItemType("Data frame")
        'ucrReceiverMultipleVar2.strSelectorHeading = "Variables"
        'ucrReceiverMultipleVar2.strSelectorHeading = "Data Frames"


        'ucrVariablesAsFactorForSurvey.SetParameter(New RParameter("y", 1))
        ''ucrVariablesAsFactorForSurvey.SetFactorReceiver(ucrFactorOptionalReceiver)
        'ucrVariablesAsFactorForSurvey.Selector = ucrSelectorSurvey
        'ucrVariablesAsFactorForSurvey.strSelectorHeading = "Variables"
        'ucrVariablesAsFactorForSurvey.SetParameterIsString()
        'ucrVariablesAsFactorForSurvey.bWithQuotes = False
        'ucrVariablesAsFactorForSurvey.SetValuesToIgnore({Chr(34) & Chr(34)})
        'ucrVariablesAsFactorForSurvey.bAddParameterIfEmpty = True


        ucrChkSummary.SetText("Summary")
        ucrChkSummary.SetParameter(New RParameter("check", 7))
        ucrChkSummary.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkSummary.SetRDefault("TRUE")

        ucrChkContingencyTables.SetText("Contingency Tables")
        ucrChkContingencyTables.SetParameter(New RParameter("check", 8))
        ucrChkContingencyTables.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkContingencyTables.SetRDefault("FALSE")

        ucrChkRatios.SetText("Ratios")
        ucrChkRatios.SetParameter(New RParameter("check", 9))
        ucrChkRatios.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkRatios.SetRDefault("FALSE")
        ucrChkRatios.AddToLinkedControls(ucrReceiverVar1, {True}, bNewLinkedHideIfParameterMissing:=True)


        ucrChkTests.SetText("Tests")
        ucrChkTests.SetParameter(New RParameter("check", 10))
        ucrChkTests.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkTests.SetRDefault("FALSE")

        ucrInputSummaryStat.SetParameter(New RParameter("x", 11, bNewIncludeArgumentName:=False))
        dctInputSummaryStat.Add("total", Chr(34) & "total" & Chr(34))
        dctInputSummaryStat.Add("mean", Chr(34) & "mean" & Chr(34))
        dctInputSummaryStat.Add("variance", Chr(34) & "variance" & Chr(34))
        dctInputSummaryStat.Add("quantile", Chr(34) & "quantile" & Chr(34))
        dctInputSummaryStat.Add("standard deviation", Chr(34) & "standard deviation" & Chr(34))
        ucrInputSummaryStat.SetItems(dctInputSummaryStat)
        ucrInputSummaryStat.SetDropDownStyleAsNonEditable()

        'panel setting
        ucrPnlMethod.SetParameter(New RParameter("checked", 0))
        ucrPnlMethod.AddRadioButton(rdoSRS, "srs")
        ucrPnlMethod.AddRadioButton(rdoStratified, "strati")
        ucrPnlMethod.AddRadioButton(rdoClustered, "cluster")

        ucrPnlMethod.AddToLinkedControls(ucrReceiverStrata, {rdoStratified}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub SetDefaults()
        clsSvydesignFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsSvrepDesignFunction = New RFunction
        clsSvymeanFunction = New RFunction
        clsVarFunction = New RFunction
        clsSvyTotalFunction = New RFunction
        clsSvyQuantileFunction = New RFunction
        clsSvySDFunction = New RFunction
        clsDummyFunction = New RFunction

        clsWeightsOperator = New ROperator
        clsRatioFunction = New RFunction
        clsSvychisqFunction = New RFunction

        clsIdOperator = New ROperator
        clsFpcOperator = New ROperator
        clsStrataOperator = New ROperator
        clsXOperator = New ROperator
        clsDCastLeftContextFormula = New ROperator
        'clsDCastLeftFormula = New ROperator

        ucrInputSummaryStat.SetName("mean")

        clsDummyFunction.AddParameter("checked", "srs", iPosition:=0)
        clsDummyFunction.AddParameter("model", "True", iPosition:=1)

        'clsDCastLeftFormula.SetOperation("+")
        'clsDCastLeftFormula.bBrackets = False

        clsDCastLeftContextFormula.SetOperation("+")
        clsDCastLeftContextFormula.bBrackets = False

        clsWeightsOperator.SetOperation("~")
        clsWeightsOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsWeightsOperator.bSpaceAroundOperation = False

        clsIdOperator.SetOperation("~")
        clsIdOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsIdOperator.bSpaceAroundOperation = False

        clsFpcOperator.SetOperation("~")
        clsFpcOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsFpcOperator.bSpaceAroundOperation = False

        clsStrataOperator.SetOperation("~")
        clsStrataOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsStrataOperator.bSpaceAroundOperation = False

        clsXOperator.SetOperation("~")
        clsXOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsXOperator.bSpaceAroundOperation = False

        clsVar1operator.SetOperation("~")
        clsVar1operator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVar1operator.bSpaceAroundOperation = False

        ucrSelectorSurvey.Reset()
        ucrReceiverMultipleVar2.SetMeAsReceiver()
        'ucrVariablesAsFactorForSurvey.SetMeAsReceiver()

        clsSvydesignFunction.SetPackageName("survey")
        clsSvydesignFunction.SetRCommand("svydesign")
        clsSvydesignFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorSurvey.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=4)
        clsSvydesignFunction.AddParameter("weights", clsROperatorParameter:=clsWeightsOperator, iPosition:=3)
        clsSvydesignFunction.AddParameter("fpc", clsROperatorParameter:=clsFpcOperator, iPosition:=2)
        clsSvydesignFunction.AddParameter("ids", clsROperatorParameter:=clsIdOperator, iPosition:=0)
        clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        clsRatioFunction.SetPackageName("survey")
        clsRatioFunction.SetRCommand("svyratio")
        clsRatioFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsRatioFunction.AddParameter("denominator", clsROperatorParameter:=clsVar1operator, iPosition:=1)
        clsRatioFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=2)
        clsRatioFunction.iCallType = 2

        clsSvychisqFunction.SetPackageName("survey")
        clsSvychisqFunction.SetRCommand("svychisq")
        clsSvychisqFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvychisqFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvychisqFunction.AddParameter("statistic", Chr(34) & "F" & Chr(34), iPosition:=2)
        clsSvychisqFunction.iCallType = 2

        clsSvrepDesignFunction.SetPackageName("survey")
        clsSvrepDesignFunction.SetRCommand("as.svrepdesign")
        clsSvrepDesignFunction.AddParameter("design", clsRFunctionParameter:=clsSvydesignFunction, iPosition:=0)

        clsSvymeanFunction.SetPackageName("survey")
        clsSvymeanFunction.SetRCommand("svymean")
        clsSvymeanFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvymeanFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        'clsSvymeanFunction.AddParameter("x", Chr(34) & "mean" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
        clsSvymeanFunction.iCallType = 2

        clsSvyQuantileFunction.SetPackageName("survey")
        clsSvyQuantileFunction.SetRCommand("svyquantile")
        clsSvyQuantileFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyQuantileFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyQuantileFunction.AddParameter("quantiles", "c(.25,.5,.75)", iPosition:=2, bIncludeArgumentName:=False)

        clsSvySDFunction.SetPackageName("survey")
        clsSvySDFunction.SetRCommand("svysd")
        clsSvySDFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvySDFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)


        clsSvyTotalFunction.SetPackageName("survey")
        clsSvyTotalFunction.SetRCommand("svytotal")
        clsSvyTotalFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyTotalFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)


        clsVarFunction.SetPackageName("survey")
        clsVarFunction.SetRCommand("svyvar")
        clsVarFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsVarFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSvydesignFunction)
        AddSummaryParameters()
        UpdateContextVariables()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrReceiverMultipleVar2.AddAdditionalCodeParameterPair(clsXOperator, New RParameter("x", 5), iAdditionalPairNo:=1)
        'ucrReceiverMultipleVar2.AddAdditionalCodeParameterPair(clsSvyQuantileFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        'ucrReceiverMultipleVar2.AddAdditionalCodeParameterPair(clsSvyTotalFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        'ucrReceiverMultipleVar2.AddAdditionalCodeParameterPair(clsVarFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        'ucrReceiverMultipleVar2.AddAdditionalCodeParameterPair(clsSvySDFunction, New RParameter("formula", 0), iAdditionalPairNo:=5)
        bRCodeSet = False

        ucrReceiverFPC.SetRCode(clsFpcOperator, bReset)
        ucrInputId.SetRCode(clsIdOperator, bReset)
        ucrReceiverStrata.SetRCode(clsStrataOperator, bReset)
        ucrReceiverVar1.SetRCode(clsVar1operator, bReset)
        ucrReceiverWeights.SetRCode(clsWeightsOperator, bReset)
        ucrChkSummary.SetRCode(clsSummaryFunction, bReset)
        ucrChkRatios.SetRCode(clsRatioFunction, bReset)
        ucrChkContingencyTables.SetRCode(clsSvychisqFunction, bReset)
        ucrPnlMethod.SetRCode(clsDummyFunction, bReset)

        'ucrReceiverFPC.SetRCode(clsDCastLeftFormula, bReset)

        'ucrReceiverMultipleVar2.SetRCode(clsDCastLeftContextFormula, bReset)
        'ucrVariablesAsFactorForSurvey.SetRCode(clsXOperator, bReset)

        bRCodeSet = True

        'UpdateContextVariables()
        AddSummaryStatParameters()
    End Sub

    Private Sub TestOkEnabled()
        'If Not ucrReceiverFPC.IsEmpty AndAlso Not ucrReceiverId.IsEmpty AndAlso Not ucrReceiverWeights.IsEmpty Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlValueChanged
        If rdoStratified.Checked Then
            ucrReceiverStrata.Visible = True
            lblStrata.Visible = True
        Else
            ucrReceiverStrata.Visible = False
            lblStrata.Visible = False
            clsSvydesignFunction.RemoveParameterByName("strata")
        End If
    End Sub

    Private Sub AddSummaryParameters()
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
    End Sub

    Private Sub AddSummaryStatParameters()
        If ucrInputSummaryStat.GetText = "mean" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvymeanFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
        ElseIf ucrInputSummaryStat.GetText = "variance" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsVarFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
        ElseIf ucrInputSummaryStat.GetText = "total" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyTotalFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
        ElseIf ucrInputSummaryStat.GetText = "standard deviation" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvySDFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
        Else
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyQuantileFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
        End If
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkRatios_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRatios.ControlValueChanged
        If ucrChkRatios.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsRatioFunction, iPosition:=0)
            ucrReceiverVar1.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRatioFunction)
            ucrReceiverVar1.Visible = False
        End If
    End Sub

    Private Sub ucrChkContingencyTables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkContingencyTables.ControlValueChanged
        If ucrChkContingencyTables.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvychisqFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvychisqFunction)
        End If
    End Sub

    Private Sub ucrInputSummaryStat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSummaryStat.ControlValueChanged
        AddSummaryStatParameters()
    End Sub

    Private Sub UpdateContextVariables()
        Dim i As Integer = 0

        'If bRCodeSet Then

        If Not ucrReceiverMultipleVar2.IsEmpty Then
            clsDCastLeftContextFormula.ClearParameters()
            For Each strContextVar As String In ucrReceiverMultipleVar2.GetVariableNamesAsList
                clsDCastLeftContextFormula.AddParameter(i, strContextVar, iPosition:=i)
                i = i + 1
            Next
            clsXOperator.AddParameter("right", clsROperatorParameter:=clsDCastLeftContextFormula)
        End If
        'If clsDCastLeftContextFormula.clsParameters.Count = 0 Then
        '    clsDCastLeftFormula.RemoveParameterByName("1")
        'Else
        '    clsDCastLeftFormula.AddParameter("1", clsROperatorParameter:=clsDCastLeftContextFormula, iPosition:=1)
        'End If
        'End If
    End Sub

    Private Sub ucrReceiverMultipleVar2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleVar2.ControlValueChanged
        UpdateContextVariables()
    End Sub
End Class