<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="UserPropertiesWindowAuth.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <%-- <asp:LoginName ID="LoginName1" FormatString="Welcome {0}!" runat="server" />--%>
             <%-- <asp:Label ID="userathtml" runat="server" Text=" <% Context.Profile.UserName %>"></asp:Label><br/>--%>

                            
             <asp:Label ID="UNAMe" runat="server" Text="Label"></asp:Label><br/>
            <asp:Label ID="Email" runat="server" Text="Email"></asp:Label><br/>
            <asp:Label ID="Error" runat="server" Text="Error"></asp:Label>

        </div>
    </form>
</body>
</html>
