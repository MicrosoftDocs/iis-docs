---
title: JobManifest.GetManifestElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetManifestElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement(System.Xml.Linq.XElement,System.String,System.Xml.Linq.XNamespace@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.getmanifestelement(v=VS.90)
ms:contentKeyID: 35520973
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetManifestElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetManifestElement Method

Returns an XML representation of the manifest metadata.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetManifestElement ( _
    manifestAsXElement, _
    localNameAsString, _
    <OutAttribute> ByRefelementNamespaceAsXNamespace _
) AsXElement
'Usage
DimmanifestAsXElementDimlocalNameAsStringDimelementNamespaceAsXNamespaceDimreturnValueAsXElementreturnValue = JobManifest.GetManifestElement(manifest, _
    localName, elementNamespace)
```

``` csharp
publicstaticXElementGetManifestElement(
    XElementmanifest,
    stringlocalName,
    outXNamespaceelementNamespace
)
```

``` c++
public:
staticXElement^ GetManifestElement(
    XElement^ manifest, 
    String^ localName, 
    [OutAttribute] XNamespace^% elementNamespace
)
```

``` fsharp
staticmemberGetManifestElement : 
        manifest:XElement * 
        localName:string * 
        elementNamespace:XNamespacebyref->XElement
```

``` jscript
publicstaticfunctionGetManifestElement(
    manifest : XElement, 
    localName : String, 
    elementNamespace : XNamespace
) : XElement
```

#### Parameters

  - manifest  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An XML element that contains the manifest.  

<!-- end list -->

  - localName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The local name of the manifest.  

<!-- end list -->

  - elementNamespace  
    Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))%  
    The namespace of the manifest element.  

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The manifest XML element.  

## Remarks

This method returns an XML representation of the job manifest metadata. For example, this method is called by Transform Manager before saving an object to the folder that is created for the job.

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

