<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545274/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1737)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to use the ASPxHtmlEditor to edit the XtraReport content directly on the web page
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1737/)**
<!-- run online end -->


<p>This example illustrates how to enable rich text editing when viewing web reports. To accomplish this task, the HTML content is obtained via the ASPxHtmlEditor.Html property, and then copied to the report's XRRichText using the XRRichText.LoadFile(Stream, XRRichTextStreamType.HtmlText) method. In the example, an extra ReportToolbar button is used to invoke the ASPxHtmlEditor embedded into the ASPxPopupControl.</p>

<br/>


