$ie = new-object -com InternetExplorer.Application
$ie.Visible = $true
$ie.Navigate("http://localhost:8080/");