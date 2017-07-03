appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.messages.bannerMessage:"This is my FTP Server!" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.messages.suppressDefaultBanner:"True" /commit:apphost