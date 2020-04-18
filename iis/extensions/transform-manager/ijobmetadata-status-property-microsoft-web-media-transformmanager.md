---
title: IJobMetadata.Status Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.Status
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.ijobmetadata.status(v=VS.90)
ms:contentKeyID: 35520634
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.set_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Status
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.set_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.Status
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Status Property

Gets or sets the status of an ongoing transform.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Property Status As String
    Get
    Set
'Usage

  Dim instance As IJobMetadata
Dim value As String

value = instance.Status

instance.Status = value
```

```csharp
  string Status { get; set; }
```

```cpp
  property String^ Status {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  abstract Status : string with get, set
```

```jscript
  function get Status () : String
function set Status (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The transform status.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
