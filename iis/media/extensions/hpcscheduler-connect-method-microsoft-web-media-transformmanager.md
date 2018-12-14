---
title: HpcScheduler.Connect Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Connect Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.Connect(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.connect(v=VS.90)
ms:contentKeyID: 35521176
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.Connect
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.Connect
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Connect Method

Connects to the HPC scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubConnect ( _
    connectionStringAsString _
)
'Usage
DiminstanceAsHpcSchedulerDimconnectionStringAsString

instance.Connect(connectionString)
```

``` csharp
publicoverridevoidConnect(
    stringconnectionString
)
```

``` c++
public:
virtualvoidConnect(
    String^ connectionString
) override
```

``` fsharp
abstractConnect : 
        connectionString:string->unitoverrideConnect : 
        connectionString:string->unit
```

``` jscript
publicoverridefunctionConnect(
    connectionString : String
)
```

#### Parameters

  - connectionString  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A connection string that is used to connect to the HPC scheduler on the head node in the cluster.  

## See Also

#### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

