---
title: SmoothStreamingMediaElement.Source Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Source Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.source(v=VS.90)
ms:contentKeyID: 23961219
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Source
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Source Property

Gets or sets a media stream source that is not a Smooth Streaming source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertySourceAsUri
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsUrivalue = instance.Source

instance.Source = value
```

``` csharp
publicUriSource { get; set; }
```

``` c++
public:
propertyUri^ Source {
    Uri^ get ();
    voidset (Uri^ value);
}
```

``` jscript
function getSource () : Urifunction setSource (value : Uri)
```

#### Property Value

Type: [System. . :: . .Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\))  
The URI of the stream that is not a Smooth Streaming source.  

## Remarks


> [!NOTE]
> <P>Do not set Source to a URI that contains a query, such as http://domain/MultiAudio.ism/Manifest?foo=axjrjrn1.</P>
> <P>If a query is set and the config.xml file includes ResponseCacheEnabled="true" instead of ResponseCacheEnabled="false", the entire URI (including the query) could be persisted in ResponseCache.</P>



When you call [SetSource(Stream)](smoothstreamingmediaelement-setsource-method-microsoft-web-media-smoothstreaming_1.md) or assign the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) or Source properties, Source is reset to [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md). However, [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is not cleared when reset to a progressive-downloading source.

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

