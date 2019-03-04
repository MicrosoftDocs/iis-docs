---
title: Tracing.IsTraceLevelEnabled Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsTraceLevelEnabled Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.IsTraceLevelEnabled(Microsoft.Web.Media.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.istracelevelenabled(v=VS.90)
ms:contentKeyID: 23961077
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceLevelEnabled
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.IsTraceLevelEnabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsTraceLevelEnabled Method

Returns a Boolean value that indicates whether the specified TraceLevel severity is enabled.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Function IsTraceLevelEnabled ( _
    traceLevel As TraceLevel _
) As Boolean
'Usage

  Dim traceLevel As TraceLevel
Dim returnValue As Boolean

returnValue = Tracing.IsTraceLevelEnabled(traceLevel)
```

```csharp
  public static bool IsTraceLevelEnabled(
    TraceLevel traceLevel
)
```

```cpp
  public:
static bool IsTraceLevelEnabled(
    TraceLevel traceLevel
)
```

```jscript
  public static function IsTraceLevelEnabled(
    traceLevel : TraceLevel
) : boolean
```

### Parameters

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A Boolean value, true if the specified TraceLevel is enabled, otherwise false.  

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

