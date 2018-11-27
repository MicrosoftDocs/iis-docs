Start-IISCommitDelay

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules' 
New-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching'; 'scanUrl' = $false; 'scanQueryString' = $false; 'scanAllRaw' = $false; } 

$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }

$ruleScanHeaders = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'scanHeaders' 
New-IISConfigCollectionElement -ConfigCollection $ruleScanHeaders -ConfigAttribute @{ 'requestHeader' = 'User-Agent' }

$ruleAppliesTo = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'appliesTo'
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.gif' }
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.jpg' }
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.png' }

$ruleDenyStrings = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'denyStrings'
New-IISConfigCollectionElement -ConfigCollection $ruleDenyStrings -ConfigAttribute @{ 'string' = 'leech-bot' }

Stop-IISCommitDelay
