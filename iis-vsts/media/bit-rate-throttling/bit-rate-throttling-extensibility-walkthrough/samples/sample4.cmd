C:\Windows\System32\inetsrv\> appcmd set config /section:bitrateThrottling /+mediaFormats.[fileExtension='asf']

C:\Windows\System32\inetsrv\> appcmd set config /section:bitrateThrottling /mediaFormats.[fileExtension='.asf'].bitrateRules.enabled:true

C:\Windows\System32\inetsrv\> appcmd set config /section:bitrateThrottling /+mediaFormats.[fileExtension='.asf'].bitrateRules.[searchPattern='A1DCAB8C47A9CF118EE400C00C205365',searchPatternType='hexValue',searchRangeStart='0',searchRangeEnd='4096',dataOffset='84',dataType='uint32',endianness='littleEndian',unitBitPerSecond='1']