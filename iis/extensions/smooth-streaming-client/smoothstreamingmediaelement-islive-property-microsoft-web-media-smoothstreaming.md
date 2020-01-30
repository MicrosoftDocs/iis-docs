---
title: SmoothStreamingMediaElement.IsLive Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsLive Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.islive(v=VS.90)
ms:contentKeyID: 23961025
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLive
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLive
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsLive Property

Gets or sets a value that indicates whether the current position is close to the live broadcast position.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property IsLive As Boolean
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.IsLive
```

```csharp
  public bool IsLive { get; }
```

```cpp
  public:
property bool IsLive {
    bool get ();
}
```

```jscript
  function get IsLive () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the media stream is close to live; otherwise, false.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

