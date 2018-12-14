---
title: TrackInfo.Bitrate Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Bitrate Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.bitrate(v=VS.90)
ms:contentKeyID: 23961234
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Bitrate
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Bitrate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Bitrate Property

Gets or sets the Bitrate property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyBitrateAsULong
'Usage
DiminstanceAsTrackInfoDimvalueAsULongvalue = instance.Bitrate

instance.Bitrate = value
```

``` csharp
publiculongBitrate { get; protectedset; }
```

``` c++
public:
propertyunsigned long longBitrate {
    unsigned long longget ();
    protected: voidset (unsigned long longvalue);
}
```

``` jscript
function getBitrate () : ulongprotectedfunction setBitrate (value : ulong)
```

#### Property Value

Type: [System. . :: . .UInt64](https://msdn.microsoft.com/en-us/library/06cf7918\(v=vs.90\))  
An unsigned long integer.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

