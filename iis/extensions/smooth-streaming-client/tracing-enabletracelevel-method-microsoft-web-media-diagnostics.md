---
title: Tracing.EnableTraceLevel Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: EnableTraceLevel Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel(Microsoft.Web.Media.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.enabletracelevel(v=VS.90)
ms:contentKeyID: 23961185
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# EnableTraceLevel Method

Enables the trace severity level that is specified by the tracelevel parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub EnableTraceLevel ( _
    traceLevel As TraceLevel _
)
'Usage

  Dim traceLevel As TraceLevel

Tracing.EnableTraceLevel(traceLevel)
```

```csharp
  public static void EnableTraceLevel(
    TraceLevel traceLevel
)
```

```cpp
  public:
static void EnableTraceLevel(
    TraceLevel traceLevel
)
```

```jscript
  public static function EnableTraceLevel(
    traceLevel : TraceLevel
)
```

### Parameters

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object that specifies the trace level to be enabled.  

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

