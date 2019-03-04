---
title: Tracing.DisableTraceArea Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: DisableTraceArea Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceArea(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.disabletracearea(v=VS.90)
ms:contentKeyID: 23961209
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceArea
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceArea
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DisableTraceArea Method

Disables the trace area that is specified by the traceArea parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub DisableTraceArea ( _
    traceArea As TraceArea _
)
'Usage

  Dim traceArea As TraceArea

Tracing.DisableTraceArea(traceArea)
```

```csharp
  public static void DisableTraceArea(
    TraceArea traceArea
)
```

```cpp
  public:
static void DisableTraceArea(
    TraceArea traceArea
)
```

```jscript
  public static function DisableTraceArea(
    traceArea : TraceArea
)
```

### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object that specifies the trace area to be disabled.  

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

