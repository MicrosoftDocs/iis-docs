logparser.exe "SELECT to_string(to_timestamp(date, time), 'yyyy-MM-dd hh') AS Hour, COUNT(*) AS Count INTO 500.gif FROM *.log WHERE sc-status=500 GROUP BY Hour ORDER BY Hour" -i:w3c -o:CHART -chartType:Column3D -ChartTitle:"500 Errors by Hour"
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    13
	Execution time:     6.32 seconds