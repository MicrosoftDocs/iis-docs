---
title: Tracing.Trace Method (String, String, String, TraceArea, TraceLevel, String) (Microsoft.Web.Media.Diagnostics)
TOCTitle: Trace Method (String, String, String, TraceArea, TraceLevel, String)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.Trace(System.String,System.String,System.String,Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.trace(v=VS.95)
ms:contentKeyID: 46307455
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.Trace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tracing.Trace Method (String, String, String, TraceArea, TraceLevel, String)

Traces a diagnostic message that is specified by the parameters.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Shared Sub Trace ( _
    mediaElementId As String, _
    className As String, _
    methodName As String, _
    traceArea As TraceArea, _
    traceLevel As TraceLevel, _
    line As String _
)
'Usage

Dim mediaElementId As String
Dim className As String
Dim methodName As String
Dim traceArea As TraceArea
Dim traceLevel As TraceLevel
Dim line As String

Tracing.Trace(mediaElementId, className, _
    methodName, traceArea, traceLevel, _
    line)
```

``` csharp
public static void Trace(
    string mediaElementId,
    string className,
    string methodName,
    TraceArea traceArea,
    TraceLevel traceLevel,
    string line
)
```

``` c++
public:
static void Trace(
    String^ mediaElementId, 
    String^ className, 
    String^ methodName, 
    TraceArea traceArea, 
    TraceLevel traceLevel, 
    String^ line
)
```

``` fsharp
static member Trace : 
        mediaElementId:string * 
        className:string * 
        methodName:string * 
        traceArea:TraceArea * 
        traceLevel:TraceLevel * 
        line:string -> unit 
```

``` jscript
public static function Trace(
    mediaElementId : String, 
    className : String, 
    methodName : String, 
    traceArea : TraceArea, 
    traceLevel : TraceLevel, 
    line : String
)
```

#### Parameters

  - mediaElementId  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
    A string value that specifies the ID of the current media element.

<!-- end list -->

  - className  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
    A string value that specifies the class name of the calling function.

<!-- end list -->

  - methodName  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
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

  - line  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
    A string value that specifies the text of the output message.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Trace Overload](tracing-trace-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

