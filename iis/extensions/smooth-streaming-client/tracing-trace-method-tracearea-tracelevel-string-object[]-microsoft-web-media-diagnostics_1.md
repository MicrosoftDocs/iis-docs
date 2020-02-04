---
title: Tracing.Trace Method (TraceArea, TraceLevel, String, Object[]) (Microsoft.Web.Media.Diagnostics)
TOCTitle: Trace Method (TraceArea, TraceLevel, String, Object[])
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.Trace(Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.trace(v=VS.95)
ms:contentKeyID: 46307626
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.Trace
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.Trace Method (TraceArea, TraceLevel, String, array\<Object\[\])

Traces a diagnostic message that is specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub Trace ( _
    traceArea As TraceArea, _
    traceLevel As TraceLevel, _
    format As String, _
    ParamArray list As Object() _
)
'Usage

Dim traceArea As TraceArea
Dim traceLevel As TraceLevel
Dim format As String
Dim list As Object()

Tracing.Trace(traceArea, traceLevel, _
    format, list)
```

```csharp
public static void Trace(
    TraceArea traceArea,
    TraceLevel traceLevel,
    string format,
    params Object[] list
)
```

```cpp
public:
static void Trace(
    TraceArea traceArea, 
    TraceLevel traceLevel, 
    String^ format, 
    ... array<Object^>^ list
)
```

``` fsharp
static member Trace : 
        traceArea:TraceArea * 
        traceLevel:TraceLevel * 
        format:string * 
        list:Object[] -> unit 
```

```jscript
public static function Trace(
    traceArea : TraceArea, 
    traceLevel : TraceLevel, 
    format : String, 
    ... list : Object[]
)
```

### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

<!-- end list -->

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

<!-- end list -->

  - format  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string value that contains a formatting string for the parameters list.

<!-- end list -->

  - list  
    Type: array\<[System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))\[\]  
    A [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)) array that contains the parameters of the trace message.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Trace Overload](tracing-trace-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

