---
title: Tracing.IsTraceAreaEnabled Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsTraceAreaEnabled Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.istraceareaenabled(v=VS.95)
ms:contentKeyID: 46307620
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tracing.IsTraceAreaEnabled Method

Returns a Boolean that value indicates whether the specified TraceArea is enabled.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Function IsTraceAreaEnabled ( _
    traceArea As TraceArea _
) As Boolean
'Usage

Dim traceArea As TraceArea
Dim returnValue As Boolean

returnValue = Tracing.IsTraceAreaEnabled(traceArea)
```

```csharp
public static bool IsTraceAreaEnabled(
    TraceArea traceArea
)
```

```cpp
public:
static bool IsTraceAreaEnabled(
    TraceArea traceArea
)
```

``` fsharp
static member IsTraceAreaEnabled : 
        traceArea:TraceArea -> bool 
```

```jscript
public static function IsTraceAreaEnabled(
    traceArea : TraceArea
) : boolean
```

### Parameters

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value that indicates whether the specified TraceArea is enabled; the value is true if enabled, otherwise false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

