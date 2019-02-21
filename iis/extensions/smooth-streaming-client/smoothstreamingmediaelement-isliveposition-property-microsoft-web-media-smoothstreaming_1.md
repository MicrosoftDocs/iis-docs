---
title: SmoothStreamingMediaElement.IsLivePosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsLivePosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLivePosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.isliveposition(v=VS.95)
ms:contentKeyID: 46307831
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLivePosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLivePosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsLivePosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsLivePosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.IsLivePosition Property

Gets or sets a value that indicates whether the current position is close to the live broadcast position.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property IsLivePosition As Boolean
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.IsLivePosition
```

```csharp
public bool IsLivePosition { get; }
```

```cpp
public:
property bool IsLivePosition {
    bool get ();
}
```

``` fsharp
member IsLivePosition : bool
```

```jscript
function get IsLivePosition () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the position in a media stream is unknown because the stream is live; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

