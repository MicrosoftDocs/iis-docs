---
title: StreamInfo.Subtype Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the StreamInfo.Subtype property and provides the property's syntax, property value, remarks, and Silverlight information.
TOCTitle: Subtype Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.subtype(v=VS.95)
ms:contentKeyID: 46307874
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Subtype
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.Subtype Property

Gets or sets the Subtype property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Subtype As String
    Get
    Friend Set
'Usage

Dim instance As StreamInfo
Dim value As String

value = instance.Subtype
```

```csharp
public string Subtype { get; internal set; }
```

```cpp
public:
property String^ Subtype {
    String^ get ();
    internal: void set (String^ value);
}
```

``` fsharp
member Subtype : string with get, internal set
```

```jscript
function get Subtype () : String
internal function set Subtype (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that specifies the subtype.

## Remarks

For more information and an example that parses [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
