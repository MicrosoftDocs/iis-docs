---
title: TraceEntry.ThreadId Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: ThreadId Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.ThreadId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.traceentry.threadid(v=VS.90)
ms:contentKeyID: 23961187
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.ThreadId
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_ThreadId
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_ThreadId
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_ThreadId
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_ThreadId
- Microsoft.Web.Media.Diagnostics.TraceEntry.ThreadId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ThreadId Property

Gets or sets the ThreadId property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ThreadId As Integer
'Usage

  Dim instance As TraceEntry
Dim value As Integer

value = instance.ThreadId

instance.ThreadId = value
```

```csharp
  public int ThreadId { get; set; }
```

```cpp
  public:
property int ThreadId {
    int get ();
    void set (int value);
}
```

```jscript
  function get ThreadId () : int
function set ThreadId (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
An integer value that specifies the numeric ID of the thread that invoked the trace.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
