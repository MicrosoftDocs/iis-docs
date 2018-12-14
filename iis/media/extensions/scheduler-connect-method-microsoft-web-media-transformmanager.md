---
title: Scheduler.Connect Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Connect Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.Connect(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.scheduler.connect(v=VS.90)
ms:contentKeyID: 35520843
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.Connect
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.Connect
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Connect Method

Connects to the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubConnect ( _
    connectionStringAsString _
)
'Usage
DiminstanceAsSchedulerDimconnectionStringAsString

instance.Connect(connectionString)
```

``` csharp
publicabstractvoidConnect(
    stringconnectionString
)
```

``` c++
public:
virtualvoidConnect(
    String^ connectionString
) abstract
```

``` fsharp
abstractConnect : 
        connectionString:string->unit
```

``` jscript
publicabstractfunctionConnect(
    connectionString : String
)
```

#### Parameters

  - connectionString  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string that is used to connect to the scheduler.  

## See Also

#### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

