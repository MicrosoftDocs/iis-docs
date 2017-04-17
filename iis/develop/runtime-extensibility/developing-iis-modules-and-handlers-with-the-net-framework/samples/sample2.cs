public void OnPreRequestHandlerExecute (
   Object source, EventArgs e) 
{ 
   HttpApplication app = (HttpApplication)source; 
   HttpRequest    request = app.Context.Request; 

   if (!String.IsNullOrEmpty( request.Headers["Referer"] )) 
   { 
       throw new HttpException(403, 
                                               "Uh-uh!"); 
   } 
}