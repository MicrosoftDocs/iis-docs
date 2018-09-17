Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/denyQueryStringSequences -Value @{ sequence = 'bad_querystring_sequence' }
