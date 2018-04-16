Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private xrLabel1 As XRLabel
    Private ReportHeader As ReportHeaderBand
    Private richText As XRRichText
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resourceFileName As String = "XtraReport1.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.XtraReport1.ResourceManager
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.richText = New DevExpress.XtraReports.UI.XRRichText()
        DirectCast(Me.richText, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.richText})
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel1
        ' 
        Me.xrLabel1.Font = New System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
        Me.xrLabel1.Location = New System.Drawing.Point(17, 0)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel1.Size = New System.Drawing.Size(458, 33)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.Text = "Sample report document displaying HTML content"
        ' 
        ' ReportHeader
        ' 
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
        Me.ReportHeader.Height = 40
        Me.ReportHeader.Name = "ReportHeader"
        ' 
        ' richText
        ' 
        Me.richText.Location = New System.Drawing.Point(0, 0)
        Me.richText.Name = "richText"
        Me.richText.SerializableRtfString = resources.GetString("richText.SerializableRtfString")
        Me.richText.Size = New System.Drawing.Size(650, 100)
        ' 
        ' XtraReport1
        ' 
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader})
        Me.Version = "9.2"
        DirectCast(Me.richText, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
