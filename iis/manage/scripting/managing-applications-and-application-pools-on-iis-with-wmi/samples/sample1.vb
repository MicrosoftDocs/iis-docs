Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")
' Define the Path, SiteName, and PhysicalPath for the new application.
strApplicationPath = "/NewApp"
strSiteName = "Default Web Site"
strPhysicalPath = "D:\inetpub\NewApp"
  
' Create the new application
oWebAdmin.Get("Application").Create _
      strApplicationPath, strSiteName, strPhysicalPath