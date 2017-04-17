ICACLS "%SystemDrive%\Windows\System32\inetsrv\config" /Grant "Network Service":R /T
ICACLS "%SystemDrive%\Windows\System32\inetsrv\config\administration.config" /Grant "Network Service":R
ICACLS "%SystemDrive%\Windows\System32\inetsrv\config\redirection.config" /Grant "Network Service":R