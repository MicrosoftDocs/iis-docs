%windir%\system32\inetsrv\config.
icacls %windir%\system32\inetsrv\config /grant CustomAppUser:(R,RD,RA,REA)