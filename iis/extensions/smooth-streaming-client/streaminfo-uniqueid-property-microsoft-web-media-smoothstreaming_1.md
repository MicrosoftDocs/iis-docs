---
title: StreamInfo.UniqueId Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: UniqueId Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.uniqueid(v=VS.95)
ms:contentKeyID: 46307869
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# StreamInfo.UniqueId Property

Gets or sets the Id that identifies this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property UniqueId As String
    Get
    Friend Set
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

``` fsharp
member UniqueId : string with get, internal set
```

```jscript
function get UniqueId () : String
internal function set UniqueId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that contains the Id.

## Remarks

For more information see the examples in [Timeline Markers and Events](timeline-markers-and-events.md).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

