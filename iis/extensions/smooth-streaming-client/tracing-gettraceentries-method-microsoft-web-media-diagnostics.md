---
title: Tracing.GetTraceEntries Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: GetTraceEntries Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.gettraceentries(v=VS.90)
ms:contentKeyID: 23961259
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.GetTraceEntries
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTraceEntries Method

Gets an array of trace entries.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Shared Function GetTraceEntries ( _
    flushList As Boolean _
) As TraceEntry()
'Usage

  Dim flushList As Boolean
Dim returnValue As TraceEntry()

returnValue = Tracing.GetTraceEntries(flushList)
```

``` csharp
  public static TraceEntry[] GetTraceEntries(
    bool flushList
)
```

``` c++
  public:
static array<TraceEntry^>^ GetTraceEntries(
    bool flushList
)
```

``` jscript
  public static function GetTraceEntries(
    flushList : boolean
) : TraceEntry[]
```

#### Parameters

  - flushList  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    A Boolean value that specifies whether to flush the current buffer of trace entries.  

#### Return Value

Type: array\<[Microsoft.Web.Media.Diagnostics. . :: . .TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md)\> \[\] () \[\] \[\]  
An array of [TraceEntry](traceentry-class-microsoft-web-media-diagnostics_1.md) objects.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

