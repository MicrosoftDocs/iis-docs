---
title: JobManifest.FindJobElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: FindJobElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.FindJobElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.findjobelement(v=VS.90)
ms:contentKeyID: 35520636
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.FindJobElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.FindJobElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FindJobElement Method

Returns the XML job element from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Function FindJobElement As XElement
'Usage

  Dim instance As JobManifest
Dim returnValue As XElement

returnValue = instance.FindJobElement()
```

``` csharp
  public XElement FindJobElement()
```

``` c++
  public:
XElement^ FindJobElement()
```

``` fsharp
  member FindJobElement : unit -> XElement 
```

``` jscript
  public function FindJobElement() : XElement
```

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The XML job element.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

