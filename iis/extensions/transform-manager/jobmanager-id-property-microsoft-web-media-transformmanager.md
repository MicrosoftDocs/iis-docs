---
title: JobManager.Id Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Id
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.id(v=VS.90)
ms:contentKeyID: 35521045
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.Id
- Microsoft.Web.Media.TransformManager.JobManager.get_Id
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_Id
- Microsoft.Web.Media.TransformManager.JobManager.Id
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Id Property

Gets the XML element ID of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Id As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.Id
```

```csharp
  public string Id { get; }
```

```cpp
  public:
property String^ Id {
    String^ get ();
}
```

``` fsharp
  member Id : string
```

```jscript
  function get Id () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The XML element ID of the IIS Transform Manager configuration.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
