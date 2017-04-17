try
{
    var config = WScript.CreateObject( "Microsoft.ApplicationHost.WritableAdminManager" );
  config.CommitPath = "MACHINE/REDIRECTION";
    var section = config.GetAdminSection( "configurationRedirection","MACHINE/REDIRECTION" );
  section.Properties.Item( "enabled" ).Value = true;
  section.Properties.Item( "path" ).Value = "\\\\somemachine\\sharefile://folder/";
  section.Properties.Item( "userName" ).Value = "testuser";
  section.Properties.Item( "password" ).Value = "testuser";
  config.CommitChanges();
}
catch(e)
{
  WScript.Echo(e.number);
  WScript.Echo(e.description);
}