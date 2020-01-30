---
title: SmoothStreamingMediaElement.ClipClickThrough Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipClickThrough Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipClickThrough
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipclickthrough(v=VS.95)
ms:contentKeyID: 46307489
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipClickThrough
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ClipClickThrough
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipClickThrough
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ClipClickThrough
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ClipClickThrough Event

Occurs when a user clicks the media display.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ClipClickThrough As EventHandler(Of ClipEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipEventArgs)

AddHandler instance.ClipClickThrough, handler
```

```csharp
public event EventHandler<ClipEventArgs> ClipClickThrough
```

```cpp
public:
 event EventHandler<ClipEventArgs^>^ ClipClickThrough {
    void add (EventHandler<ClipEventArgs^>^ value);
    void remove (EventHandler<ClipEventArgs^>^ value);
}
```

``` fsharp
member ClipClickThrough : <EventHandler<ClipEventArgs>,
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

