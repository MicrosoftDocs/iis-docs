Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/denyUrlSequences -Value @{ sequence = '..' }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/denyUrlSequences -Value @{ sequence = ':' }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/denyUrlSequences -Value @{ sequence = '\' }
