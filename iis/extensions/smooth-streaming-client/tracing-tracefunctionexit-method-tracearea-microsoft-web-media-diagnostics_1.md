---
title: Tracing.TraceFunctionExit Method (TraceArea) (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceFunctionExit Method (TraceArea)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionExit(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.tracefunctionexit(v=VS.95)
ms:contentKeyID: 46307633
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionExit
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.TraceFunctionExit Method (TraceArea)

Records the exit from a function as specified by the parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub TraceFunctionExit ( _
    traceArea As TraceArea _
)
'Usage

Dim traceArea As TraceArea

Tracing.TraceFunctionExit(traceArea)
```

```csharp
public static void TraceFunctionExit(
    TraceArea traceArea
)
```

```cpp
public:
static void TraceFunctionExit(
    TraceArea traceArea
)
```

``` fsharp
static member TraceFunctionExit : 
        traceArea:TraceArea -> unit 
```

```jscript
public static function TraceFunctionExit(
    traceArea : TraceArea
)
```

### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[TraceFunctionExit Overload](tracing-tracefunctionexit-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
