---
title: SmoothStreamingMediaElement.SetPlaybackRangeCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.setplaybackrangecompleted(v=VS.95)
ms:contentKeyID: 46307506
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeCompleted
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_SetPlaybackRangeCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_SetPlaybackRangeCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SetPlaybackRangeCompleted Event

Occurs when a SetPlaybackRangeAsync operation has completed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Event SetPlaybackRangeCompleted As SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler

AddHandler instance.SetPlaybackRangeCompleted, handler
```

``` csharp
public event SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler SetPlaybackRangeCompleted
```

``` c++
public:
 event SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler^ SetPlaybackRangeCompleted {
    void add (SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler^ value);
    void remove (SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler^ value);
}
```

``` fsharp
member SetPlaybackRangeCompleted : <SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler,
    AsyncCompletedEventArgs>
```

``` jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

