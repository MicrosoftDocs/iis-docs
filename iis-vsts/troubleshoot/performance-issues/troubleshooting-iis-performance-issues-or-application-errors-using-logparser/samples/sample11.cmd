logparser.exe "SELECT date, time, c-ip, cs-uri-stem, cs-uri-query, sc-status, sc-substatus, sc-win32-status, sc-bytes, cs-bytes, time-taken INTO u_exJUSTRIGHT.log FROM u_exTOOBIG.log" -i:w3c -o:w3c
	
	Statistics:
	-----------
	Elements processed: 19712301
	Elements output:    19712301
	Execution time:     3.07 seconds