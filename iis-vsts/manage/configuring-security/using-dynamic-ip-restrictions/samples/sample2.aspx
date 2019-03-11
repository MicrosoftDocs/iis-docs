<%@ Page Language="C#" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"> 
<script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
 System.Threading.Thread.Sleep(3000);
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
 <title>Dynamic IP Restrictions Test</title>
 </head>
 <body>
 <form id="form1" runat="server">
 <div>
 <h1>Hello World!</h1>
 </div>
 </form>
 </body>
</html>