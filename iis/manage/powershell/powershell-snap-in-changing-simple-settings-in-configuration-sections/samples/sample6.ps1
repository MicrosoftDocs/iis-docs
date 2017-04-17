PS IIS:\Sites\DemoSite\DemoApp> $winAuth = Get-WebConfiguration -filter /system.webServer/security/authentication/windowsAuthentication 
PS IIS:\Sites\DemoSite\DemoApp> $winAuth.enabled = $false
PS IIS:\Sites\DemoSite\DemoApp> $winAuth | set-Webconfiguration -filter /system.webServer/security/authentication/windowsAuthentication -PSPath IIS:\ -location "DemoSite/DemoApp"