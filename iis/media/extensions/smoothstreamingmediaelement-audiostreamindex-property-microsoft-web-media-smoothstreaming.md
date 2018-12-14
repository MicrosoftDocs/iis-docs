---
title: SmoothStreamingMediaElement.AudioStreamIndex Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AudioStreamIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.audiostreamindex(v=VS.90)
ms:contentKeyID: 23960993
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamIndex
dev_langs:
- CSharp
- JScript
- VB
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

# AudioStreamIndex Property

Gets or sets the audio stream index. (This property is available only for Windows Media Player video (.wmv) content.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyAudioStreamIndexAsNullable(OfInteger)
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsNullable(OfInteger)

value = instance.AudioStreamIndex

instance.AudioStreamIndex = value
```

``` csharp
publicNullable<int> AudioStreamIndex { get; set; }
```

``` c++
public:
propertyNullable<int> AudioStreamIndex {
    Nullable<int> get ();
    voidset (Nullable<int> value);
}
```

``` jscript
function getAudioStreamIndex () : Nullable<int>
function setAudioStreamIndex (value : Nullable<int>)
```

#### Property Value

Type: [System. . :: . .Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.90\))\< (Of \< ( \<'[Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))\> ) \> ) \>  
The audio stream index.  

## Remarks

For more information, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

