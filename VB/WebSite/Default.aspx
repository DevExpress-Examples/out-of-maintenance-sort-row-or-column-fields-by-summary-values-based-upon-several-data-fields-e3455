<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>

	</div>
	<dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" 
		DataSourceID="AccessDataSource1" 
		oncustomsummary="ASPxPivotGrid1_CustomSummary">
		<Fields>
			<dxwpg:PivotGridField ID="fieldUnitPrice" Area="DataArea" AreaIndex="1" 
				FieldName="UnitPrice"  >
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldQuantity" Area="DataArea" AreaIndex="1" 
				FieldName="Quantity" Visible="False" >
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldDiscount" Area="DataArea"  AreaIndex="0" 
				FieldName="Discount">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldExtendedPrice" Area="DataArea"  AreaIndex="1" 
				FieldName="ExtendedPrice" Visible="False" >
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldFreight" Area="DataArea"  AreaIndex="4"  FieldName="Freight" Visible="False" >
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldProductName" Area="RowArea" AreaIndex="0" 
				FieldName="ProductName">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldCity" AreaIndex="1" FieldName="City">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldCountry" AreaIndex="2" FieldName="Country">
			</dxwpg:PivotGridField>
			<dxwpg:PivotGridField ID="fieldOrderDate" Area="FilterArea" AreaIndex="0" 
				FieldName="OrderDate" GroupInterval="DateYear" 
				UnboundFieldName="fieldOrderDate">
			</dxwpg:PivotGridField>
		</Fields>
		<OptionsPager RowsPerPage="40">
		</OptionsPager>
		<OptionsView DataHeadersDisplayMode="Popup" DataHeadersPopupMinCount="3" />
	</dxwpg:ASPxPivotGrid>
	<asp:AccessDataSource ID="AccessDataSource1" runat="server" 
		DataFile="~/App_Data/nwind.mdb" 
		SelectCommand="SELECT [UnitPrice], [Quantity], [Discount], [ExtendedPrice], [Freight], [ProductName], [City], [Country], [OrderDate] FROM [Invoices]">
	</asp:AccessDataSource>
	</form>
</body>
</html>