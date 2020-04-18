---
title: JobManifest.GetManifestElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetManifestElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement(System.Xml.Linq.XElement,System.String,System.Xml.Linq.XNamespace@)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.getmanifestelement(v=VS.90)
ms:contentKeyID: 35520973
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetManifestElement Method

Returns an XML representation of the manifest metadata.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetManifestElement ( _
    manifest As XElement, _
    localName As String, _
    <OutAttribute> ByRef elementNamespace As XNamespace _
) As XElement
'Usage

  Dim manifest As XElement
Dim localName As String
Dim elementNamespace As XNamespace
Dim returnValue As XElement

returnValue = JobManifest.GetManifestElement(manifest, _
    localName, elementNamespace)
```

```csharp
  public static XElement GetManifestElement(
    XElement manifest,
    string localName,
    out XNamespace elementNamespace
)
```

```cpp
  public:
static XElement^ GetManifestElement(
    XElement^ manifest, 
    String^ localName, 
    [OutAttribute] XNamespace^% elementNamespace
)
```

``` fsharp
  static member GetManifestElement : 
        manifest:XElement * 
        localName:string * 
        elementNamespace:XNamespace byref -> XElement 
```

```jscript
  public static function GetManifestElement(
    manifest : XElement, 
    localName : String, 
    elementNamespace : XNamespace
) : XElement
```

### Parameters

  - manifest  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An XML element that contains the manifest.  

<!-- end list -->

  - localName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The local name of the manifest.  

<!-- end list -->

  - elementNamespace  
    Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)%  
    The namespace of the manifest element.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The manifest XML element.  

## Remarks

This method returns an XML representation of the job manifest metadata. For example, this method is called by Transform Manager before saving an object to the folder that is created for the job.

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
