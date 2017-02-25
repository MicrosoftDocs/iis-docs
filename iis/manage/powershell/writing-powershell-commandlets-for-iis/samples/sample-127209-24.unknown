> add-iissite Foo @{Protocol="http"; BindingInformation="*:888"} e:\inetpub\demo -computer test-server -passthru | format-table Name,Status

Name                                    Status
----                                    ------
Foo                                     Stopped
 
> get-iissite -computer sergeia-a | format-table name,status

Name                                    Status
----                                    ------
Default Web Site                        Started
Foo                                     Stopped