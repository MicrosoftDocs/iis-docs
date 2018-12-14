---
title: Tracing.IsTraceDestinationEnabled Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsTraceDestinationEnabled Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.IsTraceDestinationEnabled(Microsoft.Web.Media.Diagnostics.TraceDestination)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.istracedestinationenabled(v=VS.95)
ms:contentKeyID: 46307628
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceDestinationEnabled
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# Tracing.IsTraceDestinationEnabled Method

Returns a Boolean value that indicates whether the specified TraceDestination is enabled.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Shared Function IsTraceDestinationEnabled ( _
    traceDestination As TraceDestination _
) As Boolean
'Usage

Dim traceDestination As TraceDestination
Dim returnValue As Boolean

returnValue = Tracing.IsTraceDestinationEnabled(traceDestination)
```

``` csharp
public static bool IsTraceDestinationEnabled(
    TraceDestination traceDestination
)
```

``` c++
public:
static bool IsTraceDestinationEnabled(
    TraceDestination traceDestination
)
```

``` fsharp
static member IsTraceDestinationEnabled : 
        traceDestination:TraceDestination -> bool 
```

``` jscript
public static function IsTraceDestinationEnabled(
    traceDestination : TraceDestination
) : boolean
```

#### Parameters

  - traceDestination  
    Type: [Microsoft.Web.Media.Diagnostics.TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceDestination](tracedestination-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

#### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if the given trace destination is enabled, otherwise false.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

