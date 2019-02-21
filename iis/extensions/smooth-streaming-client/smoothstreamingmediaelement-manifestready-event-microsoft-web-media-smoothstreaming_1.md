---
title: SmoothStreamingMediaElement.ManifestReady Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestReady Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestReady
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.manifestready(v=VS.95)
ms:contentKeyID: 46307500
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestReady
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ManifestReady
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestReady
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ManifestReady
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.ManifestReady Event

Occurs when the manifest for the Smooth Streaming content is available for track selection.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ManifestReady As EventHandler(Of EventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of EventArgs)

AddHandler instance.ManifestReady, handler
```

```csharp
public event EventHandler<EventArgs> ManifestReady
```

```cpp
public:
 event EventHandler<EventArgs^>^ ManifestReady {
    void add (EventHandler<EventArgs^>^ value);
    void remove (EventHandler<EventArgs^>^ value);
}
```

``` fsharp
member ManifestReady : <EventHandler<EventArgs>,
    EventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

Applications should parse the manifest for markers during the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event, but not earlier. Specifically, applications should not parse the manifest during the ManifestReady event, because all markers set before [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) are cleared in Silverlight when the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event occurs.

For more information, see [Select and Monitor Bitrate](select-and-monitor-bitrate.md) and [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

