---
title: CacheResponse2.UsedTrack Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: UsedTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse2.UsedTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse2.usedtrack(v=VS.95)
ms:contentKeyID: 46307749
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.get_UsedTrack
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.set_UsedTrack
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.UsedTrack
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.get_UsedTrack
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.set_UsedTrack
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2.UsedTrack
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheResponse2.UsedTrack Property

Gets or sets the track the cache plug-in uses for downloading a media chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property UsedTrack As TrackInfo
    Get
    Set
'Usage

Dim instance As CacheResponse2
Dim value As TrackInfo

value = instance.UsedTrack

instance.UsedTrack = value
```

``` csharp
public TrackInfo UsedTrack { get; set; }
```

``` c++
public:
property TrackInfo^ UsedTrack {
    TrackInfo^ get ();
    void set (TrackInfo^ value);
}
```

``` fsharp
member UsedTrack : TrackInfo with get, set
```

``` jscript
function get UsedTrack () : TrackInfo
function set UsedTrack (value : TrackInfo)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A TrackInfo object that represents the track.

## Remarks

The UsedTrack property must be set if the cache plug-in uses a different bitrate than the bitrate requested by the media element.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[CacheResponse2 Class](cacheresponse2-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

