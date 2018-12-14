---
title: StreamInfo.ParentStream Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParentStream Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.parentstream(v=VS.90)
ms:contentKeyID: 23961247
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.ParentStream
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_ParentStream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ParentStream Property

Gets or sets the parent stream in the case of a sparse stream. Otherwise this is null.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyParentStreamAsStreamInfo
'Usage
DiminstanceAsStreamInfoDimvalueAsStreamInfovalue = instance.ParentStream
```

``` csharp
publicStreamInfoParentStream { get; internalset; }
```

``` c++
public:
propertyStreamInfo^ ParentStream {
    StreamInfo^ get ();
    internal: voidset (StreamInfo^ value);
}
```

``` jscript
function getParentStream () : StreamInfointernalfunction setParentStream (value : StreamInfo)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

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

