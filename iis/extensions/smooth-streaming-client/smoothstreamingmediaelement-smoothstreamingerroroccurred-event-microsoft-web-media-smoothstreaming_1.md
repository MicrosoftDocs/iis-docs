---
title: SmoothStreamingMediaElement.SmoothStreamingErrorOccurred Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingErrorOccurred Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingerroroccurred(v=VS.95)
ms:contentKeyID: 46307525
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_SmoothStreamingErrorOccurred
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_SmoothStreamingErrorOccurred
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.SmoothStreamingErrorOccurred Event

Occurs when an error is raised during playback of Smooth Streaming content.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event SmoothStreamingErrorOccurred As EventHandler(Of SmoothStreamingErrorEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of SmoothStreamingErrorEventArgs)

AddHandler instance.SmoothStreamingErrorOccurred, handler
```

```csharp
public event EventHandler<SmoothStreamingErrorEventArgs> SmoothStreamingErrorOccurred
```

```cpp
public:
 event EventHandler<SmoothStreamingErrorEventArgs^>^ SmoothStreamingErrorOccurred {
    void add (EventHandler<SmoothStreamingErrorEventArgs^>^ value);
    void remove (EventHandler<SmoothStreamingErrorEventArgs^>^ value);
}
```

``` fsharp
member SmoothStreamingErrorOccurred : <EventHandler<SmoothStreamingErrorEventArgs>,
    SmoothStreamingErrorEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

