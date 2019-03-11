logparser.exe "SELECT TO_STRING(TO_TIMESTAMP(date,time),'yyyy-MM-dd hh') AS Hour,
COUNT(*) FROM *.log WHERE sc-status=500 AND cs-uri-stem='/Start/default.aspx' AND date='2012-10-18' GROUP BY Hour ORDER BY Hour" -i:w3c
	
	Hour          COUNT(ALL *)
	------------- ------------
	2012-10-18 08 191
	2012-10-18 09 163
	2012-10-18 14 150
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    3
	Execution time:     6.36 seconds