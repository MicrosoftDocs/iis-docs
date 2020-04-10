---
title: SmoothStreamingMediaElement.AudioStreamCount Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AudioStreamCount Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.audiostreamcount(v=VS.90)
ms:contentKeyID: 23961079
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamCount
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamCount
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AudioStreamCount Property

Gets or sets the audio stream count. (This property is available only for Windows Media Player video (.wmv) content.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property AudioStreamCount As Integer
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Integer

value = instance.AudioStreamCount

instance.AudioStreamCount = value
```

```csharp
  public int AudioStreamCount { get; set; }
```

```cpp
  public:
property int AudioStreamCount {
    int get ();
    void set (int value);
}
```

```jscript
  function get AudioStreamCount () : int
function set AudioStreamCount (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The audio stream count.  

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
