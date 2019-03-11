PS IIS:\Sites\DemoSite\DemoApp> Get-WebConfigurationProperty -filter //handlers -name Collection[scriptProcessor="*aspnet_isapi.dll"]  | select name,path
name                                              path
----                                              ----
svc-ISAPI-2.0-64                                  *.svc
svc-ISAPI-2.0                                     *.svc
AXD-ISAPI-2.0                                     *.axd
PageHandlerFactory-ISAPI-2.0                      *.mspx
SimpleHandlerFactory-ISAPI-2.0                    *.ashx
WebServiceHandlerFactory-ISAPI-2.0                *.asmx
HttpRemotingHandlerFactory-rem-ISAPI-2.0          *.rem
HttpRemotingHandlerFactory-soap-ISAPI-2.0         *.soap
AXD-ISAPI-2.0-64                                  *.axd
PageHandlerFactory-ISAPI-2.0-64                   *.mspx
SimpleHandlerFactory-ISAPI-2.0-64                 *.ashx
WebServiceHandlerFactory-ISAPI-2.0-64             *.asmx
HttpRemotingHandlerFactory-rem-ISAPI-2.0-64       *.rem
HttpRemotingHandlerFactory-soap-ISAPI-2.0-64      *.soap