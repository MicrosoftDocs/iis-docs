---
title: SmoothStreamingMediaElement.DownloadProgressOffset Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadProgressOffset Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadprogressoffset(v=VS.95)
ms:contentKeyID: 46307818
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_DownloadProgressOffset
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_DownloadProgressOffset
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.DownloadProgressOffset Property

Gets or sets the progress offset as a percentage.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property DownloadProgressOffset As Double
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.DownloadProgressOffset

instance.DownloadProgressOffset = value
```

```csharp
public double DownloadProgressOffset { get; set; }
```

```cpp
public:
property double DownloadProgressOffset {
    double get ();
    void set (double value);
}
```

``` fsharp
member DownloadProgressOffset : float with get, set
```

```jscript
function get DownloadProgressOffset () : double
function set DownloadProgressOffset (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
A value that indicates the progress offset.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

