---
title: TrackInfo.CustomAttributes Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CustomAttributes Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.CustomAttributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.customattributes(v=VS.95)
ms:contentKeyID: 46307881
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_CustomAttributes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_CustomAttributes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrackInfo.CustomAttributes Property

Gets or sets the CustomAttributes property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property CustomAttributes As IDictionary(Of String, String)
    Get
    Protected Set
'Usage

Dim instance As TrackInfo
Dim value As IDictionary(Of String, String)

value = instance.CustomAttributes

instance.CustomAttributes = value
```

```csharp
public IDictionary<string, string> CustomAttributes { get; protected set; }
```

```cpp
public:
property IDictionary<String^, String^>^ CustomAttributes {
    IDictionary<String^, String^>^ get ();
    protected: void set (IDictionary<String^, String^>^ value);
}
```

``` fsharp
member CustomAttributes : IDictionary<string, string> with get, set
```

```jscript
function get CustomAttributes () : IDictionary<String, String>
protected function set CustomAttributes (value : IDictionary<String, String>)
```

### Property Value

Type: [System.Collections.Generic.IDictionary](https://msdn.microsoft.com/library/s4ys34ea\(v=vs.95\))\<[String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\)), [String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))\>  
A dictionary of name-value pairs of string values.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

