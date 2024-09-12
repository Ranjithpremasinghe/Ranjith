<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pdfViwer.aspx.cs" Inherits="Monitoring_sys_NMA.pdfViwer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h1>Welcome to PDF viewer</h1>
   
    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Upload PDF</title>
</head>
<body>
    
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:TextBox ID="DepartmentCodeTextBox" runat="server" placeholder="Department Code"></asp:TextBox>
            <asp:Button ID="UploadButton" runat="server" Text="Upload"/>
            <asp:Label ID="UploadStatusLabel" runat="server" Text=""></asp:Label>
        </div>
    
</body>
</html>
</asp:Content>
