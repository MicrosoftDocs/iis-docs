---
title: Tracing.Trace Method (String, String, TraceArea, TraceLevel, String, Object[]) (Microsoft.Web.Media.Diagnostics)
TOCTitle: Trace Method (String, String, TraceArea, TraceLevel, String, Object[])
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.Trace(System.String,System.String,Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.trace(v=VS.95)
ms:contentKeyID: 46307445
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
- Microsoft.Web.Media.Diagnostics.Tracing.Trace
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.Trace Method (String, String, TraceArea, TraceLevel, String, array\<Object\[\])

Traces a diagnostic message that is specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub Trace ( _
    className As String, _
    methodName As String, _
    traceArea As TraceArea, _
    traceLevel As TraceLevel, _
    format As String, _
    ParamArray list As Object() _
)
'Usage

Dim className As String
Dim methodName As String
Dim traceArea As TraceArea
Dim traceLevel As TraceLevel
Dim format As String
Dim list As Object()

Tracing.Trace(className, methodName, _
    traceArea, traceLevel, format, list)
```

```csharp
public static void Trace(
    string className,
    string methodName,
    TraceArea traceArea,
    TraceLevel traceLevel,
    string format,
    params Object[] list
)
```

```cpp
public:
static void Trace(
    String^ className, 
    String^ methodName, 
    TraceArea traceArea, 
    TraceLevel traceLevel, 
    String^ format, 
    ... array<Object^>^ list
)
```

``` fsharp
static member Trace : 
        className:string * 
        methodName:string * 
        traceArea:TraceArea * 
        traceLevel:TraceLevel * 
        format:string * 
        list:Object[] -> unit 
```

```jscript
public static function Trace(
    className : String, 
    methodName : String, 
    traceArea : TraceArea, 
    traceLevel : TraceLevel, 
    format : String, 
    ... list : Object[]
)
```

### Parameters

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

<!-- end list -->

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

<!-- end list -->

  - format  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string value that contains a formatting string for the parameters list.

<!-- end list -->

  - list  
    Type: array\<[System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))\[\]  
    A [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)) array that contains the parameters of the trace message.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Trace Overload](tracing-trace-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

