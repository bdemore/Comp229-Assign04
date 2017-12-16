<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Comp229_Assign04.UpdatePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%
        Response.Write(Request.QueryString["model"]);
    %>
</asp:Content>
