---
title: ClipPlaybackEventArgs.Progress Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Progress Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.Progress
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipplaybackeventargs.progress(v=VS.90)
ms:contentKeyID: 23961121
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.Progress
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.get_Progress
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.set_Progress
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.get_Progress
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.Progress
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs.set_Progress
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Progress Property

Gets or sets the Progress property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Progress As ClipProgress
'Usage

  Dim instance As ClipPlaybackEventArgs
Dim value As ClipProgress

value = instance.Progress
```

```csharp
  public ClipProgress Progress { get; private set; }
```

```cpp
  public:
property ClipProgress Progress {
    ClipProgress get ();
    private: void set (ClipProgress value);
}
```

```jscript
  function get Progress () : ClipProgress
private function set Progress (value : ClipProgress)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipProgress](clipprogress-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A [ClipProgress](clipprogress-enumeration-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipPlaybackEventArgs Class](clipplaybackeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
