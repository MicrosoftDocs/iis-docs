logparser.exe "SELECT cs-uri-stem, COUNT(*) FROM *.log WHERE sc-status=500 GROUP BY cs-uri-stem ORDER BY COUNT(*) DESC" -i:w3c
	
	cs-uri-stem                 COUNT(ALL *)
	--------------------------- ------------
	/ShoppingCart/ViewCart.aspx 1378
	/DataService.asmx           1377  
	/Start/default.aspx         949
	/GetDetailsView.aspx        753
	/Details/ImageUrls.asmx     722
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    5
	Execution time:     24.89 seconds