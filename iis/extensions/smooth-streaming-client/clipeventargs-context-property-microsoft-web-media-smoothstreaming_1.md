---
title: ClipEventArgs.Context Property (Microsoft.Web.Media.SmoothStreaming)
description: This article contains syntax and version information for the ClipEventArgs.Context property, as well as links to reference materials.
TOCTitle: Context Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipeventargs.context(v=VS.95)
ms:contentKeyID: 46307768
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.get_Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.set_Context
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.get_Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.set_Context
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipEventArgs.Context Property

Gets or sets the Context property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Context As ClipContext
    Get
    Private Set
'Usage

Dim instance As ClipEventArgs
Dim value As ClipContext

value = instance.Context
```

```csharp
public ClipContext Context { get; private set; }
```

```cpp
public:
property ClipContext^ Context {
    ClipContext^ get ();
    private: void set (ClipContext^ value);
}
```

``` fsharp
member Context : ClipContext with get, private set
```

```jscript
function get Context () : ClipContext
private function set Context (value : ClipContext)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.

## Remarks

For more information, see [Scheduling Media Clips](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipEventArgs Class](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
