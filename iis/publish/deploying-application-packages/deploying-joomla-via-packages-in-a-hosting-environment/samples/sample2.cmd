msdeploy.exe -verb:sync -source:package=C:\Websites\Packages\Temp\JoomlaMSDeployPackage.zip 
    -dest:auto -setParam:name="SiteName",kind=ProviderPath,scope=iisApp,Value=Joomla/; 
    -setParam:name="ConnectionString",kind=ProviderPath,scope=dbMySql,Value=server=localhost;
     database=Joomla;Uid=Joomla;Pwd=password; > DWSpackage7.log