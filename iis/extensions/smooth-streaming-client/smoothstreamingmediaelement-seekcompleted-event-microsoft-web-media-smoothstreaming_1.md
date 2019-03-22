---
title: SmoothStreamingMediaElement.SeekCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SeekCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.seekcompleted(v=VS.95)
ms:contentKeyID: 46307523
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_SeekCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_SeekCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.SeekCompleted Event

Occurs when a seek operation completes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event SeekCompleted As EventHandler(Of SeekCompletedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of SeekCompletedEventArgs)

AddHandler instance.SeekCompleted, handler
```

```csharp
public event EventHandler<SeekCompletedEventArgs> SeekCompleted
```

```cpp
public:
 event EventHandler<SeekCompletedEventArgs^>^ SeekCompleted {
    void add (EventHandler<SeekCompletedEventArgs^>^ value);
    void remove (EventHandler<SeekCompletedEventArgs^>^ value);
}
```

``` fsharp
member SeekCompleted : <EventHandler<SeekCompletedEventArgs>,
    SeekCompletedEventArgs>
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

