---
title: IisNamespaces.JobDefinitionNamespace Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.iisnamespaces.jobdefinitionnamespace(v=VS.90)
ms:contentKeyID: 35521194
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobDefinitionNamespace
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobDefinitionNamespace Property

Gets the URI of a media services schema document that is related to job definitions.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property JobDefinitionNamespace As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.JobDefinitionNamespace
```

```csharp
  public static XNamespace JobDefinitionNamespace { get; }
```

```cpp
  public:
static property XNamespace^ JobDefinitionNamespace {
    XNamespace^ get ();
}
```

``` fsharp
  static member JobDefinitionNamespace : XNamespace
```

```jscript
  static function get JobDefinitionNamespace () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition\#".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
