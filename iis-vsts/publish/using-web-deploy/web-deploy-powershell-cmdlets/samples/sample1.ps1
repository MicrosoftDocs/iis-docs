$cred = Get-Credential
New-WDPublishSettings -ComputerName owais-1 -Site Site1 -Credentials $cred -AllowUntrusted -SiteUrl "https://www.mywebsite.com" -FileName C:\pprofiles\mywebsite.publishsettings -AgentType wmsvc
Get-WDPublishSettings cmdlet allows to load values from a publish setting file into PublishSettings object.
$publishsettings=Get-WDPublishSettings C:\pprofiles\mywebsite.publishsettings