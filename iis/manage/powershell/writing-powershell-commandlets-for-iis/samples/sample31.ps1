> $sitelist = get-iissite -computer $(cat farm.txt) | where {$_.Computer -like "iissb*"}
> foreach ($site in $sitelist) {
>> if ($site.Status -eq "Started") {$site.Stop()}
>> }
>>
> get-iissite -computer $(cat farm.txt) | ft Computer,Name,Status

Computer                   Name                       Status
--------                   ----                       ------
test-server                Default Web Site           Started
iissb-101                  Default Web Site           Stopped
iissb-101                  Demo                       Stopped
iissb-102                  Default Web Site           Stopped