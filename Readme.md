<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
<!-- default file list end -->
# How to use the ASPxHtmlEditor to edit the XtraReport content directly on the web page


<p>This example illustrates how to enable rich text editing when viewing web reports. To accomplish this task, the HTML content is obtained via the ASPxHtmlEditor.Html property, and then copied to the report's XRRichText using the XRRichText.LoadFile(Stream, XRRichTextStreamType.HtmlText) method. In the example, an extra ReportToolbar button is used to invoke the ASPxHtmlEditor embedded into the ASPxPopupControl.</p>

<br/>


