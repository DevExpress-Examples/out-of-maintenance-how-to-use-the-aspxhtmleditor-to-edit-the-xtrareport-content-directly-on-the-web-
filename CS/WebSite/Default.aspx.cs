using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraRichEdit;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

public partial class _Default : System.Web.UI.Page
{
    const string HTMLDocumentTemplate = "<html><body>{0}</body></html>";


    protected void Page_Load(object sender, EventArgs e)
    {
        SynchronizeReport();
    }

    private void SynchronizeReport() {
        XtraReport1 report = new XtraReport1();
        XRRichText richText = report.FindControl("richText", true) as XRRichText;
        MemoryStream ms = new MemoryStream();
        byte[] stringByteArray = ToByteArray(string.Format(HTMLDocumentTemplate, this.ASPxHtmlEditor1.Html));
        ms.Write(stringByteArray, 0, stringByteArray.Length);
        ms.Position = 0;
        richText.LoadFile(ms, XRRichTextStreamType.HtmlText);
        ms.Close();
        this.ReportViewer1.Report = report;
        this.ReportViewer1.DataBind();
    }

   
    public byte[] ToByteArray(string str) {
        System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
        return encoding.GetBytes(str);
    }


}
