---
title: JobManifest.Template Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Template Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Template
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.template(v=VS.90)
ms:contentKeyID: 35520848
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.Template
- Microsoft.Web.Media.TransformManager.JobManifest.get_Template
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Template
- Microsoft.Web.Media.TransformManager.JobManifest.Template
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Template Property

Gets an XML element that contains a set of sequential tasks that define a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Template As XElement
    Get
'Usage

  Dim instance As JobManifest
Dim value As XElement

value = instance.Template
```

```csharp
  public XElement Template { get; }
```

```cpp
  public:
property XElement^ Template {
    XElement^ get ();
}
```

``` fsharp
  member Template : XElement
```

```jscript
  function get Template () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
An XML element that contains a set of sequential tasks that define a job.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

