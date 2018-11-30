$hiddenSegments = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigElement -ChildElementName 'hiddenSegments'
Set-IISConfigAttributeValue -ConfigElement $hiddenSegments -AttributeName 'applyToWebDAV' -AttributeValue $false

$hiddenSegments = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'hiddenSegments'
New-IISConfigCollectionElement -ConfigCollection $hiddenSegments -ConfigAttribute @{ 'segment' = '_private' }
