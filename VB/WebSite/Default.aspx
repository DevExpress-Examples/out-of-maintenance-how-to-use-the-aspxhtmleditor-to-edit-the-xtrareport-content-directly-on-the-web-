<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPopupControl" TagPrefix="dxpc" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dxhe" %>
<%@ Register Assembly="DevExpress.Web.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.ASPxSpellChecker.v13.2, Version=13.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxSpellChecker" TagPrefix="dxwsc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ASPxHtmlEditor and XtraReport synchronization</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <dxxr:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%#ReportViewer1%>"
                        ShowDefaultButtons="False">
                        <Items>
                            <dxxr:ReportToolbarButton ItemKind="Search" />
                            <dxxr:ReportToolbarSeparator />
                            <dxxr:ReportToolbarButton ItemKind="PrintReport" />
                            <dxxr:ReportToolbarButton ItemKind="PrintPage" />
                            <dxxr:ReportToolbarSeparator />
                            <dxxr:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
                            <dxxr:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
                            <dxxr:ReportToolbarLabel ItemKind="PageLabel" />
                            <dxxr:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
                            </dxxr:ReportToolbarComboBox>
                            <dxxr:ReportToolbarLabel ItemKind="OfLabel" />
                            <dxxr:ReportToolbarTextBox ItemKind="PageCount" />
                            <dxxr:ReportToolbarButton ItemKind="NextPage" />
                            <dxxr:ReportToolbarButton ItemKind="LastPage" />
                            <dxxr:ReportToolbarSeparator />
                            <dxxr:ReportToolbarButton ItemKind="SaveToDisk" />
                            <dxxr:ReportToolbarButton ItemKind="SaveToWindow" />
                            <dxxr:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                                <Elements>
                                    <dxxr:ListElement Value="pdf" />
                                    <dxxr:ListElement Value="xls" />
                                    <dxxr:ListElement Value="xlsx" />
                                    <dxxr:ListElement Value="rtf" />
                                    <dxxr:ListElement Value="mht" />
                                    <dxxr:ListElement Value="txt" />
                                    <dxxr:ListElement Value="csv" />
                                    <dxxr:ListElement Value="png" />
                                </Elements>
                            </dxxr:ReportToolbarComboBox>
                            <dxxr:ReportToolbarButton Name="ShowEditor" Text="Show HTML Editor" />
                        </Items>
                        <Styles>
                            <LabelStyle>
                                <Margins MarginLeft="3px" MarginRight="3px" />
                            </LabelStyle>
                        </Styles>
                        <ClientSideEvents ItemClick="function(s, e) {
	if (e.item.name == 'ShowEditor') 
	pc.Show();}" />
                    </dxxr:ReportToolbar>
                    <dxxr:ReportViewer ID="ReportViewer1" runat="server">
                    </dxxr:ReportViewer>
                    <br />
        <dxpc:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="pc"
            Height="400px" CloseAction="CloseButton" Modal="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter">
            <HeaderTemplate>
                HTML editor
            </HeaderTemplate>
            <ContentCollection>
                <dxpc:PopupControlContentControl runat="server">
        <dxhe:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server" Height="300px" Width="500px">
            <SettingsImageUpload>
                <ValidationSettings AllowedContentTypes="image/jpeg, image/pjpeg, image/gif, image/png, image/x-png">
                </ValidationSettings>
            </SettingsImageUpload>
        </dxhe:ASPxHtmlEditor>
                    <dxe:ASPxButton ID="ASPxButton1" runat="server" Text="Close Editor">
                        <ClientSideEvents Click="function(s, e) { pc.Hide();}" />
                    </dxe:ASPxButton>
                </dxpc:PopupControlContentControl>
            </ContentCollection>
        </dxpc:ASPxPopupControl>
    </div>
    </form>
</body>
</html>