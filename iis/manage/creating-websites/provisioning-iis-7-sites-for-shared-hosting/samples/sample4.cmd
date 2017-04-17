md %systemdrive%\inetpub\tempcompilation\aspnettemp\<sitename>

cacls %systemdrive%\inetpub\tempcompilation\aspnettemp\<sitename> /G AppPoolUsername:F Administrators:F System:F