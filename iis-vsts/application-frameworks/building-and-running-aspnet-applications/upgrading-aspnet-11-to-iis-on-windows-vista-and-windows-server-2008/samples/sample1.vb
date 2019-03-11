Public void Init(httpApplication context)
{
	Context.AuthenticateRequest += new EventHandler(this.AuthenticateUser);
}