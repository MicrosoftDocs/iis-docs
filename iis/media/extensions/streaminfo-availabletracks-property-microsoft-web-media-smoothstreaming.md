---
title: StreamInfo.AvailableTracks Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AvailableTracks Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.AvailableTracks
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.availabletracks(v=VS.90)
ms:contentKeyID: 23961245
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.AvailableTracks
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_AvailableTracks
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.AvailableTracks
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_AvailableTracks
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AvailableTracks Property

Gets the AvailableTracks property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyAvailableTracksAsIList(OfTrackInfo)
'Usage
DiminstanceAsStreamInfoDimvalueAsIList(OfTrackInfo)

value = instance.AvailableTracks
```

``` csharp
publicIList<TrackInfo> AvailableTracks { get; }
```

``` c++
public:
propertyIList<TrackInfo^>^ AvailableTracks {
    IList<TrackInfo^>^ get ();
}
```

``` jscript
function getAvailableTracks () : IList<TrackInfo>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\< (Of \< ( \<'[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A generic list of [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects.  

## Remarks

For more information and an example that parses [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

