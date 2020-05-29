---
title: StreamInfo.ChildStreams Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChildStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.childstreams(v=VS.90)
ms:contentKeyID: 23961043
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ChildStreams Property

Gets the ChildStreams property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ChildStreams As IList(Of StreamInfo)
'Usage

  Dim instance As StreamInfo
Dim value As IList(Of StreamInfo)

value = instance.ChildStreams
```

```csharp
  public IList<StreamInfo> ChildStreams { get; }
```

```cpp
  public:
property IList<StreamInfo^>^ ChildStreams {
    IList<StreamInfo^>^ get ();
}
```

```jscript
  function get ChildStreams () : IList<StreamInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A generic list of [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
