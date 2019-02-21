---
title: SmoothStreamingMediaElement.MediaEnded Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MediaEnded Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediaended(v=VS.95)
ms:contentKeyID: 46307501
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_MediaEnded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaEnded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_MediaEnded
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.MediaEnded Event

Occurs when media playback reaches the end.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event MediaEnded As RoutedEventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.MediaEnded, handler
```

```csharp
public event RoutedEventHandler MediaEnded
```

```cpp
public:
 event RoutedEventHandler^ MediaEnded {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

``` fsharp
member MediaEnded : <RoutedEventHandler,
    RoutedEventArgs>
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

