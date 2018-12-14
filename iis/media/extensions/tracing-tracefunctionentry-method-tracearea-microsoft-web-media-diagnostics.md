---
title: Tracing.TraceFunctionEntry Method (TraceArea) (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceFunctionEntry Method (TraceArea)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionEntry(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.tracefunctionentry(v=VS.90)
ms:contentKeyID: 23961052
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionEntry
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TraceFunctionEntry Method (TraceArea)

Records the entry into a function as specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubTraceFunctionEntry ( _
    traceAreaAsTraceArea _
)
'Usage
DimtraceAreaAsTraceAreaTracing.TraceFunctionEntry(traceArea)
```

``` csharp
publicstaticvoidTraceFunctionEntry(
    TraceAreatraceArea
)
```

``` c++
public:
staticvoidTraceFunctionEntry(
    TraceAreatraceArea
)
```

``` jscript
publicstaticfunctionTraceFunctionEntry(
    traceArea : TraceArea
)
```

#### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics. . :: . .TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.  

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

[TraceFunctionEntry Overload](tracing-tracefunctionentry-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

