' Declare the name of the site to clean.
Const strSiteName = "Default Web Site"

' Declare the configuration path for the applicationHost.config (AppHost) file.
Const strConfigPath = "MACHINE/WEBROOT/APPHOST"

' Create the Admin Manager object.
Set objAdminManager = WScript.CreateObject( "Microsoft.ApplicationHost.WritableAdminManager" )

' Set the configuration path to AppHost.
objAdminManager.CommitPath = strConfigPath

' Get a configuration object for the AppHost file.
Set objConfigFile = objAdminManager.ConfigManager.GetConfigFile( strConfigPath )

' Get the collection of location elements.
Set objLocations = objConfigFile.Locations

' Loop through the location collection.
For intLocationIndex = 0 To CInt(objLocations.Count)-1
   ' Get an object for an individual location element.
   Set objLocation = objLocations.Item( intLocationIndex )
   ' Make sure that it's for the correct site.
   If LCase(Left(objLocation.Path,Len(strSiteName))) = LCase(strSiteName) Then
      ' Make sure that it's for FPSE location paths.
      If (Right(objLocation.Path,5) = "/fpdb") Or _
         (Right(objLocation.Path,9) = "/_private") Or _
         (Right(objLocation.Path,9) = "/_vti_bin") Or _
         (Right(objLocation.Path,9) = "/_vti_cnf") Or _
         (Right(objLocation.Path,9) = "/_vti_log") Or _
         (Right(objLocation.Path,9) = "/_vti_pvt") Or _
         (Right(objLocation.Path,9) = "/_vti_txt") Or _
         (Right(objLocation.Path,12) = "/_vti_script") Then
             ' Loop through the collection of child elements.
             For intChildLocationIndex = 0 To CInt(objLocation.Count)-1
                 ' Get an object for an individual child element.
                 Set objChildLocation = objLocation.Item(intChildLocationIndex)
                 ' Clear the configuration settings.
                 objChildLocation.Clear
             Next
     End If
   End If
Next

' Commit the changes to the AppHost file.
objAdminManager.CommitChanges