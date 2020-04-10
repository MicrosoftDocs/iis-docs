---
title: SmoothStreamingMediaElement.AutoPlay Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AutoPlay Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.autoplay(v=VS.90)
ms:contentKeyID: 23961119
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AutoPlay
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AutoPlay
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AutoPlay
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AutoPlay Property

Gets or sets a value that specifies whether the media element starts automatically.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property AutoPlay As Boolean
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.AutoPlay

instance.AutoPlay = value
```

```csharp
  public bool AutoPlay { get; set; }
```

```cpp
  public:
property bool AutoPlay {
    bool get ();
    void set (bool value);
}
```

```jscript
  function get AutoPlay () : boolean
function set AutoPlay (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the media element starts automatically; otherwise, false.  

## Remarks

For more information and for examples, see [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md).

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
