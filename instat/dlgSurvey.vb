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
    Private iBasicHeight As Integer
    Private iBaseMaxY As Integer
    Private iSaveMaxY As Integer
    Private iucrID As Integer
    Private clsSvydesignFunction As New RFunction
    Private clsSvrepDesignFunction, clsSvyTotalFunction, ClsTableFunction, clsSvycoFunction, clsSvymeanFunction, clsVarFunction, clsSvyContrastFunction, clsSvyQuantileFunction, clsSvySDFunction As New RFunction
    Private clsSummaryFunction, clsDummyFunction, clsRatioFunction, clsSvygofchisqFunction, clsSvychisqFunction As New RFunction
    Private clsDCastLeftContextFormula, clsVar2Operator, clsDollarOperator, clsWeightsOperator, clsIdOperator, clsFpcOperator, clsStrataOperator, clsXOperator, clsVar1operator As New ROperator


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

        ucrSelectorSurvey.SetParameter(New RParameter("data", 0))
        ucrSelectorSurvey.SetParameterIsString()

        ucrReceiverFPC.SetParameter(New RParameter("fpc", 1))
        ucrReceiverFPC.Selector = ucrSelectorSurvey
        ucrReceiverFPC.bWithQuotes = False
        ucrReceiverFPC.SetParameterIsString()
        ucrReceiverFPC.SetMeAsReceiver()

        ucrReceiverSingleID.SetParameter(New RParameter("ids", 11))
        ucrReceiverSingleID.Selector = ucrSelectorSurvey
        ucrReceiverSingleID.bWithQuotes = False
        ucrReceiverSingleID.SetParameterIsString()
        ucrReceiverSingleID.SetMeAsReceiver()

        ucrReceiverMultipleId.SetParameter(New RParameter("ids", 13))
        ucrReceiverMultipleId.SetParameterIsString()
        ucrReceiverMultipleId.bWithQuotes = False
        ucrReceiverMultipleId.Selector = ucrSelectorSurvey
        ucrReceiverMultipleId.SetLinkedDisplayControl(lblMultipleId)

        ucrInputId.SetParameter(New RParameter("ids", 2))
        ucrInputId.AddQuotesIfUnrecognised = False
        ucrInputId.SetLinkedDisplayControl(lblInputID)

        ucrReceiverMultipleFPC.SetParameter(New RParameter("fpc", 12))
        ucrReceiverMultipleFPC.SetParameterIsString()
        ucrReceiverMultipleFPC.bWithQuotes = False
        ucrReceiverMultipleFPC.Selector = ucrSelectorSurvey
        ucrReceiverMultipleFPC.SetLinkedDisplayControl(lblMultipleFPC)

        ucrReceiverStrata.SetParameter(New RParameter("strata", 4))
        ucrReceiverStrata.Selector = ucrSelectorSurvey
        ucrReceiverStrata.bWithQuotes = False
        ucrReceiverStrata.SetParameterIsString()
        ucrReceiverStrata.SetMeAsReceiver()
        ucrReceiverStrata.SetLinkedDisplayControl(lblStrata)

        ucrReceiverWeights.SetParameter(New RParameter("weights", 3))
        ucrReceiverWeights.Selector = ucrSelectorSurvey
        ucrReceiverWeights.bWithQuotes = False
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.SetMeAsReceiver()

        ucrReceiverMultipleVar2.SetParameter(New RParameter("x", 5))
        ucrReceiverMultipleVar2.SetParameterIsString()
        ucrReceiverMultipleVar2.bWithQuotes = False
        ucrReceiverMultipleVar2.Selector = ucrSelectorSurvey

        ucrChkSummary.SetText("Summary")
        ucrChkSummary.SetParameter(New RParameter("check", 7))
        ucrChkSummary.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkSummary.SetRDefault("TRUE")

        ucrChkMultistageSampling.SetText("Multistage Sampling")
        ucrChkMultistageSampling.AddParameterValuesCondition(True, "Sampling", "False")
        ucrChkMultistageSampling.AddParameterValuesCondition(False, "Sampling", "True")
        ucrChkMultistageSampling.AddToLinkedControls({ucrReceiverMultipleFPC, ucrReceiverMultipleId}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSummaryStat.SetParameter(New RParameter("x", 11, bNewIncludeArgumentName:=False))
        dctInputSummaryStat.Add("total", Chr(34) & "total" & Chr(34))
        dctInputSummaryStat.Add("mean", Chr(34) & "mean" & Chr(34))
        dctInputSummaryStat.Add("variance", Chr(34) & "variance" & Chr(34))
        dctInputSummaryStat.Add("quantile", Chr(34) & "quantile" & Chr(34))
        dctInputSummaryStat.Add("standard deviation", Chr(34) & "standard deviation" & Chr(34))
        dctInputSummaryStat.Add("correlation", Chr(34) & "correlation" & Chr(34))
        ucrInputSummaryStat.SetItems(dctInputSummaryStat)
        ucrInputSummaryStat.SetDropDownStyleAsNonEditable()

        'panel setting
        ucrPnlMethod.SetParameter(New RParameter("checked", 0))
        ucrPnlMethod.AddRadioButton(rdoSRS, "srs")
        ucrPnlMethod.AddRadioButton(rdoStratified, "strati")
        ucrPnlMethod.AddRadioButton(rdoClustered, "cluster")

        'ucrPnlMethod.AddToLinkedControls(ucrReceiverFPC, {rdoStratified, rdoClustered, rdoSRS}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrInputId, {rdoSRS, rdoStratified}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls({ucrChkMultistageSampling, ucrReceiverSingleID}, {rdoClustered}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        clsSvycoFunction = New RFunction
        clsDummyFunction = New RFunction
        ClsTableFunction = New RFunction
        clsSvygofchisqFunction = New RFunction

        clsWeightsOperator = New ROperator
        clsSvychisqFunction = New RFunction

        clsIdOperator = New ROperator
        clsFpcOperator = New ROperator
        clsStrataOperator = New ROperator
        clsXOperator = New ROperator
        clsVar2Operator = New ROperator
        clsDCastLeftContextFormula = New ROperator
        clsDollarOperator = New ROperator

        ucrInputSummaryStat.SetName("mean")

        clsDummyFunction.AddParameter("checked", "srs", iPosition:=0)
        clsDummyFunction.AddParameter("...", "True", iPosition:=1)
        clsDummyFunction.AddParameter("Sampling", "True", iPosition:=2)

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

        clsVar2Operator.SetOperation("~")
        clsVar2Operator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVar2Operator.bSpaceAroundOperation = False

        clsVar1operator.SetOperation("~")
        clsVar1operator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVar1operator.bSpaceAroundOperation = False

        ucrSelectorSurvey.Reset()
        ucrReceiverMultipleVar2.SetMeAsReceiver()

        clsSvydesignFunction.SetPackageName("survey")
        clsSvydesignFunction.SetRCommand("svydesign")
        clsSvydesignFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorSurvey.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=4)
        clsSvydesignFunction.AddParameter("weights", clsROperatorParameter:=clsWeightsOperator, iPosition:=3)
        clsSvydesignFunction.AddParameter("fpc", clsROperatorParameter:=clsFpcOperator, iPosition:=2)
        clsSvydesignFunction.AddParameter("ids", clsROperatorParameter:=clsIdOperator, iPosition:=0)
        'clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        'clsRatioFunction.SetPackageName("survey")
        'clsRatioFunction.SetRCommand("svyratio")
        'clsRatioFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        'clsRatioFunction.AddParameter("denominator", clsROperatorParameter:=clsVar1operator, iPosition:=1)
        'clsRatioFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=2)
        'clsRatioFunction.iCallType = 2

        clsSvychisqFunction.SetPackageName("survey")
        clsSvychisqFunction.SetRCommand("svychisq")
        clsSvychisqFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvychisqFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvychisqFunction.AddParameter("statistic", Chr(34) & "F" & Chr(34), iPosition:=2)
        clsSvychisqFunction.iCallType = 2

        clsSvrepDesignFunction.SetPackageName("survey")
        clsSvrepDesignFunction.SetRCommand("as.svrepdesign")
        clsSvrepDesignFunction.AddParameter("design", clsRFunctionParameter:=clsSvydesignFunction, iPosition:=0)
        clsSvrepDesignFunction.iCallType = 2

        clsSvymeanFunction.SetPackageName("survey")
        clsSvymeanFunction.SetRCommand("svymean")
        clsSvymeanFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvymeanFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvymeanFunction.iCallType = 2

        clsSvyQuantileFunction.SetPackageName("survey")
        clsSvyQuantileFunction.SetRCommand("svyquantile")
        clsSvyQuantileFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyQuantileFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyQuantileFunction.AddParameter("quantiles", "c(.25,.5,.75)", iPosition:=2, bIncludeArgumentName:=False)
        clsSvyQuantileFunction.iCallType = 2

        clsSvySDFunction.SetPackageName("jtools")
        clsSvySDFunction.SetRCommand("svysd")
        clsSvySDFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvySDFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvySDFunction.iCallType = 2

        clsSvycoFunction.SetPackageName("jtools")
        clsSvycoFunction.SetRCommand("svycor")
        clsSvycoFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvycoFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvycoFunction.iCallType = 2

        clsSvyTotalFunction.SetPackageName("survey")
        clsSvyTotalFunction.SetRCommand("svytotal")
        clsSvyTotalFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyTotalFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyTotalFunction.iCallType = 2

        clsVarFunction.SetPackageName("survey")
        clsVarFunction.SetRCommand("svyvar")
        clsVarFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsVarFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsVarFunction.iCallType = 2


        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSvydesignFunction)
        AddSummaryParameters()
        UpdateContextVariables()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverFPC.SetRCode(clsFpcOperator, bReset)
        ucrReceiverMultipleFPC.SetRCode(clsFpcOperator, bReset)
        ucrInputId.SetRCode(clsIdOperator, bReset)
        ucrReceiverMultipleId.SetRCode(clsIdOperator, bReset)
        ucrReceiverSingleID.SetRCode(clsIdOperator, bReset)
        ucrReceiverStrata.SetRCode(clsStrataOperator, bReset)
        'ucrReceiverSingleVar2.SetRCode(clsVar2Operator, bReset)
        ucrReceiverWeights.SetRCode(clsWeightsOperator, bReset)
        ucrChkSummary.SetRCode(clsSummaryFunction, bReset)
        'ucrChkRatios.SetRCode(clsRatioFunction, bReset)
        'ucrChkTests.SetRCode(clsDummyFunction, bReset)
        'ucrChkContingencyTables.SetRCode(clsSvychisqFunction, bReset)
        ucrChkMultistageSampling.SetRCode(clsDummyFunction, bReset)
        ucrPnlMethod.SetRCode(clsDummyFunction, bReset)




        AddSummaryStatParameters()
    End Sub

    Private Sub TestOkEnabled()

    End Sub



    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlValueChanged
        RemoveStrata()
        'ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)

        If rdoStratified.Checked Then
            'ucrReceiverStrata.Visible = True
            ucrInputId.Visible = True
            ucrChkMultistageSampling.Visible = False
            'clsSvydesignFunction.AddParameter("strata")
        ElseIf rdoClustered.Checked Then
            ucrChkMultistageSampling.Visible = True
            'clsSvydesignFunction.RemoveParameterByName("strata")
            ucrInputId.Visible = False
            'ucrReceiverStrata.Visible = False
            If ucrChkMultistageSampling.Checked Then
                ucrReceiverMultipleFPC.Visible = True
                ucrReceiverMultipleId.Visible = True
                ucrReceiverSingleID.Visible = False
            Else
                ucrReceiverMultipleFPC.Visible = False
                ucrReceiverMultipleId.Visible = False
                ucrReceiverSingleID.Visible = True
            End If
        Else
            ucrInputId.Visible = True
            'ucrReceiverStrata.Visible = False
            ucrChkMultistageSampling.Visible = False
            'clsSvydesignFunction.RemoveParameterByName("strata")
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
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "variance" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsVarFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "total" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyTotalFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "standard deviation" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvySDFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "quantile" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyQuantileFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        Else
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvycoFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
        End If
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub Sampling()
        If ucrChkMultistageSampling.Checked Then
            ucrReceiverMultipleFPC.Visible = True
            ucrReceiverMultipleId.Visible = True
            ucrReceiverFPC.Visible = False
            ucrReceiverSingleID.Visible = False
        Else
            ucrReceiverMultipleFPC.Visible = False
            ucrReceiverMultipleId.Visible = False
            ucrReceiverFPC.Visible = True
            ucrReceiverSingleID.Visible = True
        End If
    End Sub

    Private Sub ucrChkMultistageSampling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultistageSampling.ControlValueChanged
        Sampling()
    End Sub

    Private Sub ucrInputSummaryStat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSummaryStat.ControlValueChanged
        AddSummaryStatParameters()
    End Sub



    Private Sub UpdateContextVariables()
        Dim i As Integer = 0

        If Not ucrReceiverMultipleVar2.IsEmpty Then
            clsDCastLeftContextFormula.ClearParameters()
            For Each strContextVar As String In ucrReceiverMultipleVar2.GetVariableNamesAsList
                clsDCastLeftContextFormula.AddParameter(i, strContextVar, iPosition:=i)
                i = i + 1
            Next
            clsXOperator.AddParameter("right", clsROperatorParameter:=clsDCastLeftContextFormula)
        End If
    End Sub



    Private Sub ucrReceiverMultipleVar2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleVar2.ControlValueChanged
        UpdateContextVariables()
    End Sub



    Private Sub RemoveStrata()
        clsSvydesignFunction.RemoveParameterByName("strata")
        If rdoStratified.Checked Then
            clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)
        Else
            clsSvydesignFunction.RemoveParameterByName("strata")
            'ucrInputIDColName.bAddRemoveParameter = False
        End If
    End Sub

    Private Sub ucrReceiverStrata_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStrata.ControlValueChanged
        RemoveStrata()
        'clsSvydesignFunction.RemoveParameterByName("strata")
        'If rdoStratified.Checked Then
        '    clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)
        'Else
        '    clsSvydesignFunction.RemoveParameterByName("strata")
        '    'ucrInputIDColName.bAddRemoveParameter = False
        'End If
    End Sub
End Class