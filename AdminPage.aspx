<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="pLevnon.AdminPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblShowusers" runat="server" Text="Showusers"></asp:Label>
    <asp:DropDownList ID="DdlCities" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DdlCities_SelectedIndexChanged" ></asp:DropDownList>
    <asp:Button ID="btnSho" runat="server" Text="Button" />
     
</asp:Content>
