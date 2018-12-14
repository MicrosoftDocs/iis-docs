---
title: ClipContext.ClipInformation Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.clipinformation(v=VS.90)
ms:contentKeyID: 23961224
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_ClipInformation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_ClipInformation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipInformation Property

Gets or sets the ClipInformation property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyClipInformationAsClipInformation
'Usage
DiminstanceAsClipContextDimvalueAsClipInformationvalue = instance.ClipInformation
```

``` csharp
publicClipInformationClipInformation { get; privateset; }
```

``` c++
public:
propertyClipInformation^ ClipInformation {
    ClipInformation^ get ();
    private: voidset (ClipInformation^ value);
}
```

``` jscript
function getClipInformation () : ClipInformationprivatefunction setClipInformation (value : ClipInformation)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

Clip information associated with the context. For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

