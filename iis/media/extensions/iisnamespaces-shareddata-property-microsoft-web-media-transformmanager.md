---
title: IisNamespaces.SharedData Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: SharedData Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.SharedData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.shareddata(v=VS.90)
ms:contentKeyID: 35520561
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.SharedData
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_SharedData
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_SharedData
- Microsoft.Web.Media.TransformManager.IisNamespaces.SharedData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SharedData Property

Gets the URI of an XML namespace that is related to shared data.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertySharedDataAsXNamespaceGet
'Usage
DimvalueAsXNamespacevalue = IisNamespaces.SharedData
```

``` csharp
publicstaticXNamespaceSharedData { get; }
```

``` c++
public:
staticpropertyXNamespace^ SharedData {
    XNamespace^ get ();
}
```

``` fsharp
staticmemberSharedData : XNamespace
```

``` jscript
staticfunction getSharedData () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/SharedData\#".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

