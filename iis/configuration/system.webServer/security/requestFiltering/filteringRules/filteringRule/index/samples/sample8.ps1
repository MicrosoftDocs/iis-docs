$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
New-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching'; 'scanUrl' = $false; 'scanQueryString' = $false; 'scanAllRaw' = $false; }

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }
$ruleScanHeaders = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'scanHeaders'
New-IISConfigCollectionElement -ConfigCollection $ruleScanHeaders -ConfigAttribute @{ 'requestHeader' = 'User-Agent' }

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }
$ruleAppliesTo = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'appliesTo'
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.gif' }

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }
$ruleAppliesTo = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'appliesTo'
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.jpg' }

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }
$ruleAppliesTo = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'appliesTo'
New-IISConfigCollectionElement -ConfigCollection $ruleAppliesTo -ConfigAttribute @{ 'fileExtension' = '.png' }

$filteringRules = Get-IISConfigSection -CommitPath 'Default Web Site' -SectionPath 'system.webServer/security/requestFiltering' | Get-IISConfigCollection -CollectionName 'filteringRules'
$Rule = Get-IISConfigCollectionElement -ConfigCollection $filteringRules -ConfigAttribute @{ 'name' = 'Block Image Leeching' }
$ruleDenyStrings = Get-IISConfigCollection -ConfigElement $Rule -CollectionName 'denyStrings'
New-IISConfigCollectionElement -ConfigCollection $ruleDenyStrings -ConfigAttribute @{ 'string' = 'leech-bot' }
