---
title: Tracing.ConfigLoaded Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: ConfigLoaded Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.Tracing.ConfigLoaded
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.configloaded(v=VS.95)
ms:contentKeyID: 46307737
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.ConfigLoaded
- Microsoft.Web.Media.Diagnostics.Tracing.get_ConfigLoaded
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.ConfigLoaded
- Microsoft.Web.Media.Diagnostics.Tracing.get_ConfigLoaded
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.ConfigLoaded Property

Gets the ConfigLoaded property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared ReadOnly Property ConfigLoaded As Boolean
    Get
'Usage

Dim value As Boolean

value = Tracing.ConfigLoaded
```

```csharp
public static bool ConfigLoaded { get; }
```

```cpp
public:
static property bool ConfigLoaded {
    bool get ();
}
```

``` fsharp
static member ConfigLoaded : bool
```

```jscript
static function get ConfigLoaded () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value that specifies whether tracing configuration data has been loaded.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

