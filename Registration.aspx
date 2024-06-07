<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="pLevnon.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       body {
    background-color: #f0f2f5;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    color: #333;
    margin: 0;
    padding: 0;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.container {
    max-width: 800px; /* הרחבתי את הרוחב */
    width: 100%;
    margin: 20px;
    padding: 30px;
    background-color: #fff;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    border-radius: 10px;
    box-sizing: border-box;
}

h2 {
    text-align: center;
    color: #007bff;
    margin-bottom: 20px;
}

label {
    display: block;
    margin-bottom: 5px;
    font-weight: bold;
}

.form-control {
    width: 100%;
    padding: 10px;
    margin-bottom: 15px;
    border: 1px solid #ccc;
    border-radius: 5px;
    box-sizing: border-box;
    font-size: 16px;
    transition: border-color 0.3s ease;
}

.form-control:focus {
    border-color: #007bff;
    outline: none;
    box-shadow: 0 0 5px rgba(0, 123, 255, 0.25);
}

.error {
    color: red;
    font-size: 12px;
    margin-top: -10px;
    margin-bottom: 10px;
}

.btn {
    display: block;
    width: 100%;
    padding: 12px;
    background-color: #007bff;
    color: #fff;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
    transition: background-color 0.3s ease;
}

.btn:hover {
    background-color: #0056b3;
}

.btn:focus {
    outline: none;
    box-shadow: 0 0 5px rgba(0, 123, 255, 0.5);
}


    </style>
    <script type="text/javascript">
        function checkUserName() {
            var username = document.getElementById('<%= TxtUsername.ClientID%>');
            var errorLabel = document.getElementById("<%= DUsername.ClientID%>");
            if (username.value == null || username.value == "") {
                errorLabel.innerHTML = "You must enter a username";
                return false;
            }
            if (username.value.length < 5 || username.value.length > 15) {
                errorLabel.innerHTML = "The username length must be between 5 and 15 characters";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function checkPassword() {
            var password = document.getElementById('<%= TxtPassword.ClientID%>');
            var errorLabel = document.getElementById("<%= DPassword.ClientID%>");
            if (password.value == null || password.value == "") {
                errorLabel.innerHTML = "The password is required";
                return false;
            }
            if (password.value.length < 5) {
                errorLabel.innerHTML = "The password must be longer than 5 characters";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function checkFirstName() {
            var firstName = document.getElementById('<%= TxtFirstName.ClientID %>');
            var errorLabel = document.getElementById("<%= DFirstName.ClientID %>");
            if (firstName.value == null || firstName.value == "") {
                errorLabel.innerHTML = "First name is required";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function checkLastName() {
            var lastName = document.getElementById('<%= TxtLastName.ClientID %>');
            var errorLabel = document.getElementById("<%= DLastName.ClientID %>");
            if (lastName.value == null || lastName.value == "") {
                errorLabel.innerHTML = "Last name is required";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function checkEmail() {
            var email = document.getElementById('<%= TxtEmail.ClientID %>');
            var errorLabel = document.getElementById("<%= DEmail.ClientID %>");
            var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            if (email.value == null || email.value == "") {
                errorLabel.innerHTML = "Email is required";
                return false;
            }
            if (!emailPattern.test(email.value)) {
                errorLabel.innerHTML = "Invalid email format";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function checkAddress() {
            var address = document.getElementById('<%= TxtAddress.ClientID %>');
            var errorLabel = document.getElementById("<%= DAddress.ClientID %>");
            if (address.value == null || address.value == "") {
                errorLabel.innerHTML = "Address is required";
                return false;
            }
            errorLabel.innerHTML = "";
            return true;
        }

        function validateForm() {
            var valid = true;
            if (!checkUserName()) valid = false;
            if (!checkPassword()) valid = false;
            if (!checkFirstName()) valid = false;
            if (!checkLastName()) valid = false;
            if (!checkEmail()) valid = false;
            if (!checkAddress()) valid = false;
            return valid;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Registration</h2>
        <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>
        
        <label for="TxtUsername">Username</label>
        <asp:TextBox ID="TxtUsername" CssClass="form-control" onfocusout="checkUserName()" runat="server"></asp:TextBox>
        <asp:Label ID="DUsername" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="TxtPassword">Password</label>
        <asp:TextBox ID="TxtPassword" CssClass="form-control" onfocusout="checkPassword()" TextMode="Password" runat="server"></asp:TextBox>
        <asp:Label ID="DPassword" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="TxtFirstName">First Name</label>
        <asp:TextBox ID="TxtFirstName" CssClass="form-control" onfocusout="checkFirstName()" runat="server"></asp:TextBox>
        <asp:Label ID="DFirstName" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="TxtLastName">Last Name</label>
        <asp:TextBox ID="TxtLastName" CssClass="form-control" onfocusout="checkLastName()" runat="server"></asp:TextBox>
        <asp:Label ID="DLastName" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="TxtEmail">Email</label>
        <asp:TextBox ID="TxtEmail" CssClass="form-control" onfocusout="checkEmail()" runat="server"></asp:TextBox>
        <asp:Label ID="DEmail" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="TxtAddress">Address</label>
        <asp:TextBox ID="TxtAddress" CssClass="form-control" onfocusout="checkAddress()" runat="server"></asp:TextBox>
        <asp:Label ID="DAddress" CssClass="error" runat="server" Text=""></asp:Label>

        <label for="DdlYear">Year of Birth</label>
        <asp:DropDownList ID="DdlYear" CssClass="form-control" runat="server"></asp:DropDownList>

        <input type="submit" id="BtnRegistr" class="btn" text="Register" onclick="if (!validateForm()) return false;"/>
    </div>
</asp:Content>