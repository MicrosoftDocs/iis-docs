---
title: SmoothStreamingMediaElement.Source Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Source Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.source(v=VS.95)
ms:contentKeyID: 46307844
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Source
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Source
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Source
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.Source Property

Gets or sets a media stream source that is not a Smooth Streaming source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Source As Uri
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Uri

value = instance.Source

instance.Source = value
```

```csharp
public Uri Source { get; set; }
```

```cpp
public:
property Uri^ Source {
    Uri^ get ();
    void set (Uri^ value);
}
```

``` fsharp
member Source : Uri with get, set
```

```jscript
function get Source () : Uri
function set Source (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
The URI of the stream that is not a Smooth Streaming source.

## Remarks

> [!NOTE]  
> Do not set Source to a URI that contains a query, such as `http://domain/MultiAudio.ism/Manifest?foo=axjrjrn1`.
>
> If a query is set and the config.xml file includes `ResponseCacheEnabled="true"` instead of `ResponseCacheEnabled="false"`, the entire URI (including the query) could be persisted in ResponseCache.

When you call [SetSource(Stream)](smoothstreamingmediaelement-setsource-method-microsoft-web-media-smoothstreaming_1.md) or assign the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) or Source properties, Source is reset to [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md). However, [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is not cleared when reset to a progressive-downloading source.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

