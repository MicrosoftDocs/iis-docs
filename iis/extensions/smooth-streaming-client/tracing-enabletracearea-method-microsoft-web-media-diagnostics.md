---
title: Tracing.EnableTraceArea Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: EnableTraceArea Method
description: "The EnableTraceArea method enables the trace area that is specified by the traceArea parameter. This article describes its syntax, version information, and permissions."
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceArea(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.enabletracearea(v=VS.90)
ms:contentKeyID: 23961233
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceArea
dev_langs:
- csharp
- jscript
- vb
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

# EnableTraceArea Method

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
