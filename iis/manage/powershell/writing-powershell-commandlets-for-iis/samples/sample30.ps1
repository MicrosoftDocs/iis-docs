>$("test-server","iissb-101","iissb-102" >farm.txt
>cat farm.txt

test-server 
tissb-101
tissb-102
>get-iissite –computer $(cat farm.txt) | ft Computer,Name,Status

Computer                   Name                       Status
--------                   ----                       ------
test-server                Default Web Site           Started
iissb-101                  Default Web Site           Started
iissb-101                  Demo                       Started
iissb-102                  Default Web Site           Started
>get-iissite –computer $(cat farm.txt) | where {$_.Computer –like "iissb*"} | ft Computer,Name,Status
 
Computer                   Name                       Status
--------                   ----                       ------
iissb-101                  Default Web Site           Started
iissb-101                  Demo                       Started
iissb-102                  Default Web Site           Started