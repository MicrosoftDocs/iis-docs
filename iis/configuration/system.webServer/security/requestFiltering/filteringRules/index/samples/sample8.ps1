Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules -Value @{ name="Block Image Leeching" }

Set-WebConfigurationProperty -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`'] -Name scanUrl -Value "false"

Set-WebConfigurationProperty -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`'] -Name scanQueryString -Value "false"

Set-WebConfigurationProperty -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`'] -Name scanAllRaw -Value "false"

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`']/scanHeaders -Value @{ requestHeader = "User-Agent" }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`']/appliesTo -Value @{ fileExtension = ".gif" }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`']/appliesTo -Value @{ fileExtension = ".jpg" }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`']/appliesTo -Value @{ fileExtension = ".png" }

Add-WebConfiguration -PSPath "IIS:\Sites\Default Web Site" -Filter system.webserver/security/requestFiltering/filteringRules/filteringRule[`@name=`'"Block Image Leeching"`']/denyStrings -Value @{ string = "leech-bot" }
