$alwaysAllowedUrls = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'alwaysAllowedUrls'
New-IISConfigCollectionElement -ConfigCollection $alwaysAllowedUrls -ConfigAttribute @{ 'url' = '/_allowed_url.aspx' }
