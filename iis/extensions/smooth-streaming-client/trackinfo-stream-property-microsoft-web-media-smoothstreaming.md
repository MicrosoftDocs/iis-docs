---
title: TrackInfo.Stream Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Stream Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Stream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.stream(v=VS.90)
ms:contentKeyID: 31469198
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Stream
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Stream
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Stream
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Stream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Stream Property

Gets the stream for this track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property Stream As StreamInfo
'Usage

  Dim instance As TrackInfo
Dim value As StreamInfo

value = instance.Stream
```

```csharp
  public StreamInfo Stream { get; }
```

```cpp
  public:
property StreamInfo^ Stream {
    StreamInfo^ get ();
}
```

```jscript
  function get Stream () : StreamInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

