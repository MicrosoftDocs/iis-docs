---
title: JobMetadata.SuccessCodes Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SuccessCodes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.successcodes(v=VS.90)
ms:contentKeyID: 35520901
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
- Microsoft.Web.Media.TransformManager.JobMetadata.get_SuccessCodes
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_SuccessCodes
- Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SuccessCodes Property

Gets the success codes from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySuccessCodesAsInteger()
    Get
'Usage
DiminstanceAsJobMetadataDimvalueAsInteger()

value = instance.SuccessCodes
```

``` csharp
publicint[] SuccessCodes { get; }
```

``` c++
public:
propertyarray<int>^ SuccessCodes {
    array<int>^ get ();
}
```

``` fsharp
memberSuccessCodes : int[]
```

``` jscript
function getSuccessCodes () : int[]
```

#### Property Value

Type: array\<[System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))\> \[\] () \[\] \[\]  
The success codes.  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

