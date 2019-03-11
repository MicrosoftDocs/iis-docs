---
title: SmoothStreamingMediaElement.MediaEnded Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MediaEnded Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediaended(v=VS.90)
ms:contentKeyID: 23961091
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_MediaEnded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_MediaEnded
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MediaEnded Event

Occurs when media playback reaches the end.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event MediaEnded As RoutedEventHandler
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.MediaEnded, handler
```

```csharp
  public event RoutedEventHandler MediaEnded
```

```cpp
  public:
 event RoutedEventHandler^ MediaEnded {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

