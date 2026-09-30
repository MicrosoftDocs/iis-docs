$iisIpSecurity = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/ipSecurity'

Set-IISConfigAttributeValue -ConfigElement $iisIpSecurity -AttributeName 'enableReverseDns' -AttributeValue $true
