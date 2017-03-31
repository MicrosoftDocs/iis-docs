PS IIS:\> New-ItemProperty IIS:\sites\DemoSite -name bindings -value @{protocol="http";bindingInform
ation=":8081:"}

PS IIS:\> dir IIS:\Sites
Name             ID   State      Physical Path                  Bindings
----             --   -----      -------------                  --------
Default Web Site 1    Started    f:\inetpub\wwwroot             http *:80:
DemoSite         2    Started    c:\demosite                    http :8080:
                                                                http :8081: