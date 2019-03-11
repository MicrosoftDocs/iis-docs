# Changes default global backup behavior to enabled
Configure-Backups -Enabled $true

# Changes default backup behavior for site "foo" to enabled
Configure-Backups -SiteName "foo" -Enabled $true

# Changes the path of where backups are stored to a sibling directory named "siteName_snapshots".  
# For more information about path variables, see the "backupPath" attribute in the section 
# "Configuring  Backup Settings on the Server for Global usage manually in IIS Config"
Configure-Backups -BackupPath "{SitePathParent}\{siteName}_snapshots"

# Configures default backup limit to 5 backups
Configure-Backups -NumberOfBackups 5

# Configures sync behavior to fail if a sync fails for any reason
Configure-Backups -ContinueSyncOnBackupFailure $false

# Adds providers to skip when performing a backup
Configure-Backups -AddExcludedProviders @("dbmysql","dbfullsql")
