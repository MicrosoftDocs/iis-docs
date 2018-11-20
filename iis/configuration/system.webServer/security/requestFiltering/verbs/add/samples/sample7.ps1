$verbs = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'verbs'
Set-IISConfigAttributeValue -ConfigElement $verbs -AttributeName 'applyToWebDAV' -AttributeValue $false

$verbs = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'verbs'
New-IISConfigCollectionElement -ConfigCollection $verbs -ConfigAttribute @{ 'verb'='PUT';'allowed'=$false }
