---
title: ClipInformation Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipInformation
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation(v=VS.95)
ms:contentKeyID: 46307938
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation Class

Metadata class for scheduling and viewing a segment of audio or video media data.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.ClipInformation  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class ClipInformation
'Usage

Dim instance As ClipInformation
```

```csharp
public class ClipInformation
```

```cpp
public ref class ClipInformation
```

``` fsharp
type ClipInformation =  class end
```

```jscript
public class ClipInformation
```

The ClipInformation type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri)](clipinformation-constructor-boolean-uri-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri)](clipinformation-constructor-boolean-uri-uri-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Duration)](clipinformation-constructor-boolean-uri-duration-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri, Duration)](clipinformation-constructor-boolean-uri-uri-duration-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ClipInformation(Boolean, Uri, Uri, Duration, ISmoothStreamingCache)](clipinformation-constructor-boolean-uri-uri-duration-ismoothstreamingcache-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the ClipInformation class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a [Uri](https://msdn.microsoft.com/library/txt7706a(v=vs.95)) object that contains the Uri to additional information.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a [Uri](https://msdn.microsoft.com/library/txt7706a(v=vs.95)) object that contains the clip source.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the running time of the media clip.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[IsSmoothStreamingSource](clipinformation-issmoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[SmoothStreamingCache](clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the Smooth Streaming cache.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[UseSmoothStreamingCache](clipinformation-usesmoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets a Boolean value that indicates whether to use the Smooth Streaming cache.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[SetSource](clipinformation-setsource-method-microsoft-web-media-smoothstreaming_1.md)|Sets the source for the clip. Enables setting the clip information on the clip MediaElement for extensibility purposes.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|

## Examples

You can initialize a ClipInformation object that specifies the media clip to play by its [ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md) and [Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md). You can also supply the [ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md) to provide follow-up information to the user when he clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while it is playing the clip.

``` 
    private void InsertClipCheckbox_Checked(object sender, RoutedEventArgs e)
    {
        clips.Add(new ClipInformation(true,
            new Uri("http://<serverName>/advertisement-clip.ism/Manifest"),
            new Uri("http://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.aspx"),
            new TimeSpan(1789250001)));
    }
```

For more information, see [Scheduling Media Clips](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
