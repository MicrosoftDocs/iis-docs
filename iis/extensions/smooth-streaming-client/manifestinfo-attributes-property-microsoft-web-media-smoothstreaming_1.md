---
title: ManifestInfo.Attributes Property (Microsoft.Web.Media.SmoothStreaming)
description: Learn how the ManifestInfo.Attributes property gets or sets attributes, as well as details about its syntax and property value.
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Attributes
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.manifestinfo.attributes(v=VS.95)
ms:contentKeyID: 46307786
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_Attributes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_Attributes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestInfo.Attributes Property

Gets or sets attributes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Attributes As IDictionary(Of String, String)
    Get
    Friend Set
'Usage

Dim instance As ManifestInfo
Dim value As IDictionary(Of String, String)

value = instance.Attributes
```

```csharp
public IDictionary<string, string> Attributes { get; internal set; }
```

```cpp
public:
property IDictionary<String^, String^>^ Attributes {
    IDictionary<String^, String^>^ get ();
    internal: void set (IDictionary<String^, String^>^ value);
}
```

``` fsharp
member Attributes : IDictionary<string, string> with get, internal set
```

```jscript
function get Attributes () : IDictionary<String, String>
internal function set Attributes (value : IDictionary<String, String>)
```

### Property Value

Type: [System.Collections.Generic.IDictionary](https://msdn.microsoft.com/library/s4ys34ea\(v=vs.95\))\<[String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\)), [String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))\>  
An IDictionary object that contains attributes and values.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
