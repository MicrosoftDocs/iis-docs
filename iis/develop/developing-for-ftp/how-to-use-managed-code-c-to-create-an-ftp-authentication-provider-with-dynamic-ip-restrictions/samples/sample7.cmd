AppCmd.exe set config -section:system.applicationHost/sites /"[name='Default Web Site'].ftpServer.security.authentication.basicAuthentication.enabled:False" /commit:apphost

AppCmd.exe set config -section:system.applicationHost/sites /+"[name='Default Web Site'].ftpServer.security.authentication.customAuthentication.providers.[name='FtpAddressRestrictionAuthentication',enabled='True']" /commit:apphost

AppCmd set site "Default Web Site" /+ftpServer.customFeatures.providers.[name='FtpAddressRestrictionAuthentication',enabled='true'] /commit:apphost