---
title: SmoothStreamingMediaElement.DownloadProgressChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadProgressChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadprogresschanged(v=VS.90)
ms:contentKeyID: 23961016
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_DownloadProgressChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_DownloadProgressChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DownloadProgressChanged Event

Occurs when the [DownloadProgress](smoothstreamingmediaelement-downloadprogress-property-microsoft-web-media-smoothstreaming_1.md) property changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

```jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

