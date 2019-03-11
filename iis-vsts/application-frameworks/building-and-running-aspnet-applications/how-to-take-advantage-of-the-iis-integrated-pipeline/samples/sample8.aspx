<% 
for each s in Request.ServerVariables
   Response.Write s & ": "&Request.ServerVariables(s) & VbCrLf
next
%>