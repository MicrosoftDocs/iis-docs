public void Init(HttpApplication context) 
{ 
    context.PreRequestHandlerExecute += 
        newEventHandler(OnPreRequestHandlerExecute) 
}