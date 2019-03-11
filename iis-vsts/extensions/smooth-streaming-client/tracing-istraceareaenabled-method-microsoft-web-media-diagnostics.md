---
title: Tracing.IsTraceAreaEnabled Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsTraceAreaEnabled Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled(Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.istraceareaenabled(v=VS.90)
ms:contentKeyID: 23960997
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceAreaEnabled
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsTraceAreaEnabled Method

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

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A Boolean value that indicates whether the specified TraceArea is enabled; the value is true if enabled, otherwise false.  

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

