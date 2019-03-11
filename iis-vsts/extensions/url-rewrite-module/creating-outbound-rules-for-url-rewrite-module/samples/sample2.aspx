<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>URL Rewrite Module v2 Test</title>
</head>
<body>
    <h1>URL Rewrite Module v2 Test Page</h1>
    <h2>Inbound URL Rewriting</h2>
    <table>
        <tr>
            <th>Server Variable</th>
            <th>Value</th>
        </tr>
        <tr>
            <td>Original URL: </td>
            <td><%= Request.ServerVariables["UNENCODED_URL"] %></td>
        </tr>
        <tr>
            <td>Final URL: </td>
            <td><%= Request.ServerVariables["SCRIPT_NAME"] + "?" + Request.ServerVariables["QUERY_STRING"] %></td>
        </tr>
    </table>
    <h2>Outbound URL Rewriting</h2>
        <a href="<%= Request.ServerVariables["SCRIPT_NAME"] + "?" + Request.ServerVariables["QUERY_STRING"] %>">Here</a> is the link to this article.
</body>
</html>