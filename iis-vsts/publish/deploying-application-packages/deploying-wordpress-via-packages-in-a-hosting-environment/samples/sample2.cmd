msdeploy.exe -verb:sync -source:package=C:\Websites\Packages\Temp\WordPressMSDeployPackage.zip 
    -dest:auto -setParam:name="SiteName",kind=ProviderPath,scope=iisApp,Value=WordPress/; 
    -setParam:name="ConnectionString",kind=ProviderPath,scope=dbMySql,Value=server=localhost;
     database= WordPress;Uid= WordPress;Pwd=password; > DWSpackage7.log