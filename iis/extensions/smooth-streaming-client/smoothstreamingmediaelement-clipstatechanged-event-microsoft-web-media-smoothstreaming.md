---
title: SmoothStreamingMediaElement.ClipStateChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipStateChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipstatechanged(v=VS.90)
ms:contentKeyID: 23961063
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ClipStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ClipStateChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipStateChanged Event

Occurs when a media clip state changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event ClipStateChanged As EventHandler(Of ClipEventArgs)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipEventArgs)

AddHandler instance.ClipStateChanged, handler
```

```csharp
  public event EventHandler<ClipEventArgs> ClipStateChanged
```

```cpp
  public:
 event EventHandler<ClipEventArgs^>^ ClipStateChanged {
    void add (EventHandler<ClipEventArgs^>^ value);
    void remove (EventHandler<ClipEventArgs^>^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
