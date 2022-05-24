---
title: JobDetails.StatusString Property (Microsoft.Web.Media.TransformManager)
TOCTitle: StatusString Property
description: Describes the JobDetails.StatusString property and provides the field's namespace, assembly, syntax, and property value.
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.StatusString
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.statusstring(v=VS.90)
ms:contentKeyID: 35521034
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StatusString
- Microsoft.Web.Media.TransformManager.JobDetails.StatusString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StatusString
- Microsoft.Web.Media.TransformManager.JobDetails.StatusString
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StatusString Property

Gets a string representation of the status.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property StatusString As String
    Get
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.StatusString
```

```csharp
  public string StatusString { get; }
```

```cpp
  public:
property String^ StatusString {
    String^ get ();
}
```

``` fsharp
  member StatusString : string
```

```jscript
  function get StatusString () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string representation of the status.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
