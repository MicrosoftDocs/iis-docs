$requestLimits = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigElement -ChildElementName 'requestLimits'
$headerLimits = Get-IISConfigCollection -ConfigElement $requestLimits -CollectionName 'headerLimits'
New-IISConfigCollectionElement -ConfigCollection $headerLimits -ConfigAttribute @{ 'header'='Content-Type'; 'sizeLimit'=100 }
