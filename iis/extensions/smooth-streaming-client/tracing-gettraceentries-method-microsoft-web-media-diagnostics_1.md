---
title: Tracing.GetTraceEntries Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: GetTraceEntries Method
description: Describes the GetTraceEntries Method and provides the namespace, assembly, syntax, return value, and version information.
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.gettraceentries(v=VS.95)
ms:contentKeyID: 46307619
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.GetTraceEntries Method

Gets an array of trace entries.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Function GetTraceEntries ( _
    flushList As Boolean _
) As TraceEntry()
'Usage

Dim flushList As Boolean
Dim returnValue As TraceEntry()

returnValue = Tracing.GetTraceEntries(flushList)
```

```csharp
public static TraceEntry[] GetTraceEntries(
    bool flushList
)
```

```cpp
public:
static array<TraceEntry^>^ GetTraceEntries(
    bool flushList
)
```

``` fsharp
static member GetTraceEntries : 
        flushList:bool -> TraceEntry[] 
```

```jscript
public static function GetTraceEntries(
    flushList : boolean
) : TraceEntry[]
```

### Parameters

  - flushList  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    A Boolean value that specifies whether to flush the current buffer of trace entries.

### Return Value

Type: array\<[Microsoft.Web.Media.Diagnostics.TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md)\[\]  
An array of [TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md) objects.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
