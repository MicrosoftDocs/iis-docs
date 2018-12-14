---
title: SmoothStreamingMediaElement.StartPosition Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StartPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.startposition(v=VS.90)
ms:contentKeyID: 23961094
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_StartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_StartPosition
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_StartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_StartPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.StartPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartPosition Property

Gets or sets the start position of the current stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyStartPositionAsTimeSpan
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsTimeSpanvalue = instance.StartPosition

instance.StartPosition = value
```

``` csharp
publicTimeSpanStartPosition { get; set; }
```

``` c++
public:
propertyTimeSpanStartPosition {
    TimeSpanget ();
    voidset (TimeSpanvalue);
}
```

``` jscript
function getStartPosition () : TimeSpanfunction setStartPosition (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
The start position.  

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

