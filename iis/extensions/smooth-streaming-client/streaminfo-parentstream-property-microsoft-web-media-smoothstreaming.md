---
title: StreamInfo.ParentStream Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParentStream Property
description: Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.parentstream(v=VS.90)
ms:contentKeyID: 23961247
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ParentStream Property

Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ParentStream As StreamInfo
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

```jscript
  function get ParentStream () : StreamInfo
internal function set ParentStream (value : StreamInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

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
