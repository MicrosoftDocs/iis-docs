---
title: StreamInfo.ChildStreams Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChildStreams Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.childstreams(v=VS.90)
ms:contentKeyID: 23961043
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ChildStreams
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ChildStreams
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChildStreams Property

Gets the ChildStreams property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyChildStreamsAsIList(OfStreamInfo)
'Usage
DiminstanceAsStreamInfoDimvalueAsIList(OfStreamInfo)

value = instance.ChildStreams
```

``` csharp
publicIList<StreamInfo> ChildStreams { get; }
```

``` c++
public:
propertyIList<StreamInfo^>^ ChildStreams {
    IList<StreamInfo^>^ get ();
}
```

``` jscript
function getChildStreams () : IList<StreamInfo>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\< (Of \< ( \<'[StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
A generic list of [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects.  

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

