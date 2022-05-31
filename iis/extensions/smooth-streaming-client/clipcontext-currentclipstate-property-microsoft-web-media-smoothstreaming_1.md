---
title: ClipContext.CurrentClipState Property (Microsoft.Web.Media.SmoothStreaming)
description: This article contains information on syntax and version information for the ClipContext.CurrentClipState property.
TOCTitle: CurrentClipState Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.CurrentClipState
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext.currentclipstate(v=VS.95)
ms:contentKeyID: 46307765
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.CurrentClipState
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_CurrentClipState
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# ClipContext.CurrentClipState Property

Gets the CurrentClipState property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property CurrentClipState As MediaElementState
    Get
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

``` fsharp
member CurrentClipState : MediaElementState
```

```jscript
function get CurrentClipState () : MediaElementState
```

### Property Value

Type: [System.Windows.Media.MediaElementState](https://msdn.microsoft.com/library/cc190214\(v=vs.95\))  
State as specified by the System.Windows.Media.MediaElementState enumeration.

## Remarks

Specifies the current state of the media element playing the clip.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
