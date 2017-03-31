icacls %systemroot%\serviceprofiles\networkservice\AppData\Local\Temp /grant Users:(CI)(S,WD,AD,X)

icacls %systemroot%\serviceprofiles\networkservice\AppData\Local\Temp /grant "CREATOR OWNER":(OI)(CI)(IO)(F)