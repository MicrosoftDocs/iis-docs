$alwaysAllowedQueryStrings = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'alwaysAllowedQueryStrings'
New-IISConfigCollectionElement -ConfigCollection $alwaysAllowedQueryStrings -ConfigAttribute @{ 'queryString' = 'allowed=sequence' }
