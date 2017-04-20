<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Reverse Proxy Test - WebMail Application</title>
</head>
<body>
    <h1>Reverse Proxy Test Page - WebMail Application</h1>
    <p>Requested URL path is <%= Request.ServerVariables["SCRIPT_NAME"] %><p>
    <p><a href="<%= Request.ServerVariables["SCRIPT_NAME"] %>">Here</a> is the link to this page.</p>
</body>
</html>