---
title: ConfigurationBase.ConfigurationDirectory Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.configurationdirectory(v=VS.90)
ms:contentKeyID: 35520680
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationDirectory
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_ConfigurationDirectory
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationDirectory Property

Gets or sets the configuration directory path for the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Property ConfigurationDirectory As String
    Get
    Set
'Usage

  Dim value As String

value = ConfigurationBase.ConfigurationDirectory

ConfigurationBase.ConfigurationDirectory = value
```

```csharp
  public static string ConfigurationDirectory { get; set; }
```

```cpp
  public:
static property String^ ConfigurationDirectory {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  static member ConfigurationDirectory : string with get, set
```

```jscript
  static function get ConfigurationDirectory () : String
static function set ConfigurationDirectory (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The configuration directory path.  

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

