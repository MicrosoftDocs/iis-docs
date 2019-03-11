public void ProcessRequest(HttpContext context) 
{ 
    DateTime dt; 
    String useUtc = context.Request.QueryString["utc"]; 
    if (!String.IsNullOrEmpty(useUtc) && 
            useUtc.Equals("true")) 
    { 
        dt = DateTime.UtcNow; 
    } 
    else 
    { 
        dt = DateTime.Now; 
    } 
    context.Response.Write( 
        String.Format( "<h1>{0}</h1>", 
                       dt.ToLongTimeString() 
                       ) ); 
}