---
title: ClipInformation.Duration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Duration Property
description: Gets or sets the running time of the media clip.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.duration(v=VS.90)
ms:contentKeyID: 23960958
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Duration Property

Gets or sets the running time of the media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Duration As Duration
'Usage

  Dim instance As ClipInformation
Dim value As Duration

value = instance.Duration
```

```csharp
  public Duration Duration { get; private set; }
```

```cpp
  public:
property Duration Duration {
    Duration get ();
    private: void set (Duration value);
}
```

```jscript
  function get Duration () : Duration
private function set Duration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372)  
A [Duration](https://msdn.microsoft.com/library/ms602372) object.  

## Remarks

For a complete example that uses the Duration property, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
