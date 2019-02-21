---
title: Tracing.TraceFunctionExit Method (String, String, String, TraceArea) (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceFunctionExit Method (String, String, String, TraceArea)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.TraceFunctionExit(System.String,System.String,System.String,Microsoft.Web.Media.Diagnostics.TraceArea)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.tracefunctionexit(v=VS.95)
ms:contentKeyID: 46307634
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
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Tracing.TraceFunctionExit Method (String, String, String, TraceArea)

Records the exit from a function as specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub TraceFunctionExit ( _
    mediaElementId As String, _
    className As String, _
    methodName As String, _
    traceArea As TraceArea _
)
'Usage

Dim mediaElementId As String
Dim className As String
Dim methodName As String
Dim traceArea As TraceArea

Tracing.TraceFunctionExit(mediaElementId, _
    className, methodName, traceArea)
```

```csharp
public static void TraceFunctionExit(
    string mediaElementId,
    string className,
    string methodName,
    TraceArea traceArea
)
```

```cpp
public:
static void TraceFunctionExit(
    String^ mediaElementId, 
    String^ className, 
    String^ methodName, 
    TraceArea traceArea
)
```

``` fsharp
static member TraceFunctionExit : 
        mediaElementId:string * 
        className:string * 
        methodName:string * 
        traceArea:TraceArea -> unit 
```

```jscript
public static function TraceFunctionExit(
    mediaElementId : String, 
    className : String, 
    methodName : String, 
    traceArea : TraceArea
)
```

### Parameters

  - mediaElementId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    The ID of the current media element.

<!-- end list -->

  - className  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string value that specifies the class name of the calling function.

<!-- end list -->

  - methodName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string value that specifies the name of the calling function.

<!-- end list -->

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

