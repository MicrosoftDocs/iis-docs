---
title: TraceEntry.MethodName Property 
description: Describes the TraceEntry.MethodName property and provides the property's namespace, assembly, syntax, property value, and references.
TOCTitle: MethodName Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.traceentry.methodname(v=VS.95)
ms:contentKeyID: 46307728
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MethodName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MethodName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TraceEntry.MethodName Property

Gets or sets the MethodName property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property MethodName As String
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As String

value = instance.MethodName

instance.MethodName = value
```

```csharp
public string MethodName { get; set; }
```

```cpp
public:
property String^ MethodName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member MethodName : string with get, set
```

```jscript
function get MethodName () : String
function set MethodName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that specifies the method name of the method that invoked the trace.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
