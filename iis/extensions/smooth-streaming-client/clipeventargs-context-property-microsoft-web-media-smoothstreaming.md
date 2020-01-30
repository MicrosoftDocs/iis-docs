---
title: ClipEventArgs.Context Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Context Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipeventargs.context(v=VS.90)
ms:contentKeyID: 23961095
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.get_Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.set_Context
dev_langs:
- csharp
- jscript
- vb
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

# Context Property

Gets or sets the Context property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Context As ClipContext
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

```jscript
  function get Context () : ClipContext
private function set Context (value : ClipContext)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipEventArgs Class](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

