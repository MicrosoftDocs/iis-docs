logparser.exe "SELECT date, time, c-ip, cs-uri-stem, cs-uri-query, sc-status, sc-substatus, sc-win32-status, sc-bytes, cs-bytes, time-taken INTO u_exJUSTRIGHT.log FROM u_exTOOBIG.log WHERE to_timestamp(date, time) >= timestamp('2012-11-09 00:00:00', 'yyyy-MM-dd hh:mm:ss')" -i:w3c -o:w3c
	
	Statistics:
	-----------
	Elements processed: 240123
	Elements output:    240123
	Execution time:     0.45 seconds