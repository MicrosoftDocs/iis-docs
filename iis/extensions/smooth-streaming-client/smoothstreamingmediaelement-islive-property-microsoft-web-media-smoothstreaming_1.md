---
title: SmoothStreamingMediaElement.IsLive Property (Microsoft.Web.Media.SmoothStreaming)
description: Details the syntax for the SmoothStreamingMediaElement.IsLive property and gets or sets a value to indicates the current position for a live broadcast.
TOCTitle: IsLive Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.islive(v=VS.95)
ms:contentKeyID: 46307826
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLive
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLive
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLive
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.IsLive Property

Gets or sets a value that indicates whether the current position is close to the live broadcast position.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property IsLive As Boolean
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.IsLive
```

```csharp
public bool IsLive { get; }
```

```cpp
public:
property bool IsLive {
    bool get ();
}
```

``` fsharp
member IsLive : bool
```

```jscript
function get IsLive () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the media stream is close to live; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
