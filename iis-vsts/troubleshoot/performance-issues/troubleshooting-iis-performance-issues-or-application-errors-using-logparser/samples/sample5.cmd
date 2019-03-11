logparser.exe "SELECT  cs-method, COUNT(*) AS TotalCount, MAX(time-taken) AS MaximumTime, AVG(time-taken) AS AverageTime FROM *.log GROUP BY cs-method ORDER BY TotalCount DESC" -i:w3c
	
	cs-method TotalCount MaximumTime AverageTime
	--------- ---------- ----------- -----------
	GET       3172034    1366976     153
	POST      1011765    256539      359  
	HEAD      5363       26750       209  
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    3
	Execution time:     6.36 seconds