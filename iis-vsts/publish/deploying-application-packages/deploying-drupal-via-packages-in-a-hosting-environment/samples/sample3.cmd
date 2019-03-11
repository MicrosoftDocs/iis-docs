[Array]$arguments = "-verb:sync", "-source:contentPath=`"$web_staging_directory`"", 
    "-dest:contentPath=`"\\$Server\$share\$appname\$web_project_name`"" 
    $proc = Start-Process $msdeploy -ArgumentList $arguments -NoNewWindow -Wait -PassThru 
if($proc.ExitCode -ne 0)  { throw "Failed to deploy" }