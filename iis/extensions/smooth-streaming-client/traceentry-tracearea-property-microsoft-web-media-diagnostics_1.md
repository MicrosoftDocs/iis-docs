---
title: TraceEntry.TraceArea Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceArea Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.TraceArea
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.tracearea(v=VS.95)
ms:contentKeyID: 46307732
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.TraceArea
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_TraceArea
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_TraceArea
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_TraceArea
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_TraceArea
- Microsoft.Web.Media.Diagnostics.TraceEntry.TraceArea
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TraceEntry.TraceArea Property

Gets or sets the TraceArea property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property TraceArea As TraceArea
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As TraceArea

value = instance.TraceArea

instance.TraceArea = value
```

```csharp
public TraceArea TraceArea { get; set; }
```

```cpp
public:
property TraceArea TraceArea {
    TraceArea get ();
    void set (TraceArea value);
}
```

``` fsharp
member TraceArea : TraceArea with get, set
```

```jscript
function get TraceArea () : TraceArea
function set TraceArea (value : TraceArea)
```

### Property Value

Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

