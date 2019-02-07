---
title: SegmentInfo.SelectStreamsAsync Method (IList(StreamInfo)) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectStreamsAsync Method (IList(StreamInfo))
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectStreamsAsync(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.StreamInfo})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.selectstreamsasync(v=VS.95)
ms:contentKeyID: 46307669
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectStreamsAsync
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SegmentInfo.SelectStreamsAsync Method (IList\<StreamInfo\>)

Initializes a new instance of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Sub SelectStreamsAsync ( _
    selectedStreams As IList(Of StreamInfo) _
)
'Usage

Dim instance As SegmentInfo
Dim selectedStreams As IList(Of StreamInfo)

instance.SelectStreamsAsync(selectedStreams)
```

``` csharp
public void SelectStreamsAsync(
    IList<StreamInfo> selectedStreams
)
```

``` c++
public:
void SelectStreamsAsync(
    IList<StreamInfo^>^ selectedStreams
)
```

``` fsharp
member SelectStreamsAsync : 
        selectedStreams:IList<StreamInfo> -> unit 
```

``` jscript
public function SelectStreamsAsync(
    selectedStreams : IList<StreamInfo>
)
```

#### Parameters

  - selectedStreams  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.95\))\<[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
    An IList object that contains the selected streams.

## Remarks

Calling this method to change streams on a smooth streaming presentation with multiple video streams at the \<StreamIndex\> level will throw a .

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[SelectStreamsAsync Overload](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

