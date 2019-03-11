private void Application_EndRequest(Object source, EventArgs e)        
{    
	tsStatus.TraceEvent(TraceEventType.Start, 0, "[REQDATA MODULE] START EndRequest");

	// other code

	tsStatus.TraceEvent(TraceEventType.Stop, 0, "[REQDATA MODULE] END EndRequest");    
}