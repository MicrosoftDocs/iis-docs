---
title: JobScheduler.ConfigurationDirectory Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.configurationdirectory(v=VS.90)
ms:contentKeyID: 35521109
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobScheduler.get_ConfigurationDirectory
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobScheduler.get_ConfigurationDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ConfigurationDirectory Property

Gets the path of the configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared ReadOnly Property ConfigurationDirectory As String
    Get
'Usage

  Dim value As String

value = JobScheduler.ConfigurationDirectory
```

```csharp
  public static string ConfigurationDirectory { get; }
```

```cpp
  public:
static property String^ ConfigurationDirectory {
    String^ get ();
}
```

``` fsharp
  static member ConfigurationDirectory : string
```

```jscript
  static function get ConfigurationDirectory () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The path of the configuration file.  

## See Also

### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

