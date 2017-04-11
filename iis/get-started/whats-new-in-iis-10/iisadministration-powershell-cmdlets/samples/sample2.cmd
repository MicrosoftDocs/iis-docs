PS:>$ConfigSection = Get-IISConfigSection -SectionPath "system.applicationHost/sites"

PS:>Get-IISConfigCollection $configSection | Get-IISConfigCollectionElement -ConfigAttribute @{"Name"="Default Web Site"} | Get-IISConfigAttributeValue -AttributeName "State"