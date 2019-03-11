$webclient = New-Object Net.WebClient
$webclient.DownloadString("http://localhost:8080/");
$webclient.DownloadString("http://localhost:8080/DemoApp");
$webclient.DownloadString("http://localhost:8080/DemoVirtualDir1");
$webclient.DownloadString("http://localhost:8080/DemoApp/DemoVirtualDir2");