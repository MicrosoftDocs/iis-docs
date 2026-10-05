###########################################################################################################
# This is an example script for cleaning up old IIS Log Files designed to run as a scheduled task.
#
# Example powershell for scheduling the script to run every day at 2:00 AM as system. Adjust file path and user as appropriate.
# $scriptPath = "C:\inetpub\logs\IISLogCleanup.ps1"
# $action = New-ScheduledTaskAction -Execute "PowerShell.exe" -Argument "-NoProfile -ExecutionPolicy Bypass -File $scriptPath"
# $trigger = New-ScheduledTaskTrigger -Daily -At 2:00AM
# Register-ScheduledTask -Action $action -Trigger $trigger -TaskName "IIS Log Cleanup" -User "NT AUTHORITY\SYSTEM"
###########################################################################################################


# Configure your settings...
$logPath = "C:\inetpub\logs\LogFiles"
$daysToKeep = 365

# Find old log files...
$dateToCompare = $(Get-Date).AddDays(-$daysToKeep)
$oldLogFiles = Get-ChildItem -Path $logPath -Filter "*.log" -Recurse | Where-Object { $_.LastWriteTime -lt $dateToCompare }
$measure = $oldLogFiles | Measure-Object -Property length -Sum

# Delete old log files...
$oldLogFiles | ForEach-Object {
    Remove-Item $_.FullName -Force
}

# Report results...
Write-Host "Completed cleanup of log files older than $daysToKeep days. Attempted to remove" ($oldLogFiles.Count).ToString("n0") "files," ($measure.Sum / 1MB).ToString("n1") "MB in size."

