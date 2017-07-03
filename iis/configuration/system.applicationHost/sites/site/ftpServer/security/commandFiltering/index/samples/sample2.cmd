appcmd.exe set config -section:system.applicationHost/sites /[name='Default Web Site'].ftpServer.security.commandFiltering.allowUnlisted:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/sites /+"[name='Default Web Site'].ftpServer.security.commandFiltering.[command='SYST',allowed='False']" /commit:apphost