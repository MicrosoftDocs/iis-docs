%windir%\system32\inetsrv\appcmd set config "Default Web Site/pictures" 
    -section:caching /+profiles.[extension='.jpg',duration='00:00:10',
    policy='CacheForTimePeriod',varyByHeaders='Accept-Language']