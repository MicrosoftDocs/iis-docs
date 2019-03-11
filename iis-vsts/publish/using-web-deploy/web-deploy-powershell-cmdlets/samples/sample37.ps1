New-WDPublishSettings -ComputerName owais-1 -AgentType MSDepSvc -FileName c:\owais1.publishsettings
Publish settings file created at: 'c:\owais1.publishsettings'.
New-WDPublishSettings -ComputerName owais-2 -AgentType MSDepSvc -FileName c:\owais2.publishsettings
Publish settings file created at: 'c:\owais2.publishsettings'.
Sync-WDServer -SourcePublishSettings c:\owais1.publishSettings -DestinationPublishSettings c:\owais2.publishSettings