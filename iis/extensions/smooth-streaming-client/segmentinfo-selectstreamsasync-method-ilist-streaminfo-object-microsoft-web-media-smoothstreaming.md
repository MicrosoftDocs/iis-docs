---
title: SegmentInfo.SelectStreamsAsync Method (IList(StreamInfo), Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectStreamsAsync Method (IList(StreamInfo), Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectStreamsAsync(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.StreamInfo},System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.segmentinfo.selectstreamsasync(v=VS.90)
ms:contentKeyID: 31469309
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

# SelectStreamsAsync Method (IList(StreamInfo), Object)

Initializes a new instance of the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub SelectStreamsAsync ( _
    selectedStreams As IList(Of StreamInfo), _
    userState As Object _
)
'Usage

  Dim instance As SegmentInfo
Dim selectedStreams As IList(Of StreamInfo)
Dim userState As Object

instance.SelectStreamsAsync(selectedStreams, _
    userState)
```

```csharp
  public void SelectStreamsAsync(
    IList<StreamInfo> selectedStreams,
    Object userState
)
```

```cpp
  public:
void SelectStreamsAsync(
    IList<StreamInfo^>^ selectedStreams, 
    Object^ userState
)
```

```jscript
  public function SelectStreamsAsync(
    selectedStreams : IList<StreamInfo>, 
    userState : Object
)
```

### Parameters

  - selectedStreams  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
    An IList object that contains the selected streams.  

<!-- end list -->

  - userState  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    The user can pass any state information in a standard or custom type.  

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
