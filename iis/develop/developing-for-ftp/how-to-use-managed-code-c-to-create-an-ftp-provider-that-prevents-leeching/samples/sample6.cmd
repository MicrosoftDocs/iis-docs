cd /d "%WinDir%\System32\Inetsrv"

appcmd.exe set site "Default Web Site" /+ftpServer.customFeatures.providers.[name='FtpLeechPrevention',enabled='true'] /commit:apphost