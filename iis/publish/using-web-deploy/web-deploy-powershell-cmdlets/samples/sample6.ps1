Backup-WDSite "Default Web Site" -ConfigOnly
Backup-WDSite MySite –IncludeAppPool
Backup-WDSite MySite -SkipFileList $list