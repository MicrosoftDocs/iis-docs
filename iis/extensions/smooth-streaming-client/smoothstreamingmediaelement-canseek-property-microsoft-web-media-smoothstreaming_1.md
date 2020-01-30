---
title: SmoothStreamingMediaElement.CanSeek Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CanSeek Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.canseek(v=VS.95)
ms:contentKeyID: 46307814
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CanSeek
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CanSeek
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.CanSeek Property

Gets or sets whether the position in the stream can be reset.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property CanSeek As Boolean
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.CanSeek

instance.CanSeek = value
```

```csharp
public bool CanSeek { get; set; }
```

```cpp
public:
property bool CanSeek {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member CanSeek : bool with get, set
```

```jscript
function get CanSeek () : boolean
function set CanSeek (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the media element can seek to a new position in the stream; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

