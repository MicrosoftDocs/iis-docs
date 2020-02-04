---
title: SmoothStreamingMediaElement.Volume Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Volume Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.volume(v=VS.95)
ms:contentKeyID: 46307858
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Volume
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.Volume Property

Gets or sets the audio volume.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Volume As Double
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.Volume

instance.Volume = value
```

```csharp
public double Volume { get; set; }
```

```cpp
public:
property double Volume {
    double get ();
    void set (double value);
}
```

``` fsharp
member Volume : float with get, set
```

```jscript
function get Volume () : double
function set Volume (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
The audio volume.

## Remarks

For more information, see [Silverlight Applications](silverlight-applications.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

