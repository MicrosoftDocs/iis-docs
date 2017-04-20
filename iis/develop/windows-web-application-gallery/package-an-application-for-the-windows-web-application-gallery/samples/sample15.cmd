"C:\Program Files\IIS\Microsoft Web Deploy\msdeploy.exe" ^
 -verb:sync -source:Package="application.zip" ^
 -dest:auto ^
 -setParam:dbAdminUsername="root" ^
 -setParam:dbAdminPassword="<password>" ^
 -setParam:dbUsername="appuser" ^
 -setParam:dbUserPassword="<password>" ^
 -setParam:dbServer="localhost" ^
 -setParam:dbName="application"  ^
 -setParam:AppPath="Default Web Site/application"