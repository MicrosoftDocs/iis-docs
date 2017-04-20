logparser.exe "SELECT sc-status AS Status, COUNT(*) AS Count INTO status.csv FROM *.log WHERE sc-status > 200 GROUP BY Status ORDER BY Status" -i:w3c -o:csv
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    10
	Execution time:     6.20 seconds