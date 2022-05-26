---
title: Tracing.FormatTraceOutput Method (Microsoft.Web.Media.Diagnostics)
description: "This article shares syntax, return value, and permissions for the Tracing.FormatTraceOutput Method, which formats the trace output according to the current configuration settings for Microsoft.Web.Media.Diagnostics."
TOCTitle: FormatTraceOutput Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput(Microsoft.Web.Media.Diagnostics.TraceEntry)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.formattraceoutput(v=VS.95)
ms:contentKeyID: 46307618
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.FormatTraceOutput Method

Formats the trace output according to the current configuration settings.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Function FormatTraceOutput ( _
    entry As TraceEntry _
) As String
'Usage

Dim entry As TraceEntry
Dim returnValue As String

returnValue = Tracing.FormatTraceOutput(entry)
```

```csharp
public static string FormatTraceOutput(
    TraceEntry entry
)
```

```cpp
public:
static String^ FormatTraceOutput(
    TraceEntry^ entry
)
```

``` fsharp
static member FormatTraceOutput : 
        entry:TraceEntry -> string 
```

```jscript
public static function FormatTraceOutput(
    entry : TraceEntry
) : String
```

### Parameters

  - entry  
    Type: [Microsoft.Web.Media.Diagnostics.TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md)  
    A [TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md) object that specifies the entry to format.

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
