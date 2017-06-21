appcmd.exe set config -section:system.webServer/tracing/traceProviderDefinitions /+"[name='MyTraceProvider',guid='{00000000-0000-0000-0000-00000000000}']" /commit:apphost

appcmd.exe set config -section:system.webServer/tracing/traceProviderDefinitions /+"[guid='{00000000-0000-0000-0000-00000000000}'].areas.[name='ProviderAreaOne',value='0']" /commit:apphost

appcmd.exe set config -section:system.webServer/tracing/traceProviderDefinitions /+"[guid='{00000000-0000-0000-0000-00000000000}'].areas.[name='ProviderAreaTwo',value='1']" /commit:apphost