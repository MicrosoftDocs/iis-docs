---
title: IisNamespaces.JobDefinitionNamespace Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.jobdefinitionnamespace(v=VS.90)
ms:contentKeyID: 35521194
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobDefinitionNamespace Property

Gets the URI of a media services schema document that is related to job definitions.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertyJobDefinitionNamespaceAsXNamespaceGet
'Usage
DimvalueAsXNamespacevalue = IisNamespaces.JobDefinitionNamespace
```

``` csharp
publicstaticXNamespaceJobDefinitionNamespace { get; }
```

``` c++
public:
staticpropertyXNamespace^ JobDefinitionNamespace {
    XNamespace^ get ();
}
```

``` fsharp
staticmemberJobDefinitionNamespace : XNamespace
```

``` jscript
staticfunction getJobDefinitionNamespace () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition\#".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

