Start-IISCommitDelay

$denyUrlSequences = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'denyUrlSequences'

New-IISConfigCollectionElement -ConfigCollection $denyUrlSequences -ConfigAttribute @{ 'sequence' = '..' }
New-IISConfigCollectionElement -ConfigCollection $denyUrlSequences -ConfigAttribute @{ 'sequence' = ':' }
New-IISConfigCollectionElement -ConfigCollection $denyUrlSequences -ConfigAttribute @{ 'sequence' = '\' }

Stop-IISCommitDelay
