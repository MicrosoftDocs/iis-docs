---
title: StreamInfo.ChildStreams Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChildStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.childstreams(v=VS.95)
ms:contentKeyID: 46307868
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# StreamInfo.ChildStreams Property

Gets the ChildStreams property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property ChildStreams As IList(Of StreamInfo)
    Get
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

``` fsharp
member ChildStreams : IList<StreamInfo>
```

```jscript
function get ChildStreams () : IList<StreamInfo>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
A generic list of [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

