---
title: JobMetadata.Status Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.status(v=VS.90)
ms:contentKeyID: 35521097
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.Status
- Microsoft.Web.Media.TransformManager.JobMetadata.get_Status
- Microsoft.Web.Media.TransformManager.JobMetadata.set_Status
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_Status
- Microsoft.Web.Media.TransformManager.JobMetadata.set_Status
- Microsoft.Web.Media.TransformManager.JobMetadata.Status
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Status Property

Gets or sets the status of an ongoing transform.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Status As String
    Get
    Set
'Usage

  Dim instance As JobMetadata
Dim value As String

value = instance.Status

instance.Status = value
```

```csharp
  public string Status { get; set; }
```

```cpp
  public:
virtual property String^ Status {
    String^ get () sealed;
    void set (String^ value) sealed;
}
```

``` fsharp
  abstract Status : string with get, set
override Status : string with get, set
```

```jscript
  final function get Status () : String
final function set Status (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The status.  

### Implements

[IJobMetadata.Status](ijobmetadata-status-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

