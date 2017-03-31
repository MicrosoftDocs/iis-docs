PS IIS:\Sites> Get-Item 'Default Web Site' | Select-Object *

PSPath                     : IIsProviderSnapIn\WebAdministration::\\THDLAP\Sites\Default Web Site
PSParentPath               : IIsProviderSnapIn\WebAdministration::\\THDLAP\Sites
PSChildName                : Default Web Site
PSDrive                    : IIS
PSProvider                 : IIsProviderSnapIn\WebAdministration
PSIsContainer              : True
State                      : Started
name                       : Default Web Site
id                         : 1
serverAutoStart            : True
bindings                   : {binding, binding}
limits                     : Microsoft.Web.Administration.ConfigurationElement
logFile                    : Microsoft.Web.Administration.ConfigurationElement
traceFailedRequestsLogging : Microsoft.Web.Administration.ConfigurationElement
applicationDefaults        : Microsoft.Web.Administration.ConfigurationElement
virtualDirectoryDefaults   : Microsoft.Web.Administration.ConfigurationElement
applicationPool            : DefaultAppPool
enabledProtocols           : http
userName                   :
password                   :
physicalPath               : f:\inetpub\wwwroot
Attributes                 : {name, id, serverAutoStart, state}
ChildElements              : {bindings, limits, logFile, traceFailedRequestsLogging...}
ElementTagName             : site
IsLocallyStored            : True
Methods                    : {Start, Stop}
RawAttributes              : {name, id, serverAutoStart, state}
Schema                     : Microsoft.Web.Administration.ConfigurationElementSchema