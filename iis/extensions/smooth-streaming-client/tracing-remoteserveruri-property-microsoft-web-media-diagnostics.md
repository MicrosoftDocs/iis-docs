---
title: Tracing.RemoteServerUri Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: RemoteServerUri Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.remoteserveruri(v=VS.90)
ms:contentKeyID: 31469263
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.get_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.set_RemoteServerUri
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.get_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.set_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# RemoteServerUri Property

Gets or sets the [Uri](https://msdn.microsoft.com/library/txt7706a) of the remote server.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Property RemoteServerUri As Uri
'Usage

  Dim value As Uri

value = Tracing.RemoteServerUri
```

```csharp
  public static Uri RemoteServerUri { get; private set; }
```

```cpp
  public:
static property Uri^ RemoteServerUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

```jscript
  static function get RemoteServerUri () : Uri
private static function set RemoteServerUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a)  
A [Uri](https://msdn.microsoft.com/library/txt7706a) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

