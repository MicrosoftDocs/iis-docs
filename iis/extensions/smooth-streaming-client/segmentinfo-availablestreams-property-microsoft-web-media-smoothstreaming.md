---
title: SegmentInfo.AvailableStreams Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AvailableStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.availablestreams(v=VS.90)
ms:contentKeyID: 31469220
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_AvailableStreams
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.AvailableStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_AvailableStreams
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AvailableStreams Property

Gets the available [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects that is contained by a [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property AvailableStreams As IList(Of StreamInfo)
'Usage

  Dim instance As SegmentInfo
Dim value As IList(Of StreamInfo)

value = instance.AvailableStreams
```

```csharp
  public IList<StreamInfo> AvailableStreams { get; }
```

```cpp
  public:
property IList<StreamInfo^>^ AvailableStreams {
    IList<StreamInfo^>^ get ();
}
```

```jscript
  function get AvailableStreams () : IList<StreamInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A generic IList of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md).  

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

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

