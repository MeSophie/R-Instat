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
    Private clsSvydesignFunction As New RFunction
    Private clsSvrepDesignFunction, clsSvyTotalFunction, clsSvymeanFunction, clsVarFunction, clsSvyContrastFunction, clsSvyQuantileFunction, clsSvySDFunction As New RFunction
    Private clsSvyBoxplotFunction, clsPlotSmoothFunction, clsSvyHistFunction, clsSvycoplotFunction, clsSvySmoothFunction, clsSvyqqPlotFunction, clsSvyqqmathFunction As New RFunction
    Private clsSummaryFunction, clsDummyFunction, clsRatioFunction, clsSvychisqFunction As New RFunction
    Private clsWeightsOperator, clsIdOperator, clsFpcOperator, clsStrataOperator, clsXOperator, clsVar1operator As New ROperator


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
        Dim dctInputModelType As New Dictionary(Of String, String)
        Dim dtcInputPlotType As New Dictionary(Of String, String)

        ucrReceiverFPC.SetParameter(New RParameter("fpc", 2))
        ucrReceiverFPC.Selector = ucrSelectorSurvey
        ucrReceiverFPC.bWithQuotes = False
        ucrReceiverFPC.SetParameterIsString()
        ucrReceiverFPC.SetMeAsReceiver()

        ucrInputId.SetParameter(New RParameter("ids", 3))
        ucrInputId.AddQuotesIfUnrecognised = False
        ucrInputId.SetLinkedDisplayControl(lblId)

        ucrReceiverVar1.SetParameter(New RParameter("denominator", 14))
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

        ucrReceiverWeights.SetParameter(New RParameter("weights", 1))
        ucrReceiverWeights.Selector = ucrSelectorSurvey
        ucrReceiverWeights.bWithQuotes = False
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.SetMeAsReceiver()

        ucrVariablesAsFactorforVar.SetParameter(New RParameter("x", 0))
        'ucrVariablesAsFactorforVar.SetFactorReceiver(ucrInputSummaryStat)
        ucrVariablesAsFactorforVar.Selector = ucrSelectorSurvey
        ucrVariablesAsFactorforVar.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforVar.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforVar.bWithQuotes = False
        ucrVariablesAsFactorforVar.SetParameterIsString()

        ucrChkModel.SetText("Model")
        ucrChkModel.AddParameterValuesCondition(True, "model", "False")
        ucrChkModel.AddParameterValuesCondition(False, "model", "True")
        ucrChkModel.AddToLinkedControls({ucrChkModelPlot, ucrInputModelType, ucrChkModelSummary}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSummary.SetText("Summary")
        ucrChkSummary.SetParameter(New RParameter("check", 7))
        ucrChkSummary.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkSummary.SetRDefault("TRUE")

        ucrChkModelSummary.SetText("Summary Model")
        ucrChkModelSummary.SetParameter(New RParameter("check", 8))
        ucrChkModelSummary.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkModelSummary.SetRDefault("TRUE")

        ucrChkModelPlot.SetText("Model Plot")
        ucrChkModelPlot.SetParameter(New RParameter("check", 9))
        ucrChkModelPlot.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkModelPlot.SetRDefault("FALSE")

        ucrChkContingencyTables.SetText("Contingency Tables")
        ucrChkContingencyTables.SetParameter(New RParameter("check", 10))
        ucrChkContingencyTables.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkContingencyTables.SetRDefault("FALSE")

        ucrChkRatios.SetText("Ratios")
        ucrChkRatios.SetParameter(New RParameter("check", 11))
        ucrChkRatios.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkRatios.SetRDefault("FALSE")
        ucrChkRatios.AddToLinkedControls(ucrReceiverVar1, {True}, bNewLinkedHideIfParameterMissing:=True)


        ucrChkTests.SetText("Tests")
        ucrChkTests.SetParameter(New RParameter("check", 12))
        ucrChkTests.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkTests.SetRDefault("FALSE")

        ucrInputSummaryStat.SetParameter(New RParameter("x", 13))
        dctInputSummaryStat.Add("total", Chr(34) & "total" & Chr(34))
        dctInputSummaryStat.Add("mean", Chr(34) & "mean" & Chr(34))
        dctInputSummaryStat.Add("variance", Chr(34) & "variance" & Chr(34))
        dctInputSummaryStat.Add("quantile", Chr(34) & "quantile" & Chr(34))
        dctInputSummaryStat.Add("standard deviation", Chr(34) & "standard deviation" & Chr(34))
        ucrInputSummaryStat.SetItems(dctInputSummaryStat)
        ucrInputSummaryStat.SetDropDownStyleAsNonEditable()

        ucrInputModelType.SetParameter(New RParameter("y", 13))
        dctInputModelType.Add("linear regression", Chr(34) & "linear regression" & Chr(34))
        dctInputModelType.Add("multiple regression", Chr(34) & "multiple regression" & Chr(34))
        dctInputModelType.Add("logistic regression", Chr(34) & "logitic regression" & Chr(34))
        dctInputModelType.Add("linear association", Chr(34) & "linear association" & Chr(34))
        'dctInputModelType.Add("log-linear regression", Chr(34) & "log-linear regression" & Chr(34))
        ucrInputModelType.SetItems(dctInputModelType)
        ucrInputModelType.SetDropDownStyleAsNonEditable()
        ucrInputModelType.SetLinkedDisplayControl(lblModelType)

        ucrInputPlotType.SetParameter(New RParameter("z", 14))
        dtcInputPlotType.Add("boxplot", Chr(34) & "boxplot" & Chr(34))
        dtcInputPlotType.Add("histogram", Chr(34) & "histogram" & Chr(34))
        dtcInputPlotType.Add("smooth plots", Chr(34) & "smooth plots" & Chr(34))
        dtcInputPlotType.Add("quantile plots", Chr(34) & "quantile plots" & Chr(34))
        dtcInputPlotType.Add("conditioning plots", Chr(34) & "conditioning plots" & Chr(34))
        'dtcInputPlotType.Add("dotplot", Chr(34) & "dotplot" & Chr(34))
        'dtcInputPlotType.Add("log-linear regression", Chr(34) & "log-linear regression" & Chr(34))
        ucrInputPlotType.SetItems(dtcInputPlotType)
        ucrInputPlotType.SetDropDownStyleAsNonEditable()

        'panel setting
        ucrPnlMethod.SetParameter(New RParameter("checked", 0))
        ucrPnlMethod.AddRadioButton(rdoSRS, "srs")
        ucrPnlMethod.AddRadioButton(rdoStratified, "strati")
        ucrPnlMethod.AddRadioButton(rdoClustered, "cluster")
        'ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoSRS, "checked", "srs")
        'ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoStratified, "checked", "strati")
        'ucrPnlMethod.AddParameterValueFunctionNamesCondition(rdoClustered, "checked", "clustered")

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
        clsSvyBoxplotFunction = New RFunction
        clsSvyHistFunction = New RFunction
        clsSvySmoothFunction = New RFunction
        clsSvyqqmathFunction = New RFunction
        clsSvyqqPlotFunction = New RFunction
        'clsSvyContrastFunction = New RFunction
        clsWeightsOperator = New ROperator
        clsRatioFunction = New RFunction
        clsSvychisqFunction = New RFunction
        clsSvycoplotFunction = New RFunction
        clsPlotSmoothFunction = New RFunction

        clsIdOperator = New ROperator
        clsFpcOperator = New ROperator
        clsStrataOperator = New ROperator
        clsXOperator = New ROperator

        ucrInputSummaryStat.SetName("mean")

        ucrInputModelType.SetName("linear regression")

        ucrInputPlotType.SetName("boxplot")

        clsDummyFunction.AddParameter("checked", "srs", iPosition:=0)
        clsDummyFunction.AddParameter("model", "True", iPosition:=1)

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
        ucrVariablesAsFactorforVar.SetMeAsReceiver()


        clsSvydesignFunction.SetPackageName("survey")
        clsSvydesignFunction.SetRCommand("svydesign")
        clsSvydesignFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorSurvey.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=4)
        clsSvydesignFunction.AddParameter("weights", clsROperatorParameter:=clsWeightsOperator, iPosition:=3)
        clsSvydesignFunction.AddParameter("fpc", clsROperatorParameter:=clsFpcOperator, iPosition:=2)
        clsSvydesignFunction.AddParameter("ids", clsROperatorParameter:=clsIdOperator, iPosition:=0)
        clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)


        clsSummaryFunction.SetPackageName("dplyr")
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

        clsSvyHistFunction.SetPackageName("survey")
        clsSvyHistFunction.SetRCommand("svyhist")
        clsSvyHistFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyHistFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyHistFunction.iCallType = 2

        clsSvyBoxplotFunction.SetPackageName("survey")
        clsSvyBoxplotFunction.SetRCommand("svyboxplot")
        clsSvyBoxplotFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyBoxplotFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyBoxplotFunction.iCallType = 2

        clsSvycoplotFunction.SetPackageName("survey")
        clsSvycoplotFunction.SetRCommand("svycoplot")
        clsSvycoplotFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvycoplotFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvycoplotFunction.iCallType = 2

        clsSvySmoothFunction.SetPackageName("survey")
        clsSvySmoothFunction.SetRCommand("svysmooth")
        clsSvySmoothFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvySmoothFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvySmoothFunction.iCallType = 2

        clsSvyqqmathFunction.SetPackageName("survey")
        clsSvyqqmathFunction.SetRCommand("svyqqmath")
        clsSvyqqmathFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyqqmathFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyqqmathFunction.iCallType = 2

        clsSvyqqPlotFunction.SetPackageName("survey")
        clsSvyqqPlotFunction.SetRCommand("svyqqplot")
        clsSvyqqPlotFunction.AddParameter("formula", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvyqqPlotFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyqqPlotFunction.iCallType = 2

        clsSvrepDesignFunction.SetPackageName("survey")
        clsSvrepDesignFunction.SetRCommand("as.svrepdesign")
        clsSvrepDesignFunction.AddParameter("design", clsRFunctionParameter:=clsSvydesignFunction, iPosition:=0)


        clsSvymeanFunction.SetPackageName("survey")
        clsSvymeanFunction.SetRCommand("svymean")
        clsSvymeanFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        clsSvymeanFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvymeanFunction.iCallType = 2

        'clsSvyContrastFunction.SetPackageName("survey")
        'clsSvyContrastFunction.SetRCommand("svycontrast")
        'clsSvyContrastFunction.AddParameter("x", clsROperatorParameter:=clsXOperator, iPosition:=0)
        'clsSvyContrastFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)

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

        clsPlotSmoothFunction.SetPackageName("graphics")
        clsPlotSmoothFunction.SetRCommand("plot")
        clsPlotSmoothFunction.AddParameter("x", clsRFunctionParameter:=clsSvySmoothFunction, iPosition:=0)

        'clsSvymeanFunction.AddParameter("x", iPosition:=0)
        'clsSvymeanFunction.AddParameter("", clsROperatorParameter:=clsStrataOperator, iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSvydesignFunction)
        AddSummaryParameters()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvySDFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvyQuantileFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvyTotalFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsVarFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsRatioFunction, New RParameter("formula", 0), iAdditionalPairNo:=5)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvychisqFunction, New RParameter("formula", 0), iAdditionalPairNo:=6)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvyHistFunction, New RParameter("formula", 0), iAdditionalPairNo:=7)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvyBoxplotFunction, New RParameter("formula", 0), iAdditionalPairNo:=8)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvycoplotFunction, New RParameter("formula", 0), iAdditionalPairNo:=9)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvySmoothFunction, New RParameter("formula", 0), iAdditionalPairNo:=10)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvyqqPlotFunction, New RParameter("formula", 0), iAdditionalPairNo:=11)
        ucrVariablesAsFactorforVar.AddAdditionalCodeParameterPair(clsSvySDFunction, New RParameter("formula", 0), iAdditionalPairNo:=12)

        ucrReceiverFPC.SetRCode(clsFpcOperator, bReset)
        ucrInputId.SetRCode(clsIdOperator, bReset)
        ucrReceiverStrata.SetRCode(clsStrataOperator, bReset)
        ucrReceiverVar1.SetRCode(clsVar1operator, bReset)
        ucrReceiverWeights.SetRCode(clsWeightsOperator, bReset)
        ucrChkSummary.SetRCode(clsSummaryFunction, bReset)
        ucrChkModelSummary.SetRCode(clsSummaryFunction, bReset)
        ucrChkRatios.SetRCode(clsRatioFunction, bReset)
        ucrChkContingencyTables.SetRCode(clsSvychisqFunction, bReset)
        ucrPnlMethod.SetRCode(clsDummyFunction, bReset)
        ucrChkModel.SetRCode(clsDummyFunction, bReset)
        'ucrInputSummaryStat.SetRCode(clsSummaryStatFunc, bReset)

        ucrVariablesAsFactorforVar.SetRCode(clsSvymeanFunction, bReset)
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
        '    Method()
        '    DialogSize()
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

    'Private Sub AddRatioParameters()
    '    clsRatioFunction.AddParameter("object", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
    'End Sub

    Private Sub AddSummaryStatParameters()
        If ucrInputSummaryStat.GetText = "mean" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvymeanFunction, iPosition:=0)
        ElseIf ucrInputSummaryStat.GetText = "variance" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsVarFunction, iPosition:=0)
        ElseIf ucrInputSummaryStat.GetText = "total" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyTotalFunction, iPosition:=0)
        ElseIf ucrInputSummaryStat.GetText = "standard deviation" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvySDFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyQuantileFunction, iPosition:=0)
        End If
    End Sub


    Private Sub AddModelTypeParameters()
        If ucrInputModelType.GetText = "linear regression" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvymeanFunction, iPosition:=0)
        ElseIf ucrInputModelType.GetText = "multiple regression" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsVarFunction, iPosition:=0)
        ElseIf ucrInputModelType.GetText = "logistic regression" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyTotalFunction, iPosition:=0)
        ElseIf ucrInputModelType.GetText = "linear association" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvySDFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyQuantileFunction, iPosition:=0)
        End If
    End Sub

    Private Sub AddPlotTypeParameters()
        If ucrInputPlotType.GetText = "boxplot" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyBoxplotFunction, iPosition:=0)
        ElseIf ucrInputPlotType.GetText = "histogram" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyHistFunction, iPosition:=0)
        ElseIf ucrInputPlotType.GetText = "smooth plots" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsPlotSmoothFunction, iPosition:=0)
        ElseIf ucrInputPlotType.GetText = "conditioning plots" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvycoplotFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyqqmathFunction, iPosition:=0)

            'If ucrVariablesAsFactorforVar.GetVariableNames Then
            'ucrBase.clsRsyntax.AddToAfterCodes(clsSvyqqmathFunction, iPosition:=0)
            'Else
            'ucrBase.clsRsyntax.AddToAfterCodes(clsSvyqqmathFunction, iPosition:=0)
            'End If
        End If
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkModelSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModelSummary.ControlValueChanged
        If ucrChkModelSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkRatios_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRatios.ControlValueChanged
        If ucrChkRatios.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsRatioFunction, iPosition:=0)
            ucrReceiverVar1.Visible = True
            'lblVar1.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRatioFunction)
            ucrReceiverVar1.Visible = False
            'lblVar1.Visible = False
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

    Private Sub ucrInputModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelType.ControlValueChanged
        AddModelTypeParameters()
    End Sub

    Private Sub ucrInputPlotType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPlotType.ControlValueChanged
        AddPlotTypeParameters()
    End Sub
End Class