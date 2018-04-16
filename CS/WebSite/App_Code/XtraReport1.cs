using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private XRLabel xrLabel1;
    private ReportHeaderBand ReportHeader;
    private XRRichText richText;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport1()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "XtraReport1.resx";
        System.Resources.ResourceManager resources = global::Resources.XtraReport1.ResourceManager;
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.richText = new DevExpress.XtraReports.UI.XRRichText();
        ((System.ComponentModel.ISupportInitialize)(this.richText)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.richText});
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.xrLabel1.Location = new System.Drawing.Point(17, 0);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.Size = new System.Drawing.Size(458, 33);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "Sample report document displaying HTML content";
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.ReportHeader.Height = 40;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // richText
        // 
        this.richText.Location = new System.Drawing.Point(0, 0);
        this.richText.Name = "richText";
        this.richText.SerializableRtfString = resources.GetString("richText.SerializableRtfString");
        this.richText.Size = new System.Drawing.Size(650, 100);
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader});
        this.Version = "9.2";
        ((System.ComponentModel.ISupportInitialize)(this.richText)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
