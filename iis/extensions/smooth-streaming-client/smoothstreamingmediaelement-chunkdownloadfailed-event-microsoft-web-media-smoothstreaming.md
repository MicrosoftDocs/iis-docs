---
title: SmoothStreamingMediaElement.ChunkDownloadFailed Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkDownloadFailed Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ChunkDownloadFailed
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.chunkdownloadfailed(v=VS.95)
ms:contentKeyID: 46307510
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ChunkDownloadFailed
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ChunkDownloadFailed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ChunkDownloadFailed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ChunkDownloadFailed
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.ChunkDownloadFailed Event

Occurs when the chunk download associated with an audio or video stream fails.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ChunkDownloadFailed As EventHandler(Of ChunkDownloadedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ChunkDownloadedEventArgs)

AddHandler instance.ChunkDownloadFailed, handler
```

```csharp
public event EventHandler<ChunkDownloadedEventArgs> ChunkDownloadFailed
```

```cpp
public:
 event EventHandler<ChunkDownloadedEventArgs^>^ ChunkDownloadFailed {
    void add (EventHandler<ChunkDownloadedEventArgs^>^ value);
    void remove (EventHandler<ChunkDownloadedEventArgs^>^ value);
}
```

``` fsharp
member ChunkDownloadFailed : <EventHandler<ChunkDownloadedEventArgs>,
    ChunkDownloadedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

The ChunkDownloadFailed event does not occur for download failures associated with clips (ScheduleClip and ScheduleLinearClip) and composite manifests.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

