---
title: Tracing.EnableTraceLevel Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: EnableTraceLevel Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel(Microsoft.Web.Media.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.enabletracelevel(v=VS.95)
ms:contentKeyID: 46307621
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.EnableTraceLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tracing.EnableTraceLevel Method

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

``` fsharp
static member EnableTraceLevel : 
        traceLevel:TraceLevel -> unit 
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

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

