---
title: TraceEntry.MediaElementId Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: MediaElementId Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.MediaElementId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.mediaelementid(v=VS.95)
ms:contentKeyID: 46307733
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.MediaElementId
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MediaElementId
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MediaElementId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MediaElementId
- Microsoft.Web.Media.Diagnostics.TraceEntry.MediaElementId
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MediaElementId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TraceEntry.MediaElementId Property

Gets or sets the MediaElementId property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property MediaElementId As String
    Get
    Set
'Usage

Dim instance As TraceEntry
Dim value As String

value = instance.MediaElementId

instance.MediaElementId = value
```

```csharp
public string MediaElementId { get; set; }
```

```cpp
public:
property String^ MediaElementId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member MediaElementId : string with get, set
```

```jscript
function get MediaElementId () : String
function set MediaElementId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that specifies the media element ID.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

