---
title: IisNamespaces.Smil Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Smil Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.Smil
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.smil(v=VS.90)
ms:contentKeyID: 35520631
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Smil
- Microsoft.Web.Media.TransformManager.IisNamespaces.Smil
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_Smil
- Microsoft.Web.Media.TransformManager.IisNamespaces.Smil
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Smil Property

Gets the URI of an XML based Synchronized Multimedia Integration Language (SMIL) namespace that is used to represent information about audiovisual presentations.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertySmilAsXNamespaceGet
'Usage
DimvalueAsXNamespacevalue = IisNamespaces.Smil
```

``` csharp
publicstaticXNamespaceSmil { get; }
```

``` c++
public:
staticpropertyXNamespace^ Smil {
    XNamespace^ get ();
}
```

``` fsharp
staticmemberSmil : XNamespace
```

``` jscript
staticfunction getSmil () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://www.w3.org/2001/SMIL20".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

