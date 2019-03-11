appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.connections.controlChannelTimeout:"120" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /[name='ftp.example.com'].ftpServer.connections.dataChannelTimeout:"30" /commit:apphost