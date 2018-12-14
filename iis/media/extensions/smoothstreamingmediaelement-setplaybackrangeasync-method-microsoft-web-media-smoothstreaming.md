---
title: SmoothStreamingMediaElement.SetPlaybackRangeAsync Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeAsync Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeAsync(System.TimeSpan,System.TimeSpan,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.setplaybackrangeasync(v=VS.95)
ms:contentKeyID: 46307692
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeAsync
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeAsync
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SetPlaybackRangeAsync Method

Specifies a start position for playing media content.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Sub SetPlaybackRangeAsync ( _
    leftEdge As TimeSpan, _
    rightEdge As TimeSpan, _
    userState As Object _
)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim leftEdge As TimeSpan
Dim rightEdge As TimeSpan
Dim userState As Object

instance.SetPlaybackRangeAsync(leftEdge, _
    rightEdge, userState)
```

``` csharp
public void SetPlaybackRangeAsync(
    TimeSpan leftEdge,
    TimeSpan rightEdge,
    Object userState
)
```

``` c++
public:
void SetPlaybackRangeAsync(
    TimeSpan leftEdge, 
    TimeSpan rightEdge, 
    Object^ userState
)
```

``` fsharp
member SetPlaybackRangeAsync : 
        leftEdge:TimeSpan * 
        rightEdge:TimeSpan * 
        userState:Object -> unit 
```

``` jscript
public function SetPlaybackRangeAsync(
    leftEdge : TimeSpan, 
    rightEdge : TimeSpan, 
    userState : Object
)
```

#### Parameters

  - leftEdge  
    Type: [System.TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\))  
    The start position of the content.

<!-- end list -->

  - rightEdge  
    Type: [System.TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\))  
    Reserved for future use.

<!-- end list -->

  - userState  
    Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
    The user state for later retrieval.

## Remarks

The SetPlaybackRangeAsync method is an asynchronous operation and only supports a start-over scenario in Live-to-VOD.

The SetPlaybackRangeAsync method fails if it is called and then called again before the first call completes, or if it is called before a SegmentInfo.SelectStreamsAsync call or seek operation completes. A SegmentInfo.SelectStreamsAsync call fails if it called before a SetPlaybackRangeAsync call completes.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

