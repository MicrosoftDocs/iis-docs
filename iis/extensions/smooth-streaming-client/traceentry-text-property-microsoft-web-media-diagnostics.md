---
title: TraceEntry.Text Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: Text Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.Text
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.text(v=VS.90)
ms:contentKeyID: 23960995
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_Text
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_Text
dev_langs:
- CSharp
- JScript
- VB
- c++
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
ROBOTS: INDEX,FOLLOW
---

# Text Property

Gets or sets the Text property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property Text As String
'Usage

  Dim instance As TraceEntry
Dim value As String

value = instance.Text

instance.Text = value
```

``` csharp
  public string Text { get; set; }
```

``` c++
  public:
property String^ Text {
    String^ get ();
    void set (String^ value);
}
```

``` jscript
  function get Text () : String
function set Text (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string value that specifies the text description of the trace.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

