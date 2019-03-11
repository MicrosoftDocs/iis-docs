---
title: TaskDefinition.ConfigurationDirectory Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.configurationdirectory(v=VS.90)
ms:contentKeyID: 35520697
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.TaskDefinition.ConfigurationDirectory
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_ConfigurationDirectory
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationDirectory Property

Gets the path to the task definition configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ConfigurationDirectory As String
    Get
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.ConfigurationDirectory
```

```csharp
  public string ConfigurationDirectory { get; }
```

```cpp
  public:
property String^ ConfigurationDirectory {
    String^ get ();
}
```

``` fsharp
  member ConfigurationDirectory : string
```

```jscript
  function get ConfigurationDirectory () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The path.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

