---
title: IJobManifest.Initialize Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobManifest.Initialize(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmanifest.initialize(v=VS.90)
ms:contentKeyID: 35520772
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobManifest.Initialize
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobManifest.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Initializes member variables for a job manifest that is loaded from disk instead of created as part of a job submission.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
SubInitialize ( _
    fileNameAsString _
)
'Usage
DiminstanceAsIJobManifestDimfileNameAsString

instance.Initialize(fileName)
```

``` csharp
voidInitialize(
    stringfileName
)
```

``` c++
voidInitialize(
    String^ fileName
)
```

``` fsharp
abstractInitialize : 
        fileName:string->unit
```

``` jscript
functionInitialize(
    fileName : String
)
```

#### Parameters

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the job manifest file.  

## See Also

#### Reference

[IJobManifest Interface](ijobmanifest-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

