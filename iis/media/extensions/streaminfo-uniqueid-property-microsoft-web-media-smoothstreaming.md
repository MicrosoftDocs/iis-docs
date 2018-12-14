---
title: StreamInfo.UniqueId Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: UniqueId Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.uniqueid(v=VS.90)
ms:contentKeyID: 31469276
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.UniqueId
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_UniqueId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UniqueId Property

Gets or sets the Id that identifies this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyUniqueIdAsString
'Usage
DiminstanceAsStreamInfoDimvalueAsStringvalue = instance.UniqueId
```

``` csharp
publicstringUniqueId { get; internalset; }
```

``` c++
public:
propertyString^ UniqueId {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getUniqueId () : Stringinternalfunction setUniqueId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string value that contains the Id.  

## Remarks

For more information see the examples in [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

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

