appcmd.exe set config -section:system.applicationHost/applicationPools /applicationPoolDefaults.autoStart:"True" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /applicationPoolDefaults.managedRuntimeVersion:"v2.0" /commit:apphost

appcmd.exe set config -section:system.applicationHost/applicationPools /applicationPoolDefaults.managedPipelineMode:"Integrated" /commit:apphost