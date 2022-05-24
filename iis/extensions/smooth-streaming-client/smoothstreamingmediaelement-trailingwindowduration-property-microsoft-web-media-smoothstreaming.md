---
title: SmoothStreamingMediaElement.TrailingWindowDuration Property (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax, permissions, and version information for the SmoothStreamingMediaElement.TrailingWindowDuration property.
TOCTitle: TrailingWindowDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.trailingwindowduration(v=VS.90)
ms:contentKeyID: 23961274
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_TrailingWindowDuration
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrailingWindowDuration Property

Gets or sets the trailing window duration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property TrailingWindowDuration As Duration
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Duration

value = instance.TrailingWindowDuration

instance.TrailingWindowDuration = value
```

```csharp
  public Duration TrailingWindowDuration { get; set; }
```

```cpp
  public:
property Duration TrailingWindowDuration {
    Duration get ();
    void set (Duration value);
}
```

```jscript
  function get TrailingWindowDuration () : Duration
function set TrailingWindowDuration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372)  
A duration object.  

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
