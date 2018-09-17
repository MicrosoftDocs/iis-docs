Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/alwaysAllowedQueryStrings -Value @{ queryString = 'allowed=sequence' }
