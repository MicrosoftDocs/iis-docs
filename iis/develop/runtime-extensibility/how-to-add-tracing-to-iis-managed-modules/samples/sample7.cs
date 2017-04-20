public void Init(HttpApplication application)    
{    
	application.EndRequest += (new EventHandler(this.Application_EndRequest));
	// setup traceSource
	tsStatus = new TraceSource("tsStatus");    
}