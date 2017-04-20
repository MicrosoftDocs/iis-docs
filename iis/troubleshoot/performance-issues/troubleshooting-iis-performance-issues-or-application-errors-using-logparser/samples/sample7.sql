logparser.exe "SELECT sc-status AS Status, COUNT(*) AS Count INTO status.gif FROM *.log WHERE sc-status > 200 GROUP BY Status ORDER BY Status" -i:w3c -o:CHART -chartType:PieExploded3D -ChartTitle:"Request Status"
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    10
	Execution time:     6.20 seconds