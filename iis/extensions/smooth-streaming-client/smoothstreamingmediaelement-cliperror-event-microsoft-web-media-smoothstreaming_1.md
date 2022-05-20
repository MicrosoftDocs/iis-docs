---
title: SmoothStreamingMediaElement.ClipError Event (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax and version information for the SmoothStreamingMediaElement.ClipError event.
TOCTitle: ClipError Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipError
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.cliperror(v=VS.95)
ms:contentKeyID: 46307511
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipError
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ClipError
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipError
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ClipError
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ClipError Event

Occurs when an error is raised while audio or video media is playing.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ClipError As EventHandler(Of ClipEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipEventArgs)

AddHandler instance.ClipError, handler
```

```csharp
public event EventHandler<ClipEventArgs> ClipError
```

```cpp
public:
 event EventHandler<ClipEventArgs^>^ ClipError {
    void add (EventHandler<ClipEventArgs^>^ value);
    void remove (EventHandler<ClipEventArgs^>^ value);
}
```

``` fsharp
member ClipError : <EventHandler<ClipEventArgs>,
    ClipEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
