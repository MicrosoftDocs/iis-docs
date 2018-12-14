---
title: SchedulerInfo Constructor (String, String, String, String, Int32) (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerInfo Constructor (String, String, String, String, Int32)
ms:assetid: M:Microsoft.Web.Media.TransformManager.SchedulerInfo.#ctor(System.String,System.String,System.String,System.String,System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo.schedulerinfo(v=VS.90)
ms:contentKeyID: 35521015
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchedulerInfo Constructor (String, String, String, String, Int32)

Initializes a new instance of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) class using the specified job ID, name, type, connection string, and concurrent jobs value.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    idAsString, _
    nameAsString, _
    typeAsString, _
    connectionStringAsString, _
    concurrentJobsAsInteger _
)
'Usage
DimidAsStringDimnameAsStringDimtypeAsStringDimconnectionStringAsStringDimconcurrentJobsAsIntegerDiminstanceAs NewSchedulerInfo(id, name, _
    type, connectionString, concurrentJobs)
```

``` csharp
publicSchedulerInfo(
    stringid,
    stringname,
    stringtype,
    stringconnectionString,
    intconcurrentJobs
)
```

``` c++
public:
SchedulerInfo(
    String^ id, 
    String^ name, 
    String^ type, 
    String^ connectionString, 
    intconcurrentJobs
)
```

``` fsharp
new : 
        id:string * 
        name:string * 
        type:string * 
        connectionString:string * 
        concurrentJobs:int->SchedulerInfo
```

``` jscript
publicfunctionSchedulerInfo(
    id : String, 
    name : String, 
    type : String, 
    connectionString : String, 
    concurrentJobs : int
)
```

#### Parameters

  - id  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job scheduler.  

<!-- end list -->

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the job scheduler.  

<!-- end list -->

  - type  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The scheduler type.  

<!-- end list -->

  - connectionString  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string that is used by this scheduler.  

<!-- end list -->

  - concurrentJobs  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The number of concurrent jobs that this scheduler can run.  

## See Also

#### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[SchedulerInfo Overload](schedulerinfo-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

