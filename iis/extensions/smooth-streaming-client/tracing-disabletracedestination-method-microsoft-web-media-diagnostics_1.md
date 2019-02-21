---
title: Tracing.DisableTraceDestination Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: DisableTraceDestination Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceDestination(Microsoft.Web.Media.Diagnostics.TraceDestination)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.disabletracedestination(v=VS.95)
ms:contentKeyID: 46307613
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceDestination
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.DisableTraceDestination
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Tracing.DisableTraceDestination Method

Disables the trace destination that is specified by the destination parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub DisableTraceDestination ( _
    destination As TraceDestination _
)
'Usage

Dim destination As TraceDestination

Tracing.DisableTraceDestination(destination)
```

```csharp
public static void DisableTraceDestination(
    TraceDestination destination
)
```

```cpp
public:
static void DisableTraceDestination(
    TraceDestination destination
)
```

``` fsharp
static member DisableTraceDestination : 
        destination:TraceDestination -> unit 
```

```jscript
public static function DisableTraceDestination(
    destination : TraceDestination
)
```

### Parameters

  - destination  
    Type: [Microsoft.Web.Media.Diagnostics.TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

