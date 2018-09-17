Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/alwaysAllowedUrls -Value @{ url = '/_allowed_url.aspx' }
