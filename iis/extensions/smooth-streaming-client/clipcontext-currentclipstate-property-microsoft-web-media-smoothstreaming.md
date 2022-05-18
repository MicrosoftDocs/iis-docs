---
title: ClipContext.CurrentClipState Property - (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentClipState Property
description: Gets the CurrentClipState property.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.CurrentClipState
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext.currentclipstate(v=VS.90)
ms:contentKeyID: 23961246
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.CurrentClipState
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_CurrentClipState
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.CurrentClipState
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_CurrentClipState
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CurrentClipState Property

Gets the CurrentClipState property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property CurrentClipState As MediaElementState
'Usage

  Dim instance As ClipContext
Dim value As MediaElementState

value = instance.CurrentClipState
```

```csharp
  public MediaElementState CurrentClipState { get; }
```

```cpp
  public:
property MediaElementState CurrentClipState {
    MediaElementState get ();
}
```

```jscript
  function get CurrentClipState () : MediaElementState
```

### Property Value

Type: [System.Windows.Media.MediaElementState](https://msdn.microsoft.com/library/cc190214)  
State as specified by the MediaElementState()()()() enumeration.  

## Remarks

Specifies the current state of the media element playing the clip.

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
