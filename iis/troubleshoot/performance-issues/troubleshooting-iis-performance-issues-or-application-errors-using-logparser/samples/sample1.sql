logparser.exe "SELECT TO_STRING(TO_LOCALTIME(TO_TIMESTAMP(date,time)),'yyyy-MM-dd hh:mm:ss') AS LocalTime,
COUNT(*) AS Hits FROM *.log WHERE date='2012-10-18'
GROUP BY LocalTime ORDER BY LocalTime" -i:w3c