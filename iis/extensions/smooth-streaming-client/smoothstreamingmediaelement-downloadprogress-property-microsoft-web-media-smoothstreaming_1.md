---
title: SmoothStreamingMediaElement.DownloadProgress Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadProgress Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadprogress(v=VS.95)
ms:contentKeyID: 46307822
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgress
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgress
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgress
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.DownloadProgress Property

Gets or sets the download progress.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property DownloadProgress As Double
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.DownloadProgress
```

```csharp
public double DownloadProgress { get; }
```

```cpp
public:
property double DownloadProgress {
    double get ();
}
```

``` fsharp
member DownloadProgress : float
```

```jscript
function get DownloadProgress () : double
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
A value that indicates the percentage progress of the download.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

