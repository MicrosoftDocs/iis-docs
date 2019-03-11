msdeploy.exe -verb:sync -source:package=C:\Websites\Packages\Temp\drupalMSDeployPackage.zip 
    -dest:auto -setParam:name="SiteName",kind=ProviderPath,scope=iisApp,Value=drupal/; 
    -setParam:name="ConnectionString",kind=ProviderPath,scope=dbMySql,Value=server=localhost;
     database=drupal;Uid=drupal;Pwd=password; > DWSpackage7.log