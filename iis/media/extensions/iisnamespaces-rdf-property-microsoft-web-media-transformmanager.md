---
title: IisNamespaces.Rdf Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Rdf Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.Rdf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.rdf(v=VS.90)
ms:contentKeyID: 35520676
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.Rdf
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Rdf
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Rdf
- Microsoft.Web.Media.TransformManager.IisNamespaces.Rdf
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Rdf Property

Gets the URI of a specific XML namespace related to Resource Description Framework (RDF) schema that is used to represent information about Web resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertyRdfAsXNamespaceGet
'Usage
DimvalueAsXNamespacevalue = IisNamespaces.Rdf
```

``` csharp
publicstaticXNamespaceRdf { get; }
```

``` c++
public:
staticpropertyXNamespace^ Rdf {
    XNamespace^ get ();
}
```

``` fsharp
staticmemberRdf : XNamespace
```

``` jscript
staticfunction getRdf () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://www.w3.org/1999/02/22-rdf-syntax-ns\#".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

