---
title: Tracing.Trace Method (TraceArea, TraceLevel, String, Object[]) (Microsoft.Web.Media.Diagnostics)
TOCTitle: Trace Method (TraceArea, TraceLevel, String, Object[])
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.Trace(Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.trace(v=VS.90)
ms:contentKeyID: 23961009
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
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

# Trace Method (TraceArea, TraceLevel, String, Object\[\])

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
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A string value that contains a formatting string for the parameters list.  

<!-- end list -->

  - list  
    Type: array\<[System.Object](https://msdn.microsoft.com/library/e5kfa45b)\> \[\] () \[\] \[\]  
    A [Object](https://msdn.microsoft.com/library/e5kfa45b) array that contains the parameters of the trace message.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Trace Overload](tracing-trace-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

