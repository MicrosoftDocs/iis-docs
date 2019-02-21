---
title: SmoothStreamingMediaElement.MediaOpened Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MediaOpened Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaOpened
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediaopened(v=VS.90)
ms:contentKeyID: 23960982
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaOpened
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_MediaOpened
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaOpened
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_MediaOpened
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# MediaOpened Event

Occurs when the media stream has been validated and opened and the file headers have been read.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event MediaOpened As RoutedEventHandler
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.MediaOpened, handler
```

```csharp
  public event RoutedEventHandler MediaOpened
```

```cpp
  public:
 event RoutedEventHandler^ MediaOpened {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

Applications should parse the manifest for markers during the MediaOpened event, but not earlier. Specifically, applications should not parse the manifest during the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event, because all markers set before MediaOpened are cleared in Silverlight when the MediaOpened event occurs.

For more information, see [Events (IIS Smooth Streaming)](events.md) and [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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

