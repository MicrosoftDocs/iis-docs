---
title: ClipInformation.IsSmoothStreamingSource Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsSmoothStreamingSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.issmoothstreamingsource(v=VS.90)
ms:contentKeyID: 23961127
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_IsSmoothStreamingSource
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_IsSmoothStreamingSource
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsSmoothStreamingSource Property

Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIsSmoothStreamingSourceAsBoolean
'Usage
DiminstanceAsClipInformationDimvalueAsBooleanvalue = instance.IsSmoothStreamingSource
```

``` csharp
publicboolIsSmoothStreamingSource { get; privateset; }
```

``` c++
public:
propertyboolIsSmoothStreamingSource {
    boolget ();
    private: voidset (boolvalue);
}
```

``` jscript
function getIsSmoothStreamingSource () : booleanprivatefunction setIsSmoothStreamingSource (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
A Boolean value, true if the media clip is in Smooth Streaming format, otherwise false.  

## Remarks

For a complete example that uses the IsSmoothStreamingSource property, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

