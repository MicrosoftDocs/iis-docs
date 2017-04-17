logparser.exe "SELECT sc-status, sc-substatus, COUNT(*) FROM *.log GROUP BY sc-status, sc-substatus ORDER BY sc-status" -i:w3c
	
	sc-status sc-substatus COUNT(ALL *)
	--------- ------------ ------------
	200       0            3920658
	206       0            2096
	301       0            1031
	302       0            65386
	304       0            178705
	400       0            35
	401       2            692096
	404       0            2935
	404       11           7
	405       0            1
	406       0            36
	500       0            11418
	
	Statistics:
	-----------
	Elements processed: 4189228
	Elements output:    12
	Execution time:     7.70 seconds