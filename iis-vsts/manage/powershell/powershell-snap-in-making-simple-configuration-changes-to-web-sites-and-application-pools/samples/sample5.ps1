PS IIS:\> Set-ItemProperty IIS:\Sites\DemoSite -name name -value NewDemoSite
PS IIS:\> dir iis:\Sites
Name             ID   State      Physical Path                  Bindings
----             --   -----      -------------                  --------
Default Web Site 1    Started    f:\inetpub\wwwroot             http *:80:
NewDemoSite      2    Started    c:\demosite                    http :8080:
                                                                http :8081: