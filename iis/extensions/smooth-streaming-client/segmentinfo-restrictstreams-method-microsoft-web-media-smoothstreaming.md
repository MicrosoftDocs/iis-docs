---
title: SegmentInfo.RestrictStreams Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: RestrictStreams Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.RestrictStreams(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.StreamInfo})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.restrictstreams(v=VS.95)
ms:contentKeyID: 46307674
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.RestrictStreams
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.RestrictStreams
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SegmentInfo.RestrictStreams Method

Restricts decoder initialization to the specified list of available streams.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub RestrictStreams ( _
    availableStreams As IList(Of StreamInfo) _
)
'Usage

Dim instance As SegmentInfo
Dim availableStreams As IList(Of StreamInfo)

instance.RestrictStreams(availableStreams)
```

```csharp
public void RestrictStreams(
    IList<StreamInfo> availableStreams
)
```

```cpp
public:
void RestrictStreams(
    IList<StreamInfo^>^ availableStreams
)
```

``` fsharp
member RestrictStreams : 
        availableStreams:IList<StreamInfo> -> unit 
```

```jscript
public function RestrictStreams(
    availableStreams : IList<StreamInfo>
)
```

### Parameters

  - availableStreams  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
    A list of streams to initialize. The list must be a subset of the current available streams. The list must contain at least one stream.

## Remarks

The RestrictStreams method can be called only for child streams in a [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event handler, and must be called before the [RestrictTracks](streaminfo-restricttracks-method-microsoft-web-media-smoothstreaming_1.md) method.

The RestrictStreams method can be called only once per [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) instance.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

