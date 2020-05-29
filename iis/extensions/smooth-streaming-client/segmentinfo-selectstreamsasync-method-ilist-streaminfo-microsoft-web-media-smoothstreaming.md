---
title: SegmentInfo.SelectStreamsAsync Method (IList(StreamInfo)) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectStreamsAsync Method (IList(StreamInfo))
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectStreamsAsync(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.StreamInfo})
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.segmentinfo.selectstreamsasync(v=VS.90)
ms:contentKeyID: 31469275
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectStreamsAsync
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SelectStreamsAsync Method (IList(StreamInfo))

Initializes a new instance of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub SelectStreamsAsync ( _
    selectedStreams As IList(Of StreamInfo) _
)
'Usage

  Dim instance As SegmentInfo
Dim selectedStreams As IList(Of StreamInfo)

instance.SelectStreamsAsync(selectedStreams)
```

```csharp
  public void SelectStreamsAsync(
    IList<StreamInfo> selectedStreams
)
```

```cpp
  public:
void SelectStreamsAsync(
    IList<StreamInfo^>^ selectedStreams
)
```

```jscript
  public function SelectStreamsAsync(
    selectedStreams : IList<StreamInfo>
)
```

### Parameters

  - selectedStreams  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
    An IList object that contains the selected streams.  

## Remarks

Calling this method to change streams on a smooth streaming presentation with multiple video streams at the \<StreamIndex\> level will throw a \[NotImplementedException\].

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[SelectStreamsAsync Overload](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
