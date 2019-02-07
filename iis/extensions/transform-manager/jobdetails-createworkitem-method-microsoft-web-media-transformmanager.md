---
title: JobDetails.CreateWorkItem Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateWorkItem Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItem(Microsoft.Web.Media.TransformManager.JobManifest)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.createworkitem(v=VS.90)
ms:contentKeyID: 35521182
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItem
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItem
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateWorkItem Method

Creates a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item based on the specified job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Shared Function CreateWorkItem ( _
    manifest As JobManifest _
) As JobDetails
'Usage

  Dim manifest As JobManifest
Dim returnValue As JobDetails

returnValue = JobDetails.CreateWorkItem(manifest)
```

``` csharp
  public static JobDetails CreateWorkItem(
    JobManifest manifest
)
```

``` c++
  public:
static JobDetails^ CreateWorkItem(
    JobManifest^ manifest
)
```

``` fsharp
  static member CreateWorkItem : 
        manifest:JobManifest -> JobDetails 
```

``` jscript
  public static function CreateWorkItem(
    manifest : JobManifest
) : JobDetails
```

#### Parameters

  - manifest  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
    The job manifest to use to create a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

