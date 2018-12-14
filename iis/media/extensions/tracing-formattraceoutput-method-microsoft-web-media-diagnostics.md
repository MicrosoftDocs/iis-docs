---
title: Tracing.FormatTraceOutput Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: FormatTraceOutput Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput(Microsoft.Web.Media.Diagnostics.TraceEntry)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.formattraceoutput(v=VS.90)
ms:contentKeyID: 23961101
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.FormatTraceOutput
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FormatTraceOutput Method

Formats the trace output according to the current configuration settings.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionFormatTraceOutput ( _
    entryAsTraceEntry _
) AsString
'Usage
DimentryAsTraceEntryDimreturnValueAsStringreturnValue = Tracing.FormatTraceOutput(entry)
```

``` csharp
publicstaticstringFormatTraceOutput(
    TraceEntryentry
)
```

``` c++
public:
staticString^ FormatTraceOutput(
    TraceEntry^ entry
)
```

``` jscript
publicstaticfunctionFormatTraceOutput(
    entry : TraceEntry
) : String
```

#### Parameters

  - entry  
    Type: [Microsoft.Web.Media.Diagnostics. . :: . .TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md)  
    A [TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md) object that specifies the entry to format.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

