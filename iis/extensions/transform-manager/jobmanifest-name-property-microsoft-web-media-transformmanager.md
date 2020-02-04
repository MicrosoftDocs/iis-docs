---
title: JobManifest.Name Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Name
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.name(v=VS.90)
ms:contentKeyID: 35520565
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Name
- Microsoft.Web.Media.TransformManager.JobManifest.set_Name
- Microsoft.Web.Media.TransformManager.JobManifest.Name
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Name
- Microsoft.Web.Media.TransformManager.JobManifest.Name
- Microsoft.Web.Media.TransformManager.JobManifest.set_Name
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Name Property

Gets or sets the name of the job manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Name As String
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.Name

instance.Name = value
```

```csharp
  public string Name { get; set; }
```

```cpp
  public:
property String^ Name {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member Name : string with get, set
```

```jscript
  function get Name () : String
function set Name (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the job manifest.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

