logparser.exe "SELECT sc-status AS Status, COUNT(*) AS Count INTO cache.gif FROM *.log WHERE sc-status=200 OR sc-status=304 GROUP BY Status ORDER BY Status" -i:w3c -o:CHART -chartType:PieExploded3D -ChartTitle:"Cache" -values:ON
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    2
	Execution time:     6.35 seconds