# Allows a site administrator to enable backups and set the number of backups at the site level
Configure-BackupSettingsProvider -CanSetEnabled $true -CanSetNumBackups $true

# Allows a site administrator to control which providers they want to skip in a backup, as 
# well as whether they can continue a sync after a backup failure
Configure-BackupSettingsProvider -CanSetContinueSyncOnBackupFailure $true -CanAddExcludedProviders $true