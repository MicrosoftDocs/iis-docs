---
title: JobMetadata.SuccessCodes Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SuccessCodes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.successcodes(v=VS.90)
ms:contentKeyID: 35520901
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
- Microsoft.Web.Media.TransformManager.JobMetadata.get_SuccessCodes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_SuccessCodes
- Microsoft.Web.Media.TransformManager.JobMetadata.SuccessCodes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SuccessCodes Property

Gets the success codes from the task element that is contained in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property SuccessCodes As Integer()
    Get
'Usage

  Dim instance As JobMetadata
Dim value As Integer()

value = instance.SuccessCodes
```

```csharp
  public int[] SuccessCodes { get; }
```

```cpp
  public:
property array<int>^ SuccessCodes {
    array<int>^ get ();
}
```

``` fsharp
  member SuccessCodes : int[]
```

```jscript
  function get SuccessCodes () : int[]
```

### Property Value

Type: array\<[System.Int32](https://msdn.microsoft.com/library/td2s409d)\> \[\] () \[\] \[\]  
The success codes.  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
