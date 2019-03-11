Import-module IISAdministration
New-IISSite -Name "AspNetCoreSite" -PhysicalPath c:\HelloAspNetcore\wwwroot -BindingInformation "*:8000:"