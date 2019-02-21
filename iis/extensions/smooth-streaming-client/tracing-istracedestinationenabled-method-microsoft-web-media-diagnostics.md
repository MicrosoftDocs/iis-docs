---
title: Tracing.IsTraceDestinationEnabled Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsTraceDestinationEnabled Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.IsTraceDestinationEnabled(Microsoft.Web.Media.Diagnostics.TraceDestination)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.istracedestinationenabled(v=VS.90)
ms:contentKeyID: 23961105
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceDestinationEnabled
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceDestinationEnabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# IsTraceDestinationEnabled Method

Returns a Boolean value that indicates whether the specified TraceDestination is enabled.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Function IsTraceDestinationEnabled ( _
    traceDestination As TraceDestination _
) As Boolean
'Usage

  Dim traceDestination As TraceDestination
Dim returnValue As Boolean

returnValue = Tracing.IsTraceDestinationEnabled(traceDestination)
```

```csharp
  public static bool IsTraceDestinationEnabled(
    TraceDestination traceDestination
)
```

```cpp
  public:
static bool IsTraceDestinationEnabled(
    TraceDestination traceDestination
)
```

```jscript
  public static function IsTraceDestinationEnabled(
    traceDestination : TraceDestination
) : boolean
```

### Parameters

  - traceDestination  
    Type: [Microsoft.Web.Media.Diagnostics.TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A Boolean value, true if the given trace destination is enabled, otherwise false.  

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

