class MyModule : IHttpModule 
   public void Dispose() { 
   }
   public void Init(HttpApplication context) {
      context.BeginRequest += new EventHandler(OnContextBeginRequest);
   }
	void OnContextBeginRequest(object sender, EventArgs e) {
	HttpApplication app = (HttpApplication)sender;
	app.Context.Request.ServerVariables.Set("foo", "bar");
   }
}