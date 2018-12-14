---
title: IisNamespaces.Xmlns Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Xmlns Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.Xmlns
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.xmlns(v=VS.90)
ms:contentKeyID: 35520695
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.Xmlns
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Xmlns
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Xmlns
- Microsoft.Web.Media.TransformManager.IisNamespaces.Xmlns
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Xmlns Property

Gets a URL to an XML namespace that is related to XML namespaces.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertyXmlnsAsXNamespaceGet
'Usage
DimvalueAsXNamespacevalue = IisNamespaces.Xmlns
```

``` csharp
publicstaticXNamespaceXmlns { get; }
```

``` c++
public:
staticpropertyXNamespace^ Xmlns {
    XNamespace^ get ();
}
```

``` fsharp
staticmemberXmlns : XNamespace
```

``` jscript
staticfunction getXmlns () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://www.w3.org/2000/xmlns/".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

