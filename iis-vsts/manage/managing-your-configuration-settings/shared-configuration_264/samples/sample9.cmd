try
{
  var config = WScript.CreateObject( "Microsoft.ApplicationHost.AdminManager" );
  var section = config.GetAdminSection( "configurationRedirection", "MACHINE/REDIRECTION" );

  WScript.Echo( "Current redirection:" );
  WScript.Echo( "enabled = " + section.Properties.Item( "enabled" ).Value );
  WScript.Echo( "path = " + section.Properties.Item( "path" ).Value );
  WScript.Echo( "user = " + section.Properties.Item( "userName" ).Value );
  WScript.Echo( "pass = " + section.Properties.Item( "password" ).Value );
}
catch(e)
{
  WScript.Echo(e.number);
  WScript.Echo(e.description);
}