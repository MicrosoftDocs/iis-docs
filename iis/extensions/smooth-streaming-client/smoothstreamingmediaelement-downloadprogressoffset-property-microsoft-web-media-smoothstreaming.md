---
title: SmoothStreamingMediaElement.DownloadProgressOffset Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DownloadProgressOffset Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.downloadprogressoffset(v=VS.90)
ms:contentKeyID: 23961037
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_DownloadProgressOffset
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_DownloadProgressOffset
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_DownloadProgressOffset
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# DownloadProgressOffset Property

Gets or sets the progress offset as a percentage.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property DownloadProgressOffset As Double
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

```jscript
  function get DownloadProgressOffset () : double
function set DownloadProgressOffset (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t)  
A value that indicates the progress offset.  

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

