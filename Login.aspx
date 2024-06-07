<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="pLevnon.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h style="color: white; font-size: 100%">

    <h1>Login</h1>
    <table border="1">
        
        <tr>
            <td>
                  
                <asp:Label ID="LblUsername" runat="server" Text="Username"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="TxtUsername" runat="server"></asp:TextBox>
             </td>
        </tr>
         <tr>
            <td>
                <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
            </td>
             <td>
                 <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox>
             </td>
        </tr>
        <tr>
    <td>
        <asp:Label ID="LblMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
    </td>

</tr>
        <tr >
            <td colspan="2">
                <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" /></td>
        </tr>

    </table>
    </h>
</asp:Content>