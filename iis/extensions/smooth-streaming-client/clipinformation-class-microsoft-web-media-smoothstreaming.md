---
title: ClipInformation Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipInformation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation(v=VS.90)
ms:contentKeyID: 23961135
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipInformation Class

Metadata class for scheduling and viewing a segment of audio or video media data.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.SmoothStreaming..::..ClipInformation  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Class ClipInformation
'Usage

  Dim instance As ClipInformation
```

``` csharp
  public class ClipInformation
```

``` c++
  public ref class ClipInformation
```

``` jscript
  public class ClipInformation
```

The ClipInformation type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri)](clipinformation-constructor-boolean-uri-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri)](clipinformation-constructor-boolean-uri-uri-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Duration)](clipinformation-constructor-boolean-uri-duration-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri, Duration)](clipinformation-constructor-boolean-uri-uri-duration-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri, Duration, ISmoothStreamingCache)](clipinformation-constructor-boolean-uri-uri-duration-ismoothstreamingcache-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a [Uri](https://msdn.microsoft.com/en-us/library/txt7706a(v=vs.90)) object that contains the Uri to additional information.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a [Uri](https://msdn.microsoft.com/en-us/library/txt7706a(v=vs.90)) object that contains the clip source.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the running time of the media clip.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[IsSmoothStreamingSource](clipinformation-issmoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[SmoothStreamingCache](clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the Smooth Streaming cache.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[UseSmoothStreamingCache](clipinformation-usesmoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a Boolean value that indicates whether to use the Smooth Streaming cache.|


Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[SetSource](clipinformation-setsource-method-microsoft-web-media-smoothstreaming_1.md)|Sets the source for the clip. Enables setting the clip information on the clip MediaElement for extensibility purposes.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|


Top

## Examples

You can initialize a ClipInformation object that specifies the media clip to play by its [ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md) and [Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md). You can also supply the [ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md) to provide follow-up information to the user when he clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while it is playing the clip.

``` 
    private void InsertClipCheckbox_Checked(object sender, RoutedEventArgs e)
    {
        clips.Add(new ClipInformation(true,
            new Uri("http://<serverName>/advertisement-clip.ism/Manifest"),
            new Uri("http://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.aspx"),
            new TimeSpan(1789250001)));
    }
```

For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

