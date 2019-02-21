---
title: SegmentInfo.SelectedStreams Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectedStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectedStreams
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.segmentinfo.selectedstreams(v=VS.95)
ms:contentKeyID: 46307791
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_SelectedStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectedStreams
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.get_SelectedStreams
- Microsoft.Web.Media.SmoothStreaming.SegmentInfo.SelectedStreams
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SegmentInfo.SelectedStreams Property

Gets the selected [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property SelectedStreams As IList(Of StreamInfo)
    Get
'Usage

Dim instance As SegmentInfo
Dim value As IList(Of StreamInfo)

value = instance.SelectedStreams
```

```csharp
public IList<StreamInfo> SelectedStreams { get; }
```

```cpp
public:
property IList<StreamInfo^>^ SelectedStreams {
    IList<StreamInfo^>^ get ();
}
```

``` fsharp
member SelectedStreams : IList<StreamInfo>
```

```jscript
function get SelectedStreams () : IList<StreamInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
A generic IList of type [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SegmentInfo Class](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

