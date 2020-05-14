---
title: Tracing.EnableTraceArea Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: EnableTraceArea Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceArea(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.enabletracearea(v=VS.95)
ms:contentKeyID: 46307615
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceArea
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceArea
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.EnableTraceArea Method

Enables the trace area that is specified by the traceArea parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub EnableTraceArea ( _
    traceArea As TraceArea _
)
'Usage

Dim traceArea As TraceArea

Tracing.EnableTraceArea(traceArea)
```

```csharp
public static void EnableTraceArea(
    TraceArea traceArea
)
```

```cpp
public:
static void EnableTraceArea(
    TraceArea traceArea
)
```

``` fsharp
static member EnableTraceArea :
        traceArea:TraceArea -> unit
```

```jscript
public static function EnableTraceArea(
    traceArea : TraceArea
)
```

### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object that specifies the trace area to be enabled.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
