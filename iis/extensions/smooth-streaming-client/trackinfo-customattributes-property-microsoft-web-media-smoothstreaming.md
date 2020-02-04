---
title: TrackInfo.CustomAttributes Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CustomAttributes Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.CustomAttributes
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackinfo.customattributes(v=VS.90)
ms:contentKeyID: 23961139
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_CustomAttributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_CustomAttributes
dev_langs:
- csharp
- jscript
- vb
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

# CustomAttributes Property

Gets or sets the CustomAttributes property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property CustomAttributes As IDictionary(Of String, String)
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

```jscript
  function get CustomAttributes () : IDictionary<String, String>
protected function set CustomAttributes (value : IDictionary<String, String>)
```

### Property Value

Type: [System.Collections.Generic.IDictionary](https://msdn.microsoft.com/library/s4ys34ea)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf), [String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A dictionary of name-value pairs of string values.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

