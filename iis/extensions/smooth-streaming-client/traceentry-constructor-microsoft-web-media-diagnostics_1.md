---
title: TraceEntry Constructor  (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceEntry Constructor
ms:assetid: M:Microsoft.Web.Media.Diagnostics.TraceEntry.#ctor(System.String,System.String,System.String,Microsoft.Web.Media.Diagnostics.TraceArea,Microsoft.Web.Media.Diagnostics.TraceLevel,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.traceentry(v=VS.95)
ms:contentKeyID: 46307416
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.#ctor
- Microsoft.Web.Media.Diagnostics.TraceEntry.TraceEntry
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TraceEntry Constructor

Initializes and new instance of the [TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md) class.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    mediaElementId As String, _
    className As String, _
    methodName As String, _
    traceArea As TraceArea, _
    traceLevel As TraceLevel, _
    text As String _
)
'Usage

Dim mediaElementId As String
Dim className As String
Dim methodName As String
Dim traceArea As TraceArea
Dim traceLevel As TraceLevel
Dim text As String

Dim instance As New TraceEntry(mediaElementId, _
    className, methodName, traceArea, _
    traceLevel, text)
```

```csharp
public TraceEntry(
    string mediaElementId,
    string className,
    string methodName,
    TraceArea traceArea,
    TraceLevel traceLevel,
    string text
)
```

```cpp
public:
TraceEntry(
    String^ mediaElementId, 
    String^ className, 
    String^ methodName, 
    TraceArea traceArea, 
    TraceLevel traceLevel, 
    String^ text
)
```

``` fsharp
new : 
        mediaElementId:string * 
        className:string * 
        methodName:string * 
        traceArea:TraceArea * 
        traceLevel:TraceLevel * 
        text:string -> TraceEntry
```

```jscript
public function TraceEntry(
    mediaElementId : String, 
    className : String, 
    methodName : String, 
    traceArea : TraceArea, 
    traceLevel : TraceLevel, 
    text : String
)
```

### Parameters

  - mediaElementId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    String value that specifies the media element ID.

<!-- end list -->

  - className  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    String value that specifies the class name of the method that invoked the trace.

<!-- end list -->

  - methodName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    String value that specifies the method name of the method that invoked the trace.

<!-- end list -->

  - traceArea  
    Type: [Microsoft.Web.Media.Diagnostics.TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceArea](tracearea-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

<!-- end list -->

  - traceLevel  
    Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
    A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.

<!-- end list -->

  - text  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    String value that specifies the text description of the trace.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

