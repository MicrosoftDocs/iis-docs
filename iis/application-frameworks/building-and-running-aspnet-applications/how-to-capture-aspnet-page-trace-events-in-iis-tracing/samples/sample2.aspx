<%@ Page language="C#" trace="true" %>

<%
  Trace.Write("Hey, there");
  Trace.Warn("Doh, a warning");

  Response.Write("hello, world");
%>