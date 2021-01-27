Start-IISCommitDelay

$iisIpSecurity = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/ipSecurity' | Get-IISConfigCollection
New-IISConfigCollectionElement -ConfigCollection $iisIpSecurity -ConfigAttribute @{ 'ipAddress' = '192.168.100.1'; 'allowed' = $false }
New-IISConfigCollectionElement -ConfigCollection $iisIpSecurity -ConfigAttribute @{ 'ipAddress' = '169.254.0.0'; 'subnetMask' = '255.255.0.0'; 'allowed' = $false }

Stop-IISCommitDelay
