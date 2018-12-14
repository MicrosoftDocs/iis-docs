---
title: TrackInfo.Attributes Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Attributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.attributes(v=VS.90)
ms:contentKeyID: 31469165
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Attributes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Attributes
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Attributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Attributes Property

Gets or sets the attributes for a track.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyAttributesAsIDictionary(OfString, String)
'Usage
DiminstanceAsTrackInfoDimvalueAsIDictionary(OfString, String)

value = instance.Attributes
```

``` csharp
publicIDictionary<string, string> Attributes { get; internalset; }
```

``` c++
public:
propertyIDictionary<String^, String^>^ Attributes {
    IDictionary<String^, String^>^ get ();
    internal: voidset (IDictionary<String^, String^>^ value);
}
```

``` jscript
function getAttributes () : IDictionary<String, String>
internalfunction setAttributes (value : IDictionary<String, String>)
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IDictionary](https://msdn.microsoft.com/en-us/library/s4ys34ea\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\)), [String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
An IDictionary of name/value pairs of attributes.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

