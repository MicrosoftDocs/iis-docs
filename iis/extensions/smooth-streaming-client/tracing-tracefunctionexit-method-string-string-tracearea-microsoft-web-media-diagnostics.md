---
title: Tracing.TraceFunctionExit Method (String, String, TraceArea) (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceFunctionExit Method (String, String, TraceArea)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionExit(System.String,System.String,Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.tracefunctionexit(v=VS.90)
ms:contentKeyID: 23960944
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
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

# TraceFunctionExit Method (String, String, TraceArea)

Records the exit from a function as specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub TraceFunctionExit ( _
    className As String, _
    methodName As String, _
    traceArea As TraceArea _
)
'Usage

  Dim className As String
Dim methodName As String
Dim traceArea As TraceArea

Tracing.TraceFunctionExit(className, _
    methodName, traceArea)
```

```csharp
  public static void TraceFunctionExit(
    string className,
    string methodName,
    TraceArea traceArea
)
```

```cpp
  public:
static void TraceFunctionExit(
    String^ className, 
    String^ methodName, 
    TraceArea traceArea
)
```

```jscript
  public static function TraceFunctionExit(
    className : String, 
    methodName : String, 
    traceArea : TraceArea
)
```

### Parameters

  - className  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A string value that specifies the class name of the calling function.  

<!-- end list -->

  - methodName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A string value that specifies the name of the calling function.  

<!-- end list -->

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.  

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

[TraceFunctionExit Overload](tracing-tracefunctionexit-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
