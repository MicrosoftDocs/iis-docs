---
title: TraceEntry.Text Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: Text Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.Text
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.text(v=VS.95)
ms:contentKeyID: 46307736
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Text
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.Text
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TraceEntry.Text Property

Gets or sets the Text property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Text As String
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As String

value = instance.Text

instance.Text = value
```

```csharp
public string Text { get; set; }
```

```cpp
public:
property String^ Text {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member Text : string with get, set
```

```jscript
function get Text () : String
function set Text (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that specifies the text description of the trace.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

