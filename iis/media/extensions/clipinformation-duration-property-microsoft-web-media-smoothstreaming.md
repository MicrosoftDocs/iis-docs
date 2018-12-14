---
title: ClipInformation.Duration Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Duration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.duration(v=VS.90)
ms:contentKeyID: 23960958
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Duration Property

Gets or sets the running time of the media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDurationAsDuration
'Usage
DiminstanceAsClipInformationDimvalueAsDurationvalue = instance.Duration
```

``` csharp
publicDurationDuration { get; privateset; }
```

``` c++
public:
propertyDurationDuration {
    Durationget ();
    private: voidset (Durationvalue);
}
```

``` jscript
function getDuration () : Durationprivatefunction setDuration (value : Duration)
```

#### Property Value

Type: [System.Windows. . :: . .Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.90\))  
A [Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.90\)) object.  

## Remarks

For a complete example that uses the Duration property, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

