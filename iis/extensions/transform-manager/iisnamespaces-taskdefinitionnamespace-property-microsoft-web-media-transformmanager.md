---
title: IisNamespaces.TaskDefinitionNamespace Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinitionNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.TaskDefinitionNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.taskdefinitionnamespace(v=VS.90)
ms:contentKeyID: 35521011
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_TaskDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.TaskDefinitionNamespace
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_TaskDefinitionNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.TaskDefinitionNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TaskDefinitionNamespace Property

Gets the URI of an XML namespace that is related to task definitions.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property TaskDefinitionNamespace As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.TaskDefinitionNamespace
```

```csharp
  public static XNamespace TaskDefinitionNamespace { get; }
```

```cpp
  public:
static property XNamespace^ TaskDefinitionNamespace {
    XNamespace^ get ();
}
```

``` fsharp
  static member TaskDefinitionNamespace : XNamespace
```

```jscript
  static function get TaskDefinitionNamespace () : XNamespace
```

### Property Value

Type: [System.Xml.Linq.XNamespace](https://msdn.microsoft.com/library/bb291898)  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/TM/TaskDefinition\#".  

## See Also

### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

