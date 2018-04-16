# How to use the ASPxHtmlEditor to edit the XtraReport content directly on the web page


<p>This example illustrates how to enable rich text editing when viewing web reports. To accomplish this task, the HTML content is obtained via the ASPxHtmlEditor.Html property, and then copied to the report's XRRichText using the XRRichText.LoadFile(Stream, XRRichTextStreamType.HtmlText) method. In the example, an extra ReportToolbar button is used to invoke the ASPxHtmlEditor embedded into the ASPxPopupControl.</p>

<br/>


