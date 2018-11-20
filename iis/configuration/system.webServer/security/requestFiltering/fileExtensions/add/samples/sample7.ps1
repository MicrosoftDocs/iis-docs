$fileExtensions = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'fileExtensions'
New-IISConfigCollectionElement -ConfigCollection $fileExtensions -ConfigAttribute @{ 'fileExtension' = '.inc'; 'allowed' = $false } -AddAt 0

$fileExtensions = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigElement -ChildElementName 'fileExtensions'
Set-IISConfigAttributeValue -ConfigElement $fileExtensions -AttributeName 'applyToWebDAV' -AttributeValue $false
