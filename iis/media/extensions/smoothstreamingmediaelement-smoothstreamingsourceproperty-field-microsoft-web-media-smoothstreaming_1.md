---
title: SmoothStreamingMediaElement.SmoothStreamingSourceProperty Field (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingSourceProperty Field
ms:assetid: F:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSourceProperty
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingsourceproperty(v=VS.95)
ms:contentKeyID: 46307578
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSourceProperty
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingSourceProperty
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SmoothStreamingSourceProperty Field

Represents a dependency property that specifies the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Shared ReadOnly SmoothStreamingSourceProperty As DependencyProperty
'Usage

Dim value As DependencyProperty

value = SmoothStreamingMediaElement.SmoothStreamingSourceProperty
```

``` csharp
public static readonly DependencyProperty SmoothStreamingSourceProperty
```

``` c++
public:
static initonly DependencyProperty^ SmoothStreamingSourceProperty
```

``` fsharp
static val SmoothStreamingSourceProperty: DependencyProperty
```

``` jscript
public static final var SmoothStreamingSourceProperty : DependencyProperty
```

## Remarks

Use this member to assign a Smooth Streaming source. For other media data that is not in Smooth Streaming format, use the StreamingMediaElement.Source class.


> [!NOTE]
> <P>Do not set <A href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</A> to a URI that contains a query, such as http://domain/MultiAudio.ism/Manifest?foo=axjrjrn1.</P>
> <P>If a query is set and the config.xml file includes ResponseCacheEnabled="true" instead of ResponseCacheEnabled="false", the entire URI (including the query) could be persisted in ResponseCache.</P>



## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

