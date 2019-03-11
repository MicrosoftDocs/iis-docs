---
title: TraceEntry.ClassName Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: ClassName Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.ClassName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.classname(v=VS.95)
ms:contentKeyID: 46307727
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.ClassName
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_ClassName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_ClassName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.ClassName
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_ClassName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_ClassName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TraceEntry.ClassName Property

Gets or sets the ClassName property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ClassName As String
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As String

value = instance.ClassName

instance.ClassName = value
```

```csharp
public string ClassName { get; set; }
```

```cpp
public:
property String^ ClassName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member ClassName : string with get, set
```

```jscript
function get ClassName () : String
function set ClassName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that specifies the class name of the method that invoked the trace.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

