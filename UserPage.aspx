<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="pLevnon.UserPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="color: white; font-size: 300%">
    <tr>
        
        <td>
            <h style="color: white; font-size: 300%"><u><b>Registration</b></u></h>
            <h1>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                update your details
            </h1>
        </td>
    </tr>
    <tr>
        <td>    
            <asp:Label ID="LblUsername" runat="server" Text="Username">

            </asp:Label>
        </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        
    </tr>
    <tr>
        <td>    
            <asp:Label ID="LblPassword" runat="server" Text="Password">

            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>    
            <asp:Label ID="LblFirstName" runat="server" Text="FirstName">

            </asp:Label>

        </td>

        <td>
            <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td>    
            <asp:Label ID="LblLastName" runat="server" Text="LastName">

            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtLastName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>    
            <asp:Label ID="LblEmail" runat="server" Text="Email">

            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>    
            <asp:Label ID="LblAddress" runat="server" Text="Address">

            </asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
        </td>
    </tr>
     <tr>
        <td>    
            <asp:Label ID="LblYearOfBirth" runat="server" Text="YearOfBirth">

            </asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="DdlYear" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>    
            <asp:Button ID="BtnUpdate" runat="server" Text="Update" onClick="BtnUpdate_Click"/>
        </td>
        <td>
            <asp:Label ID="LblMessage" runat="server" Text="Message"></asp:Label>
        </td>
        <td>
             <asp:Button ID="Cancel" runat="server" Text="Cancel" onClick="Cancel_Click"/
        </td>
        
    </tr>

</table>
</asp:Content>
