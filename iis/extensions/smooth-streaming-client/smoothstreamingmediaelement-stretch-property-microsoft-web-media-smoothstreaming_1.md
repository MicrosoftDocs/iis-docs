---
title: SmoothStreamingMediaElement.Stretch Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Stretch Property
description: Gets or sets an object that determines how to stretch the media display.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.stretch(v=VS.95)
ms:contentKeyID: 46307845
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Stretch
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Stretch
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Stretch
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.Stretch Property

Gets or sets an object that determines how to stretch the media display.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Stretch As Stretch
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Stretch

value = instance.Stretch

instance.Stretch = value
```

```csharp
public Stretch Stretch { get; set; }
```

```cpp
public:
property Stretch Stretch {
    Stretch get ();
    void set (Stretch value);
}
```

``` fsharp
member Stretch : Stretch with get, set
```

```jscript
function get Stretch () : Stretch
function set Stretch (value : Stretch)
```

### Property Value

Type: [System.Windows.Media.Stretch](https://msdn.microsoft.com/library/ms635549\(v=vs.95\))  
An object that specifies how the media element should be stretched to fill the destination rectangle.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
