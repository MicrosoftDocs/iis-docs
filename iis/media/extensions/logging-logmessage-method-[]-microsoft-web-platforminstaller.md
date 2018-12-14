---
title: Logging.LogMessage Method (, , []) (Microsoft.Web.PlatformInstaller)
TOCTitle: LogMessage Method (, , [])
ms:assetid: M:Microsoft.Web.PlatformInstaller.Logging.LogMessage(System.Diagnostics.TraceEventType,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.logging.logmessage(v=VS.90)
ms:contentKeyID: 22753899
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

# LogMessage Method (, , \[\])

Logs a message with the specified TraceEventType, format, and arguments.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubLogMessage ( _
    eventTypeAsTraceEventType, _
    formatAsString, _
    ParamArrayargsAsObject() _
)
'Usage
DimeventTypeAsTraceEventTypeDimformatAsStringDimargsAsObject()

Logging.LogMessage(eventType, format, _
    args)
```

``` csharp
publicstaticvoidLogMessage(
    TraceEventTypeeventType,
    stringformat,
    paramsObject[] args
)
```

``` c++
public:
staticvoidLogMessage(
    TraceEventTypeeventType, 
    String^ format, 
    ... array<Object^>^ args
)
```

``` jscript
publicstaticfunctionLogMessage(
    eventType : TraceEventType, 
    format : String, 
    ... args : Object[]
)
```

#### Parameters

  - eventType  
    Type: TraceEventType  
    A valid value from TraceEventType enumeration.  

<!-- end list -->

  - format  
    Type: String  
    A string value that specifies the format.  

<!-- end list -->

  - args  
    Type: array\<Object\> \[\] () \[\] \[\]  
    An array of parameter objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Logging Class](logging-class-microsoft-web-platforminstaller.md)

[Logging Members](logging-members-microsoft-web-platforminstaller.md)

[LogMessage Overload](logging-logmessage-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

