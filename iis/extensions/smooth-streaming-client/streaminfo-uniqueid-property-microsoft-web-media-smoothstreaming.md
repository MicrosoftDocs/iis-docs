---
title: StreamInfo.UniqueId Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: UniqueId Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.uniqueid(v=VS.90)
ms:contentKeyID: 31469276
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_UniqueId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UniqueId Property

Gets or sets the Id that identifies this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property UniqueId As String
'Usage

  Dim instance As StreamInfo
Dim value As String

value = instance.UniqueId
```

```csharp
  public string UniqueId { get; internal set; }
```

```cpp
  public:
property String^ UniqueId {
    String^ get ();
    internal: void set (String^ value);
}
```

```jscript
  function get UniqueId () : String
internal function set UniqueId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string value that contains the Id.  

## Remarks

For more information see the examples in [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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

