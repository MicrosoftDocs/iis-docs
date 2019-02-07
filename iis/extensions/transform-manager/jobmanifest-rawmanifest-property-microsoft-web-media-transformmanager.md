---
title: JobManifest.RawManifest Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: RawManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.RawManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.rawmanifest(v=VS.90)
ms:contentKeyID: 35520727
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_RawManifest
- Microsoft.Web.Media.TransformManager.JobManifest.RawManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_RawManifest
- Microsoft.Web.Media.TransformManager.JobManifest.RawManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RawManifest Property

Gets the manifest XML content.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property RawManifest As XElement
    Get
'Usage

  Dim instance As JobManifest
Dim value As XElement

value = instance.RawManifest
```

``` csharp
  public XElement RawManifest { get; }
```

``` c++
  public:
property XElement^ RawManifest {
    XElement^ get ();
}
```

``` fsharp
  member RawManifest : XElement
```

``` jscript
  function get RawManifest () : XElement
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The manifest XML content.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

