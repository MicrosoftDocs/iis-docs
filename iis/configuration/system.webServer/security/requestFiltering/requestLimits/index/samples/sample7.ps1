Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/requestLimits/headerLimits -Value @{ header='Content-Type'; sizeLimit=100 }
