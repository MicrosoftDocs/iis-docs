---
title: Tracing.Trace Method (TraceArea, TraceLevel, String) (Microsoft.Web.Media.Diagnostics)
TOCTitle: Trace Method (TraceArea, TraceLevel, String)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.Trace(Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.trace(v=VS.90)
ms:contentKeyID: 23961200
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

# Trace Method (TraceArea, TraceLevel, String)

Traces a diagnostic message that is specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub Trace ( _
    traceArea As TraceArea, _
    traceLevel As TraceLevel, _
    line As String _
)
'Usage

  Dim traceArea As TraceArea
Dim traceLevel As TraceLevel
Dim line As String

Tracing.Trace(traceArea, traceLevel, _
    line)
```

```csharp
  public static void Trace(
    TraceArea traceArea,
    TraceLevel traceLevel,
    string line
)
```

```cpp
  public:
static void Trace(
    TraceArea traceArea, 
    TraceLevel traceLevel, 
    String^ line
)
```

```jscript
  public static function Trace(
    traceArea : TraceArea, 
    traceLevel : TraceLevel, 
    line : String
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

  - line  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A string value that specifies the text of the output message.  

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
