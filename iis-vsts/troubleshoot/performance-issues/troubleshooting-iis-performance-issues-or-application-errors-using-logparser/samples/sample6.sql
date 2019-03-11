logparser.exe "SELECT cs-uri-stem, time-taken, sc-bytes FROM *.log WHERE time-taken > 250000 ORDER BY time-taken DESC" -i:w3c
	
	cs-uri-stem                 time-taken sc-bytes
	--------------------------- ---------- --------
	/ShoppingCart/ViewCart.aspx 1366976    256328
	/DataService.asmx           1265383    53860
	/Start/default.aspx         262796     8077
	/GetDetailsView.aspx        261305     5038
	/Details/ImageUrls.asmx     256539     2351
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    5
	Execution time:     8.98 seconds