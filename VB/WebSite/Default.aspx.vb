Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.XtraPivotGrid

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If (Not IsPostBack) Then
			SetCustomSortBySummary()
		End If
	End Sub

	Private Sub SetCustomSortBySummary()
		fieldProductName.SortBySummaryInfo.FieldName = fieldDiscount.FieldName
		fieldProductName.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
	End Sub
	Protected Sub ASPxPivotGrid1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.PivotGridCustomSummaryEventArgs)
		Dim discount As Decimal = Convert.ToDecimal(e.SummaryValue.Summary)
		Dim unitPrice As Decimal= 0
		Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
		For i As Integer = 0 To ds.RowCount - 1
				unitPrice += Convert.ToDecimal(ds(i)("UnitPrice"))
		Next i
		e.CustomValue = New SBSInf(discount, unitPrice)
	End Sub

	Private Class SBSInf
		Inherits Object
		Implements IComparable
		Private discount As Decimal
		Private unitPrice As Decimal
		Public Sub New(ByVal discount As Decimal, ByVal unitPrice As Decimal)
			Me.discount = discount
			Me.unitPrice = unitPrice
		End Sub

		#Region "IComparable Members"

		Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
			Dim info As SBSInf = CType(obj, SBSInf)
			Dim result As Integer = discount.CompareTo(info.discount)
			If result = 0 Then
				result = unitPrice.CompareTo(info.unitPrice)
			End If
			Return result
		End Function

		#End Region

	End Class
End Class
