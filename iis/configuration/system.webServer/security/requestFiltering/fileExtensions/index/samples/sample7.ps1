Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/fileExtensions -Value @{ fileExtension = ".inc"; allowed = "false" }

Set-WebConfigurationProperty -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/fileExtensions -Name "applyToWebDAV" -Value "false"
