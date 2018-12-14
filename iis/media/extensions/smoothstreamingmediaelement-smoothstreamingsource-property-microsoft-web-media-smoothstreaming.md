---
title: SmoothStreamingMediaElement.SmoothStreamingSource Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSource
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingsource(v=VS.90)
ms:contentKeyID: 23961153
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingSource
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_SmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_SmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSource
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingSource Property

Gets or sets the URI of the Smooth Streaming source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertySmoothStreamingSourceAsUri
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsUrivalue = instance.SmoothStreamingSource

instance.SmoothStreamingSource = value
```

``` csharp
publicUriSmoothStreamingSource { get; set; }
```

``` c++
public:
propertyUri^ SmoothStreamingSource {
    Uri^ get ();
    voidset (Uri^ value);
}
```

``` jscript
function getSmoothStreamingSource () : Urifunction setSmoothStreamingSource (value : Uri)
```

#### Property Value

Type: [System. . :: . .Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\))  
The URI of the Smooth Streaming source.  

## Remarks

When you call [SetSource(Stream)](smoothstreamingmediaelement-setsource-method-microsoft-web-media-smoothstreaming_1.md) or assign the SmoothStreamingSource or [Source](smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md) properties, [Source](smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md) is reset to SmoothStreamingSource. However, SmoothStreamingSource is not cleared when reset to a progressive-downloading source.

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

