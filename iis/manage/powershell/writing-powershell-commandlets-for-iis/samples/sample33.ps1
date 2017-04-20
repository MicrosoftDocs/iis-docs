> get-iissite -computer (cat farm.txt) | foreach { if ($_.Status -eq "Stopped") { $_.Start() }}
> get-iissite -computer $(cat farm.txt) | ft Computer,Name,Status
 
Computer                   Name                       Status
--------                   ----                       ------
test-server                Default Web Site           Started
iissb-101                  Default Web Site           Started
iissb-101                  Demo                       Started
iissb-102                  Default Web Site           Started