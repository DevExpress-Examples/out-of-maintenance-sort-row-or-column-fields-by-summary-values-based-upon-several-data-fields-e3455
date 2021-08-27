<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579741/11.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3455)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Solution.sln](./CS/Solution.sln) (VB: [Solution.sln](./VB/Solution.sln))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# Sort row or column fields by summary values based upon several data fields
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3455/)**
<!-- run online end -->


<p>The <a href="http://documentation.devexpress.com/#AspNet/CustomDocument8456"><u>Sorting by Summary </u></a>feature allows one to sort any column or row fields by summary values in a specific row or column. In some situation it might be useful to sort data by two rows or columns. E.g you want to sort by the discount column that provides many equal values. In this situation you can sort equal data against values in the second field. Our Pivot Grid controls does not provide this capability by default but it is possible to implement it via the "CustomSummary" event.</p>

<br/>


