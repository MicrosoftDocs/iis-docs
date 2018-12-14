---
title: JobMetadata.InstanceFileName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.instancefilename(v=VS.90)
ms:contentKeyID: 35521102
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobMetadata.InstanceFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstanceFileName Property

Gets the instance file name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInstanceFileNameAsStringGet
'Usage
DiminstanceAsJobMetadataDimvalueAsStringvalue = instance.InstanceFileName
```

``` csharp
publicstringInstanceFileName { get; }
```

``` c++
public:
virtualpropertyString^ InstanceFileName {
    String^ get () sealed;
}
```

``` fsharp
abstractInstanceFileName : stringoverrideInstanceFileName : string
```

``` jscript
finalfunction getInstanceFileName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The instance file name.  

#### Implements

[IJobMetadata. . :: . .InstanceFileName](ijobmetadata-instancefilename-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

