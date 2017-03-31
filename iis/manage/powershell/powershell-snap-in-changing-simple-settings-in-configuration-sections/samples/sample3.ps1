PS IIS:\Sites\DemoSite\DemoApp> Set-WebConfigurationProperty -filter /system.webServer/security/authentication/windowsAuthentication -name enabled -value true
Set-WebConfigurationProperty : This configuration section cannot be used at this path. This happens
 when the section is locked at a parent level. Locking is either by default (overrideModeDefault="D
eny"), or set explicitly by a location tag with overrideMode="Deny" or the legacy allowOverride="fa
lse".
At line:1 char:29
+ Set-WebConfigurationProperty  <<<< -filter /system.webServer/security/authentication/windowsAuthentication -name enabled -value true