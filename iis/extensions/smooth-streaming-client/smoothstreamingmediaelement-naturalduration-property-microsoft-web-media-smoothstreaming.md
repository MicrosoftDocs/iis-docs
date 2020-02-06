---
title: SmoothStreamingMediaElement.NaturalDuration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalDuration
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.naturalduration(v=VS.90)
ms:contentKeyID: 23961123
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalDuration
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.NaturalDuration
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# NaturalDuration Property

Gets the duration of the current stream when it plays to the end.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property NaturalDuration As Duration
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Duration

value = instance.NaturalDuration
```

```csharp
  public Duration NaturalDuration { get; }
```

```cpp
  public:
property Duration NaturalDuration {
    Duration get ();
}
```

```jscript
  function get NaturalDuration () : Duration
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372)  
The duration of the stream.  

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

