appcmd.exe set config "Contoso" -section:system.webServer/tracing/traceFailedRequests /+"[path='*.aspx']" 

appcmd.exe set config "Contoso" -section:system.webServer/tracing/traceFailedRequests /+"[path='*.aspx'].traceAreas.[provider='ASPNET',areas='Infrastructure,Module,Page,AppServices',verbosity='Verbose']" 

appcmd.exe set config "Contoso" -section:system.webServer/tracing/traceFailedRequests /[path='*.aspx'].failureDefinitions.statusCodes:"500"