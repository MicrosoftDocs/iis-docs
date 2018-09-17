 Set-WebConfigurationProperty -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/hiddenSegments -Name "applyToWebDAV" -Value "false"

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/hiddenSegments -Value @{ segment ='_private' }
