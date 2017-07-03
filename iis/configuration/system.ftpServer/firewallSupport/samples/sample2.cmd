appcmd.exe set config -section:system.ftpServer/firewallSupport /lowDataChannelPort:"5000" /commit:apphost

appcmd.exe set config -section:system.ftpServer/firewallSupport /highDataChannelPort:"6000" /commit:apphost