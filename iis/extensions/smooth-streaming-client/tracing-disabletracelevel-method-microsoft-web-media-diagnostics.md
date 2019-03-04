---
title: Tracing.DisableTraceLevel Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: DisableTraceLevel Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel(Microsoft.Web.Media.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.disabletracelevel(v=VS.90)
ms:contentKeyID: 23961019
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DisableTraceLevel Method

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

