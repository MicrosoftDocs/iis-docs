---
title: TraceEntry.Date Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: Date Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.Date
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.date(v=VS.95)
ms:contentKeyID: 46307726
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Date
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Date
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TraceEntry.Date Property

Gets or sets the Date property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Date As DateTime
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As DateTime

value = instance.Date

instance.Date = value
```

``` csharp
public DateTime Date { get; set; }
```

``` c++
public:
property DateTime Date {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
member Date : DateTime with get, set
```

``` jscript
function get Date () : DateTime
function set Date (value : DateTime)
```

#### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.95\))  
A DateTime object that specifies the date and time of the trace entry.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

