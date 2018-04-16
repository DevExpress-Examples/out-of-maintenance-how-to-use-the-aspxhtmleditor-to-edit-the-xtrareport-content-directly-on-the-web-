Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraRichEdit
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Private Const HTMLDocumentTemplate As String = "<html><body>{0}</body></html>"


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        SynchronizeReport()
    End Sub

    Private Sub SynchronizeReport()
        Dim report As New XtraReport1()
        Dim richText As XRRichText = TryCast(report.FindControl("richText", True), XRRichText)
        Dim ms As New MemoryStream()
        Dim stringByteArray() As Byte = ToByteArray(String.Format(HTMLDocumentTemplate, Me.ASPxHtmlEditor1.Html))
        ms.Write(stringByteArray, 0, stringByteArray.Length)
        ms.Position = 0
        richText.LoadFile(ms, XRRichTextStreamType.HtmlText)
        ms.Close()
        Me.ReportViewer1.Report = report
        Me.ReportViewer1.DataBind()
    End Sub


    Public Function ToByteArray(ByVal str As String) As Byte()
        Dim encoding As New System.Text.ASCIIEncoding()
        Return encoding.GetBytes(str)
    End Function


End Class
