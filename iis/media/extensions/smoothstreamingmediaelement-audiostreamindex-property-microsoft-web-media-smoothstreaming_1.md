---
title: SmoothStreamingMediaElement.AudioStreamIndex Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AudioStreamIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.audiostreamindex(v=VS.95)
ms:contentKeyID: 46307811
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamIndex
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamIndex
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.AudioStreamIndex Property

Gets or sets the audio stream index. (This property is available only for Windows Media Video (.wmv) content.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property AudioStreamIndex As Nullable(Of Integer)
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of Integer)

value = instance.AudioStreamIndex

instance.AudioStreamIndex = value
```

``` csharp
public Nullable<int> AudioStreamIndex { get; set; }
```

``` c++
public:
property Nullable<int> AudioStreamIndex {
    Nullable<int> get ();
    void set (Nullable<int> value);
}
```

``` fsharp
member AudioStreamIndex : Nullable<int> with get, set
```

``` jscript
function get AudioStreamIndex () : Nullable<int>
function set AudioStreamIndex (value : Nullable<int>)
```

#### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.95\))\<[Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.95\))\>  
The audio stream index.

## Remarks

For more information, see [Timeline Markers and Events](timeline-markers-and-events.md).

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

