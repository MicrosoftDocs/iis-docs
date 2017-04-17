<%@ Page Language="C#" %>
<%@ Import Namespace="System.ComponentModel" %>
<html>
<head runat="server">
<title>Login Page</title>
</head>
<body>
   <form id="form1" runat="server">
      <asp:Login id="Login1" runat="server"
            BorderStyle="Solid"
            BackColor="#ffffcc"
            BorderWidth="1px"
            BorderColor="#cccc99"
            Font-Size="10pt"
            Font-Names="Verdana">
         <TitleTextStyle Font-Bold="True"
            ForeColor="#ffffff"
            BackColor="#666666"/>
      </asp:Login>
   </form>
</body>
</html>