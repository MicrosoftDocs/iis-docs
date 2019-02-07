---
title: SegmentInfo.AvailableStreams Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AvailableStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.availablestreams(v=VS.95)
ms:contentKeyID: 46307790
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_AvailableStreams
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_AvailableStreams
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SegmentInfo.AvailableStreams Property

Gets the available [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects that is contained by a [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public ReadOnly Property AvailableStreams As IList(Of StreamInfo)
    Get
'Usage

Dim instance As SegmentInfo
Dim value As IList(Of StreamInfo)

value = instance.AvailableStreams
```

``` csharp
public IList<StreamInfo> AvailableStreams { get; }
```

``` c++
public:
property IList<StreamInfo^>^ AvailableStreams {
    IList<StreamInfo^>^ get ();
}
```

``` fsharp
member AvailableStreams : IList<StreamInfo>
```

``` jscript
function get AvailableStreams () : IList<StreamInfo>
```

#### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.95\))\<[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
A generic IList of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md).

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

