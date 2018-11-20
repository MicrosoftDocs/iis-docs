$denyQueryStringSequences = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'denyQueryStringSequences'
New-IISConfigCollectionElement -ConfigCollection $denyQueryStringSequences -ConfigAttribute @{ 'sequence' = 'bad_querystring_sequence' }
