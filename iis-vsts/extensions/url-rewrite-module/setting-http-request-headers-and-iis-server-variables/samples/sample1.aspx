<%@ Page Language="C#" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
 <title>URL Rewrite Module v2 Test - Setting Server Variables</title>
</head>
<body>
 <h1>Setting HTTP request header and a server variable with URL Rewrite Module v2</h1>
 <p>The value of the Language cookie is <strong><%=( Request.Cookies["Language"] != null ) ? Request.Cookies["Language"].Value : "Cookie not set" %></strong></p>
 <p>The originally requested URI is <strong><%= HttpUtility.HtmlEncode( Request.ServerVariables["ORIGINAL_URI"] ) %></strong></p>
</body>
</html>