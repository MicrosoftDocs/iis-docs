---
title: SmoothStreamingMediaElement.TotalBytesDownloaded Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: TotalBytesDownloaded Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TotalBytesDownloaded
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.totalbytesdownloaded(v=VS.90)
ms:contentKeyID: 28440974
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TotalBytesDownloaded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TotalBytesDownloaded
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TotalBytesDownloaded
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TotalBytesDownloaded
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TotalBytesDownloaded Property

Gets the total bytes downloaded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property TotalBytesDownloaded As Long
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Long

value = instance.TotalBytesDownloaded
```

```csharp
  public long TotalBytesDownloaded { get; }
```

```cpp
  public:
property long long TotalBytesDownloaded {
    long long get ();
}
```

```jscript
  function get TotalBytesDownloaded () : long
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek)  
The number of bytes downloaded.  

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

