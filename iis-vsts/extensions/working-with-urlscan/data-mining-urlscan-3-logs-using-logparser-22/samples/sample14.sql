logparser.exe "SELECT DISTINCT s-siteid INTO siteids.tsv FROM UrlScan.*.log" -i:W3C -o:tsv -headers:off

for /f %%a in (siteids.tsv) do (
   logparser.exe "SELECT * INTO W3SVC%%a.log FROM UrlScan.*.log WHERE s-siteid='%%a' ORDER BY date,time" -i:W3C -o:w3c
)