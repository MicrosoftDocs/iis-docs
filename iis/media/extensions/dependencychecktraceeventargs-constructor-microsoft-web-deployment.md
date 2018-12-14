---
title: DependencyCheckTraceEventArgs Constructor  (Microsoft.Web.Deployment)
TOCTitle: DependencyCheckTraceEventArgs Constructor
ms:assetid: M:Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.#ctor(System.Diagnostics.TraceLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.dependencychecktraceeventargs.dependencychecktraceeventargs(v=VS.90)
ms:contentKeyID: 22754002
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.DependencyCheckTraceEventArgs
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DependencyCheckTraceEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DependencyCheckTraceEventArgs Constructor

Initializes a new instance of the [DependencyCheckTraceEventArgs](dependencychecktraceeventargs-class-microsoft-web-deployment.md) class.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    levelAsTraceLevel, _
    messageAsString _
)
'Usage
DimlevelAsTraceLevelDimmessageAsStringDiminstanceAs NewDependencyCheckTraceEventArgs(level, message)
```

``` csharp
publicDependencyCheckTraceEventArgs(
    TraceLevellevel,
    stringmessage
)
```

``` c++
public:
DependencyCheckTraceEventArgs(
    TraceLevellevel, 
    String^ message
)
```

``` jscript
publicfunctionDependencyCheckTraceEventArgs(
    level : TraceLevel, 
    message : String
)
```

#### Parameters

  - level  
    Type: [System.Diagnostics. . :: . .TraceLevel](https://msdn.microsoft.com/en-us/library/20aafb76\(v=vs.90\))  
    The trace level of the event to log.  

<!-- end list -->

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The message to log.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DependencyCheckTraceEventArgs Class](dependencychecktraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

