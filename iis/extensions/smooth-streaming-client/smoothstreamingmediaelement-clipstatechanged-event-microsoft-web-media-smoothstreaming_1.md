---
title: SmoothStreamingMediaElement.ClipStateChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipStateChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipstatechanged(v=VS.95)
ms:contentKeyID: 46307512
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ClipStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ClipStateChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.ClipStateChanged Event

Occurs when a media clip state changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ClipStateChanged As EventHandler(Of ClipEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipEventArgs)

AddHandler instance.ClipStateChanged, handler
```

```csharp
public event EventHandler<ClipEventArgs> ClipStateChanged
```

```cpp
public:
 event EventHandler<ClipEventArgs^>^ ClipStateChanged {
    void add (EventHandler<ClipEventArgs^>^ value);
    void remove (EventHandler<ClipEventArgs^>^ value);
}
```

``` fsharp
member ClipStateChanged : <EventHandler<ClipEventArgs>,
    ClipEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

The ClipStateChanged event does not occur for linear ads.

For more information, see [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

