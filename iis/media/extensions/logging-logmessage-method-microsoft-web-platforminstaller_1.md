---
title: Logging.LogMessage Method (, ) (Microsoft.Web.PlatformInstaller)
TOCTitle: LogMessage Method (, )
ms:assetid: M:Microsoft.Web.PlatformInstaller.Logging.LogMessage(System.Diagnostics.TraceEventType,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.logging.logmessage(v=VS.90)
ms:contentKeyID: 22049574
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Logging.LogMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogMessage Method (, )

Logs a message with the specified trace type and message.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubLogMessage ( _
    levelAsTraceEventType, _
    messageAsString _
)
'Usage
DimlevelAsTraceEventTypeDimmessageAsStringLogging.LogMessage(level, message)
```

``` csharp
publicstaticvoidLogMessage(
    TraceEventTypelevel,
    stringmessage
)
```

``` c++
public:
staticvoidLogMessage(
    TraceEventTypelevel, 
    String^ message
)
```

``` jscript
publicstaticfunctionLogMessage(
    level : TraceEventType, 
    message : String
)
```

#### Parameters

  - level  
    Type: TraceEventType  
    A valid value from TraceEventType enumeration.  

<!-- end list -->

  - message  
    Type: String  
    The message to log.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Logging Class](logging-class-microsoft-web-platforminstaller.md)

[Logging Members](logging-members-microsoft-web-platforminstaller.md)

[LogMessage Overload](logging-logmessage-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

