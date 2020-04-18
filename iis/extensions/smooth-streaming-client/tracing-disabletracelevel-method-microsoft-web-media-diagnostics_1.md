---
title: Tracing.DisableTraceLevel Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: DisableTraceLevel Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel(Microsoft.Web.Media.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.disabletracelevel(v=VS.95)
ms:contentKeyID: 46307614
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.DisableTraceLevel Method

Disables the trace severity level that is specified by the tracelevel parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub DisableTraceLevel ( _
    traceLevel As TraceLevel _
)
'Usage

Dim traceLevel As TraceLevel

Tracing.DisableTraceLevel(traceLevel)
```

```csharp
public static void DisableTraceLevel(
    TraceLevel traceLevel
)
```

```cpp
public:
static void DisableTraceLevel(
    TraceLevel traceLevel
)
```

``` fsharp
static member DisableTraceLevel : 
        traceLevel:TraceLevel -> unit 
```

```jscript
public static function DisableTraceLevel(
    traceLevel : TraceLevel
)
```

### Parameters

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object that specifies the trace level to be disabled.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
