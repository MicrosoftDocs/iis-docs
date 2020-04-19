---
title: SmoothStreamingMediaElement.DownloadProgressChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadProgressChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadprogresschanged(v=VS.95)
ms:contentKeyID: 46307493
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_DownloadProgressChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_DownloadProgressChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.DownloadProgressChanged Event

Occurs when the [DownloadProgress](smoothstreamingmediaelement-downloadprogress-property-microsoft-web-media-smoothstreaming_1.md) property changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event DownloadProgressChanged As RoutedEventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.DownloadProgressChanged, handler
```

```csharp
public event RoutedEventHandler DownloadProgressChanged
```

```cpp
public:
 event RoutedEventHandler^ DownloadProgressChanged {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

``` fsharp
member DownloadProgressChanged : <RoutedEventHandler,
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
