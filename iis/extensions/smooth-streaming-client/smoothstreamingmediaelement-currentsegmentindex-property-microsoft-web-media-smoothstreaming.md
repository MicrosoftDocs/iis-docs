---
title: SmoothStreamingMediaElement.CurrentSegmentIndex Property (Microsoft.Web.Media.SmoothStreaming)
description: The CurrentSegmentIndex property gets the index of the current playing segment.
TOCTitle: CurrentSegmentIndex Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentsegmentindex(v=VS.90)
ms:contentKeyID: 31469206
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentSegmentIndex
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentSegmentIndex
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentSegmentIndex
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CurrentSegmentIndex Property

Gets the index of the current playing segment.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property CurrentSegmentIndex As Nullable(Of Integer)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Nullable(Of Integer)

value = instance.CurrentSegmentIndex
```

```csharp
  public Nullable<int> CurrentSegmentIndex { get; }
```

```cpp
  public:
property Nullable<int> CurrentSegmentIndex {
    Nullable<int> get ();
}
```

```jscript
  function get CurrentSegmentIndex () : Nullable<int>
```

### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/library/b3h38hb0)\< (Of \< ( \<'[Int32](https://msdn.microsoft.com/library/td2s409d)\> ) \> ) \>  
The index of the playing segment.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
