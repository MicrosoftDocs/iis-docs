Import-Module IISAdministration
Reset-IISServerManager -Confirm:$false
Start-IISCommitDelay

$sitesCollection = Get-IISConfigSection -SectionPath "system.applicationHost/sites" | Get-IISConfigCollection
$siteDefaultsElement = Get-IISConfigElement -ConfigElement $sitesCollection -ChildElementName "siteDefaults"
$hstsElement = Get-IISConfigElement -ConfigElement $siteDefaultsElement -ChildElementName "hsts"
Set-IISConfigAttributeValue -ConfigElement $hstsElement -AttributeName "enabled" -AttributeValue $true
Set-IISConfigAttributeValue -ConfigElement $hstsElement -AttributeName "max-age" -AttributeValue 31536000
Set-IISConfigAttributeValue -ConfigElement $hstsElement -AttributeName "includeSubDomains" -AttributeValue $true
Set-IISConfigAttributeValue -ConfigElement $hstsElement -AttributeName "redirectHttpToHttps" -AttributeValue $true

Stop-IISCommitDelay
Remove-Module IISAdministration