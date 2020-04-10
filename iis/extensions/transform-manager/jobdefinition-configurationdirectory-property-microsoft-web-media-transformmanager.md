---
title: JobDefinition.ConfigurationDirectory Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.configurationdirectory(v=VS.90)
ms:contentKeyID: 35521152
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobDefinition.ConfigurationDirectory
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ConfigurationDirectory
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationDirectory Property

Gets the path of the job definition configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ConfigurationDirectory As String
    Get
'Usage

  Dim instance As JobDefinition
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
The path of the job definition configuration file.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
