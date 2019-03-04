---
title: ClipContext.NaturalDuration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.naturalduration(v=VS.95)
ms:contentKeyID: 46307767
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_NaturalDuration
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_NaturalDuration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipContext.NaturalDuration Property

Gets the natural duration for the clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Overridable Property NaturalDuration As Duration
    Get
    Friend Set
'Usage

Dim instance As ClipContext
Dim value As Duration

value = instance.NaturalDuration
```

```csharp
public virtual Duration NaturalDuration { get; internal set; }
```

```cpp
public:
virtual property Duration NaturalDuration {
    Duration get ();
    internal: void set (Duration value);
}
```

``` fsharp
abstract NaturalDuration : Duration with get, internal set
override NaturalDuration : Duration with get, internal set
```

```jscript
function get NaturalDuration () : Duration
internal function set NaturalDuration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\))  
A [Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\)) object.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

