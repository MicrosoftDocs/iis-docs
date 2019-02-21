---
title: TraceEntry.Date Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: Date Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.Date
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.date(v=VS.90)
ms:contentKeyID: 23960989
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Date
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Date
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
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
---

# Date Property

Gets or sets the Date property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Date As DateTime
'Usage

  Dim instance As TraceEntry
Dim value As DateTime

value = instance.Date

instance.Date = value
```

```csharp
  public DateTime Date { get; set; }
```

```cpp
  public:
property DateTime Date {
    DateTime get ();
    void set (DateTime value);
}
```

```jscript
  function get Date () : DateTime
function set Date (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
A DateTime object that specifies the date and time of the trace entry.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

