---
title: LocalScheduler.CleanupWorkFolder Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CleanupWorkFolder Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.cleanupworkfolder(v=VS.90)
ms:contentKeyID: 46408418
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.CleanupWorkFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CleanupWorkFolder Method

This member overrides [Scheduler. . :: . .CleanupWorkFolder(String)](scheduler-cleanupworkfolder-method-microsoft-web-media-transformmanager.md).

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesSubCleanupWorkFolder ( _
    workfolderAsString _
)
'Usage
DiminstanceAsLocalSchedulerDimworkfolderAsString

instance.CleanupWorkFolder(workfolder)
```

``` csharp
publicoverridevoidCleanupWorkFolder(
    stringworkfolder
)
```

``` c++
public:
virtualvoidCleanupWorkFolder(
    String^ workfolder
) override
```

``` fsharp
abstractCleanupWorkFolder : 
        workfolder:string->unitoverrideCleanupWorkFolder : 
        workfolder:string->unit
```

``` jscript
publicoverridefunctionCleanupWorkFolder(
    workfolder : String
)
```

#### Parameters

  - workfolder  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

