---
title: SmoothStreamingMediaElement.LinearClipChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LinearClipChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LinearClipChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.linearclipchanged(v=VS.95)
ms:contentKeyID: 46307496
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LinearClipChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_LinearClipChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LinearClipChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_LinearClipChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.LinearClipChanged Event

Occurs when a media stream transitions in and out of a linear clip between two linear ads.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event LinearClipChanged As EventHandler(Of ClipEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipEventArgs)

AddHandler instance.LinearClipChanged, handler
```

```csharp
public event EventHandler<ClipEventArgs> LinearClipChanged
```

```cpp
public:
 event EventHandler<ClipEventArgs^>^ LinearClipChanged {
    void add (EventHandler<ClipEventArgs^>^ value);
    void remove (EventHandler<ClipEventArgs^>^ value);
}
```

``` fsharp
member LinearClipChanged : <EventHandler<ClipEventArgs>,
    ClipEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

The context of the previous linear clip is passed through the [ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

The LinearClipChanged event does not occur for non-linear clips.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

