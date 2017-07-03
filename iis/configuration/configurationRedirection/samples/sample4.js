try
{
   var config = WScript.CreateObject( "Microsoft.ApplicationHost.WritableAdminManager" );
   config.CommitPath = "MACHINE/REDIRECTION";
   var section = config.GetAdminSection( "configurationRedirection","MACHINE/REDIRECTION" );
   section.Properties.Item( "enabled" ).Value = true;
   section.Properties.Item( "path" ).Value = "\\\\SeverName\\ShareName";
   section.Properties.Item( "userName" ).Value = "MyUser";
   section.Properties.Item( "password" ).Value = "P@ssw0rd";
   config.CommitChanges();
}
catch(e)
{
   WScript.Echo(e.number); 
   WScript.Echo(e.description);
}