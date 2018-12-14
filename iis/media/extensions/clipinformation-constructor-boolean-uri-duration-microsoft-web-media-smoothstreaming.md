---
title: ClipInformation Constructor (Boolean, Uri, Duration) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Constructor (Boolean, Uri, Duration)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ClipInformation.#ctor(System.Boolean,System.Uri,System.Windows.Duration)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.clipinformation(v=VS.90)
ms:contentKeyID: 31469209
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipInformation Constructor (Boolean, Uri, Duration)

Initializes a new instance of the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    isSmoothStreamingSourceAsBoolean, _
    clipUriAsUri, _
    durationAsDuration _
)
'Usage
DimisSmoothStreamingSourceAsBooleanDimclipUriAsUriDimdurationAsDurationDiminstanceAs NewClipInformation(isSmoothStreamingSource, _
    clipUri, duration)
```

``` csharp
publicClipInformation(
    boolisSmoothStreamingSource,
    UriclipUri,
    Durationduration
)
```

``` c++
public:
ClipInformation(
    boolisSmoothStreamingSource, 
    Uri^ clipUri, 
    Durationduration
)
```

``` jscript
publicfunctionClipInformation(
    isSmoothStreamingSource : boolean, 
    clipUri : Uri, 
    duration : Duration
)
```

#### Parameters

  - isSmoothStreamingSource  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    A Boolean value that indicates whether the clip source is Smooth Streaming media.  

<!-- end list -->

  - clipUri  
    Type: [System. . :: . .Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\))  
    A [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\)) object that contains the clip source.  

<!-- end list -->

  - duration  
    Type: [System.Windows. . :: . .Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.90\))  
    A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object that contains the duration of the clip in ticks.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[ClipInformation Overload](clipinformation-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

