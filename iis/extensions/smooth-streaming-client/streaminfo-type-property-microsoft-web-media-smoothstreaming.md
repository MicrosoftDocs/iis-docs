---
title: StreamInfo.Type Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Type Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Type
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.type(v=VS.90)
ms:contentKeyID: 23961206
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Type
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Type
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Type
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Type
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Type
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Type
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Type Property

Gets or sets the Type property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Type As MediaStreamType
'Usage

  Dim instance As StreamInfo
Dim value As MediaStreamType

value = instance.Type
```

```csharp
  public MediaStreamType Type { get; internal set; }
```

```cpp
  public:
property MediaStreamType Type {
    MediaStreamType get ();
    internal: void set (MediaStreamType value);
}
```

```jscript
  function get Type () : MediaStreamType
internal function set Type (value : MediaStreamType)
```

### Property Value

Type: [System.Windows.Media.MediaStreamType](https://msdn.microsoft.com/library/cc672180)  
A string value that specifies the type.  

## Remarks

For more information and an example that parses [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events from Stream."

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

