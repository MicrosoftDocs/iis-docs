>$s = get-iissite "Default Web Site" –computer test-server 
> $s | get-member

   TypeName: System.Management.Automation.PSCustomObject

Name                       MemberType   Definition
----                       ----------   ----------
Start                      CodeMethod   static System.Void Start(PSObject site)
Stop                       CodeMethod   static System.Void Stop(PSObject site)
Status                     CodeProperty System.String Status{get=GetStatus;}
Equals                     Method       System.Boolean Equals(Object obj)
GetHashCode                Method       System.Int32 GetHashCode()
GetType                    Method       System.Type GetType()
ToString                   Method       System.String ToString()
ApplicationDefaults        NoteProperty System.Management.Automation.PSObjec...
Bindings                   NoteProperty System.Management.Automation.PSObjec...
Computer                   NoteProperty System.String Computer=iissb-101
Credential                 NoteProperty System.Management.Automation.PSCrede...
Id                         NoteProperty System.UInt32 Id=1
Limits                     NoteProperty System.Management.Automation.PSObjec...
LogFile                    NoteProperty System.Management.Automation.PSObjec...
Name                       NoteProperty System.String Name=Default Web Site
ServerAutoStart            NoteProperty System.Boolean ServerAutoStart=True
TraceFailedRequestsLogging NoteProperty System.Management.Automation.PSObjec...
VirtualDirectoryDefaults   NoteProperty System.Management.Automation.PSObjec...
 
>$s.Status
Started
> $s.Stop()
> $s.Status
Stopped
> $s.Start()
> $s.Status
Started