﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="ValidationForm.validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1 style="color:black">Insert Your Details:</h1>
        </div>
        <p>
            NAME :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtname" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name" ControlToValidate="Txtname" ForeColor="Red">*</asp:RequiredFieldValidator>
        </p>
        <p>
            FAMILY NAME :&nbsp;&nbsp;
            <asp:TextBox ID="Txtfamname" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Familyname" ControlToValidate="Txtfamname" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Txtname" ControlToValidate="Txtfamname" ErrorMessage="Differs From Name" ForeColor="Red" Operator="NotEqual"></asp:CompareValidator>
        </p>
        <p>
            ADDRESS :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txtaddress" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Address" ControlToValidate="Txtaddress" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Txtaddress" ErrorMessage="Enter Atleast 2 Chars" ForeColor="Red" ValidationExpression="^.*[a-zA-Z]{2,}.*$"></asp:RegularExpressionValidator>
        </p>
        <p>
            CITY :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtcity" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="City" ControlToValidate="Txtcity" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="Txtcity" ErrorMessage="Enter Atleast 2 Chars" ForeColor="Red" ValidationExpression="^.*[a-zA-Z]{2,}.*$"></asp:RegularExpressionValidator>
        </p>
        <p>
            ZIP CODE :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txtzip" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Zipcode" ForeColor="Red" ControlToValidate="Txtzip">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txtzip" ErrorMessage="(XXXXX)" ForeColor="Red" ValidationExpression="^\d{5,}(?:[-\s]\d{4})?$"></asp:RegularExpressionValidator>
        </p>
        <p>
            PHONE NO :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="Txtnum" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Phone Number" ControlToValidate="Txtnum" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Txtnum" ErrorMessage="Phone no must be in this format XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red" ValidationExpression="^\d{2,3}-\d{7}|\d{2,3}-\d{8}$"></asp:RegularExpressionValidator>
        </p>
        <p>
            EMAIL :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Txtemail" runat="server" BackColor="#FFFF66"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Email" ControlToValidate="Txtemail" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Txtemail" ErrorMessage="example@gmail.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <asp:Button ID="Btncheck" runat="server" Text="Check" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="ValidationSummary" />
    </form>
</body>
</html>
