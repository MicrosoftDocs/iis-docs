---
title: SmoothStreamingMediaElement.Volume Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Volume Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.volume(v=VS.90)
ms:contentKeyID: 23961250
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Volume
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Volume
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Volume
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Volume Property

Gets or sets the audio volume.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Volume As Double
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

```jscript
  function get Volume () : double
function set Volume (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t)  
The audio volume.  

## Remarks

For more information, see [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md).

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

