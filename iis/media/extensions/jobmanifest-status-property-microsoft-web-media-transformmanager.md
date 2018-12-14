---
title: JobManifest.Status Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.status(v=VS.90)
ms:contentKeyID: 35520891
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.set_Status
- Microsoft.Web.Media.TransformManager.JobManifest.get_Status
- Microsoft.Web.Media.TransformManager.JobManifest.Status
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Status
- Microsoft.Web.Media.TransformManager.JobManifest.set_Status
- Microsoft.Web.Media.TransformManager.JobManifest.Status
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Status Property

Gets or sets the status value from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyStatusAsStringGetSet
'Usage
DiminstanceAsJobManifestDimvalueAsStringvalue = instance.Status

instance.Status = value
```

``` csharp
publicstringStatus { get; set; }
```

``` c++
public:
propertyString^ Status {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
memberStatus : stringwithget, set
```

``` jscript
function getStatus () : Stringfunction setStatus (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The status value from the manifest.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

