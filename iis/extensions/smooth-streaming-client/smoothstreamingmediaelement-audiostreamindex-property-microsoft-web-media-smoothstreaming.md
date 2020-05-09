---
title: SmoothStreamingMediaElement.AudioStreamIndex Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AudioStreamIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.audiostreamindex(v=VS.90)
ms:contentKeyID: 23960993
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamIndex
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AudioStreamIndex Property

Gets or sets the audio stream index. (This property is available only for Windows Media Player video (.wmv) content.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property AudioStreamIndex As Nullable(Of Integer)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of Integer)

value = instance.AudioStreamIndex

instance.AudioStreamIndex = value
```

```csharp
  public Nullable<int> AudioStreamIndex { get; set; }
```

```cpp
  public:
property Nullable<int> AudioStreamIndex {
    Nullable<int> get ();
    void set (Nullable<int> value);
}
```

```jscript
  function get AudioStreamIndex () : Nullable<int>
function set AudioStreamIndex (value : Nullable<int>)
```

### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/library/b3h38hb0)\< (Of \< ( \<'[Int32](https://msdn.microsoft.com/library/td2s409d)\> ) \> ) \>  
The audio stream index.  

## Remarks

For more information, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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
