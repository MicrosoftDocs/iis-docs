---
title: SmoothStreamingMediaElement.LiveEventCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LiveEventCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveeventcompleted(v=VS.95)
ms:contentKeyID: 46307520
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_LiveEventCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_LiveEventCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.LiveEventCompleted Event

Occurs when a live media stream ends.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event LiveEventCompleted As EventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler

AddHandler instance.LiveEventCompleted, handler
```

```csharp
public event EventHandler LiveEventCompleted
```

```cpp
public:
 event EventHandler^ LiveEventCompleted {
    void add (EventHandler^ value);
    void remove (EventHandler^ value);
}
```

``` fsharp
member LiveEventCompleted : <EventHandler,
    EventArgs>
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

