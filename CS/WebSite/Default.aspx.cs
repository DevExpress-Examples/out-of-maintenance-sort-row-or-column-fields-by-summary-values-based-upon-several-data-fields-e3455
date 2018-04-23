using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.XtraPivotGrid;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack )
            SetCustomSortBySummary();
    }

    private void SetCustomSortBySummary()
    {
        fieldProductName.SortBySummaryInfo.FieldName = fieldDiscount.FieldName;
        fieldProductName.SortBySummaryInfo.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
    }
    protected void ASPxPivotGrid1_CustomSummary(object sender, DevExpress.Web.ASPxPivotGrid.PivotGridCustomSummaryEventArgs e)
    {
        decimal discount = Convert.ToDecimal( e.SummaryValue.Summary );
        decimal unitPrice=  0;
        PivotDrillDownDataSource ds = e.CreateDrillDownDataSource();
        for (int i = 0; i < ds.RowCount ; i++)
			{
                unitPrice += Convert.ToDecimal(ds[i]["UnitPrice"]);
			}
        e.CustomValue  = new SBSInf(discount, unitPrice );
    }

    class SBSInf : Object, IComparable 
    {
        decimal discount;
        decimal unitPrice;
        public SBSInf(decimal discount, decimal unitPrice)
        {
            this.discount = discount;
            this.unitPrice = unitPrice;
        }
               
        #region IComparable Members

        public int CompareTo(object obj)
        {
            SBSInf info = (SBSInf)obj;
            int result = discount.CompareTo(info.discount );
            if (result == 0)
                result = unitPrice.CompareTo(info.unitPrice);
            return result;
        }

        #endregion

    }
}
