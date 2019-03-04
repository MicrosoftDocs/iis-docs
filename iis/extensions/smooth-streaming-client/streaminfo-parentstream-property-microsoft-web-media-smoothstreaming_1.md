---
title: StreamInfo.ParentStream Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParentStream Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.parentstream(v=VS.95)
ms:contentKeyID: 46307867
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamInfo.ParentStream Property

Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ParentStream As StreamInfo
    Get
    Friend Set
'Usage

Dim instance As StreamInfo
Dim value As StreamInfo

value = instance.ParentStream
```

```csharp
public StreamInfo ParentStream { get; internal set; }
```

```cpp
public:
property StreamInfo^ ParentStream {
    StreamInfo^ get ();
    internal: void set (StreamInfo^ value);
}
```

``` fsharp
member ParentStream : StreamInfo with get, internal set
```

```jscript
function get ParentStream () : StreamInfo
internal function set ParentStream (value : StreamInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

