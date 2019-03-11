%windir%\system32\inetsrv\appcmd set config -section:urlCompression /doDynamicCompression:true
%windir%\system32\inetsrv\appCmd set config -section:httpCompression /dynamicCompressionDisableCpuUsage:50
%windir%\system32\inetsrv\appCmd set config -section:httpCompression /dynamicCompressionEnableCpuUsage:30